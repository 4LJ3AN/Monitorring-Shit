namespace Monitorring_Shit
{
    partial class Badminton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textStat1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(236, 223, 204);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(57, 57, 63);
            textBox1.Location = new Point(26, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 64);
            textBox1.TabIndex = 0;
            textBox1.Text = "Badminton Courts";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(131, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 519);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(593, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(354, 519);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textStat1
            // 
            textStat1.BackColor = Color.FromArgb(236, 223, 204);
            textStat1.BorderStyle = BorderStyle.None;
            textStat1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            textStat1.ForeColor = Color.FromArgb(57, 57, 63);
            textStat1.Location = new Point(223, 676);
            textStat1.Multiline = true;
            textStat1.Name = "textStat1";
            textStat1.Size = new Size(174, 26);
            textStat1.TabIndex = 3;
            textStat1.Text = "Court Status";
            textStat1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(236, 223, 204);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(57, 57, 63);
            textBox2.Location = new Point(686, 676);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 26);
            textBox2.TabIndex = 4;
            textBox2.Text = "Court Status";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Badminton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 223, 204);
            Controls.Add(textBox2);
            Controls.Add(textStat1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Name = "Badminton";
            Size = new Size(1074, 838);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textStat1;
        private TextBox textBox2;
    }
}
