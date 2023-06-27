namespace Client.UI.USFDelivery
{
    partial class DeliveryDetail
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
            this.btnBackDelivery = new System.Windows.Forms.Button();
            this.detailData = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResturantName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeliveryTime = new System.Windows.Forms.Label();
            this.tbDeliveryID = new System.Windows.Forms.TextBox();
            this.tbResturantID = new System.Windows.Forms.TextBox();
            this.tbSupplierssupID = new System.Windows.Forms.TextBox();
            this.tbDeliveryDate = new System.Windows.Forms.TextBox();
            this.tbDeliveryT = new System.Windows.Forms.TextBox();
            this.tbResturant = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.detailData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackDelivery
            // 
            this.btnBackDelivery.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnBackDelivery.Location = new System.Drawing.Point(29, 683);
            this.btnBackDelivery.Name = "btnBackDelivery";
            this.btnBackDelivery.Size = new System.Drawing.Size(111, 46);
            this.btnBackDelivery.TabIndex = 0;
            this.btnBackDelivery.Text = "Back";
            this.btnBackDelivery.UseVisualStyleBackColor = true;
            this.btnBackDelivery.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailData
            // 
            this.detailData.AllowUserToAddRows = false;
            this.detailData.AllowUserToDeleteRows = false;
            this.detailData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.detailData.ColumnHeadersHeight = 50;
            this.detailData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.detailData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.itemID,
            this.itemName,
            this.itemQuantity,
            this.price});
            this.detailData.Location = new System.Drawing.Point(29, 361);
            this.detailData.Name = "detailData";
            this.detailData.RowHeadersWidth = 51;
            this.detailData.RowTemplate.Height = 27;
            this.detailData.Size = new System.Drawing.Size(796, 316);
            this.detailData.TabIndex = 2;
            this.detailData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderID
            // 
            this.orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderID.DataPropertyName = "OrderID";
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            // 
            // itemID
            // 
            this.itemID.DataPropertyName = "itemID";
            this.itemID.HeaderText = "Item ID";
            this.itemID.MinimumWidth = 6;
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemQuantity
            // 
            this.itemQuantity.DataPropertyName = "itemQuantity";
            this.itemQuantity.HeaderText = "Item Quantity";
            this.itemQuantity.MinimumWidth = 6;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnDownload.Location = new System.Drawing.Point(717, 326);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(96, 29);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delivery ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F);
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delivery Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(308, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resturant ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(557, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supplierssup ID:";
            // 
            // tbResturantName
            // 
            this.tbResturantName.AutoSize = true;
            this.tbResturantName.Font = new System.Drawing.Font("新細明體", 10F);
            this.tbResturantName.Location = new System.Drawing.Point(26, 237);
            this.tbResturantName.Name = "tbResturantName";
            this.tbResturantName.Size = new System.Drawing.Size(114, 17);
            this.tbResturantName.TabIndex = 8;
            this.tbResturantName.Text = "Resturant Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(337, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address:";
            // 
            // tbDeliveryTime
            // 
            this.tbDeliveryTime.AutoSize = true;
            this.tbDeliveryTime.Font = new System.Drawing.Font("新細明體", 10F);
            this.tbDeliveryTime.Location = new System.Drawing.Point(308, 150);
            this.tbDeliveryTime.Name = "tbDeliveryTime";
            this.tbDeliveryTime.Size = new System.Drawing.Size(104, 17);
            this.tbDeliveryTime.TabIndex = 10;
            this.tbDeliveryTime.Text = "Delivery Time:";
            // 
            // tbDeliveryID
            // 
            this.tbDeliveryID.Location = new System.Drawing.Point(146, 53);
            this.tbDeliveryID.Name = "tbDeliveryID";
            this.tbDeliveryID.Size = new System.Drawing.Size(131, 25);
            this.tbDeliveryID.TabIndex = 11;
            this.tbDeliveryID.TextChanged += new System.EventHandler(this.tbDeliveryID_TextChanged);
            // 
            // tbResturantID
            // 
            this.tbResturantID.Location = new System.Drawing.Point(418, 55);
            this.tbResturantID.Name = "tbResturantID";
            this.tbResturantID.Size = new System.Drawing.Size(133, 25);
            this.tbResturantID.TabIndex = 12;
            this.tbResturantID.TextChanged += new System.EventHandler(this.tbResturantID_TextChanged);
            // 
            // tbSupplierssupID
            // 
            this.tbSupplierssupID.Location = new System.Drawing.Point(677, 60);
            this.tbSupplierssupID.Name = "tbSupplierssupID";
            this.tbSupplierssupID.Size = new System.Drawing.Size(136, 25);
            this.tbSupplierssupID.TabIndex = 13;
            this.tbSupplierssupID.TextChanged += new System.EventHandler(this.tbSupplierssupID_TextChanged);
            // 
            // tbDeliveryDate
            // 
            this.tbDeliveryDate.Location = new System.Drawing.Point(146, 142);
            this.tbDeliveryDate.Name = "tbDeliveryDate";
            this.tbDeliveryDate.Size = new System.Drawing.Size(131, 25);
            this.tbDeliveryDate.TabIndex = 14;
            this.tbDeliveryDate.TextChanged += new System.EventHandler(this.tbDeliveryDate_TextChanged);
            // 
            // tbDeliveryT
            // 
            this.tbDeliveryT.Location = new System.Drawing.Point(418, 149);
            this.tbDeliveryT.Name = "tbDeliveryT";
            this.tbDeliveryT.Size = new System.Drawing.Size(133, 25);
            this.tbDeliveryT.TabIndex = 15;
            this.tbDeliveryT.TextChanged += new System.EventHandler(this.tbDeliveryT_TextChanged);
            // 
            // tbResturant
            // 
            this.tbResturant.Location = new System.Drawing.Point(146, 236);
            this.tbResturant.Name = "tbResturant";
            this.tbResturant.Size = new System.Drawing.Size(131, 25);
            this.tbResturant.TabIndex = 16;
            this.tbResturant.TextChanged += new System.EventHandler(this.tbResturant_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(415, 237);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(266, 25);
            this.tbAddress.TabIndex = 17;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // DeliveryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 774);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbResturant);
            this.Controls.Add(this.tbDeliveryT);
            this.Controls.Add(this.tbDeliveryDate);
            this.Controls.Add(this.tbSupplierssupID);
            this.Controls.Add(this.tbResturantID);
            this.Controls.Add(this.tbDeliveryID);
            this.Controls.Add(this.tbDeliveryTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResturantName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailData);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBackDelivery);
            this.Name = "DeliveryDetail";
            this.Text = "Delivery Detail";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackDelivery;
        private System.Windows.Forms.DataGridView detailData;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tbResturantName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tbDeliveryTime;
        private System.Windows.Forms.TextBox tbDeliveryID;
        private System.Windows.Forms.TextBox tbResturantID;
        private System.Windows.Forms.TextBox tbSupplierssupID;
        private System.Windows.Forms.TextBox tbDeliveryDate;
        private System.Windows.Forms.TextBox tbDeliveryT;
        private System.Windows.Forms.TextBox tbResturant;
        private System.Windows.Forms.TextBox tbAddress;
    }
}