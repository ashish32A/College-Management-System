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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMgmtSystem
{
    public partial class Teacher : Form
    {
        public Teacher()
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

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegemanagementDataSet8.teachersT' table. You can move, or remove it, as needed.
            this.teachersTTableAdapter.Fill(this.collegemanagementDataSet8.teachersT);
            // TODO: This line of code loads data into the 'collegemanagementDataSet8.TeacherTbl' table. You can move, or remove it, as needed.


            filldepartment();

        }
        private void populate()
        {
            con.Open();
            String query = "Select * from teachersT";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void filldepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select DepName from DepartmentTbl",con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            Depart.ValueMember = "DepName";
            Depart.DataSource = dt;
             con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                if (id.Text == "" || name.Text == "" || Phone.Text == "" || Add.Text == "")
                {
                    MessageBox.Show(" fill the data !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into teachersT values('" + id.Text + "','" + name.Text + "','" + Gender.SelectedItem.ToString() + "','" + dob.Text + "','" + Phone.Text + "','" + Depart.SelectedItem.ToString() + "','" + Add.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Successfully Added ");
                    con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("something Went wrong");
            }
       
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || name.Text == "" || Phone.Text == "" || Add.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update teachersT set name='" + name.Text + "',Gender='" + Gender.Text + "' ,DOB='"+ dob.Text+"',Phone='"+Phone.Text+"',Department='"+Depart.Text+"',Address='"+Add.Text+"' where ID='" + id.Text + "'", con);
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

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Depart_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    String query = "delete from teachersT where ID=" + id.Text + "";
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Gender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dob.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Phone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Depart.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Add.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
        }
    }
}
