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
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btn_meal_Click(object sender, EventArgs e)
        {
            MealInformationForm Mf1;
            Mf1 = new MealInformationForm();
            Mf1.Show();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            ItemInformationForm If1;
            If1 = new ItemInformationForm();
            If1.Show();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            EmployeeInformationForm Ef1;
            Ef1 = new EmployeeInformationForm();
            Ef1.Show();
        }

        private void btn_Vip_Click(object sender, EventArgs e)
        {
            VipInformationForm Vf1;
            Vf1 = new VipInformationForm();
            Vf1.Show();
        }
    }
}
