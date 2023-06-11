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
    public partial class AdminChangePricing : Form
    {
        public AdminChangePricing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();
            thisCommand.CommandText = "UPDATE inventory SET itemprice = '" + textBox2.Text + "'where itemname LIKE '%" + textBox1.Text + "%'";
            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            var confirmResult = MessageBox.Show("Are you sure you want to update pricing?",
                                                 "Please confirm!",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    thisCommand.ExecuteNonQuery();
                    MessageBox.Show("Updated Price in stock");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Could not update pricing");
            }

            sv.thisConnection.Close();
            this.Close();

            AdminChangePricing ob = new AdminChangePricing();
            ob.Show();
            this.Hide();
        }

        private void AdminChangePricing_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Search Failed!");
                AdminChangePricing adminChangePricing = new AdminChangePricing();
                adminChangePricing.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }
    }
}
