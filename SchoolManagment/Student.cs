using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagment
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.CustomFormat = "";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid Student Name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "Select Gender")
            {
                MessageBox.Show("Please select a valid Gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid Phone number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter a valid Email.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Studentdb VALUES(@StudentId, @StudentName, @DoB,@Gender,@Phone,@Email)", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cmd.Parameters.AddWithValue("@DoB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Studentdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "Select Gender")
            {
                MessageBox.Show("Please select a valid Gender.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Studentdb set StudentName=@StudentName, DoB=@DoB,Gender=@Gender,Phone=@Phone,Email=@Email where StudentId=@StudentId", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cmd.Parameters.AddWithValue("@DoB", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
           
            MessageBox.Show("Record Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Studentdb WHERE StudentId = @StudentId", con);
            cmd.Parameters.AddWithValue("@StudentId", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            textBox3.Text = "";
            textBox4.Text = "";
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = -1; 
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Studentdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Studentdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
