using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CollegeMgmtSystem
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ashish singh\OneDrive\Desktop\CollegeMgmtSystem\CollegeMgmtSystem\Collegemanagement.mdf"";Integrated Security=True;Connect Timeout=30");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void filldepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select StdID from StudentTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdID", typeof(int));
            dt.Load(rdr);
            Sid.ValueMember = "StdID";
            Sid.DataSource = dt;


            con.Close();
        }

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            con.Open();
            String query = "Select * from FeesTbl";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);
            SqlCommandBuilder bul = new SqlCommandBuilder(ada);
            var ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }
        private void updatestd()
        {
            con.Open();
            String q = "update StudentTbl set StdFees='" + Amount.Text + "'where StdID='" + Sid.Text+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String date = period.Value.Year.ToString();


                if (Num.Text == "" || Name.Text == "" || Amount.Text == "")
                {
                    MessageBox.Show("Fill the  Data !");
                }
                else
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select count(*) from FeesTbl where StdId=" + Sid.Text + " and Period=" + date + "", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("No dues for selected Period ");
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into FeesTbl values('" + Num.Text + "','" + Sid.Text + "','" + Name.Text + "','" + date + "','" + Amount.Text + "')", con); ;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Successfully Added ");
                        con.Close();
                        populate();
                        updatestd();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Fees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegemanagementDataSet10.FeesTbl' table. You can move, or remove it, as needed.
            this.feesTblTableAdapter.Fill(this.collegemanagementDataSet10.FeesTbl);
            populate();
            filldepartment();
        }

        private void Sid_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Sid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from StudentTbl where StdID=" + Sid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Name.Text = dr["StdName"].ToString();
                
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String date = period.Value.Year.ToString();

                if (Num.Text == "" || Name.Text == "" || Amount.Text == "")
                {
                    MessageBox.Show("Fill the  Data !");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update FeesTbl set StdID='" + Convert.ToInt32(Sid.Text) + "',StdName='" + Name.Text + "',period='" + date + "',Amount='" + Amount.Text + "' where FeesNum='"+Num.Text+"'", con); ;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Successfully Updatedd ");
                    con.Close();
                    populate();
                    updatestd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Num.Text == "")
                {
                    MessageBox.Show("Enter the FeesNum ID");
                }
                else
                {
                    con.Open();
                    String query = "delete from FeesTbl where FeesNum=" + Num.Text + "";
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
            Num.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Sid.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Amount.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           
        }
    }
}
