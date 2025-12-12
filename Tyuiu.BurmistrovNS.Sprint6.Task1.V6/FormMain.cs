using Tyuiu.BurmistrovNS.Sprint6.Task1.V6.Lib;

namespace Tyuiu.BurmistrovNS.Sprint6.Task1.V6
{
    public partial class FormMain_BNS : Form
    {
        public FormMain_BNS()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonVPL_BNS_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart_BNS.Text);
                int stopstep = Convert.ToInt32(textBoxKONEC_BNS.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);

                textBoxResult_BNS.Text = "";
                textBoxResult_BNS.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_BNS.AppendText("|    X     |    F(x)    |" + Environment.NewLine);
                textBoxResult_BNS.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1, 6:f2}    | ", startstep, valueArray[i]);
                    textBoxResult_BNS.AppendText(strline + Environment.NewLine);
                    startstep++;
                }

                textBoxResult_BNS.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSPR_BNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-25-1 Бурмистров Н.С.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
