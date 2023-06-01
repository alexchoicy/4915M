namespace Client.UI.Contract
{
    partial class AddContractItem
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
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acAddItemViewGrid = new System.Windows.Forms.DataGridView();
            this.acRmBtn = new System.Windows.Forms.Button();
            this.acAddBtn = new System.Windows.Forms.Button();
            this.acItemTxt = new System.Windows.Forms.TextBox();
            this.acQtyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acCancelBtn = new System.Windows.Forms.Button();
            this.acSubmitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemName});
            this.itemDataGridView.Location = new System.Drawing.Point(43, 326);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 62;
            this.itemDataGridView.RowTemplate.Height = 28;
            this.itemDataGridView.Size = new System.Drawing.Size(1054, 251);
            this.itemDataGridView.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 8;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 150;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "ItemName";
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.Width = 150;
            // 
            // acAddItemViewGrid
            // 
            this.acAddItemViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acAddItemViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddItemName,
            this.addItemID,
            this.addqty});
            this.acAddItemViewGrid.Location = new System.Drawing.Point(43, 31);
            this.acAddItemViewGrid.Name = "acAddItemViewGrid";
            this.acAddItemViewGrid.RowHeadersWidth = 62;
            this.acAddItemViewGrid.RowTemplate.Height = 28;
            this.acAddItemViewGrid.Size = new System.Drawing.Size(1054, 186);
            this.acAddItemViewGrid.TabIndex = 1;
            // 
            // acRmBtn
            // 
            this.acRmBtn.Location = new System.Drawing.Point(799, 243);
            this.acRmBtn.Name = "acRmBtn";
            this.acRmBtn.Size = new System.Drawing.Size(146, 61);
            this.acRmBtn.TabIndex = 2;
            this.acRmBtn.Text = "Remove";
            this.acRmBtn.UseVisualStyleBackColor = true;
            // 
            // acAddBtn
            // 
            this.acAddBtn.Location = new System.Drawing.Point(951, 243);
            this.acAddBtn.Name = "acAddBtn";
            this.acAddBtn.Size = new System.Drawing.Size(146, 61);
            this.acAddBtn.TabIndex = 3;
            this.acAddBtn.Text = "Add";
            this.acAddBtn.UseVisualStyleBackColor = true;
            this.acAddBtn.Click += new System.EventHandler(this.acAddBtn_Click);
            // 
            // acItemTxt
            // 
            this.acItemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acItemTxt.Location = new System.Drawing.Point(185, 258);
            this.acItemTxt.Name = "acItemTxt";
            this.acItemTxt.Size = new System.Drawing.Size(100, 30);
            this.acItemTxt.TabIndex = 4;
            // 
            // acQtyTxt
            // 
            this.acQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acQtyTxt.Location = new System.Drawing.Point(556, 258);
            this.acQtyTxt.Name = "acQtyTxt";
            this.acQtyTxt.Size = new System.Drawing.Size(130, 30);
            this.acQtyTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // AddItemName
            // 
            this.AddItemName.HeaderText = "Item Name";
            this.AddItemName.MinimumWidth = 8;
            this.AddItemName.Name = "AddItemName";
            this.AddItemName.Width = 150;
            // 
            // addItemID
            // 
            this.addItemID.HeaderText = "Item ID";
            this.addItemID.MinimumWidth = 8;
            this.addItemID.Name = "addItemID";
            this.addItemID.Width = 150;
            // 
            // addqty
            // 
            this.addqty.HeaderText = "Quantity";
            this.addqty.MinimumWidth = 8;
            this.addqty.Name = "addqty";
            this.addqty.Width = 150;
            // 
            // acCancelBtn
            // 
            this.acCancelBtn.Location = new System.Drawing.Point(799, 599);
            this.acCancelBtn.Name = "acCancelBtn";
            this.acCancelBtn.Size = new System.Drawing.Size(146, 66);
            this.acCancelBtn.TabIndex = 8;
            this.acCancelBtn.Text = "Cancel";
            this.acCancelBtn.UseVisualStyleBackColor = true;
            // 
            // acSubmitBtn
            // 
            this.acSubmitBtn.Location = new System.Drawing.Point(951, 599);
            this.acSubmitBtn.Name = "acSubmitBtn";
            this.acSubmitBtn.Size = new System.Drawing.Size(146, 66);
            this.acSubmitBtn.TabIndex = 9;
            this.acSubmitBtn.Text = "Sumbit";
            this.acSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // AddContractItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 677);
            this.Controls.Add(this.acSubmitBtn);
            this.Controls.Add(this.acCancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acQtyTxt);
            this.Controls.Add(this.acItemTxt);
            this.Controls.Add(this.acAddBtn);
            this.Controls.Add(this.acRmBtn);
            this.Controls.Add(this.acAddItemViewGrid);
            this.Controls.Add(this.itemDataGridView);
            this.Name = "AddContractItem";
            this.Text = "AddContractItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView acAddItemViewGrid;
        private System.Windows.Forms.Button acRmBtn;
        private System.Windows.Forms.Button acAddBtn;
        private System.Windows.Forms.TextBox acItemTxt;
        private System.Windows.Forms.TextBox acQtyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn addqty;
        private System.Windows.Forms.Button acCancelBtn;
        private System.Windows.Forms.Button acSubmitBtn;
    }
}