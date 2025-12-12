namespace Tyuiu.BurmistrovNS.Spriint6.Task6.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BNS));
            panelUp_BNS = new Panel();
            panelLeft_BNS = new Panel();
            panelRight_BNS = new Panel();
            splitter1 = new Splitter();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox_BNS = new GroupBox();
            textBox3 = new TextBox();
            panelUp_BNS.SuspendLayout();
            panelLeft_BNS.SuspendLayout();
            panelRight_BNS.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox_BNS.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_BNS
            // 
            panelUp_BNS.BackColor = SystemColors.ActiveBorder;
            panelUp_BNS.Controls.Add(groupBox_BNS);
            panelUp_BNS.Dock = DockStyle.Top;
            panelUp_BNS.Location = new Point(0, 0);
            panelUp_BNS.Name = "panelUp_BNS";
            panelUp_BNS.Size = new Size(782, 127);
            panelUp_BNS.TabIndex = 0;
            // 
            // panelLeft_BNS
            // 
            panelLeft_BNS.BackColor = SystemColors.ButtonFace;
            panelLeft_BNS.Controls.Add(groupBox1);
            panelLeft_BNS.Dock = DockStyle.Left;
            panelLeft_BNS.Location = new Point(0, 127);
            panelLeft_BNS.Name = "panelLeft_BNS";
            panelLeft_BNS.Size = new Size(380, 436);
            panelLeft_BNS.TabIndex = 1;
            // 
            // panelRight_BNS
            // 
            panelRight_BNS.Controls.Add(groupBox2);
            panelRight_BNS.Dock = DockStyle.Fill;
            panelRight_BNS.Location = new Point(380, 127);
            panelRight_BNS.Name = "panelRight_BNS";
            panelRight_BNS.Size = new Size(402, 436);
            panelRight_BNS.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(380, 127);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 436);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 436);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод Данных";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 436);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод Данных";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(374, 410);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 23);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(396, 410);
            textBox2.TabIndex = 0;
            // 
            // groupBox_BNS
            // 
            groupBox_BNS.Controls.Add(textBox3);
            groupBox_BNS.Location = new Point(3, 33);
            groupBox_BNS.Name = "groupBox_BNS";
            groupBox_BNS.Size = new Size(773, 94);
            groupBox_BNS.TabIndex = 0;
            groupBox_BNS.TabStop = false;
            groupBox_BNS.Text = "Условие";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Location = new Point(6, 26);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(758, 64);
            textBox3.TabIndex = 0;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // FormMain_BNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 563);
            Controls.Add(splitter1);
            Controls.Add(panelRight_BNS);
            Controls.Add(panelLeft_BNS);
            Controls.Add(panelUp_BNS);
            MinimumSize = new Size(800, 450);
            Name = "FormMain_BNS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  4 | Вариант 27 | Бурмистров Н.С. ";
            Load += this.FormMain_BNS_Load;
            panelUp_BNS.ResumeLayout(false);
            panelLeft_BNS.ResumeLayout(false);
            panelRight_BNS.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox_BNS.ResumeLayout(false);
            groupBox_BNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_BNS;
        private Panel panelLeft_BNS;
        private Panel panelRight_BNS;
        private Splitter splitter1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox_BNS;
        private TextBox textBox3;
    }
}
