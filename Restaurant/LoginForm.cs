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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        static int sid ;

        public int id()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30");
            // SqlCommand cmd = new SqlCommand("SELECT password FROM staffs WHERE staff_id = " + textBox1.Text, cn);
            SqlCommand cmd = new SqlCommand("SELECT job_id FROM staffs WHERE staff_id = " + sid , cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            return Convert.ToInt32(dt.Rows[0]["job_id"].ToString());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sid = Convert.ToInt32(textBox1.Text);

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30");
            // SqlCommand cmd = new SqlCommand("SELECT password FROM staffs WHERE staff_id = " + textBox1.Text, cn);
            SqlCommand cmd = new SqlCommand("SELECT job_id,password FROM staffs WHERE staff_id = " + textBox1.Text, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            
                try
                {
                    if (textBox2.Text == dt.Rows[0]["password"].ToString())
                    {
                        ChooseForm Cf1;
                        Cf1 = new ChooseForm();
                        Cf1.Show();
                    }
                    else
                    {
                        MessageBox.Show("帳號密碼錯誤", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("帳號密碼錯誤", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            
            Close();
        }
    }
}
