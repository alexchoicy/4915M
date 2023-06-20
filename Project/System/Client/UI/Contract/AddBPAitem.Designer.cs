﻿namespace Client.UI.Contract
{
    partial class AddBPAitem
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
            this.acAddBtn = new System.Windows.Forms.Button();
            this.acQtyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acCancelBtn = new System.Windows.Forms.Button();
            this.acSubmitBtn = new System.Windows.Forms.Button();
            this.acItemTxt = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acRmBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToOrderColumns = true;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemName});
            this.itemDataGridView.Location = new System.Drawing.Point(44, 326);
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
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 150;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "ItemName";
            this.itemName.MinimumWidth = 8;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // acAddItemViewGrid
            // 
            this.acAddItemViewGrid.AllowUserToAddRows = false;
            this.acAddItemViewGrid.AllowUserToDeleteRows = false;
            this.acAddItemViewGrid.AllowUserToOrderColumns = true;
            this.acAddItemViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acAddItemViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addItemID,
            this.AddItemName,
            this.addqty,
            this.acRmBtn});
            this.acAddItemViewGrid.Location = new System.Drawing.Point(44, 31);
            this.acAddItemViewGrid.Name = "acAddItemViewGrid";
            this.acAddItemViewGrid.RowHeadersWidth = 62;
            this.acAddItemViewGrid.RowTemplate.Height = 28;
            this.acAddItemViewGrid.Size = new System.Drawing.Size(1054, 186);
            this.acAddItemViewGrid.TabIndex = 1;
            this.acAddItemViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.acAddItemViewGrid_CellContentClick);
            // 
            // acAddBtn
            // 
            this.acAddBtn.Location = new System.Drawing.Point(951, 243);
            this.acAddBtn.Name = "acAddBtn";
            this.acAddBtn.Size = new System.Drawing.Size(146, 62);
            this.acAddBtn.TabIndex = 3;
            this.acAddBtn.Text = "Add";
            this.acAddBtn.UseVisualStyleBackColor = true;
            this.acAddBtn.Click += new System.EventHandler(this.acAddBtn_Click);
            // 
            // acQtyTxt
            // 
            this.acQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acQtyTxt.Location = new System.Drawing.Point(727, 262);
            this.acQtyTxt.Name = "acQtyTxt";
            this.acQtyTxt.Size = new System.Drawing.Size(130, 30);
            this.acQtyTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Order Quantity";
            // 
            // acCancelBtn
            // 
            this.acCancelBtn.Location = new System.Drawing.Point(800, 598);
            this.acCancelBtn.Name = "acCancelBtn";
            this.acCancelBtn.Size = new System.Drawing.Size(146, 66);
            this.acCancelBtn.TabIndex = 8;
            this.acCancelBtn.Text = "Cancel";
            this.acCancelBtn.UseVisualStyleBackColor = true;
            this.acCancelBtn.Click += new System.EventHandler(this.acCancelBtn_Click);
            // 
            // acSubmitBtn
            // 
            this.acSubmitBtn.Location = new System.Drawing.Point(951, 598);
            this.acSubmitBtn.Name = "acSubmitBtn";
            this.acSubmitBtn.Size = new System.Drawing.Size(146, 66);
            this.acSubmitBtn.TabIndex = 9;
            this.acSubmitBtn.Text = "Sumbit";
            this.acSubmitBtn.UseVisualStyleBackColor = true;
            this.acSubmitBtn.Click += new System.EventHandler(this.acSubmitBtn_Click);
            // 
            // acItemTxt
            // 
            this.acItemTxt.FormattingEnabled = true;
            this.acItemTxt.Location = new System.Drawing.Point(482, 265);
            this.acItemTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acItemTxt.Name = "acItemTxt";
            this.acItemTxt.Size = new System.Drawing.Size(180, 28);
            this.acItemTxt.TabIndex = 10;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(108, 262);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(217, 26);
            this.searchTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Search";
            // 
            // addItemID
            // 
            this.addItemID.HeaderText = "Item ID";
            this.addItemID.MinimumWidth = 8;
            this.addItemID.Name = "addItemID";
            this.addItemID.ReadOnly = true;
            this.addItemID.Width = 150;
            // 
            // AddItemName
            // 
            this.AddItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AddItemName.HeaderText = "Item Name";
            this.AddItemName.MinimumWidth = 8;
            this.AddItemName.Name = "AddItemName";
            this.AddItemName.ReadOnly = true;
            this.AddItemName.Width = 123;
            // 
            // addqty
            // 
            this.addqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.addqty.HeaderText = "Minimum Order Quantity";
            this.addqty.MinimumWidth = 8;
            this.addqty.Name = "addqty";
            this.addqty.Width = 197;
            // 
            // acRmBtn
            // 
            this.acRmBtn.HeaderText = "";
            this.acRmBtn.MinimumWidth = 8;
            this.acRmBtn.Name = "acRmBtn";
            this.acRmBtn.ReadOnly = true;
            this.acRmBtn.Text = "Remove";
            this.acRmBtn.Width = 150;
            // 
            // AddBPAitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.acItemTxt);
            this.Controls.Add(this.acSubmitBtn);
            this.Controls.Add(this.acCancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acQtyTxt);
            this.Controls.Add(this.acAddBtn);
            this.Controls.Add(this.acAddItemViewGrid);
            this.Controls.Add(this.itemDataGridView);
            this.Name = "AddBPAitem";
            this.Text = "AddContractItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAddItemViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridView acAddItemViewGrid;
        private System.Windows.Forms.Button acAddBtn;
        private System.Windows.Forms.TextBox acQtyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button acCancelBtn;
        private System.Windows.Forms.Button acSubmitBtn;
        private System.Windows.Forms.ComboBox acItemTxt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addqty;
        private System.Windows.Forms.DataGridViewButtonColumn acRmBtn;
    }
}