using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class payForm : Form
    {
        public payForm()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            money.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            money.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            money.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            money.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            money.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            money.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            money.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            money.Text += "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            money.Text += "0";
        }
         private void button10_Click(object sender, EventArgs e)
        {
            money.Text += "00";
        }
        private void delete_Click(object sender, EventArgs e)
        {
            money.Text = "";
            cash.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(label4.Text) <= Convert.ToInt32(money.Text))
                {
                    cash.Text = Convert.ToString(Convert.ToInt32(money.Text) - Convert.ToInt32(label4.Text));
                }
                else
                {
                    MessageBox.Show("付款不足", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    money.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("請輸入付款金額", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
