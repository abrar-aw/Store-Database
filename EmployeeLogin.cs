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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        private void logincheck()
        {
            try
            {

                connection CN = new connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM employeelogintable WHERE employee_username='" + textBox1.Text + "' AND employee_password='" + textBox2.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    EmployeeHomeScreen oform = new EmployeeHomeScreen();
                    oform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or  Password");
                }
                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            logincheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }
    }
}
