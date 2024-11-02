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
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            int EId;
            if (!int.TryParse(textBox1.Text, out EId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();

               
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Endb WHERE EId = @EId", con);
                checkCmd.Parameters.AddWithValue("@EId", EId);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("A record with this ID already exists. Please use a unique ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

              
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Endb (EId, StudentName, Section, EnrollDate) VALUES (@EId, @StudentName, @Section, @EnrollDate)", con))
                {
                    cmd.Parameters.AddWithValue("@EId", EId);
                    cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Section", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker2.Value);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Endb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int EId;
            if (!int.TryParse(textBox1.Text, out EId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Endb SET StudentName=@StudentName, Section=@Section, EnrollDate=@EnrollDate WHERE EId=@EId", con))
                {
                    cmd.Parameters.AddWithValue("@EId", EId);
                    cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Section", textBox3.Text);
                    cmd.Parameters.AddWithValue("@EnrollDate", dateTimePicker2.Value);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found. Please check the ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            int EId;
            if (!int.TryParse(textBox1.Text, out EId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Endb WHERE EId = @EId", con))
                {
                    cmd.Parameters.AddWithValue("@EId", EId);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found. Please check the ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker2.Value = DateTime.Now;

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Endb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Endb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
