
namespace SchoolManagment
{
    partial class Student
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
            pictureBox1 = new PictureBox();
            btnDisplay = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSave = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(800, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnDisplay);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 317);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student's Information";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.student;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(535, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 167);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnDisplay
            // 
            btnDisplay.BackColor = Color.FromArgb(128, 128, 255);
            btnDisplay.Location = new Point(562, 273);
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
            btnNew.Location = new Point(477, 273);
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
            btnDelete.Location = new Point(382, 273);
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
            btnUpdate.Location = new Point(282, 273);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(66, 31);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Location = new Point(191, 273);
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
            btnSave.Location = new Point(93, 273);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 31);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox1.Location = new Point(210, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(210, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 22);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.VisibleChanged += dateTimePicker1_VisibleChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 26);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 26);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 26);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(85, 229);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 191);
            label6.Name = "label6";
            label6.Size = new Size(50, 19);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 150);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 113);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 2;
            label4.Text = "DoB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 81);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 1;
            label3.Text = "StudentName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 47);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 0;
            label2.Text = "StudentId";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 383);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 154);
            dataGridView1.TabIndex = 2;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student";
            Load += Student_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, emailPattern))
            {
                textBox4.ForeColor = Color.Black; 
            }
            else
            {
                textBox4.ForeColor = Color.Red; 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex > 0) 
            {
                MessageBox.Show($"You selected: {comboBox1.SelectedItem}", "Selection Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnSave;
        private Button btnDisplay;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}