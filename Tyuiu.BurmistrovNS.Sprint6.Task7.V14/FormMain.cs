using System.IO;
using Tyuiu.BurmistrovNS.Sprint6.Task7.V14.Lib;

namespace Tyuiu.BurmistrovNS.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_BNS.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_BNS.Filter = "Значения, разделённые запятыми(*.csv)| *.csv|Все файлы(*.*)|*.*";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewIn_BNS.ColumnCount = 50;
            dataGridViewOut_BNS.ColumnCount = 50;

            dataGridViewIn_BNS.RowCount = 50;
            dataGridViewOut_BNS.RowCount = 50;

            panelInPut_BNS.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_BNS.Columns[i].Width = 25;
                dataGridViewOut_BNS.Columns[i].Width = 25;
            }
        }

        static int rows;
        static int columns;
        string openFilePath;

        DataService ds = new DataService();

        private void buttonOpenFile_BNS_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_BNS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BNS.ShowDialog();
            openFilePath = openFileDialogTask_BNS.FileName;

            int[,] matrix = ds.GetMatrix(openFilePath);

            dataGridViewIn_BNS.ColumnCount = matrix.GetLength(1);
            dataGridViewIn_BNS.RowCount = matrix.GetLength(0);
            dataGridViewOut_BNS.ColumnCount = matrix.GetLength(1);
            dataGridViewOut_BNS.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridViewIn_BNS.Columns[i].Width = 40;
                dataGridViewOut_BNS.Columns[i].Width = 40;
            }

            for (int r = 0; r < dataGridViewIn_BNS.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewIn_BNS.ColumnCount; c++)
                {
                    dataGridViewIn_BNS.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonDone_BNS.Enabled = true;
        }

        private void buttonDone_BNS_Click(object sender, EventArgs e)
        {

            int[,] matrix = ds.GetMatrix(openFilePath);

            for (int r = 0; r < dataGridViewOut_BNS.RowCount; r++)
            {
                for (int c = 0; c < dataGridViewOut_BNS.ColumnCount; c++)
                {
                    if ((r == 1) & (matrix[r, c] % 2 == 0))
                    {
                        dataGridViewOut_BNS.Rows[r].Cells[c].Value = 44;
                    }
                    else
                    {
                        dataGridViewOut_BNS.Rows[r].Cells[c].Value = matrix[r, c];
                    }
                }
            }

            buttonSaveFile_BNS.Enabled = true;
        }

        private void buttonSaveFile_BNS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_BNS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_BNS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_BNS.ShowDialog();

            string path = saveFileDialogMatrix_BNS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_BNS.RowCount;
            int columns = dataGridViewOut_BNS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns)
                    {
                        str = str + dataGridViewOut_BNS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_BNS.Rows[i].Cells[i].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonMessage_BNS_Click(object sender, EventArgs e)
        {
            FormAboutInfo_BNS formAbout = new FormAboutInfo_BNS();
            formAbout.ShowDialog();
        }
    }
}
