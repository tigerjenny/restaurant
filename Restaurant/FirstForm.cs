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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OrderForm Of1;
            Of1 = new OrderForm();
            Of1.Show();
        }

        private void btn_man_Click(object sender, EventArgs e)
        {
            LoginForm Lf1;
            Lf1 = new LoginForm();
            Lf1.Show();
        }
    }
}
