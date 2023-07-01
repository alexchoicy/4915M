namespace Client.UI.Order
{
    partial class CreateOrder
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
            this.orderIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.remarkTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmergencyCheck = new System.Windows.Forms.CheckBox();
            this.itemOrderDGV = new System.Windows.Forms.DataGridView();
            this.ItemIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // orderIDTxt
            // 
            this.orderIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTxt.Location = new System.Drawing.Point(182, 78);
            this.orderIDTxt.Name = "orderIDTxt";
            this.orderIDTxt.ReadOnly = true;
            this.orderIDTxt.Size = new System.Drawing.Size(301, 30);
            this.orderIDTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remark";
            // 
            // remarkTxt
            // 
            this.remarkTxt.Location = new System.Drawing.Point(182, 213);
            this.remarkTxt.Name = "remarkTxt";
            this.remarkTxt.Size = new System.Drawing.Size(301, 148);
            this.remarkTxt.TabIndex = 3;
            this.remarkTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Emergency";
            // 
            // EmergencyCheck
            // 
            this.EmergencyCheck.AutoSize = true;
            this.EmergencyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyCheck.Location = new System.Drawing.Point(182, 151);
            this.EmergencyCheck.Name = "EmergencyCheck";
            this.EmergencyCheck.Size = new System.Drawing.Size(15, 14);
            this.EmergencyCheck.TabIndex = 5;
            this.EmergencyCheck.UseVisualStyleBackColor = true;
            // 
            // itemOrderDGV
            // 
            this.itemOrderDGV.AllowUserToAddRows = false;
            this.itemOrderDGV.AllowUserToDeleteRows = false;
            this.itemOrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemOrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemIDDGV,
            this.ItemNameDGV,
            this.qtyDGV});
            this.itemOrderDGV.Location = new System.Drawing.Point(520, 12);
            this.itemOrderDGV.Name = "itemOrderDGV";
            this.itemOrderDGV.Size = new System.Drawing.Size(487, 500);
            this.itemOrderDGV.TabIndex = 6;
            // 
            // ItemIDDGV
            // 
            this.ItemIDDGV.HeaderText = "Item ID";
            this.ItemIDDGV.Name = "ItemIDDGV";
            this.ItemIDDGV.ReadOnly = true;
            // 
            // ItemNameDGV
            // 
            this.ItemNameDGV.HeaderText = "Item Name";
            this.ItemNameDGV.Name = "ItemNameDGV";
            this.ItemNameDGV.ReadOnly = true;
            // 
            // qtyDGV
            // 
            this.qtyDGV.HeaderText = "Quantity";
            this.qtyDGV.Name = "qtyDGV";
            this.qtyDGV.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(899, 545);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(108, 47);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(388, 539);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(124, 53);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(250, 539);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(133, 53);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 610);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.itemOrderDGV);
            this.Controls.Add(this.EmergencyCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.remarkTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orderIDTxt);
            this.Controls.Add(this.label1);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox remarkTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox EmergencyCheck;
        private System.Windows.Forms.DataGridView itemOrderDGV;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDGV;
    }
}