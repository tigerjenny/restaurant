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

namespace Restaurant
{
    public partial class EmployeeInformationForm : Form
    {
        public EmployeeInformationForm()
        {
            InitializeComponent();
        }

        public int view_id;

        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30";

        private void EmployeeInformationForm_Load(object sender, EventArgs e)
        {
            

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30");
            cn.Open();

            SqlCommand cmd = new SqlCommand("CREATE OR ALTER VIEW boss_view AS SELECT s.staff_id, j.job_title, s.s_name, s.salary, b.location_id , b.tel , s.password FROM staffs s JOIN jobs j ON(s.job_id = j.job_id) JOIN branches b ON(s.branch_id = b.branch_id) WHERE s.staff_id > 0", cn);
            cmd.ExecuteNonQuery();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
           // DataTable dt = ds.Tables[0];

            cmd = new SqlCommand(" CREATE OR ALTER VIEW menage_view AS SELECT s.staff_id, j.job_title, s.s_name, s.salary, b.location_id, s.password FROM staffs s JOIN jobs j ON(s.job_id = j.job_id) JOIN branches b ON(s.branch_id = b.branch_id) WHERE s.staff_id > 20", cn);
            cmd.ExecuteNonQuery();
            // da = new SqlDataAdapter(cmd);
            //ds = new DataSet();
           // da.Fill(ds);
           // dt = ds.Tables[1];

            cmd = new SqlCommand("CREATE OR ALTER VIEW normal_view AS SELECT s.staff_id, j.job_title, s.s_name, s.salary ,b.location_id FROM staffs s JOIN jobs j ON(s.job_id = j.job_id) JOIN branches b ON(s.branch_id = b.branch_id)", cn);
            cmd.ExecuteNonQuery();
            //da = new SqlDataAdapter(cmd);
           // ds = new DataSet();
            //da.Fill(ds);
            //dt = ds.Tables[2];

            LoginForm Lf2;
            Lf2 = new LoginForm();

            if(Lf2.id() == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT job_title ,s_name ,staff_id ,salary,location_id,tel,password  FROM boss_view ", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if(Lf2.id() == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT job_title ,s_name ,staff_id ,salary,location_id,password   FROM menage_view ", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT job_title ,s_name ,staff_id ,salary,location_id  FROM menage_view ", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            cn.Close();
            /*SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT job_title ,s_name ,staff_id,password ,salary,location_id,tel  FROM" +
                 " (SELECT j.job_title , s.s_name ,s.staff_id , s.password , s.salary, b.location_id , b.tel FROM jobs j JOIN staffs s ON j.job_id = s.job_id JOIN branches b ON s.branch_id = b.branch_id) b", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];*/
        }

        private void ID_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (!(e.KeyChar == '\b'))
                    e.Handled = true;
            }
        }

        private void password_Keypress(object sender, KeyPressEventArgs e)
        {
            if ( e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (!(e.KeyChar == '\b'))
                    e.Handled = true;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO staffs(staff_id,job_id,s_name,password,salary,branch_id) VALUES(" +
                    tb_Account.Text +","+ Convert.ToString(cboBox_Work.SelectedIndex) + ",N'" + cboBox_Name.Text + "',N'" + tb_Password.Text +
                    "'," + tb_salary.Text + "," + Convert.ToString(cboBox_Location.SelectedIndex+1) + ")";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                string sql = "SELECT s_name FROM staffs s JOIN jobs j ON s.job_id = j.job_id WHERE job_title = N'" + cboBox_Work.SelectedItem.ToString() + "'";
                Get_name(sql);
                EmployeeInformationForm_Load(sender , e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_Location.Text = "";
            cboBox_Name.Text = "";
            cboBox_Work.Text = "";
            tb_Account.Clear();
            tb_Password.Clear();
            tb_salary.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE staffs SET staff_id = "+ tb_Account.Text+",job_id = " + Convert.ToString(cboBox_Work.SelectedIndex) + 
                    ",s_name = N'"+ cboBox_Name.Text + "',password = N'"+ tb_Password.Text + "',salary = "+ tb_salary.Text +
                    ",branch_id = " + Convert.ToString(cboBox_Location.SelectedIndex + 1) + "WHERE staff_id = "+tb_Account.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                string sql = "SELECT s_name FROM staffs s JOIN jobs j ON s.job_id = j.job_id WHERE job_title = N'" + cboBox_Work.SelectedItem.ToString() + "'";
                Get_name(sql);
                EmployeeInformationForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_Location.Text = "";
            cboBox_Name.Text = "";
            cboBox_Work.Text = "";
            tb_Account.Clear();
            tb_Password.Clear();
            tb_salary.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM staffs WHERE staff_id = " + tb_Account.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                string sql = "SELECT s_name FROM staffs s JOIN jobs j ON s.job_id = j.job_id WHERE job_title = N'" + cboBox_Work.SelectedItem.ToString() + "'";
                Get_name(sql);
                EmployeeInformationForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_Account.Clear(); 
        }

        private void cboBox_Work_SelectedIndexChanged(object sender, EventArgs e)
        {
            string work_id = cboBox_Work.SelectedItem.ToString();
            string sql = "SELECT s_name FROM staffs s JOIN jobs j ON s.job_id = j.job_id WHERE job_title = N'" + work_id + "'";
            Get_name(sql);
        }

        private void Get_name(string sqlcmd)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboBox_Name.DataSource = dt;
            cboBox_Name.DisplayMember = "s_name";
            cn.Close();
        }
    }
}
