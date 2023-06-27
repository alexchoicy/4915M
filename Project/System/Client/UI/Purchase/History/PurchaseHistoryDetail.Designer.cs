namespace Client.UI.Purchase.History
{
    partial class PurchaseHistoryDetail
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
            this.GV = new System.Windows.Forms.DataGridView();
            this.itemidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supRefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DownBtn = new System.Windows.Forms.Button();
            this.SupIDTxt = new System.Windows.Forms.TextBox();
            this.supplierID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cdcontractIdTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acDetailBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expDatePick = new System.Windows.Forms.DateTimePicker();
            this.upBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.supRefTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DNtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pIDtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            this.SuspendLayout();
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidGV,
            this.supRefID,
            this.itemNameGV,
            this.qtyGV,
            this.price});
            this.GV.Location = new System.Drawing.Point(73, 210);
            this.GV.Name = "GV";
            this.GV.RowHeadersWidth = 62;
            this.GV.Size = new System.Drawing.Size(1250, 516);
            this.GV.TabIndex = 0;
            // 
            // itemidGV
            // 
            this.itemidGV.HeaderText = "Item ID / Unit";
            this.itemidGV.MinimumWidth = 8;
            this.itemidGV.Name = "itemidGV";
            this.itemidGV.ReadOnly = true;
            this.itemidGV.Width = 150;
            // 
            // supRefID
            // 
            this.supRefID.HeaderText = "Supplier Ref ID";
            this.supRefID.MinimumWidth = 8;
            this.supRefID.Name = "supRefID";
            this.supRefID.ReadOnly = true;
            this.supRefID.Width = 150;
            // 
            // itemNameGV
            // 
            this.itemNameGV.HeaderText = "Item Name";
            this.itemNameGV.MinimumWidth = 8;
            this.itemNameGV.Name = "itemNameGV";
            this.itemNameGV.ReadOnly = true;
            this.itemNameGV.Width = 150;
            // 
            // qtyGV
            // 
            this.qtyGV.HeaderText = "Quantity";
            this.qtyGV.MinimumWidth = 8;
            this.qtyGV.Name = "qtyGV";
            this.qtyGV.ReadOnly = true;
            this.qtyGV.Width = 150;
            // 
            // price
            // 
            this.price.HeaderText = "TotalPrice";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1128, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Download Docs";
            // 
            // DownBtn
            // 
            this.DownBtn.Location = new System.Drawing.Point(1217, 145);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(100, 54);
            this.DownBtn.TabIndex = 14;
            this.DownBtn.Text = "Download";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // SupIDTxt
            // 
            this.SupIDTxt.Location = new System.Drawing.Point(397, 39);
            this.SupIDTxt.Name = "SupIDTxt";
            this.SupIDTxt.ReadOnly = true;
            this.SupIDTxt.Size = new System.Drawing.Size(100, 20);
            this.SupIDTxt.TabIndex = 22;
            // 
            // supplierID
            // 
            this.supplierID.AutoSize = true;
            this.supplierID.Location = new System.Drawing.Point(312, 42);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(59, 13);
            this.supplierID.TabIndex = 20;
            this.supplierID.Text = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ContractID";
            // 
            // cdcontractIdTxt
            // 
            this.cdcontractIdTxt.Location = new System.Drawing.Point(169, 86);
            this.cdcontractIdTxt.Name = "cdcontractIdTxt";
            this.cdcontractIdTxt.ReadOnly = true;
            this.cdcontractIdTxt.Size = new System.Drawing.Size(100, 20);
            this.cdcontractIdTxt.TabIndex = 18;
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(169, 130);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(100, 20);
            this.dateTxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Create Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Agreement/Contact Detail";
            // 
            // acDetailBtn
            // 
            this.acDetailBtn.Location = new System.Drawing.Point(1011, 144);
            this.acDetailBtn.Name = "acDetailBtn";
            this.acDetailBtn.Size = new System.Drawing.Size(100, 57);
            this.acDetailBtn.TabIndex = 30;
            this.acDetailBtn.Text = "Detail";
            this.acDetailBtn.UseVisualStyleBackColor = true;
            this.acDetailBtn.Click += new System.EventHandler(this.acDetailBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Type";
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(400, 127);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.ReadOnly = true;
            this.typeTxt.Size = new System.Drawing.Size(100, 20);
            this.typeTxt.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Expected Delivery Date";
            // 
            // expDatePick
            // 
            this.expDatePick.Location = new System.Drawing.Point(711, 39);
            this.expDatePick.Margin = new System.Windows.Forms.Padding(2);
            this.expDatePick.Name = "expDatePick";
            this.expDatePick.Size = new System.Drawing.Size(214, 20);
            this.expDatePick.TabIndex = 36;
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(853, 103);
            this.upBtn.Margin = new System.Windows.Forms.Padding(2);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(72, 47);
            this.upBtn.TabIndex = 37;
            this.upBtn.Text = "Update";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Supplier Ref ID";
            // 
            // supRefTxt
            // 
            this.supRefTxt.Location = new System.Drawing.Point(397, 82);
            this.supRefTxt.Name = "supRefTxt";
            this.supRefTxt.ReadOnly = true;
            this.supRefTxt.Size = new System.Drawing.Size(100, 20);
            this.supRefTxt.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Supplier Delivery note";
            // 
            // DNtxt
            // 
            this.DNtxt.Location = new System.Drawing.Point(714, 77);
            this.DNtxt.Name = "DNtxt";
            this.DNtxt.Size = new System.Drawing.Size(211, 20);
            this.DNtxt.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Purchase ID";
            // 
            // pIDtxt
            // 
            this.pIDtxt.Location = new System.Drawing.Point(169, 35);
            this.pIDtxt.Name = "pIDtxt";
            this.pIDtxt.ReadOnly = true;
            this.pIDtxt.Size = new System.Drawing.Size(100, 20);
            this.pIDtxt.TabIndex = 42;
            // 
            // PurchaseHistoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 768);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pIDtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DNtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.supRefTxt);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.expDatePick);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.acDetailBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.SupIDTxt);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cdcontractIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.GV);
            this.Name = "PurchaseHistoryDetail";
            this.Text = "PurchaseHistoryDetail";
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.TextBox SupIDTxt;
        private System.Windows.Forms.Label supplierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cdcontractIdTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button acDetailBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expDatePick;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox supRefTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn supRefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DNtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pIDtxt;
    }
}