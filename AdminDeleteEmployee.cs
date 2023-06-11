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
    public partial class AdminDeleteEmployee : Form
    {
        public AdminDeleteEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.thisConnection.Open();
            OracleCommand thisCommand1 = con.thisConnection.CreateCommand();
            thisCommand1.CommandText =
                "delete employeelogintable where employee_username= '" + textBox1.Text + "'";

            thisCommand1.Connection = con.thisConnection;
            thisCommand1.CommandType = CommandType.Text;
            var confirmResult = MessageBox.Show("Are you sure to delete this username??",
                                                 "Confirm Delete!!",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    thisCommand1.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
                    adminHomeScreen.Show();
                    this.Hide();
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message); 
                }
            }
            else
            {
                
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }
    }
}
