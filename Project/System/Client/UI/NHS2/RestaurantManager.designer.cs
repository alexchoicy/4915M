namespace Client.UI.NHS2
{
    partial class RestaurantManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantManager));
            this.EditOrderbtn = new System.Windows.Forms.Button();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CreateOrderbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Importbtn = new System.Windows.Forms.Button();
            this.MappingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditOrderbtn
            // 
            this.EditOrderbtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.EditOrderbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditOrderbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditOrderbtn.Location = new System.Drawing.Point(138, 108);
            this.EditOrderbtn.Name = "EditOrderbtn";
            this.EditOrderbtn.Size = new System.Drawing.Size(117, 33);
            this.EditOrderbtn.TabIndex = 27;
            this.EditOrderbtn.Text = "Edit";
            this.EditOrderbtn.UseVisualStyleBackColor = true;
            this.EditOrderbtn.Click += new System.EventHandler(this.EditOrderbtn_Click);
            // 
            // SearchpictureBox
            // 
            this.SearchpictureBox.ErrorImage = null;
            this.SearchpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SearchpictureBox.Image")));
            this.SearchpictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SearchpictureBox.InitialImage = null;
            this.SearchpictureBox.Location = new System.Drawing.Point(739, 105);
            this.SearchpictureBox.Name = "SearchpictureBox";
            this.SearchpictureBox.Size = new System.Drawing.Size(35, 34);
            this.SearchpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchpictureBox.TabIndex = 26;
            this.SearchpictureBox.TabStop = false;
            // 
            // Searchbox
            // 
            this.Searchbox.Font = new System.Drawing.Font("新細明體", 12F);
            this.Searchbox.Location = new System.Drawing.Point(553, 108);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(180, 27);
            this.Searchbox.TabIndex = 25;
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CurrentDate.Font = new System.Drawing.Font("新細明體", 12F);
            this.CurrentDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CurrentDate.Location = new System.Drawing.Point(645, 22);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(36, 16);
            this.CurrentDate.TabIndex = 24;
            this.CurrentDate.Text = "Date";
            this.CurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("新細明體", 14F);
            this.Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Date.Location = new System.Drawing.Point(591, 21);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 19);
            this.Date.TabIndex = 23;
            this.Date.Text = "Date:";
            // 
            // CreateOrderbtn
            // 
            this.CreateOrderbtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.CreateOrderbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CreateOrderbtn.Location = new System.Drawing.Point(15, 108);
            this.CreateOrderbtn.Name = "CreateOrderbtn";
            this.CreateOrderbtn.Size = new System.Drawing.Size(117, 33);
            this.CreateOrderbtn.TabIndex = 22;
            this.CreateOrderbtn.Text = "Request Order";
            this.CreateOrderbtn.UseVisualStyleBackColor = true;
            this.CreateOrderbtn.Click += new System.EventHandler(this.CreateOrderbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(278, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Yummy Restaurant Group Limited";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "User ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "User:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MappingID,
            this.DeliverID,
            this.orderDate,
            this.DeliveryAddress,
            this.Status});
            this.DataGridView.Location = new System.Drawing.Point(15, 144);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(759, 291);
            this.DataGridView.TabIndex = 17;
            // 
            // Importbtn
            // 
            this.Importbtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.Importbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Importbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Importbtn.Location = new System.Drawing.Point(261, 108);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(117, 33);
            this.Importbtn.TabIndex = 29;
            this.Importbtn.Text = "Import";
            this.Importbtn.UseVisualStyleBackColor = true;
            // 
            // MappingID
            // 
            this.MappingID.HeaderText = "Order ID";
            this.MappingID.Name = "MappingID";
            this.MappingID.ReadOnly = true;
            this.MappingID.Width = 80;
            // 
            // DeliverID
            // 
            this.DeliverID.HeaderText = "Deliver ID";
            this.DeliverID.Name = "DeliverID";
            this.DeliverID.ReadOnly = true;
            this.DeliverID.Width = 80;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Order Date";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Width = 90;
            // 
            // DeliveryAddress
            // 
            this.DeliveryAddress.HeaderText = "Delivery Address";
            this.DeliveryAddress.Name = "DeliveryAddress";
            this.DeliveryAddress.ReadOnly = true;
            this.DeliveryAddress.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 250;
            // 
            // RestaurantManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Importbtn);
            this.Controls.Add(this.EditOrderbtn);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CreateOrderbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "RestaurantManager";
            this.Text = "Yummy Restaurant Group Limited Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditOrderbtn;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button CreateOrderbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Importbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MappingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}