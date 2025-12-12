namespace Tyuiu.BurmistrovNS.Sprint6.Task1.V6
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
            groupBoxU_BNS = new GroupBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBoxResult = new GroupBox();
            textBoxResult_BNS = new TextBox();
            groupBoxVVD_BNS = new GroupBox();
            buttonVPL_BNS = new Button();
            buttonSPR_BNS = new Button();
            groupBoxST2_BNS = new GroupBox();
            textBoxKONEC_BNS = new TextBox();
            groupBoxST1_BNS = new GroupBox();
            textBoxStart_BNS = new TextBox();
            groupBoxU_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxResult.SuspendLayout();
            groupBoxVVD_BNS.SuspendLayout();
            groupBoxST2_BNS.SuspendLayout();
            groupBoxST1_BNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxU_BNS
            // 
            groupBoxU_BNS.Controls.Add(textBox1);
            groupBoxU_BNS.Controls.Add(pictureBox1);
            groupBoxU_BNS.Location = new Point(4, 2);
            groupBoxU_BNS.Name = "groupBoxU_BNS";
            groupBoxU_BNS.Size = new Size(530, 267);
            groupBoxU_BNS.TabIndex = 0;
            groupBoxU_BNS.TabStop = false;
            groupBoxU_BNS.Tag = "";
            groupBoxU_BNS.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 114);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(523, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Произвести табулирование F(x) на заданном диапазоне [-5; 5] с шагом 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2025_12_12_192829;
            pictureBox1.Location = new Point(14, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 82);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult_BNS);
            groupBoxResult.Location = new Point(540, 2);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(257, 436);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод Данных";
            // 
            // textBoxResult_BNS
            // 
            textBoxResult_BNS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_BNS.Location = new Point(8, 24);
            textBoxResult_BNS.Multiline = true;
            textBoxResult_BNS.Name = "textBoxResult_BNS";
            textBoxResult_BNS.ReadOnly = true;
            textBoxResult_BNS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BNS.Size = new Size(244, 406);
            textBoxResult_BNS.TabIndex = 0;
            textBoxResult_BNS.Text = " ";
            // 
            // groupBoxVVD_BNS
            // 
            groupBoxVVD_BNS.Controls.Add(buttonVPL_BNS);
            groupBoxVVD_BNS.Controls.Add(buttonSPR_BNS);
            groupBoxVVD_BNS.Controls.Add(groupBoxST2_BNS);
            groupBoxVVD_BNS.Controls.Add(groupBoxST1_BNS);
            groupBoxVVD_BNS.Location = new Point(4, 275);
            groupBoxVVD_BNS.Name = "groupBoxVVD_BNS";
            groupBoxVVD_BNS.Size = new Size(530, 163);
            groupBoxVVD_BNS.TabIndex = 2;
            groupBoxVVD_BNS.TabStop = false;
            groupBoxVVD_BNS.Text = "Ввод Данных";
            // 
            // buttonVPL_BNS
            // 
            buttonVPL_BNS.BackColor = Color.Green;
            buttonVPL_BNS.Location = new Point(382, 106);
            buttonVPL_BNS.Name = "buttonVPL_BNS";
            buttonVPL_BNS.Size = new Size(139, 54);
            buttonVPL_BNS.TabIndex = 3;
            buttonVPL_BNS.Text = "ВЫПОЛНИТЬ";
            buttonVPL_BNS.UseVisualStyleBackColor = false;
            buttonVPL_BNS.Click += buttonVPL_BNS_Click;
            // 
            // buttonSPR_BNS
            // 
            buttonSPR_BNS.BackColor = SystemColors.HotTrack;
            buttonSPR_BNS.Location = new Point(244, 106);
            buttonSPR_BNS.Name = "buttonSPR_BNS";
            buttonSPR_BNS.Size = new Size(118, 54);
            buttonSPR_BNS.TabIndex = 2;
            buttonSPR_BNS.Text = "СПРАВКА";
            buttonSPR_BNS.UseVisualStyleBackColor = false;
            buttonSPR_BNS.Click += buttonSPR_BNS_Click;
            // 
            // groupBoxST2_BNS
            // 
            groupBoxST2_BNS.Controls.Add(textBoxKONEC_BNS);
            groupBoxST2_BNS.Location = new Point(6, 93);
            groupBoxST2_BNS.Name = "groupBoxST2_BNS";
            groupBoxST2_BNS.Size = new Size(208, 64);
            groupBoxST2_BNS.TabIndex = 1;
            groupBoxST2_BNS.TabStop = false;
            groupBoxST2_BNS.Text = "Конец Шага:";
            // 
            // textBoxKONEC_BNS
            // 
            textBoxKONEC_BNS.Location = new Point(12, 25);
            textBoxKONEC_BNS.Name = "textBoxKONEC_BNS";
            textBoxKONEC_BNS.Size = new Size(181, 27);
            textBoxKONEC_BNS.TabIndex = 0;
            // 
            // groupBoxST1_BNS
            // 
            groupBoxST1_BNS.Controls.Add(textBoxStart_BNS);
            groupBoxST1_BNS.Location = new Point(6, 26);
            groupBoxST1_BNS.Name = "groupBoxST1_BNS";
            groupBoxST1_BNS.Size = new Size(208, 64);
            groupBoxST1_BNS.TabIndex = 0;
            groupBoxST1_BNS.TabStop = false;
            groupBoxST1_BNS.Text = "Старт Шага:";
            // 
            // textBoxStart_BNS
            // 
            textBoxStart_BNS.Location = new Point(12, 23);
            textBoxStart_BNS.Name = "textBoxStart_BNS";
            textBoxStart_BNS.Size = new Size(186, 27);
            textBoxStart_BNS.TabIndex = 0;
            // 
            // FormMain_BNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxVVD_BNS);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxU_BNS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_BNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  1 | Вариант 6 | Бурмистров Н.С. ";
            Load += FormMain_Load;
            groupBoxU_BNS.ResumeLayout(false);
            groupBoxU_BNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxVVD_BNS.ResumeLayout(false);
            groupBoxST2_BNS.ResumeLayout(false);
            groupBoxST2_BNS.PerformLayout();
            groupBoxST1_BNS.ResumeLayout(false);
            groupBoxST1_BNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxU_BNS;
        private GroupBox groupBoxResult;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBoxVVD_BNS;
        private GroupBox groupBoxST2_BNS;
        private TextBox textBoxKONEC_BNS;
        private GroupBox groupBoxST1_BNS;
        private TextBox textBoxStart_BNS;
        private TextBox textBoxResult_BNS;
        private Button buttonVPL_BNS;
        private Button buttonSPR_BNS;
    }
}
