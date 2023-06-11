using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace PetStoreDatabase
{
    public partial class AdminHomeScreen : Form
    {
        public AdminHomeScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddEmployee adminAddEmployee  = new AdminAddEmployee();   
            adminAddEmployee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewEmployees adminViewEmployees = new AdminViewEmployees();
            adminViewEmployees.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDeleteEmployee adminDeleteEmployee = new AdminDeleteEmployee();
            adminDeleteEmployee.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminAddItem adminAddItem = new AdminAddItem();
            adminAddItem.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminChangePricing adminChangePricing = new AdminChangePricing();
            adminChangePricing.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDeleteItem adminDeleteItem = new AdminDeleteItem();
            adminDeleteItem.Show();
            this.Hide();
        }
    }
}
