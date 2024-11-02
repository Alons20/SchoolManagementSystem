using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject sj = new Subject();
            sj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher tr = new Teacher();
            tr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Section sn = new Section();
            sn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Enrollment en = new Enrollment();
            en.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Attendance ae = new Attendance();
            ae.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashboard dd = new Dashboard(); 
            dd.Show();
        }
    }
}
