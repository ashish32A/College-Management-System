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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf;Integrated Security = True; Connect Timeout = 30");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from StudentTbl",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Std.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from teachersT", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            teach.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from FeesTbl", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            fees.Text = "Rs" + Convert.ToInt32(dt2.Rows[0][0].ToString()) * 25000;

                SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from DepartmentTbl", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            depart.Text = dt3.Rows[0][0].ToString();


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Mainform main = new Mainform();
            main.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
