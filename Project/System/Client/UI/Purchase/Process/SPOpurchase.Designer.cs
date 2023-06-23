namespace Client.UI.Purchase.Process
{
    partial class SPOpurchase
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
            this.spoDGV = new System.Windows.Forms.DataGridView();
            this.ItemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeBtnGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supAddressTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.supConNumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supConEmailTxt = new System.Windows.Forms.TextBox();
            this.supIDTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SupConNameTxt = new System.Windows.Forms.TextBox();
            this.supNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pIDTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.refTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bpaIDselect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spoDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spoDGV
            // 
            this.spoDGV.AllowUserToAddRows = false;
            this.spoDGV.AllowUserToDeleteRows = false;
            this.spoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDGV,
            this.itemNameGV,
            this.qtyGV,
            this.priceGV,
            this.totalPriceGV,
            this.removeBtnGV});
            this.spoDGV.Location = new System.Drawing.Point(46, 263);
            this.spoDGV.Name = "spoDGV";
            this.spoDGV.Size = new System.Drawing.Size(1079, 563);
            this.spoDGV.TabIndex = 0;
            this.spoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemIDGV
            // 
            this.ItemIDGV.HeaderText = "Item ID";
            this.ItemIDGV.Name = "ItemIDGV";
            this.ItemIDGV.ReadOnly = true;
            // 
            // itemNameGV
            // 
            this.itemNameGV.HeaderText = "Item Name";
            this.itemNameGV.Name = "itemNameGV";
            this.itemNameGV.ReadOnly = true;
            // 
            // qtyGV
            // 
            this.qtyGV.HeaderText = "Quantity";
            this.qtyGV.Name = "qtyGV";
            // 
            // priceGV
            // 
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // totalPriceGV
            // 
            this.totalPriceGV.HeaderText = "Total Price";
            this.totalPriceGV.Name = "totalPriceGV";
            this.totalPriceGV.ReadOnly = true;
            // 
            // removeBtnGV
            // 
            this.removeBtnGV.HeaderText = "Remove";
            this.removeBtnGV.Name = "removeBtnGV";
            this.removeBtnGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supAddressTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.supConNumTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.supConEmailTxt);
            this.groupBox1.Controls.Add(this.supIDTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SupConNameTxt);
            this.groupBox1.Controls.Add(this.supNameTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(46, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 183);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Info";
            // 
            // supAddressTxt
            // 
            this.supAddressTxt.Location = new System.Drawing.Point(98, 99);
            this.supAddressTxt.Name = "supAddressTxt";
            this.supAddressTxt.ReadOnly = true;
            this.supAddressTxt.Size = new System.Drawing.Size(975, 78);
            this.supAddressTxt.TabIndex = 18;
            this.supAddressTxt.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Supplier Address";
            // 
            // supConNumTxt
            // 
            this.supConNumTxt.Location = new System.Drawing.Point(807, 73);
            this.supConNumTxt.Name = "supConNumTxt";
            this.supConNumTxt.ReadOnly = true;
            this.supConNumTxt.Size = new System.Drawing.Size(140, 20);
            this.supConNumTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier ID";
            // 
            // supConEmailTxt
            // 
            this.supConEmailTxt.Location = new System.Drawing.Point(475, 73);
            this.supConEmailTxt.Name = "supConEmailTxt";
            this.supConEmailTxt.ReadOnly = true;
            this.supConEmailTxt.Size = new System.Drawing.Size(203, 20);
            this.supConEmailTxt.TabIndex = 14;
            // 
            // supIDTxt
            // 
            this.supIDTxt.Location = new System.Drawing.Point(186, 25);
            this.supIDTxt.Name = "supIDTxt";
            this.supIDTxt.ReadOnly = true;
            this.supIDTxt.Size = new System.Drawing.Size(161, 20);
            this.supIDTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // SupConNameTxt
            // 
            this.SupConNameTxt.Location = new System.Drawing.Point(186, 72);
            this.SupConNameTxt.Name = "SupConNameTxt";
            this.SupConNameTxt.ReadOnly = true;
            this.SupConNameTxt.Size = new System.Drawing.Size(161, 20);
            this.SupConNameTxt.TabIndex = 10;
            // 
            // supNameTxt
            // 
            this.supNameTxt.Location = new System.Drawing.Point(485, 25);
            this.supNameTxt.Name = "supNameTxt";
            this.supNameTxt.ReadOnly = true;
            this.supNameTxt.Size = new System.Drawing.Size(462, 20);
            this.supNameTxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Name";
            // 
            // pIDTxt
            // 
            this.pIDTxt.Location = new System.Drawing.Point(620, 42);
            this.pIDTxt.Name = "pIDTxt";
            this.pIDTxt.ReadOnly = true;
            this.pIDTxt.Size = new System.Drawing.Size(301, 20);
            this.pIDTxt.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Purchase ID";
            // 
            // refTxt
            // 
            this.refTxt.Location = new System.Drawing.Point(202, 39);
            this.refTxt.Name = "refTxt";
            this.refTxt.ReadOnly = true;
            this.refTxt.Size = new System.Drawing.Size(335, 20);
            this.refTxt.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ref Number";
            // 
            // bpaIDselect
            // 
            this.bpaIDselect.FormattingEnabled = true;
            this.bpaIDselect.Location = new System.Drawing.Point(200, 12);
            this.bpaIDselect.Name = "bpaIDselect";
            this.bpaIDselect.Size = new System.Drawing.Size(730, 21);
            this.bpaIDselect.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Contract ID";
            // 
            // SPOpurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 905);
            this.Controls.Add(this.pIDTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.refTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bpaIDselect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.spoDGV);
            this.Name = "SPOpurchase";
            this.Text = "SPOpurchase";
            ((System.ComponentModel.ISupportInitialize)(this.spoDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView spoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceGV;
        private System.Windows.Forms.DataGridViewButtonColumn removeBtnGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox supAddressTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox supConNumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supConEmailTxt;
        private System.Windows.Forms.TextBox supIDTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupConNameTxt;
        private System.Windows.Forms.TextBox supNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pIDTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox refTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bpaIDselect;
        private System.Windows.Forms.Label label1;
    }
}