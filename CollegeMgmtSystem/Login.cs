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

namespace CollegeMgmtSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf;Integrated Security = True; Connect Timeout = 30");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            Mainform home = new Mainform();
            
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Usertbl where UserName='"+username.Text+"'and Password='"+password.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Enter the username & password");
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    home.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username And Password");
                }
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                password.UseSystemPasswordChar = false;

            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
