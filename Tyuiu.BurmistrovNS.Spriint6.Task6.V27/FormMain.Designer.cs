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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_BNS));
            panelUp_BNS = new Panel();
            buttonHelp = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            groupBox_BNS = new GroupBox();
            textBox3 = new TextBox();
            panelLeft_BNS = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            panelRight_BNS = new Panel();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            splitter1 = new Splitter();
            toolTip1 = new ToolTip(components);
            openFilePath = new OpenFileDialog();
            openFileDialogTask = new OpenFileDialog();
            panelUp_BNS.SuspendLayout();
            groupBox_BNS.SuspendLayout();
            panelLeft_BNS.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panelRight_BNS.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp_BNS
            // 
            panelUp_BNS.BackColor = SystemColors.ActiveBorder;
            panelUp_BNS.Controls.Add(buttonHelp);
            panelUp_BNS.Controls.Add(buttonDone);
            panelUp_BNS.Controls.Add(buttonOpenFile);
            panelUp_BNS.Controls.Add(groupBox_BNS);
            panelUp_BNS.Dock = DockStyle.Top;
            panelUp_BNS.Location = new Point(0, 0);
            panelUp_BNS.Name = "panelUp_BNS";
            panelUp_BNS.Size = new Size(782, 127);
            panelUp_BNS.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(668, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(102, 35);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(106, 2);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(109, 32);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Начать";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(6, 0);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(56, 36);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "файл";
            toolTip1.SetToolTip(buttonOpenFile, "Выберите файл\r\n\r\nВыберите нужный файл длля обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBox_BNS
            // 
            groupBox_BNS.Controls.Add(textBox3);
            groupBox_BNS.Dock = DockStyle.Bottom;
            groupBox_BNS.Location = new Point(0, 33);
            groupBox_BNS.Name = "groupBox_BNS";
            groupBox_BNS.Size = new Size(782, 94);
            groupBox_BNS.TabIndex = 0;
            groupBox_BNS.TabStop = false;
            groupBox_BNS.Text = "Условие";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveBorder;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(3, 23);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(776, 68);
            textBox3.TabIndex = 0;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // panelLeft_BNS
            // 
            panelLeft_BNS.BackColor = SystemColors.ButtonFace;
            panelLeft_BNS.Controls.Add(groupBoxIn);
            panelLeft_BNS.Dock = DockStyle.Left;
            panelLeft_BNS.Location = new Point(0, 127);
            panelLeft_BNS.Name = "panelLeft_BNS";
            panelLeft_BNS.Size = new Size(380, 436);
            panelLeft_BNS.TabIndex = 1;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(380, 436);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод Данных";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 23);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(374, 410);
            textBoxIn.TabIndex = 0;
            textBoxIn.TextChanged += textBoxIn_TextChanged;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(402, 436);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод Данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(396, 410);
            textBoxResult.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(380, 127);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 436);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFilePath
            // 
            openFilePath.FileName = "openFileDialog1";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
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
            panelUp_BNS.ResumeLayout(false);
            groupBox_BNS.ResumeLayout(false);
            groupBox_BNS.PerformLayout();
            panelLeft_BNS.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panelRight_BNS.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_BNS;
        private Panel panelLeft_BNS;
        private Panel panelRight_BNS;
        private Splitter splitter1;
        private GroupBox groupBoxIn;
        private GroupBox groupBox2;
        private TextBox textBoxIn;
        private TextBox textBoxResult;
        private GroupBox groupBox_BNS;
        private TextBox textBox3;
        private Button buttonOpenFile;
        private ToolTip toolTip1;
        private Button buttonHelp;
        private Button buttonDone;
        private OpenFileDialog openFilePath;
        private OpenFileDialog openFileDialogTask;
    }
}
