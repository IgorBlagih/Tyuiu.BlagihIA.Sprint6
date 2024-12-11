using Tyuiu.BlagihIA.Sprint6.Task4.V1.Lib;
namespace Tyuiu.BlagihIA.Sprint6.Task4.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int Startstep = Convert.ToInt32(textBoxVarStart.Text);
                int StopStep = Convert.ToInt32(textBoxVarStop.Text);

                int len = ds.GetMassFunction(Startstep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(Startstep, StopStep);



                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes.Text = "";
                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {

                    this.chartFunction.Series[0].Points.AddXY(Startstep, valueArray[i]);
                    this.textBoxRes.AppendText(valueArray[i] + Environment.NewLine);
                    Startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task выполнил студент группы ИИПб-24-2 Благих Игорь Алекснадрович ");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask4V1.txt");
                File.WriteAllText(path, textBoxRes.Text);

                DialogResult dialogRes = MessageBox.Show("Файл " + path + " сохранен успешно\n Открыть файл?");

                if (dialogRes == DialogResult.OK)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarStop_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStart_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
