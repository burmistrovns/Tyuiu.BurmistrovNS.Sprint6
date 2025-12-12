namespace Tyuiu.BurmistrovNS.Sprint6.Task0.V2
{
    partial class FormMain
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
            groupU_BNS = new GroupBox();
            pictureBoxFormula_BNS = new PictureBox();
            groupBoxVVOD_BNS = new GroupBox();
            textBoxDano_BNS = new TextBox();
            groupBoxVIVOD_BNS = new GroupBox();
            textBoxRes_BNS = new TextBox();
            buttonHELP_BNS = new Button();
            buttonEND_BNS = new Button();
            groupU_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BNS).BeginInit();
            groupBoxVVOD_BNS.SuspendLayout();
            groupBoxVIVOD_BNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupU_BNS
            // 
            groupU_BNS.Controls.Add(pictureBoxFormula_BNS);
            groupU_BNS.Location = new Point(3, 27);
            groupU_BNS.Name = "groupU_BNS";
            groupU_BNS.Size = new Size(785, 218);
            groupU_BNS.TabIndex = 0;
            groupU_BNS.TabStop = false;
            groupU_BNS.Text = "Условие";
            groupU_BNS.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula_BNS
            // 
            pictureBoxFormula_BNS.Image = Properties.Resources.Снимок_экрана_2025_12_12_131549;
            pictureBoxFormula_BNS.Location = new Point(9, 26);
            pictureBoxFormula_BNS.Name = "pictureBoxFormula_BNS";
            pictureBoxFormula_BNS.Size = new Size(190, 104);
            pictureBoxFormula_BNS.TabIndex = 0;
            pictureBoxFormula_BNS.TabStop = false;
            pictureBoxFormula_BNS.Click += pictureBoxFormula_BNS_Click;
            // 
            // groupBoxVVOD_BNS
            // 
            groupBoxVVOD_BNS.Controls.Add(textBoxDano_BNS);
            groupBoxVVOD_BNS.Location = new Point(3, 251);
            groupBoxVVOD_BNS.Name = "groupBoxVVOD_BNS";
            groupBoxVVOD_BNS.Size = new Size(444, 140);
            groupBoxVVOD_BNS.TabIndex = 1;
            groupBoxVVOD_BNS.TabStop = false;
            groupBoxVVOD_BNS.Text = "Ввод данных";
            groupBoxVVOD_BNS.Enter += groupBoxVVOD_BNS_Enter;
            // 
            // textBoxDano_BNS
            // 
            textBoxDano_BNS.Location = new Point(19, 58);
            textBoxDano_BNS.Name = "textBoxDano_BNS";
            textBoxDano_BNS.Size = new Size(180, 27);
            textBoxDano_BNS.TabIndex = 0;
            textBoxDano_BNS.TextChanged += textBoxDano_BNS_TextChanged;
            textBoxDano_BNS.KeyPress += textBoxDano_BNS_KeyPress;
            // 
            // groupBoxVIVOD_BNS
            // 
            groupBoxVIVOD_BNS.Controls.Add(textBoxRes_BNS);
            groupBoxVIVOD_BNS.Location = new Point(470, 251);
            groupBoxVIVOD_BNS.Name = "groupBoxVIVOD_BNS";
            groupBoxVIVOD_BNS.Size = new Size(318, 140);
            groupBoxVIVOD_BNS.TabIndex = 2;
            groupBoxVIVOD_BNS.TabStop = false;
            groupBoxVIVOD_BNS.Text = "Вывод данных";
            groupBoxVIVOD_BNS.Enter += groupBoxVIVOD_BNS_Enter;
            // 
            // textBoxRes_BNS
            // 
            textBoxRes_BNS.Location = new Point(25, 58);
            textBoxRes_BNS.Name = "textBoxRes_BNS";
            textBoxRes_BNS.ReadOnly = true;
            textBoxRes_BNS.Size = new Size(217, 27);
            textBoxRes_BNS.TabIndex = 0;
            textBoxRes_BNS.TextChanged += textBoxRes_BNS_TextChanged;
            // 
            // buttonHELP_BNS
            // 
            buttonHELP_BNS.Location = new Point(479, 403);
            buttonHELP_BNS.Name = "buttonHELP_BNS";
            buttonHELP_BNS.Size = new Size(44, 45);
            buttonHELP_BNS.TabIndex = 3;
            buttonHELP_BNS.Text = "?";
            buttonHELP_BNS.UseVisualStyleBackColor = true;
            buttonHELP_BNS.Click += buttonHELP_BNS_Click;
            // 
            // buttonEND_BNS
            // 
            buttonEND_BNS.Location = new Point(546, 403);
            buttonEND_BNS.Name = "buttonEND_BNS";
            buttonEND_BNS.Size = new Size(242, 45);
            buttonEND_BNS.TabIndex = 4;
            buttonEND_BNS.Text = "ВЫПОЛНИТЬ";
            buttonEND_BNS.UseVisualStyleBackColor = true;
            buttonEND_BNS.Click += buttonEND_BNS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEND_BNS);
            Controls.Add(buttonHELP_BNS);
            Controls.Add(groupBoxVIVOD_BNS);
            Controls.Add(groupBoxVVOD_BNS);
            Controls.Add(groupU_BNS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  0 | Вариант 2 | Бурмистров Н.С. ";
            Load += FormMain_Load;
            groupU_BNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BNS).EndInit();
            groupBoxVVOD_BNS.ResumeLayout(false);
            groupBoxVVOD_BNS.PerformLayout();
            groupBoxVIVOD_BNS.ResumeLayout(false);
            groupBoxVIVOD_BNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupU_BNS;
        private GroupBox groupBoxVVOD_BNS;
        private GroupBox groupBoxVIVOD_BNS;
        private PictureBox pictureBoxFormula_BNS;
        private TextBox textBoxDano_BNS;
        private Button buttonHELP_BNS;
        private Button buttonEND_BNS;
        private TextBox textBoxRes_BNS;
    }
}
