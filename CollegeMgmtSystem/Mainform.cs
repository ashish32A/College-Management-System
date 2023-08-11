using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMgmtSystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Userform u = new Userform();
            u.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fees f = new Fees();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Close();
        }
    }
}
