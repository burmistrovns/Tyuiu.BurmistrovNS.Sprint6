using Tyuiu.BurmistrovNS.Sprint6.Task0.V2.Lib;
namespace Tyuiu.BurmistrovNS.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void groupBoxVIVOD_BNS_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxDano_BNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxVVOD_BNS_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_BNS_Click(object sender, EventArgs e)
        {

        }

        private void buttonHELP_BNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-25-1 Бурмистров Николай Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEND_BNS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_BNS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxDano_BNS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxRes_BNS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDano_BNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }
    }
}
