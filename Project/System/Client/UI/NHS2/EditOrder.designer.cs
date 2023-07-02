namespace Client.UI.NHS2
{
    partial class EditOrder
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
            this.Submit = new System.Windows.Forms.Button();
            this.Urgenttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResturantIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsofGood = new System.Windows.Forms.DataGridView();
            this.managerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.Statustxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DeliverAddresstxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ManagerIDtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ItemNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemIDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsofGood)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Submit.Location = new System.Drawing.Point(477, 210);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 35);
            this.Submit.TabIndex = 55;
            this.Submit.Text = "Update";
            this.Submit.UseVisualStyleBackColor = true;
            // 
            // Urgenttxt
            // 
            this.Urgenttxt.Location = new System.Drawing.Point(327, 37);
            this.Urgenttxt.Name = "Urgenttxt";
            this.Urgenttxt.Size = new System.Drawing.Size(249, 20);
            this.Urgenttxt.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(230, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Urgent:";
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Location = new System.Drawing.Point(114, 37);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(110, 20);
            this.Quantitytxt.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Quantity:";
            // 
            // ResturantIDtxt
            // 
            this.ResturantIDtxt.Location = new System.Drawing.Point(326, 67);
            this.ResturantIDtxt.Name = "ResturantIDtxt";
            this.ResturantIDtxt.Size = new System.Drawing.Size(250, 20);
            this.ResturantIDtxt.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(230, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Resturant ID:";
            // 
            // DetailsofGood
            // 
            this.DetailsofGood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsofGood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerID,
            this.itemName,
            this.Quantity});
            this.DetailsofGood.Location = new System.Drawing.Point(15, 251);
            this.DetailsofGood.Name = "DetailsofGood";
            this.DetailsofGood.RowTemplate.Height = 24;
            this.DetailsofGood.Size = new System.Drawing.Size(561, 335);
            this.DetailsofGood.TabIndex = 48;
            // 
            // managerID
            // 
            this.managerID.HeaderText = "Manager ID";
            this.managerID.Name = "managerID";
            this.managerID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(12, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 47;
            this.label16.Text = "Details of goods";
            // 
            // Statustxt
            // 
            this.Statustxt.Location = new System.Drawing.Point(15, 150);
            this.Statustxt.Multiline = true;
            this.Statustxt.Name = "Statustxt";
            this.Statustxt.Size = new System.Drawing.Size(561, 54);
            this.Statustxt.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(12, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Status:";
            // 
            // DeliverAddresstxt
            // 
            this.DeliverAddresstxt.Location = new System.Drawing.Point(131, 98);
            this.DeliverAddresstxt.Name = "DeliverAddresstxt";
            this.DeliverAddresstxt.Size = new System.Drawing.Size(445, 20);
            this.DeliverAddresstxt.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(12, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Deliver Address:";
            // 
            // ManagerIDtxt
            // 
            this.ManagerIDtxt.Location = new System.Drawing.Point(114, 67);
            this.ManagerIDtxt.Name = "ManagerIDtxt";
            this.ManagerIDtxt.Size = new System.Drawing.Size(110, 20);
            this.ManagerIDtxt.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(12, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Manager ID:";
            // 
            // ItemNametxt
            // 
            this.ItemNametxt.Location = new System.Drawing.Point(327, 6);
            this.ItemNametxt.Name = "ItemNametxt";
            this.ItemNametxt.Size = new System.Drawing.Size(249, 20);
            this.ItemNametxt.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(230, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Item Name:";
            // 
            // ItemIDtxt
            // 
            this.ItemIDtxt.Location = new System.Drawing.Point(114, 6);
            this.ItemIDtxt.Name = "ItemIDtxt";
            this.ItemIDtxt.Size = new System.Drawing.Size(110, 20);
            this.ItemIDtxt.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Item ID:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 664);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Urgenttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quantitytxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResturantIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsofGood);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Statustxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DeliverAddresstxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ManagerIDtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ItemNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemIDtxt);
            this.Controls.Add(this.label2);
            this.Name = "EditOrder";
            this.Text = "Edit Test";
            ((System.ComponentModel.ISupportInitialize)(this.DetailsofGood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Urgenttxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Quantitytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ResturantIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DetailsofGood;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Statustxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DeliverAddresstxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ManagerIDtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ItemNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}