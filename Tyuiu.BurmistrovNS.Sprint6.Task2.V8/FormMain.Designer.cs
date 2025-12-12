namespace Tyuiu.BurmistrovNS.Sprint6.Task2.V8
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
            groupBoxUslovie_BNS = new GroupBox();
            textBoxUslovie_BNS = new TextBox();
            pictureBoxPrimer_BNS = new PictureBox();
            groupBoxVvod_BNS = new GroupBox();
            buttonDone_BNS = new Button();
            buttonHelp_BNS = new Button();
            groupBoxKonec_BNS = new GroupBox();
            textBoxStopStep_BNS = new TextBox();
            groupBoxStart_BNS = new GroupBox();
            textBoxStartStep_BNS = new TextBox();
            groupBoxVivod_BNS = new GroupBox();
            dataGridViewFunction_BNS = new DataGridView();
            X_BNS = new DataGridViewTextBoxColumn();
            F_BNS = new DataGridViewTextBoxColumn();
            groupBoxUslovie_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_BNS).BeginInit();
            groupBoxVvod_BNS.SuspendLayout();
            groupBoxKonec_BNS.SuspendLayout();
            groupBoxStart_BNS.SuspendLayout();
            groupBoxVivod_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUslovie_BNS
            // 
            groupBoxUslovie_BNS.Controls.Add(textBoxUslovie_BNS);
            groupBoxUslovie_BNS.Controls.Add(pictureBoxPrimer_BNS);
            groupBoxUslovie_BNS.Location = new Point(19, 21);
            groupBoxUslovie_BNS.Name = "groupBoxUslovie_BNS";
            groupBoxUslovie_BNS.Size = new Size(556, 274);
            groupBoxUslovie_BNS.TabIndex = 0;
            groupBoxUslovie_BNS.TabStop = false;
            groupBoxUslovie_BNS.Text = "Условие";
            // 
            // textBoxUslovie_BNS
            // 
            textBoxUslovie_BNS.Location = new Point(16, 111);
            textBoxUslovie_BNS.Multiline = true;
            textBoxUslovie_BNS.Name = "textBoxUslovie_BNS";
            textBoxUslovie_BNS.ReadOnly = true;
            textBoxUslovie_BNS.Size = new Size(361, 96);
            textBoxUslovie_BNS.TabIndex = 1;
            textBoxUslovie_BNS.Text = "Произвести табулирование F(x) на заданном диапазоне [-5; 5] с  шагом 1.";
            // 
            // pictureBoxPrimer_BNS
            // 
            pictureBoxPrimer_BNS.Image = Properties.Resources.Снимок_экрана_2025_12_12_211415;
            pictureBoxPrimer_BNS.Location = new Point(16, 33);
            pictureBoxPrimer_BNS.Name = "pictureBoxPrimer_BNS";
            pictureBoxPrimer_BNS.Size = new Size(361, 64);
            pictureBoxPrimer_BNS.TabIndex = 0;
            pictureBoxPrimer_BNS.TabStop = false;
            // 
            // groupBoxVvod_BNS
            // 
            groupBoxVvod_BNS.Controls.Add(buttonDone_BNS);
            groupBoxVvod_BNS.Controls.Add(buttonHelp_BNS);
            groupBoxVvod_BNS.Controls.Add(groupBoxKonec_BNS);
            groupBoxVvod_BNS.Controls.Add(groupBoxStart_BNS);
            groupBoxVvod_BNS.Location = new Point(19, 301);
            groupBoxVvod_BNS.Name = "groupBoxVvod_BNS";
            groupBoxVvod_BNS.Size = new Size(556, 182);
            groupBoxVvod_BNS.TabIndex = 1;
            groupBoxVvod_BNS.TabStop = false;
            groupBoxVvod_BNS.Text = "Ввод Данных";
            // 
            // buttonDone_BNS
            // 
            buttonDone_BNS.Location = new Point(376, 90);
            buttonDone_BNS.Name = "buttonDone_BNS";
            buttonDone_BNS.Size = new Size(170, 84);
            buttonDone_BNS.TabIndex = 3;
            buttonDone_BNS.Text = "ВЫПОЛНИТЬ";
            buttonDone_BNS.UseVisualStyleBackColor = true;
            buttonDone_BNS.Click += buttonDone_BNS_Click;
            buttonDone_BNS.MouseDown += buttonDone_BNS_MouseDown;
            buttonDone_BNS.MouseEnter += buttonDone_BNS_MouseEnter;
            buttonDone_BNS.MouseLeave += buttonDone_BNS_MouseLeave;
            // 
            // buttonHelp_BNS
            // 
            buttonHelp_BNS.BackColor = SystemColors.ActiveCaption;
            buttonHelp_BNS.Location = new Point(227, 90);
            buttonHelp_BNS.Name = "buttonHelp_BNS";
            buttonHelp_BNS.Size = new Size(125, 84);
            buttonHelp_BNS.TabIndex = 2;
            buttonHelp_BNS.Text = "Справка";
            buttonHelp_BNS.UseVisualStyleBackColor = false;
            buttonHelp_BNS.Click += buttonHelp_BNS_Click;
            // 
            // groupBoxKonec_BNS
            // 
            groupBoxKonec_BNS.Controls.Add(textBoxStopStep_BNS);
            groupBoxKonec_BNS.Location = new Point(19, 107);
            groupBoxKonec_BNS.Name = "groupBoxKonec_BNS";
            groupBoxKonec_BNS.Size = new Size(169, 74);
            groupBoxKonec_BNS.TabIndex = 1;
            groupBoxKonec_BNS.TabStop = false;
            groupBoxKonec_BNS.Text = "Конец Шага";
            // 
            // textBoxStopStep_BNS
            // 
            textBoxStopStep_BNS.Location = new Point(13, 29);
            textBoxStopStep_BNS.Name = "textBoxStopStep_BNS";
            textBoxStopStep_BNS.Size = new Size(143, 27);
            textBoxStopStep_BNS.TabIndex = 0;
            // 
            // groupBoxStart_BNS
            // 
            groupBoxStart_BNS.Controls.Add(textBoxStartStep_BNS);
            groupBoxStart_BNS.Location = new Point(19, 26);
            groupBoxStart_BNS.Name = "groupBoxStart_BNS";
            groupBoxStart_BNS.Size = new Size(169, 75);
            groupBoxStart_BNS.TabIndex = 0;
            groupBoxStart_BNS.TabStop = false;
            groupBoxStart_BNS.Text = "Старт Шага";
            // 
            // textBoxStartStep_BNS
            // 
            textBoxStartStep_BNS.Location = new Point(15, 28);
            textBoxStartStep_BNS.Name = "textBoxStartStep_BNS";
            textBoxStartStep_BNS.Size = new Size(139, 27);
            textBoxStartStep_BNS.TabIndex = 0;
            // 
            // groupBoxVivod_BNS
            // 
            groupBoxVivod_BNS.Controls.Add(dataGridViewFunction_BNS);
            groupBoxVivod_BNS.Location = new Point(592, 21);
            groupBoxVivod_BNS.Name = "groupBoxVivod_BNS";
            groupBoxVivod_BNS.Size = new Size(721, 462);
            groupBoxVivod_BNS.TabIndex = 2;
            groupBoxVivod_BNS.TabStop = false;
            groupBoxVivod_BNS.Text = "Вывод Данных";
            // 
            // dataGridViewFunction_BNS
            // 
            dataGridViewFunction_BNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BNS.Columns.AddRange(new DataGridViewColumn[] { X_BNS, F_BNS });
            dataGridViewFunction_BNS.Location = new Point(9, 36);
            dataGridViewFunction_BNS.Name = "dataGridViewFunction_BNS";
            dataGridViewFunction_BNS.RowHeadersVisible = false;
            dataGridViewFunction_BNS.RowHeadersWidth = 51;
            dataGridViewFunction_BNS.Size = new Size(219, 420);
            dataGridViewFunction_BNS.TabIndex = 0;
            // 
            // X_BNS
            // 
            X_BNS.HeaderText = "X";
            X_BNS.MinimumWidth = 6;
            X_BNS.Name = "X_BNS";
            X_BNS.Width = 50;
            // 
            // F_BNS
            // 
            F_BNS.HeaderText = "F(x)";
            F_BNS.MinimumWidth = 6;
            F_BNS.Name = "F_BNS";
            F_BNS.Width = 50;
            // 
            // FormMain_BNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 494);
            Controls.Add(groupBoxVivod_BNS);
            Controls.Add(groupBoxVvod_BNS);
            Controls.Add(groupBoxUslovie_BNS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_BNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  2 | Вариант 8 | Бурмистров Н.С. ";
            Load += Form1_Load;
            groupBoxUslovie_BNS.ResumeLayout(false);
            groupBoxUslovie_BNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrimer_BNS).EndInit();
            groupBoxVvod_BNS.ResumeLayout(false);
            groupBoxKonec_BNS.ResumeLayout(false);
            groupBoxKonec_BNS.PerformLayout();
            groupBoxStart_BNS.ResumeLayout(false);
            groupBoxStart_BNS.PerformLayout();
            groupBoxVivod_BNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_BNS;
        private TextBox textBoxUslovie_BNS;
        private PictureBox pictureBoxPrimer_BNS;
        private GroupBox groupBoxVvod_BNS;
        private Button buttonDone_BNS;
        private Button buttonHelp_BNS;
        private GroupBox groupBoxKonec_BNS;
        private TextBox textBoxStopStep_BNS;
        private GroupBox groupBoxStart_BNS;
        private TextBox textBoxStartStep_BNS;
        private GroupBox groupBoxVivod_BNS;
        private DataGridView dataGridViewFunction_BNS;
        private DataGridViewTextBoxColumn X_BNS;
        private DataGridViewTextBoxColumn F_BNS;
    }
}
