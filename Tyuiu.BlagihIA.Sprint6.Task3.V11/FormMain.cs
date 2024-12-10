using Microsoft.Win32;
using Tyuiu.BlagihIA.Sprint6.Task3.V11.Lib;
namespace Tyuiu.BlagihIA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 27, -15, 14, 2, 27 },
                                     { -8, 14, -10, 33, 0 },
                                     { 1, 7, -11, -11, 23 },
                                     { -13, -20, 15, -16, 34 },
                                       { -3, 1, -1, 5, 1 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0);
            int columns = mtrx.GetUpperBound(1);

            dataGridViewMTRX.ColumnCount = columns;
            dataGridViewMTRX.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMTRX.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMTRX.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);

                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {

            int rows = mtrx.GetUpperBound(0);
            int columns = mtrx.GetUpperBound(1);
            int[,] mtrx2 = ds.Calculate(mtrx);
            dataGridViewRes.ColumnCount = columns;
            dataGridViewRes.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows;i++)
            {
                for(int j = 0; j< columns; j++)
                {
                    dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(mtrx2[i,j]);
                }
            }
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Chartreuse;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.DarkRed;
        }

        private void buttonDown_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task выполнил студент группы ИИПб-24-2 Благих Игорь Алекснадрович ");
        }
    }
}
