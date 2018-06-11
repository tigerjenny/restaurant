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

        private void ItemInformationForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stocks", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tb_used.Text = "0";
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
    }
}
