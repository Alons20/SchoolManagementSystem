using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagment
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Teacherdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int teacherId))
            {
                MessageBox.Show("Please enter a valid Teacher ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid Teacher Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid Phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Teacherdb (TeacherId, TeacherName, Gender, Phone) VALUES (@TeacherId, @TeacherName, @Gender, @Phone)", con);


                cmd.Parameters.AddWithValue("@TeacherId", teacherId); 
                cmd.Parameters.AddWithValue("@TeacherName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Phone", textBox3.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while saving the record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Teacherdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int teacherId))
            {
                MessageBox.Show("Please enter a valid Teacher ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Teacherdb set TeacherName=@TeacherName,Gender=@Gender,Phone=@Phone WHERE TeacherId=@TeacherId", con);
            cmd.Parameters.AddWithValue("@TeacherId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@TeacherName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int teacherId))
            {
                MessageBox.Show("Please enter a valid Teacher ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Teacherdb WHERE TeacherId=@TeacherId", con);
            cmd.Parameters.AddWithValue("@TeacherId", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = 0;
            textBox3.Text = "";
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = -1; 
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Teacherdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
