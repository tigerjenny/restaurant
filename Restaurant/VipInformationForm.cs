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
    public partial class VipInformationForm : Form
    {
        public VipInformationForm()
        {
            InitializeComponent();
        }

        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30";
        int i = 1;
        private void VipInformationForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cnStr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vip", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void phone_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (!(e.KeyChar == '\b'))
                    e.Handled = true;
            }
        }

        private void Mail_Keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'A' || e.KeyChar > 'Z')
            {
                if (e.KeyChar < 'a' || e.KeyChar > 'z')
                if (e.KeyChar < '0' || e.KeyChar > '9')
                if (!(e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == '@' || e.KeyChar == '_'))
                    e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i+1;
            string id = Convert.ToString(i);
            string birthday = datePicker_Birthday.Value.ToShortDateString();
            try
            {
                SqlConnection cn = new SqlConnection(cnStr);
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO vip VALUES(" +id + ", N'" + tb_Name.Text + "',N'" +birthday+"',N'"+tb_Tphone.Text+"',N'"+tb_Mail.Text+"')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                VipInformationForm_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            tb_Tphone.Text = "";
            tb_Name.Text = "";
            tb_Mail.Text = "";
            datePicker_Birthday.Value = DateTime.Today;
        }
    }
}
