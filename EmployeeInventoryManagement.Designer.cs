namespace PetStoreDatabase
{
    partial class EmployeeInventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.itemname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemtype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemquantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Entrydate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView5 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView6 = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory At A Glance:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemname,
            this.itemtype,
            this.itemquantity,
            this.itemprice,
            this.Entrydate});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(72, 61);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1046, 217);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // itemname
            // 
            this.itemname.Text = "      Item Name";
            this.itemname.Width = 177;
            // 
            // itemtype
            // 
            this.itemtype.Text = "   Item Type";
            this.itemtype.Width = 142;
            // 
            // itemquantity
            // 
            this.itemquantity.Text = "    Quantity";
            this.itemquantity.Width = 104;
            // 
            // itemprice
            // 
            this.itemprice.Text = "  Price";
            this.itemprice.Width = 103;
            // 
            // Entrydate
            // 
            this.Entrydate.Text = "Date Added";
            this.Entrydate.Width = 555;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 91;
            this.button1.Text = "Update Stock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(520, 465);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 22);
            this.textBox2.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Enter New Stock";
            // 
            // listView5
            // 
            this.listView5.GridLines = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(171, 397);
            this.listView5.Margin = new System.Windows.Forms.Padding(4);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(186, 22);
            this.listView5.TabIndex = 88;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Item Type";
            // 
            // listView4
            // 
            this.listView4.GridLines = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(854, 340);
            this.listView4.Margin = new System.Windows.Forms.Padding(4);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(186, 22);
            this.listView4.TabIndex = 86;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Price";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(826, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 84;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView3
            // 
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(520, 340);
            this.listView3.Margin = new System.Windows.Forms.Padding(4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(186, 22);
            this.listView3.TabIndex = 83;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Item Quantity";
            // 
            // listView2
            // 
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(171, 340);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(186, 22);
            this.listView2.TabIndex = 81;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "Item Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Item Name";
            // 
            // listView6
            // 
            this.listView6.GridLines = true;
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(520, 397);
            this.listView6.Margin = new System.Windows.Forms.Padding(4);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(186, 22);
            this.listView6.TabIndex = 93;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 92;
            this.label8.Text = "Date Added";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1043, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 94;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Item Name",
            "Item Type",
            "Quantity",
            "Price",
            "Date Added"});
            this.comboBox1.Location = new System.Drawing.Point(688, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 96;
            this.label9.Text = "Search By";
            // 
            // EmployeeInventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 545);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeInventoryManagement";
            this.Text = "EmployeeInventoryManagement";
            this.Load += new System.EventHandler(this.EmployeeInventoryManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader itemname;
        private System.Windows.Forms.ColumnHeader itemtype;
        private System.Windows.Forms.ColumnHeader itemquantity;
        private System.Windows.Forms.ColumnHeader itemprice;
        private System.Windows.Forms.ColumnHeader Entrydate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}