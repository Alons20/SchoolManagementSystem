using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data;

namespace SchoolManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-6SHNGNN; Initial Catalog = schooldb; Integrated Security = True; TrustServerCertificate = True");
            con.Open();
            string username=txtUsername.Text;
            string password=txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select Username,Password from logindb where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main mn = new Main();
                mn.Show();
            }
            else 
            {
                MessageBox.Show ("You have entered inavlid Username or Password!");
            }
            con.Close();

        }
    }
}
