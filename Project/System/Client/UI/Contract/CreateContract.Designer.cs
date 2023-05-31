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
            this.supplierTxt = new System.Windows.Forms.TextBox();
            this.supDataView = new System.Windows.Forms.DataGridView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.uploadTxt = new System.Windows.Forms.TextBox();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // signTimePick
            // 
            this.signTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.signTimePick.Location = new System.Drawing.Point(153, 92);
            this.signTimePick.Name = "signTimePick";
            this.signTimePick.Size = new System.Drawing.Size(200, 20);
            this.signTimePick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ContractID";
            // 
            // contractTxt
            // 
            this.contractTxt.Location = new System.Drawing.Point(153, 43);
            this.contractTxt.Name = "contractTxt";
            this.contractTxt.Size = new System.Drawing.Size(200, 20);
            this.contractTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SignDate";
            // 
            // ExpireTime
            // 
            this.ExpireTime.AutoSize = true;
            this.ExpireTime.Location = new System.Drawing.Point(38, 145);
            this.ExpireTime.Name = "ExpireTime";
            this.ExpireTime.Size = new System.Drawing.Size(59, 13);
            this.ExpireTime.TabIndex = 4;
            this.ExpireTime.Text = "ExpireTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SupplierID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "StaffID";
            // 
            // staffTxt
            // 
            this.staffTxt.Location = new System.Drawing.Point(153, 249);
            this.staffTxt.Name = "staffTxt";
            this.staffTxt.ReadOnly = true;
            this.staffTxt.Size = new System.Drawing.Size(200, 20);
            this.staffTxt.TabIndex = 7;
            // 
            // StaffLock
            // 
            this.StaffLock.AutoSize = true;
            this.StaffLock.Location = new System.Drawing.Point(372, 252);
            this.StaffLock.Name = "StaffLock";
            this.StaffLock.Size = new System.Drawing.Size(15, 14);
            this.StaffLock.TabIndex = 8;
            this.StaffLock.UseVisualStyleBackColor = true;
            // 
            // expireTimePick
            // 
            this.expireTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireTimePick.Location = new System.Drawing.Point(153, 139);
            this.expireTimePick.Name = "expireTimePick";
            this.expireTimePick.Size = new System.Drawing.Size(200, 20);
            this.expireTimePick.TabIndex = 9;
            // 
            // supplierTxt
            // 
            this.supplierTxt.Location = new System.Drawing.Point(153, 190);
            this.supplierTxt.Name = "supplierTxt";
            this.supplierTxt.Size = new System.Drawing.Size(200, 20);
            this.supplierTxt.TabIndex = 10;
            // 
            // supDataView
            // 
            this.supDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supDataView.Location = new System.Drawing.Point(501, 43);
            this.supDataView.Name = "supDataView";
            this.supDataView.Size = new System.Drawing.Size(240, 356);
            this.supDataView.TabIndex = 11;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(211, 354);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(92, 45);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(336, 354);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(92, 45);
            this.subBtn.TabIndex = 13;
            this.subBtn.Text = "Sumbit";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // uploadTxt
            // 
            this.uploadTxt.Location = new System.Drawing.Point(153, 299);
            this.uploadTxt.Name = "uploadTxt";
            this.uploadTxt.ReadOnly = true;
            this.uploadTxt.Size = new System.Drawing.Size(148, 20);
            this.uploadTxt.TabIndex = 14;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(307, 297);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(103, 23);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload Button";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Upload File";
            // 
            // CreateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.uploadTxt);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.supDataView);
            this.Controls.Add(this.supplierTxt);
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
        private System.Windows.Forms.TextBox supplierTxt;
        private System.Windows.Forms.DataGridView supDataView;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.TextBox uploadTxt;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}