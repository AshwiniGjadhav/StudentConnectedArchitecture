using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace StudentConnectedArchitecture
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con=new SqlConnection(constr);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Student values(@sname,@sub1,@sub2,@sub3,@percentage)";
                cmd=new SqlCommand(qry,con);

                cmd.Parameters.AddWithValue("@sname",txtName.Text);
                cmd.Parameters.AddWithValue("@sub1",Convert.ToInt32(txtSub1.Text));
                cmd.Parameters.AddWithValue("@sub2",Convert.ToInt32(txtSub2.Text));
                cmd.Parameters.AddWithValue("@sub3",Convert.ToInt32(txtSub3.Text));
                cmd.Parameters.AddWithValue("@percentage",Convert.ToInt32(txtPercentage.Text));
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Student set sname=@sname,sub1=@sub1,sub2=@sub2,sub3=@sub3,percentage=@percentage where rollno=@rollno";
                cmd = new SqlCommand(qry,con);

                cmd.Parameters.AddWithValue("@sname", txtName.Text);
                cmd.Parameters.AddWithValue("@sub1", Convert.ToInt32(txtSub1.Text));
                cmd.Parameters.AddWithValue("@sub2", Convert.ToInt32(txtSub2.Text));
                cmd.Parameters.AddWithValue("@sub3", Convert.ToInt32(txtSub3.Text));
                cmd.Parameters.AddWithValue("@percentage", Convert.ToInt32(txtPercentage.Text));
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtRollno.Text));               
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if( result==1)
                {
                    MessageBox.Show("Record updated");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Student where rollno=@rollno";
                cmd=new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@rollno",Convert.ToInt32(txtRollno.Text));
                con.Open();
                int result= cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Deleted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Student where rollno=@rollno";
                cmd = new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtName.Text = dr["sname"].ToString();
                        txtSub1.Text = dr["sub1"].ToString();
                        txtSub2.Text = dr["sub2"].ToString();
                        txtSub3.Text = dr["sub3"].ToString() ;
                        txtPercentage.Text = dr["percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {

                string qry = "select * from Student";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(txtRollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                }
                else {
                    MessageBox.Show("Record not found");
                }

                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
