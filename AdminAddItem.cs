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
    public partial class AdminAddItem : Form
    {
        public AdminAddItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM inventory", sv.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "inventory");
            DataRow thisRow = thisDataSet.Tables["inventory"].NewRow();
            try
            {

                thisRow["itemname"] = textBox1.Text;
                thisRow["itemtype"] = textBox2.Text;
                thisRow["itemquantity"] = textBox3.Text;
                thisRow["itemprice"] = textBox4.Text;
                thisRow["entrydate"] = dateTimePicker1.Value;
                thisDataSet.Tables["inventory"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "inventory");
                MessageBox.Show("Product Added in inventory!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();
            AdminAddItem adminAddItem = new AdminAddItem();
            adminAddItem.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHomeScreen adminHomeScreen = new AdminHomeScreen();
            adminHomeScreen.Show();
            this.Hide();
        }
    }
}
