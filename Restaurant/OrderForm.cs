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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public int summeal;
        string number;
        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30";

        private DataSet ds = new DataSet();
        private void OrderForm_Load(object sender, EventArgs e)
        {
            ds = this.GetListMenuList();
            this.CreateMenu();
        }

        private DataSet GetListMenuList()
        {
            SqlConnection cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM test order by father_id";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
       
        private void CreateMenu()
        {
            ToolStripMenuItem topMenu = new ToolStripMenuItem();
            LoadSubMenu(topMenu , "0");
        }

        private void LoadSubMenu(ToolStripMenuItem topMenu , String inFatherId)
        {
            DataView dvList = new DataView(ds.Tables[0]);
            dvList.RowFilter = "father_id = " + inFatherId ;
            ToolStripMenuItem subMenu;

            foreach(DataRowView dv in dvList)
            {
                subMenu = new ToolStripMenuItem();
                subMenu.Name = dv["name"].ToString();
                subMenu.Text = dv["name"].ToString();

                if(inFatherId == "0")
                {
                    menuStrip1.Items.Add(subMenu);
                }
                else
                {
                    subMenu.Tag = dv["name"].ToString();
                    subMenu.Click += new EventHandler(subMenu_Click);
                    topMenu.DropDownItems.Add(subMenu);
                }
                LoadSubMenu(subMenu, dv["id"].ToString());
            }
        }

        private void subMenu_Click(object sender , EventArgs e)
        {
            try
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
                textBox1.Text = tsmi.Tag.ToString();
                SqlConnection cn = new SqlConnection(cnStr);
                SqlCommand cmd = new SqlCommand("SELECT price FROM test WHERE name = N'" + textBox1.Text + "'", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                textBox2.Text = dt.Rows[0]["price"].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       /* private void 西班牙海鮮燉飯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "西班牙海鮮燉飯";
            textBox2.Text = "180";
        }

        private void 石鍋拌飯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "石鍋拌飯";
            textBox2.Text = "160";
        }

        private void 銅板烤肉飯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "銅板烤肉飯";
            textBox2.Text = "140";

        }

        private void 番茄義大利麵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "番茄義大利麵";
            textBox2.Text = "130";
        }

        private void 韓式炸醬麵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "韓式炸醬麵";
            textBox2.Text = "120";
        }

        private void 日式豚骨拉麵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "日式豚骨拉麵";
            textBox2.Text = "150";
        }

        private void 玉米濃湯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "玉米濃湯";
            textBox2.Text = "50";
        }

        private void 味噌湯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "味噌湯";
            textBox2.Text = "30";
        }

        private void 洋蔥南瓜湯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "洋蔥南瓜湯";
            textBox2.Text = "50";
        }
        private void 千層蛋糕toolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "千層蛋糕";
            textBox2.Text = "80";
        }
        private void 提拉米蘇ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "提拉米蘇";
            textBox2.Text = "60";
        }

        private void 瑪德蓮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "瑪德蓮";
            textBox2.Text = "55";
        }

        private void 馬卡龍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "馬卡龍";
            textBox2.Text = "80";
        }

        private void 咖啡拿鐵toolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "咖啡拿鐵";
            textBox2.Text = "110";
        }
        private void 心痛的滋味ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "心痛的滋味";
            textBox2.Text = "80";
        }

        private void 蘋果醋飲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "蘋果醋飲";
            textBox2.Text = "65";
        }
       */ 
        private void tex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if(!(e.KeyChar =='\b'))
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "0")
            {
                var lvi = new ListViewItem(textBox1.Text);
                lvi.SubItems.Add(textBox2.Text);
                lvi.SubItems.Add(textBox3.Text);
                lvi.SubItems.Add(Convert.ToString(Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)));
                listView1.Items.Add(lvi);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0";
            }
            else
            {
                MessageBox.Show("請輸入份數", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == textBox1.Text)
                {
                    listView1.Items.RemoveAt(i);
                    i--;
                }
            }
            if (textBox3.Text != "0")
            {
                var lvi = new ListViewItem(textBox1.Text);
                lvi.SubItems.Add(textBox2.Text);
                lvi.SubItems.Add(textBox3.Text);
                lvi.SubItems.Add(Convert.ToString(Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text)));
                listView1.Items.Add(lvi);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "0";
            }
        }
        private void SumMomey()
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                summeal+=Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SumMomey();
            number =Microsoft.VisualBasic.Interaction.InputBox("會員電話:","會員資料");

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDB.mdf;
            Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("SELECT phone FROM vip", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
          
            if (number == dt.Rows[0]["phone"].ToString())
            {
                summeal =Convert.ToInt32(summeal * 0.9);
            }
            else
            {
                 MessageBox.Show("非本店會員", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            payForm Pf2;
            Pf2 = new payForm();
            Pf2.label4.Text = Convert.ToString(summeal);
            Pf2.Show();
            Close();
             
           
            /*if (number == "0989783233")
            {
                summeal =Convert.ToInt32(summeal * 0.9);
            }
            payForm Pf2;
            Pf2 = new payForm();
            Pf2.label4.Text = Convert.ToString(summeal);
            Pf2.Show();
            Close();
        */
    }

       
    }
}
