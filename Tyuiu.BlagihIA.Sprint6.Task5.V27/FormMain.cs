using Tyuiu.BlagihIA.Sprint6.Task5.V27.Lib;
namespace Tyuiu.BlagihIA.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V27.txt");

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNum.ColumnCount = 2;
            dataGridViewNum.Columns[0].Width = 20;
            dataGridViewNum.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag.Series[0].Points.Clear();

            double[] nummas = new double[ds.len];

            nummas = ds.LoadFromDataFile(path);

            for (int i = 0; i < nummas.Length; i++)
            {
                dataGridViewNum.Rows.Add(Convert.ToString(i), Convert.ToString(nummas[i]));
                chartDiag.Series[0].Points.AddXY(i, nummas[i]);

            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task выполнил студент группы ИИПб-24-2 Благих Игорь Алекснадрович ");
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor= Color.LawnGreen;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor= Color.Chartreuse;
        }
    }
}
