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
    public partial class MealInformationForm : Form
    {
        public MealInformationForm()
        {
            InitializeComponent();
        }
        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30";
        //string[] kinds = new string[] { "飯類","麵類","湯品","點心","飲料"};
        //int sale, cost;

        private void MealInformationForm_Load(object sender, EventArgs e)
        {
            LoginForm Lf3;
            Lf3 = new LoginForm();

            if (Lf3.id() != 0)
            {
                if (Lf3.id() != 1)
                {
                    btn_Insert.Enabled = false;
                    btn_Update.Enabled = false;
                    btn_Delete.Enabled = false;
                }
            }

            /*for(int i = 0; i < kinds.Length; i++)
            {
                cboBox_Kind.Items.Add(kinds[i]);
            }*/
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT sort , m_name , price FROM (SELECT c.sort , m.m_name , m.price FROM meals m JOIN categories c ON m.sort_id = c.sort_id) a", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            load();
        }

        private void load()
        {
            cboBox_Kind.Items.Clear();
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT sort FROM categories ", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
                cboBox_Kind.Items.Add(dt.Rows[i]["sort"].ToString());
        }

        private void tex_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (!(e.KeyChar == '\b'))
                    e.Handled = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE meals SET m_name = N'" + cboBox_MealName.Text +
                    "',price = " + tb_sale.Text+"WHERE m_name = N'" + cboBox_MealName.Text+"'";
                string aa = cboBox_MealName.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE test SET price = " + tb_sale.Text+"WHERE name = N'"+aa+"'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MealInformationForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_MealName.Text = "";
            tb_sale.Text = "";
        }
        int ii = 21;
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            ii = ii+1;
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO meals VALUES(N'" +
                    cboBox_MealName.Text +"',"+ Convert.ToString(cboBox_Kind.SelectedIndex+1) + "," +tb_sale.Text + ")";
                string aa = cboBox_MealName.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                string sql = "SELECT m_name FROM meals m JOIN categories c ON m.sort_id = c.sort_id WHERE sort = N'" + cboBox_Kind.SelectedItem.ToString() + "'";
                Get_name(sql);

                cmd.CommandText = "INSERT INTO test VALUES("+ ii +","+ Convert.ToString(cboBox_Kind.SelectedIndex + 1) + " , N'" +
                   aa + "'," + tb_sale.Text + ")";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                MealInformationForm_Load(sender , e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_MealName.Text = "";
            tb_sale.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM meals WHERE m_name = N'" + cboBox_MealName.Text+"'";
                string aa = cboBox_MealName.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                string sql = "SELECT m_name FROM meals m JOIN categories c ON m.sort_id = c.sort_id WHERE sort = N'" + cboBox_Kind.SelectedItem.ToString() + "'";
                Get_name(sql);

                cmd.CommandText = "DELETE FROM test WHERE name = N'" +aa + "'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MealInformationForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_MealName.Text = "";
            tb_sale.Text = "";
        }

        private void cboBox_Kind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kind_id = cboBox_Kind.SelectedItem.ToString();
            string sql = "SELECT m_name FROM meals m JOIN categories c ON m.sort_id = c.sort_id WHERE sort = N'" + kind_id+"'";
             Get_name(sql);

            
        }

        private void Get_name(string sqlcmd)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboBox_MealName.DataSource = dt;
            cboBox_MealName.DisplayMember = "m_name";
            cn.Close();
        }

        private void cboBox_MealName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string mname = cboBox_MealName.Text;
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT price FROM meals WHERE m_name = N'" + mname + "'", cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                tb_sale.Text = dt.Rows[0]["price"].ToString();
                cn.Close();
            }
            catch
            {
                tb_sale.Text = "0";
            }
        }
    }
}
