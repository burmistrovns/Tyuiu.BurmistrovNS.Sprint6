using Tyuiu.BurmistrovNS.Sprint6.Task2.V8.Lib;

namespace Tyuiu.BurmistrovNS.Sprint6.Task2.V8
{
    public partial class FormMain_BNS : Form
    {
        public FormMain_BNS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_BNS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BNS.BackColor = Color.Red;
        }

        private void buttonDone_BNS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BNS.BackColor = Color.Blue;
        }

        private void buttonDone_BNS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BNS.BackColor = Color.Green;
        }
        DataService ds = new DataService();
        private void buttonDone_BNS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BNS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BNS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);



                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BNS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void buttonHelp_BNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-25-1 Бурмистров Николай Сергеевич ", "Справка");
        }
    }
}
