namespace Client.UI.USFDelivery
{
    partial class Delivery
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受z控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deliveryData = new System.Windows.Forms.DataGridView();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resturantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryData
            // 
            this.deliveryData.AllowUserToAddRows = false;
            this.deliveryData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deliveryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.deliveryID,
            this.resturantID,
            this.deliveryDate,
            this.deliveryTime,
            this.deliveryState,
            this.deliveryDetail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deliveryData.DefaultCellStyle = dataGridViewCellStyle2;
            this.deliveryData.Location = new System.Drawing.Point(11, 125);
            this.deliveryData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deliveryData.MultiSelect = false;
            this.deliveryData.Name = "deliveryData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deliveryData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.deliveryData.RowHeadersWidth = 51;
            this.deliveryData.RowTemplate.Height = 27;
            this.deliveryData.Size = new System.Drawing.Size(1038, 323);
            this.deliveryData.TabIndex = 2;
            this.deliveryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // orderID
            // 
            this.orderID.DataPropertyName = "OrderID";
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.ReadOnly = true;
            this.orderID.Width = 125;
            // 
            // deliveryID
            // 
            this.deliveryID.DataPropertyName = "DeliveryID";
            this.deliveryID.HeaderText = "Delivery ID";
            this.deliveryID.MinimumWidth = 6;
            this.deliveryID.Name = "deliveryID";
            this.deliveryID.ReadOnly = true;
            this.deliveryID.Width = 125;
            // 
            // resturantID
            // 
            this.resturantID.DataPropertyName = "ResturantID";
            this.resturantID.HeaderText = "Resturant ID";
            this.resturantID.MinimumWidth = 6;
            this.resturantID.Name = "resturantID";
            this.resturantID.ReadOnly = true;
            this.resturantID.Width = 125;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            this.deliveryDate.HeaderText = "Delivery Date";
            this.deliveryDate.MinimumWidth = 6;
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            this.deliveryDate.Width = 125;
            // 
            // deliveryTime
            // 
            this.deliveryTime.DataPropertyName = "deliveryTime";
            this.deliveryTime.HeaderText = "Delivery Time";
            this.deliveryTime.MinimumWidth = 6;
            this.deliveryTime.Name = "deliveryTime";
            this.deliveryTime.ReadOnly = true;
            this.deliveryTime.Width = 125;
            // 
            // deliveryState
            // 
            this.deliveryState.DataPropertyName = "State";
            this.deliveryState.HeaderText = "Delivery State";
            this.deliveryState.MinimumWidth = 6;
            this.deliveryState.Name = "deliveryState";
            this.deliveryState.ReadOnly = true;
            this.deliveryState.Width = 125;
            // 
            // deliveryDetail
            // 
            this.deliveryDetail.DataPropertyName = "deliveryDetail";
            this.deliveryDetail.HeaderText = "Delivery Detail";
            this.deliveryDetail.MinimumWidth = 6;
            this.deliveryDetail.Name = "deliveryDetail";
            this.deliveryDetail.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(320, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yummy Restaurant Group Limited";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Date.Location = new System.Drawing.Point(666, 28);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(53, 24);
            this.Date.TabIndex = 6;
            this.Date.Text = "Date:";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDate.Location = new System.Drawing.Point(714, 29);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(110, 23);
            this.tbDate.TabIndex = 7;
            this.tbDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 564);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryData);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Delivery";
            this.Text = "Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView deliveryData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn resturantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryState;
        private System.Windows.Forms.DataGridViewButtonColumn deliveryDetail;
    }
}

