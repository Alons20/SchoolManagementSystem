namespace SchoolManagment
{
    partial class Dashboard
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblCount = new Label();
            label2 = new Label();
            panel4 = new Panel();
            lblCount1 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            lblCount2 = new Label();
            label9 = new Label();
            panel6 = new Panel();
            lblCount3 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 55);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(269, 36);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 407);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.admin_961;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(36, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 143);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(lblCount);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(301, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 143);
            panel3.TabIndex = 7;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.White;
            lblCount.Location = new Point(144, 54);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(31, 36);
            lblCount.TabIndex = 2;
            lblCount.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(146, 36);
            label2.TabIndex = 1;
            label2.Text = "Students:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Maroon;
            panel4.Controls.Add(lblCount1);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(590, 72);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 143);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount1.ForeColor = Color.White;
            lblCount1.Location = new Point(153, 54);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(31, 36);
            lblCount1.TabIndex = 4;
            lblCount1.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 54);
            label5.Name = "label5";
            label5.Size = new Size(142, 36);
            label5.TabIndex = 3;
            label5.Text = "Subjects:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Maroon;
            panel5.Controls.Add(lblCount2);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(301, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(223, 143);
            panel5.TabIndex = 8;
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount2.ForeColor = Color.White;
            lblCount2.Location = new Point(145, 56);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(31, 36);
            lblCount2.TabIndex = 8;
            lblCount2.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 53);
            label9.Name = "label9";
            label9.Size = new Size(146, 36);
            label9.TabIndex = 7;
            label9.Text = "Teachers:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Maroon;
            panel6.Controls.Add(lblCount3);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(590, 249);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 143);
            panel6.TabIndex = 8;
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount3.ForeColor = Color.White;
            lblCount3.Location = new Point(195, 56);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(31, 36);
            lblCount3.TabIndex = 6;
            lblCount3.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(12, 53);
            label7.Name = "label7";
            label7.Size = new Size(182, 36);
            label7.TabIndex = 5;
            label7.Text = "Enrollment:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 462);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblCount;
        private Label label2;
        private Label lblCount1;
        private Label label5;
        private Label lblCount2;
        private Label label9;
        private Label lblCount3;
        private Label label7;
    }
}