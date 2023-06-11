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
    public partial class EmployeeHomeScreen : Form
    {
        public EmployeeHomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeInventoryManagement inventoryManagement = new EmployeeInventoryManagement();
            inventoryManagement.Show();
            this.Hide();
        }
    }
}
