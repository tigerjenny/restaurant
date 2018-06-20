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
    public partial class ItemInformationForm : Form
    {
        public ItemInformationForm()
        {
            InitializeComponent();
        }

        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30";
        
        string iiname;

        private void ItemInformationForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stocks", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = ds.Tables[0];
            tb_used.Text = "0";
            cboBox_Items.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboBox_Items.Items.Add(dt.Rows[i]["i_name"]);
            }
            cn.Open();
            da = new SqlDataAdapter("SELECT * FROM stocks", cn);
            ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            
            for (int j = 0; j < dt.Rows.Count; j++)
            {
                int cou = Convert.ToInt32(dt.Rows[j]["num"].ToString());
                int min = Convert.ToInt32(dt.Rows[j]["minimun"].ToString());
                if (cou < min)
                {
                    iiname = iiname +"\n"+ dt.Rows[j]["i_name"].ToString();
                    
                    //MessageBox.Show("請補充"+dt.Rows[j]["i_name"].ToString()+"數量","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            MessageBox.Show("請補充"+iiname+"\n數量","注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            cn.Close();
            iiname = "";
        }
        private void tex_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (!(e.KeyChar == '\b'))
                    e.Handled = true;
            }
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            int stock, used;
            stock = Convert.ToInt32(tb_stock.Text);
            used = Convert.ToInt32(tb_used.Text);
            string count = Convert.ToString(stock - used);
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE stocks SET i_name = N'" + cboBox_Items.Text + "',num = " + count+ "WHERE i_name = N'" + cboBox_Items.Text+"'";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                ItemInformationForm_Load(sender , e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cboBox_Items.Text = "";
            tb_stock.Text = "";
            tb_used.Text = "0";
        }

        private void cboBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            string iname = cboBox_Items.SelectedItem.ToString();
            string sql = "SELECT num FROM stocks WHERE i_name = N'"+ iname+"'";
            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            tb_stock.Text = dt.Rows[0]["num"].ToString();
            cn.Close();
        }
    }
}
