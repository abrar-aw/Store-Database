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
    public partial class AdminAddEmployee : Form
    {
        public AdminAddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM employeelogintable", sv.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "employeelogintable");
            DataRow thisRow = thisDataSet.Tables["employeelogintable"].NewRow();
            try
            {
                if (textBox2.Text == textBox3.Text)
                {

                    thisRow["employee_username"] = textBox1.Text;
                    thisRow["employee_password"] = textBox2.Text;
                    thisDataSet.Tables["employeelogintable"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "employeelogintable");
                    MessageBox.Show("Employee Created!");
                }
                else
                {
                    MessageBox.Show("Passwords don't match!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't create employee!");
            }
            sv.thisConnection.Close();
            //AdminAddEmployee ob = new AdminAddEmployee();
            //ob.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }
    }
}
