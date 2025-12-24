namespace Tyuiu.BurmistrovNS.Sprint6.Task7.V14
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_BNS = new Panel();
            buttonMessage_BNS = new Button();
            buttonSaveFile_BNS = new Button();
            buttonDone_BNS = new Button();
            buttonOpenFile_BNS = new Button();
            groupBoxTask_BNS = new GroupBox();
            textBoxTask_BNS = new TextBox();
            panelInPut_BNS = new Panel();
            groupBoxLeft_BNS = new GroupBox();
            dataGridViewIn_BNS = new DataGridView();
            panelOutPut_BNS = new Panel();
            groupBoxRight_BNS = new GroupBox();
            dataGridViewOut_BNS = new DataGridView();
            splitterRas_BNS = new Splitter();
            openFileDialogTask_BNS = new OpenFileDialog();
            saveFileDialogMatrix_BNS = new SaveFileDialog();
            toolTip_BNS = new ToolTip(components);
            panelTop_BNS.SuspendLayout();
            groupBoxTask_BNS.SuspendLayout();
            panelInPut_BNS.SuspendLayout();
            groupBoxLeft_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BNS).BeginInit();
            panelOutPut_BNS.SuspendLayout();
            groupBoxRight_BNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BNS).BeginInit();
            SuspendLayout();
            // 
            // panelTop_BNS
            // 
            panelTop_BNS.Controls.Add(buttonMessage_BNS);
            panelTop_BNS.Controls.Add(buttonSaveFile_BNS);
            panelTop_BNS.Controls.Add(buttonDone_BNS);
            panelTop_BNS.Controls.Add(buttonOpenFile_BNS);
            panelTop_BNS.Controls.Add(groupBoxTask_BNS);
            panelTop_BNS.Dock = DockStyle.Top;
            panelTop_BNS.Location = new Point(0, 0);
            panelTop_BNS.Name = "panelTop_BNS";
            panelTop_BNS.Size = new Size(800, 153);
            panelTop_BNS.TabIndex = 0;
            // 
            // buttonMessage_BNS
            // 
            buttonMessage_BNS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMessage_BNS.FlatStyle = FlatStyle.Flat;
            buttonMessage_BNS.Image = (Image)resources.GetObject("buttonMessage_BNS.Image");
            buttonMessage_BNS.Location = new Point(735, 3);
            buttonMessage_BNS.Name = "buttonMessage_BNS";
            buttonMessage_BNS.Size = new Size(62, 57);
            buttonMessage_BNS.TabIndex = 1;
            toolTip_BNS.SetToolTip(buttonMessage_BNS, "Справка");
            buttonMessage_BNS.UseVisualStyleBackColor = true;
            buttonMessage_BNS.Click += buttonMessage_BNS_Click;
            // 
            // buttonSaveFile_BNS
            // 
            buttonSaveFile_BNS.Enabled = false;
            buttonSaveFile_BNS.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_BNS.Image = (Image)resources.GetObject("buttonSaveFile_BNS.Image");
            buttonSaveFile_BNS.Location = new Point(167, 3);
            buttonSaveFile_BNS.Name = "buttonSaveFile_BNS";
            buttonSaveFile_BNS.Size = new Size(62, 57);
            buttonSaveFile_BNS.TabIndex = 1;
            toolTip_BNS.SetToolTip(buttonSaveFile_BNS, "Сохранить в файл");
            buttonSaveFile_BNS.UseVisualStyleBackColor = true;
            buttonSaveFile_BNS.Click += buttonSaveFile_BNS_Click;
            // 
            // buttonDone_BNS
            // 
            buttonDone_BNS.Enabled = false;
            buttonDone_BNS.FlatStyle = FlatStyle.Flat;
            buttonDone_BNS.Image = (Image)resources.GetObject("buttonDone_BNS.Image");
            buttonDone_BNS.Location = new Point(89, 3);
            buttonDone_BNS.Name = "buttonDone_BNS";
            buttonDone_BNS.Size = new Size(62, 57);
            buttonDone_BNS.TabIndex = 1;
            toolTip_BNS.SetToolTip(buttonDone_BNS, "Выполнить");
            buttonDone_BNS.UseVisualStyleBackColor = true;
            buttonDone_BNS.Click += buttonDone_BNS_Click;
            // 
            // buttonOpenFile_BNS
            // 
            buttonOpenFile_BNS.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_BNS.Image = (Image)resources.GetObject("buttonOpenFile_BNS.Image");
            buttonOpenFile_BNS.Location = new Point(12, 3);
            buttonOpenFile_BNS.Name = "buttonOpenFile_BNS";
            buttonOpenFile_BNS.Size = new Size(62, 57);
            buttonOpenFile_BNS.TabIndex = 1;
            toolTip_BNS.SetToolTip(buttonOpenFile_BNS, "Открыть файл");
            buttonOpenFile_BNS.UseVisualStyleBackColor = true;
            buttonOpenFile_BNS.Click += buttonOpenFile_BNS_Click;
            buttonOpenFile_BNS.MouseEnter += buttonOpenFile_BNS_MouseEnter;
            // 
            // groupBoxTask_BNS
            // 
            groupBoxTask_BNS.Controls.Add(textBoxTask_BNS);
            groupBoxTask_BNS.Dock = DockStyle.Bottom;
            groupBoxTask_BNS.Location = new Point(0, 60);
            groupBoxTask_BNS.Name = "groupBoxTask_BNS";
            groupBoxTask_BNS.Size = new Size(800, 93);
            groupBoxTask_BNS.TabIndex = 0;
            groupBoxTask_BNS.TabStop = false;
            groupBoxTask_BNS.Text = "Условие";
            // 
            // textBoxTask_BNS
            // 
            textBoxTask_BNS.Dock = DockStyle.Fill;
            textBoxTask_BNS.Location = new Point(3, 23);
            textBoxTask_BNS.Multiline = true;
            textBoxTask_BNS.Name = "textBoxTask_BNS";
            textBoxTask_BNS.ReadOnly = true;
            textBoxTask_BNS.Size = new Size(794, 67);
            textBoxTask_BNS.TabIndex = 0;
            textBoxTask_BNS.Text = resources.GetString("textBoxTask_BNS.Text");
            // 
            // panelInPut_BNS
            // 
            panelInPut_BNS.Controls.Add(groupBoxLeft_BNS);
            panelInPut_BNS.Dock = DockStyle.Left;
            panelInPut_BNS.Location = new Point(0, 153);
            panelInPut_BNS.Name = "panelInPut_BNS";
            panelInPut_BNS.Size = new Size(284, 297);
            panelInPut_BNS.TabIndex = 0;
            // 
            // groupBoxLeft_BNS
            // 
            groupBoxLeft_BNS.Controls.Add(dataGridViewIn_BNS);
            groupBoxLeft_BNS.Dock = DockStyle.Fill;
            groupBoxLeft_BNS.Location = new Point(0, 0);
            groupBoxLeft_BNS.Name = "groupBoxLeft_BNS";
            groupBoxLeft_BNS.Size = new Size(284, 297);
            groupBoxLeft_BNS.TabIndex = 0;
            groupBoxLeft_BNS.TabStop = false;
            groupBoxLeft_BNS.Text = "Ввод данных";
            // 
            // dataGridViewIn_BNS
            // 
            dataGridViewIn_BNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_BNS.Dock = DockStyle.Fill;
            dataGridViewIn_BNS.Location = new Point(3, 23);
            dataGridViewIn_BNS.Name = "dataGridViewIn_BNS";
            dataGridViewIn_BNS.RowHeadersWidth = 51;
            dataGridViewIn_BNS.Size = new Size(278, 271);
            dataGridViewIn_BNS.TabIndex = 0;
            // 
            // panelOutPut_BNS
            // 
            panelOutPut_BNS.Controls.Add(groupBoxRight_BNS);
            panelOutPut_BNS.Dock = DockStyle.Fill;
            panelOutPut_BNS.Location = new Point(284, 153);
            panelOutPut_BNS.Name = "panelOutPut_BNS";
            panelOutPut_BNS.Size = new Size(516, 297);
            panelOutPut_BNS.TabIndex = 0;
            // 
            // groupBoxRight_BNS
            // 
            groupBoxRight_BNS.Controls.Add(dataGridViewOut_BNS);
            groupBoxRight_BNS.Dock = DockStyle.Fill;
            groupBoxRight_BNS.Location = new Point(0, 0);
            groupBoxRight_BNS.Name = "groupBoxRight_BNS";
            groupBoxRight_BNS.Size = new Size(516, 297);
            groupBoxRight_BNS.TabIndex = 0;
            groupBoxRight_BNS.TabStop = false;
            groupBoxRight_BNS.Text = "Вывод данных";
            // 
            // dataGridViewOut_BNS
            // 
            dataGridViewOut_BNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_BNS.Dock = DockStyle.Fill;
            dataGridViewOut_BNS.Location = new Point(3, 23);
            dataGridViewOut_BNS.Name = "dataGridViewOut_BNS";
            dataGridViewOut_BNS.RowHeadersWidth = 51;
            dataGridViewOut_BNS.Size = new Size(510, 271);
            dataGridViewOut_BNS.TabIndex = 0;
            // 
            // splitterRas_BNS
            // 
            splitterRas_BNS.Location = new Point(284, 153);
            splitterRas_BNS.Name = "splitterRas_BNS";
            splitterRas_BNS.Size = new Size(4, 297);
            splitterRas_BNS.TabIndex = 1;
            splitterRas_BNS.TabStop = false;
            // 
            // openFileDialogTask_BNS
            // 
            openFileDialogTask_BNS.FileName = "openFileDialog1";
            // 
            // toolTip_BNS
            // 
            toolTip_BNS.IsBalloon = true;
            toolTip_BNS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitterRas_BNS);
            Controls.Add(panelOutPut_BNS);
            Controls.Add(panelInPut_BNS);
            Controls.Add(panelTop_BNS);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск  7 | Вариант 14 | Бурмистров Н.С. ";
            Load += Form1_Load;
            panelTop_BNS.ResumeLayout(false);
            groupBoxTask_BNS.ResumeLayout(false);
            groupBoxTask_BNS.PerformLayout();
            panelInPut_BNS.ResumeLayout(false);
            groupBoxLeft_BNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_BNS).EndInit();
            panelOutPut_BNS.ResumeLayout(false);
            groupBoxRight_BNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_BNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_BNS;
        private Panel panelInPut_BNS;
        private Panel panelOutPut_BNS;
        private GroupBox groupBoxTask_BNS;
        private GroupBox groupBoxLeft_BNS;
        private GroupBox groupBoxRight_BNS;
        private Splitter splitterRas_BNS;
        private TextBox textBoxTask_BNS;
        private Button buttonMessage_BNS;
        private Button buttonSaveFile_BNS;
        private Button buttonDone_BNS;
        private Button buttonOpenFile_BNS;
        private DataGridView dataGridViewIn_BNS;
        private OpenFileDialog openFileDialogTask_BNS;
        private SaveFileDialog saveFileDialogMatrix_BNS;
        private DataGridView dataGridViewOut_BNS;
        private ToolTip toolTip_BNS;
    }
}
