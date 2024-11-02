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
    public partial class Section : Form
    {
        public Section()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int sectionId))
            {
                MessageBox.Show("Please enter a valid Section ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid Student Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid Section.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sectiondb (SectionId, StudentName, Section) VALUES (@SectionId, @StudentName, @Section)", con);

                cmd.Parameters.AddWithValue("@SectionId", sectionId);
                cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Section", textBox3.Text);

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
            SqlCommand cmd = new SqlCommand("Select * from Sectiondb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int sectionId))
            {
                MessageBox.Show("Please enter a valid Section ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid Student Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid Section.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Sectiondb SET StudentName=@StudentName, Section=@Section WHERE SectionId=@SectionId", con);

                cmd.Parameters.AddWithValue("@SectionId", sectionId); 
                cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
                cmd.Parameters.AddWithValue("@Section", textBox3.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while updating the record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int sectionId))
            {
                MessageBox.Show("Please enter a valid Section ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6SHNGNN; Initial Catalog=schooldb; Integrated Security=True; TrustServerCertificate=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Sectiondb WHERE SectionId=@SectionId", con);

                cmd.Parameters.AddWithValue("@SectionId", sectionId); 

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand cmd = new SqlCommand("Select * from Sectiondb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Section_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Sectiondb", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
