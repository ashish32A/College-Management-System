using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CollegeMgmtSystem
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf;Integrated Security = True; Connect Timeout = 30");

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
        private void populate()
        {
            con.Open();
            String query = "Select * from StudentTbl";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void NoDuelist()
        {
            con.Open();
            String query = "Select * from StudentTbl where StdFees > "+0+"";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (id.Text == "" || name.Text == "" || phone.Text == "" || dep.Text == "" || fees.Text == "")
                {
                    MessageBox.Show(" fill the data !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update  StudentTbl set Stdname='" + name.Text + "',StdGender='" + gender.Text + "',StdDOB='" + dob.Text + "',StdPhone='" + phone.Text + "',StdDep='" + dep.Text + "',Stdfees='" + fees.Text + "' where StdID='"+id.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updeted Successfully Added ");
                    con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    private void filldepartment()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select DepName from DepartmentTbl", con);
        SqlDataReader rdr = cmd.ExecuteReader();
        DataTable dt = new DataTable();
        dt.Columns.Add("DepName", typeof(string));
        dt.Load(rdr);
        dep.ValueMember = "DepName";
        dep.DataSource = dt;


        con.Close();
    }

    private void button4_Click(object sender, EventArgs e)
    {

        try
        {

            if (id.Text == "" || name.Text == "" || phone.Text == "" || dep.Text == "" || fees.Text == "")
            {
                MessageBox.Show(" fill the data !");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values('" + id.Text + "','" + name.Text + "','" + gender.SelectedItem.ToString() + "','" + dob.Text + "','" + phone.Text + "','" + dep.SelectedItem.ToString() + "','" + fees.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added ");
                con.Close();
                populate();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message); }
    }


        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegemanagementDataSet9.StudentTbl' table. You can move, or remove it, as needed.
            this.studentTblTableAdapter.Fill(this.collegemanagementDataSet9.StudentTbl);
            filldepartment();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "")
                {
                    MessageBox.Show("Enter the Teacher ID");
                }
                else
                {
                    con.Open();
                    String query = "delete from StudentTbl where StdID=" + id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Oops...  not Deleted");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            gender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dob.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            phone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dep.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            fees.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NoDuelist();
        }
    }
}


