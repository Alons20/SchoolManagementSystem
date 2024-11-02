namespace SchoolManagment
{
    partial class Enrollment
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
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            btnDisplay = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 42);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 0;
            label1.Text = "Enrollment";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(54, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(692, 264);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enrollment Information";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(127, 130);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(222, 26);
            dateTimePicker2.TabIndex = 21;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            dateTimePicker2.KeyDown += dateTimePicker2_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 133);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 20;
            label5.Text = "EnrollDate";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 26);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 101);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 18;
            label4.Text = "Section";
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(128, 128, 255);
            btnDisplay.Location = new Point(285, 222);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(73, 31);
            btnDisplay.TabIndex = 17;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = false;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Purple;
            btnNew.Location = new Point(198, 222);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(66, 31);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(100, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 31);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Location = new Point(285, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(73, 31);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Location = new Point(198, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(66, 31);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Location = new Point(100, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 26);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 73);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 1;
            label3.Text = "SubjectName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 41);
            label2.Name = "label2";
            label2.Size = new Size(33, 19);
            label2.TabIndex = 0;
            label2.Text = "EId";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 318);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(692, 120);
            dataGridView1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Enrol;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(414, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 118);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Enrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Enrollment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment";
            Load += Enrollment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Button btnDisplay;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSave;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}