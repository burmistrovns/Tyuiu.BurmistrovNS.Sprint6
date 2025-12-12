using Tyuiu.BurmistrovNS.Sprint6.Task6.V27.Lib;

namespace Tyuiu.BurmistrovNS.Spriint6.Task6.V27
{
    public partial class FormMain_BNS : Form
    {
        public FormMain_BNS()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            groupBox2.Text = groupBox2.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void textBoxIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
