namespace Client.UI.Contract
{
    partial class CreateContract
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
            this.signTimePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.contractTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpireTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffTxt = new System.Windows.Forms.TextBox();
            this.StaffLock = new System.Windows.Forms.CheckBox();
            this.expireTimePick = new System.Windows.Forms.DateTimePicker();
            this.supDataView = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.uploadTxt = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ccDropType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccAddBtn = new System.Windows.Forms.Button();
            this.ccRepDateTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ccCBSupID = new System.Windows.Forms.ComboBox();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moqData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // signTimePick
            // 
            this.signTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.signTimePick.Location = new System.Drawing.Point(230, 142);
            this.signTimePick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signTimePick.Name = "signTimePick";
            this.signTimePick.Size = new System.Drawing.Size(298, 26);
            this.signTimePick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ContractID";
            // 
            // contractTxt
            // 
            this.contractTxt.Location = new System.Drawing.Point(230, 66);
            this.contractTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contractTxt.Name = "contractTxt";
            this.contractTxt.ReadOnly = true;
            this.contractTxt.Size = new System.Drawing.Size(298, 26);
            this.contractTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SignDate";
            // 
            // ExpireTime
            // 
            this.ExpireTime.AutoSize = true;
            this.ExpireTime.Location = new System.Drawing.Point(57, 223);
            this.ExpireTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.Size = new System.Drawing.Size(87, 20);
            this.ExpireTime.TabIndex = 4;
            this.ExpireTime.Text = "ExpireTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SupplierID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "StaffID";
            // 
            // staffTxt
            // 
            this.staffTxt.Location = new System.Drawing.Point(230, 365);
            this.staffTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffTxt.Name = "staffTxt";
            this.staffTxt.ReadOnly = true;
            this.staffTxt.Size = new System.Drawing.Size(298, 26);
            this.staffTxt.TabIndex = 7;
            // 
            // StaffLock
            // 
            this.StaffLock.AutoSize = true;
            this.StaffLock.Location = new System.Drawing.Point(556, 369);
            this.StaffLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffLock.Name = "StaffLock";
            this.StaffLock.Size = new System.Drawing.Size(22, 21);
            this.StaffLock.TabIndex = 8;
            this.StaffLock.UseVisualStyleBackColor = true;
            this.StaffLock.CheckedChanged += new System.EventHandler(this.StaffLock_CheckedChanged);
            // 
            // expireTimePick
            // 
            this.expireTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireTimePick.Location = new System.Drawing.Point(230, 214);
            this.expireTimePick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expireTimePick.Name = "expireTimePick";
            this.expireTimePick.Size = new System.Drawing.Size(298, 26);
            this.expireTimePick.TabIndex = 9;
            // 
            // supDataView
            // 
            this.supDataView.AllowUserToAddRows = false;
            this.supDataView.AllowUserToDeleteRows = false;
            this.supDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.quantity,
            this.priceDataGrid,
            this.moqData});
            this.supDataView.Location = new System.Drawing.Point(734, 48);
            this.supDataView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supDataView.Name = "supDataView";
            this.supDataView.RowHeadersVisible = false;
            this.supDataView.RowHeadersWidth = 62;
            this.supDataView.Size = new System.Drawing.Size(659, 603);
            this.supDataView.TabIndex = 11;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(392, 582);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(138, 69);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(556, 582);
            this.subBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(138, 69);
            this.subBtn.TabIndex = 13;
            this.subBtn.Text = "Sumbit";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // uploadTxt
            // 
            this.uploadTxt.Location = new System.Drawing.Point(234, 440);
            this.uploadTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadTxt.Name = "uploadTxt";
            this.uploadTxt.ReadOnly = true;
            this.uploadTxt.Size = new System.Drawing.Size(220, 26);
            this.uploadTxt.TabIndex = 14;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(462, 435);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(154, 35);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload Button";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Upload File";
            // 
            // ccDropType
            // 
            this.ccDropType.FormattingEnabled = true;
            this.ccDropType.Items.AddRange(new object[] {
            "Planned Contract",
            "BPA"});
            this.ccDropType.Location = new System.Drawing.Point(234, 509);
            this.ccDropType.Name = "ccDropType";
            this.ccDropType.Size = new System.Drawing.Size(146, 28);
            this.ccDropType.TabIndex = 18;
            this.ccDropType.SelectedIndexChanged += new System.EventHandler(this.ccDropType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Contract Type";
            // 
            // ccAddBtn
            // 
            this.ccAddBtn.Location = new System.Drawing.Point(1272, 702);
            this.ccAddBtn.Name = "ccAddBtn";
            this.ccAddBtn.Size = new System.Drawing.Size(122, 66);
            this.ccAddBtn.TabIndex = 20;
            this.ccAddBtn.Text = "Edit";
            this.ccAddBtn.UseVisualStyleBackColor = true;
            this.ccAddBtn.Click += new System.EventHandler(this.ccAddBtn_Click);
            // 
            // ccRepDateTxt
            // 
            this.ccRepDateTxt.Location = new System.Drawing.Point(556, 508);
            this.ccRepDateTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ccRepDateTxt.Name = "ccRepDateTxt";
            this.ccRepDateTxt.Size = new System.Drawing.Size(133, 26);
            this.ccRepDateTxt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Repeat Date(Days)";
            // 
            // ccCBSupID
            // 
            this.ccCBSupID.FormattingEnabled = true;
            this.ccCBSupID.Location = new System.Drawing.Point(230, 292);
            this.ccCBSupID.Name = "ccCBSupID";
            this.ccCBSupID.Size = new System.Drawing.Size(300, 28);
            this.ccCBSupID.TabIndex = 24;
            this.ccCBSupID.SelectedIndexChanged += new System.EventHandler(this.ccCBSupID_SelectedIndexChanged);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "Item ID";
            this.itemID.MinimumWidth = 8;
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            this.itemID.Width = 96;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 96;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 8;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Visible = false;
            this.quantity.Width = 104;
            // 
            // priceDataGrid
            // 
            this.priceDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.priceDataGrid.HeaderText = "Price";
            this.priceDataGrid.MinimumWidth = 8;
            this.priceDataGrid.Name = "priceDataGrid";
            this.priceDataGrid.ReadOnly = true;
            this.priceDataGrid.Width = 80;
            // 
            // moqData
            // 
            this.moqData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.moqData.HeaderText = "MOQ";
            this.moqData.MinimumWidth = 8;
            this.moqData.Name = "moqData";
            this.moqData.ReadOnly = true;
            this.moqData.Visible = false;
            this.moqData.Width = 82;
            // 
            // CreateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 780);
            this.Controls.Add(this.ccCBSupID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ccRepDateTxt);
            this.Controls.Add(this.ccAddBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ccDropType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.uploadTxt);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.supDataView);
            this.Controls.Add(this.expireTimePick);
            this.Controls.Add(this.StaffLock);
            this.Controls.Add(this.staffTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExpireTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signTimePick);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateContract";
            this.Text = "CreateContract";
            ((System.ComponentModel.ISupportInitialize)(this.supDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker signTimePick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contractTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExpireTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffTxt;
        private System.Windows.Forms.CheckBox StaffLock;
        private System.Windows.Forms.DateTimePicker expireTimePick;
        private System.Windows.Forms.DataGridView supDataView;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.TextBox uploadTxt;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ccDropType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ccAddBtn;
        private System.Windows.Forms.TextBox ccRepDateTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ccCBSupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn moqData;
    }
}