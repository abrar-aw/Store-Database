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
    public partial class AdminDeleteItem : Form
    {
        public AdminDeleteItem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.thisConnection.Open();
            OracleCommand thisCommand1 = con.thisConnection.CreateCommand();
            thisCommand1.CommandText =
                            "delete inventory where itemname LIKE '%" + textBox1.Text + "%'";

            thisCommand1.Connection = con.thisConnection;
            thisCommand1.CommandType = CommandType.Text;
            var confirmResult = MessageBox.Show("Are you sure you want to delete the item?",
                                                 "Please confirm",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    thisCommand1.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted");
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
            connection CN = new connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT * FROM inventory where itemname LIKE '%" + textBox1.Text + "%'";
            listView2.Clear();
            listView3.Clear();
            listView4.Clear();
            listView5.Clear();
            try
            {
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    ListViewItem lsvItem2 = new ListViewItem();
                    ListViewItem lsvItem3 = new ListViewItem();
                    ListViewItem lsvItem4 = new ListViewItem();
                    ListViewItem lsvItem5 = new ListViewItem();
                    lsvItem2.Text = thisReader["itemtype"].ToString();
                    lsvItem3.Text = thisReader["itemquantity"].ToString();
                    lsvItem4.Text = thisReader["itemprice"].ToString();
                    lsvItem5.Text = thisReader["entrydate"].ToString();
                    listView2.Items.Add(lsvItem2);
                    listView3.Items.Add(lsvItem3);
                    listView4.Items.Add(lsvItem4);
                    listView5.Items.Add(lsvItem5);


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a category for search");
                EmployeeInventoryManagement inventoryManagement = new EmployeeInventoryManagement();
                inventoryManagement.Show();
                this.Hide();
            }
        }
    }
}
