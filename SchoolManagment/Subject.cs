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
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Subjectdb VALUES(@SUbjectId, @SubjectName)", con);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@SubjectName", textBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved Successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Subjectdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(textBox1.Text, out int subjectId))
            {
                MessageBox.Show("Please enter a valid Subject ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Subjectdb SET SubjectName=@SubjectName WHERE SubjectId=@SubjectId", con))
                    {
                     
                        cmd.Parameters.AddWithValue("@SubjectId", subjectId);
                        cmd.Parameters.AddWithValue("@SubjectName", textBox2.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Subject ID.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int SubjectId))
            {
                MessageBox.Show("Please enter a valid Subject ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Subjectdb where SubjectId=@SubjectId", con);
            cmd.Parameters.AddWithValue("@SubjectId", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@SubjectName", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Subjectdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Subjectdb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
