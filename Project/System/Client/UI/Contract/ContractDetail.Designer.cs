namespace Client.UI.Contract
{
    partial class ContractDetail
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.cdcontractIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierID = new System.Windows.Forms.Label();
            this.staffidTxt = new System.Windows.Forms.Label();
            this.cdSupIDTxt = new System.Windows.Forms.TextBox();
            this.cdStaffIDTxt = new System.Windows.Forms.TextBox();
            this.cdexpTxt = new System.Windows.Forms.TextBox();
            this.cdsignTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cdDownBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemCategoryID,
            this.itemName,
            this.itemQuantity,
            this.itemPrice});
            this.itemGridView.Location = new System.Drawing.Point(39, 146);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.Size = new System.Drawing.Size(739, 292);
            this.itemGridView.TabIndex = 0;
            // 
            // cdcontractIdTxt
            // 
            this.cdcontractIdTxt.Location = new System.Drawing.Point(139, 33);
            this.cdcontractIdTxt.Name = "cdcontractIdTxt";
            this.cdcontractIdTxt.ReadOnly = true;
            this.cdcontractIdTxt.Size = new System.Drawing.Size(100, 20);
            this.cdcontractIdTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ContractID";
            // 
            // supplierID
            // 
            this.supplierID.AutoSize = true;
            this.supplierID.Location = new System.Drawing.Point(288, 39);
            this.supplierID.Name = "supplierID";
            this.supplierID.Size = new System.Drawing.Size(59, 13);
            this.supplierID.TabIndex = 3;
            this.supplierID.Text = "Supplier ID";
            // 
            // staffidTxt
            // 
            this.staffidTxt.AutoSize = true;
            this.staffidTxt.Location = new System.Drawing.Point(573, 39);
            this.staffidTxt.Name = "staffidTxt";
            this.staffidTxt.Size = new System.Drawing.Size(43, 13);
            this.staffidTxt.TabIndex = 4;
            this.staffidTxt.Text = "Staff ID";
            // 
            // cdSupIDTxt
            // 
            this.cdSupIDTxt.Location = new System.Drawing.Point(367, 36);
            this.cdSupIDTxt.Name = "cdSupIDTxt";
            this.cdSupIDTxt.ReadOnly = true;
            this.cdSupIDTxt.Size = new System.Drawing.Size(100, 20);
            this.cdSupIDTxt.TabIndex = 5;
            // 
            // cdStaffIDTxt
            // 
            this.cdStaffIDTxt.Location = new System.Drawing.Point(643, 36);
            this.cdStaffIDTxt.Name = "cdStaffIDTxt";
            this.cdStaffIDTxt.ReadOnly = true;
            this.cdStaffIDTxt.Size = new System.Drawing.Size(100, 20);
            this.cdStaffIDTxt.TabIndex = 6;
            // 
            // cdexpTxt
            // 
            this.cdexpTxt.Location = new System.Drawing.Point(367, 85);
            this.cdexpTxt.Name = "cdexpTxt";
            this.cdexpTxt.ReadOnly = true;
            this.cdexpTxt.Size = new System.Drawing.Size(100, 20);
            this.cdexpTxt.TabIndex = 7;
            // 
            // cdsignTxt
            // 
            this.cdsignTxt.Location = new System.Drawing.Point(139, 85);
            this.cdsignTxt.Name = "cdsignTxt";
            this.cdsignTxt.ReadOnly = true;
            this.cdsignTxt.Size = new System.Drawing.Size(100, 20);
            this.cdsignTxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sign Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item";
            // 
            // cdDownBtn
            // 
            this.cdDownBtn.Location = new System.Drawing.Point(652, 91);
            this.cdDownBtn.Name = "cdDownBtn";
            this.cdDownBtn.Size = new System.Drawing.Size(75, 23);
            this.cdDownBtn.TabIndex = 12;
            this.cdDownBtn.Text = "Download";
            this.cdDownBtn.UseVisualStyleBackColor = true;
            this.cdDownBtn.Click += new System.EventHandler(this.cdDownBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Download Docs";
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            // 
            // itemCategoryID
            // 
            this.itemCategoryID.HeaderText = "Category ID";
            this.itemCategoryID.Name = "itemCategoryID";
            this.itemCategoryID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // ContractDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdDownBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cdsignTxt);
            this.Controls.Add(this.cdexpTxt);
            this.Controls.Add(this.cdStaffIDTxt);
            this.Controls.Add(this.cdSupIDTxt);
            this.Controls.Add(this.staffidTxt);
            this.Controls.Add(this.supplierID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cdcontractIdTxt);
            this.Controls.Add(this.itemGridView);
            this.Name = "ContractDetail";
            this.Text = "ContractDetail";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.TextBox cdcontractIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label supplierID;
        private System.Windows.Forms.Label staffidTxt;
        private System.Windows.Forms.TextBox cdSupIDTxt;
        private System.Windows.Forms.TextBox cdStaffIDTxt;
        private System.Windows.Forms.TextBox cdexpTxt;
        private System.Windows.Forms.TextBox cdsignTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cdDownBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
    }
}