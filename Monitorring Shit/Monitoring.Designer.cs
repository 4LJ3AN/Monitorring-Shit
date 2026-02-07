namespace Monitorring_Shit
{
    partial class Monitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitoring));
            panel1 = new Panel();
            buttonScooter = new Button();
            buttonBilliards = new Button();
            buttonTabTennis = new Button();
            buttonBadminton = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 50, 51);
            panel1.Controls.Add(buttonScooter);
            panel1.Controls.Add(buttonBilliards);
            panel1.Controls.Add(buttonTabTennis);
            panel1.Controls.Add(buttonBadminton);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 838);
            panel1.TabIndex = 0;
            // 
            // buttonScooter
            // 
            buttonScooter.BackColor = Color.FromArgb(42, 50, 51);
            buttonScooter.Dock = DockStyle.Top;
            buttonScooter.FlatStyle = FlatStyle.Flat;
            buttonScooter.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            buttonScooter.ForeColor = Color.FromArgb(248, 222, 126);
            buttonScooter.Location = new Point(0, 505);
            buttonScooter.Name = "buttonScooter";
            buttonScooter.Size = new Size(304, 79);
            buttonScooter.TabIndex = 4;
            buttonScooter.Text = "\U0001f6f4 Scooter";
            buttonScooter.UseVisualStyleBackColor = false;
            buttonScooter.Click += buttonScooter_Click;
            // 
            // buttonBilliards
            // 
            buttonBilliards.BackColor = Color.FromArgb(42, 50, 51);
            buttonBilliards.Dock = DockStyle.Top;
            buttonBilliards.FlatStyle = FlatStyle.Flat;
            buttonBilliards.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            buttonBilliards.ForeColor = Color.FromArgb(248, 222, 126);
            buttonBilliards.Location = new Point(0, 426);
            buttonBilliards.Name = "buttonBilliards";
            buttonBilliards.Size = new Size(304, 79);
            buttonBilliards.TabIndex = 3;
            buttonBilliards.Text = "🎱 Billiards";
            buttonBilliards.UseVisualStyleBackColor = false;
            buttonBilliards.Click += buttonBilliards_Click;
            // 
            // buttonTabTennis
            // 
            buttonTabTennis.BackColor = Color.FromArgb(42, 50, 51);
            buttonTabTennis.Dock = DockStyle.Top;
            buttonTabTennis.FlatStyle = FlatStyle.Flat;
            buttonTabTennis.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            buttonTabTennis.ForeColor = Color.FromArgb(248, 222, 126);
            buttonTabTennis.Location = new Point(0, 347);
            buttonTabTennis.Name = "buttonTabTennis";
            buttonTabTennis.Size = new Size(304, 79);
            buttonTabTennis.TabIndex = 2;
            buttonTabTennis.Text = "🏓 Table Tennis";
            buttonTabTennis.UseVisualStyleBackColor = false;
            buttonTabTennis.Click += buttonTabTennis_Click;
            // 
            // buttonBadminton
            // 
            buttonBadminton.BackColor = Color.FromArgb(42, 50, 51);
            buttonBadminton.Dock = DockStyle.Top;
            buttonBadminton.FlatStyle = FlatStyle.Flat;
            buttonBadminton.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            buttonBadminton.ForeColor = Color.FromArgb(248, 222, 126);
            buttonBadminton.Location = new Point(0, 268);
            buttonBadminton.Name = "buttonBadminton";
            buttonBadminton.Size = new Size(304, 79);
            buttonBadminton.TabIndex = 1;
            buttonBadminton.Text = "🏸 Badminton ";
            buttonBadminton.UseVisualStyleBackColor = false;
            buttonBadminton.Click += buttonBadminton_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BorderStyle = BorderStyle.Fixed3D;
            panelMain.Dock = DockStyle.Bottom;
            panelMain.Location = new Point(304, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1074, 838);
            panelMain.TabIndex = 1;
            // 
            // Monitoring
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 255, 160);
            ClientSize = new Size(1378, 838);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "Monitoring";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Monitoring_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelMain;
        private PictureBox pictureBox1;
        private Button buttonScooter;
        private Button buttonBilliards;
        private Button buttonTabTennis;
        private Button buttonBadminton;
    }
}
