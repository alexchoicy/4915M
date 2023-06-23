namespace Client.UI.Purchase
{
    partial class BPApurchase
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
            this.bpaIDselect = new System.Windows.Forms.ComboBox();
            this.BPAviewGrid = new System.Windows.Forms.DataGridView();
            this.ItemIDdata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refSupItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moqGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.supIDTxt = new System.Windows.Forms.TextBox();
            this.sumBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.supNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SupConNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.supConEmailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supAddressTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.supConNumTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.refTxt = new System.Windows.Forms.TextBox();
            this.pIDTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BPAviewGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BPA ID";
            // 
            // bpaIDselect
            // 
            this.bpaIDselect.FormattingEnabled = true;
            this.bpaIDselect.Location = new System.Drawing.Point(121, 26);
            this.bpaIDselect.Name = "bpaIDselect";
            this.bpaIDselect.Size = new System.Drawing.Size(730, 21);
            this.bpaIDselect.TabIndex = 1;
            this.bpaIDselect.SelectedIndexChanged += new System.EventHandler(this.bpaIDselect_SelectedIndexChanged);
            // 
            // BPAviewGrid
            // 
            this.BPAviewGrid.AllowUserToAddRows = false;
            this.BPAviewGrid.AllowUserToDeleteRows = false;
            this.BPAviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BPAviewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDdata,
            this.refSupItemID,
            this.itemNameGrid,
            this.unitGrid,
            this.moqGrid,
            this.quantityGrid,
            this.priceGrid});
            this.BPAviewGrid.Location = new System.Drawing.Point(47, 282);
            this.BPAviewGrid.Name = "BPAviewGrid";
            this.BPAviewGrid.Size = new System.Drawing.Size(795, 599);
            this.BPAviewGrid.TabIndex = 2;
            // 
            // ItemIDdata
            // 
            this.ItemIDdata.HeaderText = "item ID";
            this.ItemIDdata.Name = "ItemIDdata";
            this.ItemIDdata.ReadOnly = true;
            // 
            // refSupItemID
            // 
            this.refSupItemID.HeaderText = "Supplier Ref ID";
            this.refSupItemID.Name = "refSupItemID";
            this.refSupItemID.ReadOnly = true;
            // 
            // itemNameGrid
            // 
            this.itemNameGrid.HeaderText = "Item Name";
            this.itemNameGrid.Name = "itemNameGrid";
            this.itemNameGrid.ReadOnly = true;
            // 
            // unitGrid
            // 
            this.unitGrid.HeaderText = "Unit";
            this.unitGrid.Name = "unitGrid";
            this.unitGrid.ReadOnly = true;
            // 
            // moqGrid
            // 
            this.moqGrid.HeaderText = "MOQ";
            this.moqGrid.Name = "moqGrid";
            this.moqGrid.ReadOnly = true;
            // 
            // quantityGrid
            // 
            this.quantityGrid.HeaderText = "Quantity";
            this.quantityGrid.Name = "quantityGrid";
            // 
            // priceGrid
            // 
            this.priceGrid.HeaderText = "Price";
            this.priceGrid.Name = "priceGrid";
            this.priceGrid.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier ID";
            // 
            // supIDTxt
            // 
            this.supIDTxt.Location = new System.Drawing.Point(87, 26);
            this.supIDTxt.Name = "supIDTxt";
            this.supIDTxt.ReadOnly = true;
            this.supIDTxt.Size = new System.Drawing.Size(161, 20);
            this.supIDTxt.TabIndex = 4;
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(766, 947);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(110, 51);
            this.sumBtn.TabIndex = 5;
            this.sumBtn.Text = "Sumbit";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(650, 947);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 51);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // supNameTxt
            // 
            this.supNameTxt.Location = new System.Drawing.Point(350, 26);
            this.supNameTxt.Name = "supNameTxt";
            this.supNameTxt.ReadOnly = true;
            this.supNameTxt.Size = new System.Drawing.Size(439, 20);
            this.supNameTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // SupConNameTxt
            // 
            this.SupConNameTxt.Location = new System.Drawing.Point(87, 72);
            this.SupConNameTxt.Name = "SupConNameTxt";
            this.SupConNameTxt.ReadOnly = true;
            this.SupConNameTxt.Size = new System.Drawing.Size(161, 20);
            this.SupConNameTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Name";
            // 
            // supConEmailTxt
            // 
            this.supConEmailTxt.Location = new System.Drawing.Point(350, 72);
            this.supConEmailTxt.Name = "supConEmailTxt";
            this.supConEmailTxt.ReadOnly = true;
            this.supConEmailTxt.Size = new System.Drawing.Size(203, 20);
            this.supConEmailTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact email";
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
            this.groupBox1.Location = new System.Drawing.Point(56, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 166);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Info";
            // 
            // supAddressTxt
            // 
            this.supAddressTxt.Location = new System.Drawing.Point(99, 116);
            this.supAddressTxt.Name = "supAddressTxt";
            this.supAddressTxt.ReadOnly = true;
            this.supAddressTxt.Size = new System.Drawing.Size(690, 44);
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
            this.supConNumTxt.Location = new System.Drawing.Point(649, 73);
            this.supConNumTxt.Name = "supConNumTxt";
            this.supConNumTxt.ReadOnly = true;
            this.supConNumTxt.Size = new System.Drawing.Size(140, 20);
            this.supConNumTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(686, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "MOQ = Minimum Order Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ref Number";
            // 
            // refTxt
            // 
            this.refTxt.Location = new System.Drawing.Point(123, 53);
            this.refTxt.Name = "refTxt";
            this.refTxt.ReadOnly = true;
            this.refTxt.Size = new System.Drawing.Size(335, 20);
            this.refTxt.TabIndex = 19;
            // 
            // pIDTxt
            // 
            this.pIDTxt.Location = new System.Drawing.Point(541, 56);
            this.pIDTxt.Name = "pIDTxt";
            this.pIDTxt.ReadOnly = true;
            this.pIDTxt.Size = new System.Drawing.Size(301, 20);
            this.pIDTxt.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Purchase ID";
            // 
            // BPApurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 1009);
            this.Controls.Add(this.pIDTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.refTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.BPAviewGrid);
            this.Controls.Add(this.bpaIDselect);
            this.Controls.Add(this.label1);
            this.Name = "BPApurchase";
            this.Text = "BPApurchase";
            ((System.ComponentModel.ISupportInitialize)(this.BPAviewGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bpaIDselect;
        private System.Windows.Forms.DataGridView BPAviewGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supIDTxt;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox supNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupConNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supConEmailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox supConNumTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox supAddressTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox refTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn refSupItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn moqGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGrid;
        private System.Windows.Forms.TextBox pIDTxt;
        private System.Windows.Forms.Label label10;
    }
}