using Tyuiu.BurmistrovNS.Sprint6.Task3.V30.Lib;

namespace Tyuiu.BurmistrovNS.Sprint6.Task3.V30
{
    public partial class FormMain_BNS : Form
    {
        public FormMain_BNS()
        {
            InitializeComponent();
        }



        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
            {-9, -4,17,-1,-20 },
            {-19,18,-4,2,14 },
            {-12,16,-2,7,18 },
            {-16,15,4,-12,-13},
            {-15, -4 ,-16,1,-14 }
        };
        private void FormMain_BNS_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            dataGridViewMatrix_BNS.ColumnCount = cols;
            dataGridViewMatrix_BNS.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_BNS.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_BNS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_BNS_Click(object sender, EventArgs e)
        {
            textBoxResult_BNS.Text = Convert.ToString(ds.Calculate(matrix));
        }

        private void buttonHelp_BNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-25-1 Бурмистров Николай Сергеевич ", "Справка");
        }
    }





}
