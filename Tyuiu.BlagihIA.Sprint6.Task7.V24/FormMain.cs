using Tyuiu.BlagihIA.Sprint6.Task7.V24.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task7.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static string openFilePath;
        static int rows;
        static int colums;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filepath)
        {
            string fileData = File.ReadAllText(filepath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] aValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] lines_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    aValues[r, c] = Convert.ToInt32(lines_r[c]);
                }
            }

            return aValues;



        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] aValues = new int[rows, colums];

            aValues = LoadFromFileData(openFilePath);

            dataGridViewInMatrix.ColumnCount = colums;
            dataGridViewInMatrix.RowCount = rows;
            dataGridViewOutMatrix.ColumnCount = colums;
            dataGridViewOutMatrix.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInMatrix.Columns[i].Width = 25;
                dataGridViewOutMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewInMatrix.Rows[i].Cells[j].Value = aValues[i, j];
                }
            }

            aValues = ds.GetMatrix(openFilePath);
            buttonComp.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool exist = fileinfo.Exists;
            if (exist)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix.RowCount;
            int cols = dataGridViewOutMatrix.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value + ";";

                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix.Rows[i].Cells[j].Value;

                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonComp_Click(object sender, EventArgs e)
        {
            int[,] aValues = new int[rows, colums];
            aValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewOutMatrix.Rows[i].Cells[j].Value = aValues[i, j];

                }
            }

            buttonSave.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
