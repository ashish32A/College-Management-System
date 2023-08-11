using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeMgmtSystem
{
    public partial class Userform : Form
    {
        public Userform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf;Integrated Security = True");
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform main = new Mainform();
            main.Show();
            this.Hide();

        }

        private void Userform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegemanagementDataSet.Usertbl' table. You can move, or remove it, as needed.
            this.usertblTableAdapter.Fill(this.collegemanagementDataSet.Usertbl);
            populate();

        }
        private void populate()
        {
            con.Open();
            String query = "Select * from Usertbl";
            SqlDataAdapter ada = new SqlDataAdapter(query,con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try {
                if (Userid.Text == "" || Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Missing information !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Usertbl values('" + Userid.Text + "','" + Username.Text + "','" + Password.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added ");
                    con.Close();
                    populate();
                }
                   
                }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
            }
           
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Userid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Username.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Userid.Text == "")
                {
                    MessageBox.Show("Enter the User ID");
                }
                else
                {
                    con.Open();
                    String query = "delete from Usertbl where UserID=" + Userid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Oops... User not Deleted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Userid.Text == "" || Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Usertbl set UserName='" + Username.Text + "',Password='" + Password.Text + "' where UserID='"+Userid.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully  ");
                    con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
