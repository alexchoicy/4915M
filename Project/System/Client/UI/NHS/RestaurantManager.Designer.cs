namespace test
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.EditOrderbtn = new System.Windows.Forms.Button();
            this.SearchpictureBox = new System.Windows.Forms.PictureBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.CreateOrderbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Purchasepage = new System.Windows.Forms.LinkLabel();
            this.Mapping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MappingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Importbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("新細明體", 14F);
            this.linkLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabel2.Location = new System.Drawing.Point(13, 144);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 19);
            this.linkLabel2.TabIndex = 28;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Stock";
            // 
            // EditOrderbtn
            // 
            this.EditOrderbtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.EditOrderbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EditOrderbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditOrderbtn.Location = new System.Drawing.Point(312, 105);
            this.EditOrderbtn.Name = "EditOrderbtn";
            this.EditOrderbtn.Size = new System.Drawing.Size(117, 33);
            this.EditOrderbtn.TabIndex = 27;
            this.EditOrderbtn.Text = "Edit Order";
            this.EditOrderbtn.UseVisualStyleBackColor = true;
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
            this.CreateOrderbtn.Location = new System.Drawing.Point(189, 105);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mapping,
            this.MappingID,
            this.DeliverID,
            this.DeliveryDate,
            this.Status,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(189, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(585, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // Purchasepage
            // 
            this.Purchasepage.AutoSize = true;
            this.Purchasepage.Font = new System.Drawing.Font("新細明體", 14F);
            this.Purchasepage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Purchasepage.Location = new System.Drawing.Point(11, 163);
            this.Purchasepage.Name = "Purchasepage";
            this.Purchasepage.Size = new System.Drawing.Size(143, 19);
            this.Purchasepage.TabIndex = 20;
            this.Purchasepage.TabStop = true;
            this.Purchasepage.Text = "Purchase Manager";
            // 
            // Mapping
            // 
            this.Mapping.HeaderText = "MappingID";
            this.Mapping.Name = "Mapping";
            this.Mapping.ReadOnly = true;
            // 
            // MappingID
            // 
            this.MappingID.HeaderText = "Order ID";
            this.MappingID.Name = "MappingID";
            this.MappingID.ReadOnly = true;
            // 
            // DeliverID
            // 
            this.DeliverID.HeaderText = "Deliver ID";
            this.DeliverID.Name = "DeliverID";
            this.DeliverID.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Date";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Width = 90;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "⋮";
            this.Edit.Width = 30;
            // 
            // Importbtn
            // 
            this.Importbtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.Importbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Importbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Importbtn.Location = new System.Drawing.Point(435, 105);
            this.Importbtn.Name = "Importbtn";
            this.Importbtn.Size = new System.Drawing.Size(117, 33);
            this.Importbtn.TabIndex = 29;
            this.Importbtn.Text = "Import";
            this.Importbtn.UseVisualStyleBackColor = true;
            // 
            // RestaurantManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Importbtn);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.EditOrderbtn);
            this.Controls.Add(this.SearchpictureBox);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.CreateOrderbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Purchasepage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RestaurantManager";
            this.Text = "Yummy Restaurant Group Limited Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.SearchpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button EditOrderbtn;
        private System.Windows.Forms.PictureBox SearchpictureBox;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button CreateOrderbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel Purchasepage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn MappingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button Importbtn;
    }
}