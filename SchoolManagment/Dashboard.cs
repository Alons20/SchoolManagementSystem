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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Display();
            Display1();
            Display2();
            Display3();
        }

        private void Display()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) from Studentdb", con);
            Int32 count= Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount.Text = "0";
            }
            con.Close();
        }
        private void Display1()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) from Subjectdb", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount.Text = "0";
            }
            con.Close();
        }
        private void Display2()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) from Teacherdb", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount.Text = "0";
            }
            con.Close();
        }
        private void Display3()
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) from Endb", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount.Text = "0";
            }
            con.Close();
        }
    }
}
