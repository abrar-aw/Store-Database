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
    public partial class AdminViewEmployees : Form
    {
        public AdminViewEmployees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }

        private void AdminViewEmployees_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "SELECT * FROM employeelogintable order by employee_username";

            OracleDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["employee_username"].ToString();
                lsvItem.SubItems.Add(thisReader["employee_password"].ToString());
                lsvItem.SubItems.Add(thisReader["employee_password"].ToString());
                listView1.Items.Add(lsvItem);

            }

            CN.thisConnection.Close();

        }
    }
}
