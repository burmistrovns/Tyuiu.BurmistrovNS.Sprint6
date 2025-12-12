namespace Tyuiu.BurmistrovNS.Spriint6.Task6.V27
{
    partial class FormAbout
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button123 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mid_368370_753436;
            pictureBox1.Location = new Point(26, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 323);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 43);
            label1.Name = "label1";
            label1.Size = new Size(387, 60);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Бурмистров Н.С.\r\nГруппа: ИСТНб-25-1\r\nПрограмма разработана в рмаках изучения языка C#\r\n";
            // 
            // button123
            // 
            button123.Location = new Point(645, 368);
            button123.Name = "button123";
            button123.Size = new Size(102, 34);
            button123.TabIndex = 2;
            button123.Text = "ok";
            button123.UseVisualStyleBackColor = true;
            button123.Click += button123_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button123);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button123;
    }
}