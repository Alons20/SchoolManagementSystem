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

namespace SchoolManagment
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int AId;
            if (!int.TryParse(textBox1.Text, out AId))
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


                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM AttendDb WHERE AId = @AId", con);
                checkCmd.Parameters.AddWithValue("@AId", AId);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("A record with this ID already exists. Please use a unique ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (SqlCommand cmd = new SqlCommand("INSERT INTO AttendDb (AId, StudentName, Status) VALUES (@AId, @StudentName, @Status)", con))
                {
                    cmd.Parameters.AddWithValue("@AId", AId);
                    cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Status", textBox3.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Record saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AttendDb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int AId;
            if (!int.TryParse(textBox1.Text, out AId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE AttendDb SET StudentName=@StudentName, Status=@Status WHERE AId=@AId", con))
                {
                    cmd.Parameters.AddWithValue("@AId", AId);
                    cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Status", textBox3.Text);



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

            int AId;
            if (!int.TryParse(textBox1.Text, out AId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM AttendDb WHERE AId = @AId", con))
                {
                    cmd.Parameters.AddWithValue("@AId", AId);


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
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AttendDb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from AttendDb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}

