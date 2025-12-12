namespace Tyuiu.BurmistrovNS.Sprint6.Task3.V30
{
    partial class FormMain_BNS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxData_BNS = new GroupBox();
            dataGridViewMatrix_BNS = new DataGridView();
            textBoxUSL_BNS = new TextBox();
            groupBoxVV_BNS = new GroupBox();
            textBoxResult_BNS = new TextBox();
            buttonHelp_BNS = new Button();
            buttonDone_BNS = new Button();
            groupBoxData_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BNS).BeginInit();
            groupBoxVV_BNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData_BNS
            // 
            groupBoxData_BNS.Controls.Add(dataGridViewMatrix_BNS);
            groupBoxData_BNS.Controls.Add(textBoxUSL_BNS);
            groupBoxData_BNS.Location = new Point(17, 21);
            groupBoxData_BNS.Name = "groupBoxData_BNS";
            groupBoxData_BNS.Size = new Size(690, 311);
            groupBoxData_BNS.TabIndex = 0;
            groupBoxData_BNS.TabStop = false;
            groupBoxData_BNS.Text = "Условие";
            // 
            // dataGridViewMatrix_BNS
            // 
            dataGridViewMatrix_BNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BNS.Location = new Point(292, 18);
            dataGridViewMatrix_BNS.Name = "dataGridViewMatrix_BNS";
            dataGridViewMatrix_BNS.RowHeadersWidth = 51;
            dataGridViewMatrix_BNS.Size = new Size(337, 285);
            dataGridViewMatrix_BNS.TabIndex = 1;
            // 
            // textBoxUSL_BNS
            // 
            textBoxUSL_BNS.Location = new Point(16, 31);
            textBoxUSL_BNS.Multiline = true;
            textBoxUSL_BNS.Name = "textBoxUSL_BNS";
            textBoxUSL_BNS.ReadOnly = true;
            textBoxUSL_BNS.Size = new Size(230, 237);
            textBoxUSL_BNS.TabIndex = 0;
            textBoxUSL_BNS.Text = "Дана матрица 5 на 5\r\n -9  -4  17  -1 -20\r\n\r\n -19  18  -4   2  14\r\n\r\n -12  16  -2   7  18\r\n\r\n -16  15   4 -12 -13\r\n\r\n -15  -4 -16   1 -14\r\nПодсчитать количество нулей";
            // 
            // groupBoxVV_BNS
            // 
            groupBoxVV_BNS.Controls.Add(textBoxResult_BNS);
            groupBoxVV_BNS.Location = new Point(720, 21);
            groupBoxVV_BNS.Name = "groupBoxVV_BNS";
            groupBoxVV_BNS.Size = new Size(211, 147);
            groupBoxVV_BNS.TabIndex = 1;
            groupBoxVV_BNS.TabStop = false;
            groupBoxVV_BNS.Text = "Вывод данных";
            // 
            // textBoxResult_BNS
            // 
            textBoxResult_BNS.Location = new Point(15, 36);
            textBoxResult_BNS.Name = "textBoxResult_BNS";
            textBoxResult_BNS.ReadOnly = true;
            textBoxResult_BNS.Size = new Size(183, 27);
            textBoxResult_BNS.TabIndex = 0;
            // 
            // buttonHelp_BNS
            // 
            buttonHelp_BNS.Location = new Point(735, 299);
            buttonHelp_BNS.Name = "buttonHelp_BNS";
            buttonHelp_BNS.Size = new Size(32, 33);
            buttonHelp_BNS.TabIndex = 2;
            buttonHelp_BNS.Text = "?";
            buttonHelp_BNS.UseVisualStyleBackColor = true;
            buttonHelp_BNS.Click += buttonHelp_BNS_Click;
            // 
            // buttonDone_BNS
            // 
            buttonDone_BNS.Location = new Point(784, 299);
            buttonDone_BNS.Name = "buttonDone_BNS";
            buttonDone_BNS.Size = new Size(147, 33);
            buttonDone_BNS.TabIndex = 3;
            buttonDone_BNS.Text = "ВЫПОЛЛНИТЬ";
            buttonDone_BNS.UseVisualStyleBackColor = true;
            buttonDone_BNS.Click += buttonDone_BNS_Click;
            // 
            // FormMain_BNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 366);
            Controls.Add(buttonDone_BNS);
            Controls.Add(buttonHelp_BNS);
            Controls.Add(groupBoxVV_BNS);
            Controls.Add(groupBoxData_BNS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_BNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  3 | Вариант 30 | Бурмистров Н.С. ";
            Load += FormMain_BNS_Load;
            groupBoxData_BNS.ResumeLayout(false);
            groupBoxData_BNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BNS).EndInit();
            groupBoxVV_BNS.ResumeLayout(false);
            groupBoxVV_BNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_BNS;
        private TextBox textBoxUSL_BNS;
        private DataGridView dataGridViewMatrix_BNS;
        private GroupBox groupBoxVV_BNS;
        private TextBox textBoxResult_BNS;
        private Button buttonHelp_BNS;
        private Button buttonDone_BNS;
    }
}
