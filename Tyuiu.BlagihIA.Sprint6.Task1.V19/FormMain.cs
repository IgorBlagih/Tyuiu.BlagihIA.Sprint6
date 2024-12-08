using Tyuiu.BlagihIA.Sprint6.Task1.V19.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint6.Task1.V19
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

                string strLine;
                int len = ds.GetMassFunction(Startstep, StopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(Startstep, StopStep);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", Startstep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    Startstep++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
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

        private void textBoxVarStart_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
