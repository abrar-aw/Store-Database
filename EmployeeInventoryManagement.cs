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
    public partial class EmployeeInventoryManagement : Form
    {
        public EmployeeInventoryManagement()
        {
            InitializeComponent();
        }

        private void EmployeeInventoryManagement_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandText =
                "SELECT * FROM inventory order by itemname";
            OracleDataReader thisReader = thisCommand.ExecuteReader();
            try
            {
                while (thisReader.Read())
                {
                    ListViewItem lsvItem = new ListViewItem();
                    lsvItem.Text = thisReader["itemname"].ToString();
                    lsvItem.SubItems.Add(thisReader["itemtype"].ToString());
                    lsvItem.SubItems.Add(thisReader["itemquantity"].ToString());
                    lsvItem.SubItems.Add(thisReader["itemprice"].ToString());
                    lsvItem.SubItems.Add(thisReader["entrydate"].ToString());
                    listView1.Items.Add(lsvItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CN.thisConnection.Close();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM inventory where itemname LIKE '%" + textBox1.Text + "%'";
            if (comboBox1.SelectedIndex == 0)
            {
                thisCommand.CommandText = "SELECT * FROM inventory where itemname LIKE '%" + textBox1.Text + "%'";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                thisCommand.CommandText = "SELECT * FROM inventory where itemtype LIKE '%" + textBox1.Text + "%'";

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                thisCommand.CommandText = "SELECT * FROM inventory where itemquantity LIKE '%" + textBox1.Text + "%'";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                thisCommand.CommandText = "SELECT * FROM inventory where itemprice LIKE '%" + textBox1.Text + "%'";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                thisCommand.CommandText = "SELECT * FROM inventory where entrydate LIKE '%" + textBox1.Text + "%'";
            }
            listView2.Clear();
            listView3.Clear();
            listView4.Clear();
            listView5.Clear();
            listView6.Clear();
            try
            {
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    ListViewItem lsvItem2 = new ListViewItem();
                    ListViewItem lsvItem3 = new ListViewItem();
                    ListViewItem lsvItem4 = new ListViewItem();
                    ListViewItem lsvItem5 = new ListViewItem();
                    ListViewItem lsvItem6 = new ListViewItem();
                    lsvItem2.Text = thisReader["itemname"].ToString();
                    lsvItem3.Text = thisReader["itemtype"].ToString();
                    lsvItem4.Text = thisReader["itemquantity"].ToString();
                    lsvItem5.Text = thisReader["itemprice"].ToString();
                    lsvItem6.Text = thisReader["entrydate"].ToString();
                    listView2.Items.Add(lsvItem2);
                    listView3.Items.Add(lsvItem3);
                    listView4.Items.Add(lsvItem4);
                    listView5.Items.Add(lsvItem5);
                    listView6.Items.Add(lsvItem6);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please try again.");
                EmployeeInventoryManagement employeeInventoryManagement = new EmployeeInventoryManagement();
                employeeInventoryManagement.Show();
                this.Hide();
            }

            CN.thisConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeHomeScreen employeeHomeScreen = new EmployeeHomeScreen();
            employeeHomeScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "UPDATE inventory SET itemquantity = '" + textBox2.Text + "'where itemname LIKE '%" + textBox1.Text + "%'";
            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            var confirmResult = MessageBox.Show("Are you sure you want to update stock?",
                                                 "Please confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    thisCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated Quantity");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
               
                this.Hide();
            }

            sv.thisConnection.Close();
            this.Close();

            EmployeeInventoryManagement employeeInventoryManagemen  = new EmployeeInventoryManagement();
            employeeInventoryManagemen.Show();
            this.Hide();

        }
    }
}
