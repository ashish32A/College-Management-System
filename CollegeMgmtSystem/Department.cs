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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMgmtSystem
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf;Integrated Security = True; Connect Timeout = 30");

        private void button3_Click(object sender, EventArgs e)
        {
            Mainform main = new Mainform();
            main.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            con.Open();
            String query = "Select * from DepartmentTbl";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepName.Text == "" || Desc.Text == "" || Durat.Text == "")
                {
                    MessageBox.Show("Missing information !");
                }
                else
                {
                    con.Open();
                    String query = "insert into DepartmentTbl values('" + DepName.Text + "','" + Desc.Text + "','" + Durat.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Successfully Added ");
                    con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepName.Text == "" || Desc.Text == "" || Durat.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    con.Open();
                    String query = "Update DepartmentTbl set DepDesc='" + Desc.Text + "',DepDuration=" + Durat.Text + " where DepName='" + DepName.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Updated Successfully  ");
                    con.Close();
                    populate();
                }

            }
            catch
            {
                MessageBox.Show("Oops.. Department not  updated");
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegemanagementDataSet1.DepartmentTbl' table. You can move, or remove it, as needed.
            this.departmentTblTableAdapter.Fill(this.collegemanagementDataSet1.DepartmentTbl);
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Desc.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Durat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (DepName.Text == "")
                {
                    MessageBox.Show("Enter the Name");
                }
                else
                {
                    con.Open();
                    String query = "delete from DepartmentTbl where DepName='" + DepName.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department Deleted Successfully");
                    con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something Went Wrong");
            }
            
            
        }

        

    }
}
     
    

