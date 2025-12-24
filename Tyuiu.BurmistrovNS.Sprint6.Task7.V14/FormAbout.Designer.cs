namespace Tyuiu.BurmistrovNS.Sprint6.Task7.V14
{
    partial class FormAboutInfo_BNS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutInfo_BNS));
            pictureBoxAva_BNS = new PictureBox();
            labelInfo_BNS = new Label();
            buttonOk_BNS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_BNS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva_BNS
            // 
            pictureBoxAva_BNS.Image = (Image)resources.GetObject("pictureBoxAva_BNS.Image");
            pictureBoxAva_BNS.Location = new Point(20, 40);
            pictureBoxAva_BNS.Name = "pictureBoxAva_BNS";
            pictureBoxAva_BNS.Size = new Size(265, 315);
            pictureBoxAva_BNS.TabIndex = 0;
            pictureBoxAva_BNS.TabStop = false;
            // 
            // labelInfo_BNS
            // 
            labelInfo_BNS.AutoSize = true;
            labelInfo_BNS.Location = new Point(319, 40);
            labelInfo_BNS.Name = "labelInfo_BNS";
            labelInfo_BNS.Size = new Size(377, 160);
            labelInfo_BNS.TabIndex = 1;
            labelInfo_BNS.Text = resources.GetString("labelInfo_BNS.Text");
            // 
            // buttonOk_BNS
            // 
            buttonOk_BNS.Location = new Point(704, 374);
            buttonOk_BNS.Name = "buttonOk_BNS";
            buttonOk_BNS.Size = new Size(59, 39);
            buttonOk_BNS.TabIndex = 2;
            buttonOk_BNS.Text = "Ок";
            buttonOk_BNS.UseVisualStyleBackColor = true;
            buttonOk_BNS.Click += buttonOk_BNS_Click;
            // 
            // FormAboutInfo_BNS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk_BNS);
            Controls.Add(labelInfo_BNS);
            Controls.Add(pictureBoxAva_BNS);
            Name = "FormAboutInfo_BNS";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_BNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAva_BNS;
        private Label labelInfo_BNS;
        private Button buttonOk_BNS;
    }
}