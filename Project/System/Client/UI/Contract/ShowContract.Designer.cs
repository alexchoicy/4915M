namespace Client.UI.Agreement
{
    partial class ShowContract
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
            this.components = new System.ComponentModel.Container();
            this.createContractBtn = new System.Windows.Forms.Button();
            this.ContractDataView = new System.Windows.Forms.DataGridView();
            this.userInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoDGBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createContractBtn
            // 
            this.createContractBtn.Location = new System.Drawing.Point(106, 12);
            this.createContractBtn.Name = "createContractBtn";
            this.createContractBtn.Size = new System.Drawing.Size(143, 44);
            this.createContractBtn.TabIndex = 1;
            this.createContractBtn.Text = "Add new Agreement";
            this.createContractBtn.UseVisualStyleBackColor = true;
            this.createContractBtn.Click += new System.EventHandler(this.createContractBtn_Click);
            // 
            // ContractDataView
            // 
            this.ContractDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractID,
            this.SignDate,
            this.ExpireTime,
            this.ContractType,
            this.SupplierID,
            this.InfoDGBtn});
            this.ContractDataView.Location = new System.Drawing.Point(37, 62);
            this.ContractDataView.Name = "ContractDataView";
            this.ContractDataView.Size = new System.Drawing.Size(741, 336);
            this.ContractDataView.TabIndex = 0;
            this.ContractDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContractDataView_CellContentClick);
            // 
            // userInformationBindingSource
            // 
            //this.userInformationBindingSource.DataSource = typeof(Client.Model.Receive.UserInformation);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(628, 404);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(150, 34);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "Back To Main";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ContractID
            // 
            this.ContractID.HeaderText = "ContractID";
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            // 
            // SignDate
            // 
            this.SignDate.HeaderText = "SignDate";
            this.SignDate.Name = "SignDate";
            this.SignDate.ReadOnly = true;
            // 
            // ExpireTime
            // 
            this.ExpireTime.HeaderText = "ExpireTime";
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.ReadOnly = true;
            // 
            // ContractType
            // 
            this.ContractType.HeaderText = "ContractType";
            this.ContractType.Name = "ContractType";
            this.ContractType.ReadOnly = true;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "StaffID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // InfoDGBtn
            // 
            this.InfoDGBtn.HeaderText = "Info";
            this.InfoDGBtn.Name = "InfoDGBtn";
            this.InfoDGBtn.ReadOnly = true;
            // 
            // ShowContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createContractBtn);
            this.Controls.Add(this.ContractDataView);
            this.Name = "ShowContract";
            this.Text = "ContractShow";
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userInformationBindingSource;
        private System.Windows.Forms.Button createContractBtn;
        private System.Windows.Forms.DataGridView ContractDataView;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewButtonColumn InfoDGBtn;
    }
}