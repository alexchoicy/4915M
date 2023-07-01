namespace Client.UI.Order
{
    partial class EditItem
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
            this.label3 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.acItemTxt = new System.Windows.Forms.ComboBox();
            this.acSubmitBtn = new System.Windows.Forms.Button();
            this.acCancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acQtyTxt = new System.Windows.Forms.TextBox();
            this.acAddBtn = new System.Windows.Forms.Button();
            this.AddItemViewGrid = new System.Windows.Forms.DataGridView();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(62, 522);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(189, 30);
            this.searchTxt.TabIndex = 24;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // acItemTxt
            // 
            this.acItemTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acItemTxt.FormattingEnabled = true;
            this.acItemTxt.Location = new System.Drawing.Point(71, 446);
            this.acItemTxt.Name = "acItemTxt";
            this.acItemTxt.Size = new System.Drawing.Size(180, 33);
            this.acItemTxt.TabIndex = 23;
            // 
            // acSubmitBtn
            // 
            this.acSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acSubmitBtn.Location = new System.Drawing.Point(668, 767);
            this.acSubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acSubmitBtn.Name = "acSubmitBtn";
            this.acSubmitBtn.Size = new System.Drawing.Size(140, 70);
            this.acSubmitBtn.TabIndex = 22;
            this.acSubmitBtn.Text = "Sumbit";
            this.acSubmitBtn.UseVisualStyleBackColor = true;
            this.acSubmitBtn.Click += new System.EventHandler(this.acSubmitBtn_Click);
            // 
            // acCancelBtn
            // 
            this.acCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acCancelBtn.Location = new System.Drawing.Point(509, 767);
            this.acCancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acCancelBtn.Name = "acCancelBtn";
            this.acCancelBtn.Size = new System.Drawing.Size(140, 70);
            this.acCancelBtn.TabIndex = 21;
            this.acCancelBtn.Text = "Cancel";
            this.acCancelBtn.UseVisualStyleBackColor = true;
            this.acCancelBtn.Click += new System.EventHandler(this.acCancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Item ID";
            // 
            // acQtyTxt
            // 
            this.acQtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acQtyTxt.Location = new System.Drawing.Point(445, 445);
            this.acQtyTxt.Margin = new System.Windows.Forms.Padding(2);
            this.acQtyTxt.Name = "acQtyTxt";
            this.acQtyTxt.Size = new System.Drawing.Size(131, 30);
            this.acQtyTxt.TabIndex = 18;
            // 
            // acAddBtn
            // 
            this.acAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acAddBtn.Location = new System.Drawing.Point(680, 418);
            this.acAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.acAddBtn.Name = "acAddBtn";
            this.acAddBtn.Size = new System.Drawing.Size(128, 60);
            this.acAddBtn.TabIndex = 17;
            this.acAddBtn.Text = "Add";
            this.acAddBtn.UseVisualStyleBackColor = true;
            this.acAddBtn.Click += new System.EventHandler(this.acAddBtn_Click);
            // 
            // AddItemViewGrid
            // 
            this.AddItemViewGrid.AllowUserToAddRows = false;
            this.AddItemViewGrid.AllowUserToDeleteRows = false;
            this.AddItemViewGrid.AllowUserToOrderColumns = true;
            this.AddItemViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddItemViewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addItemID,
            this.AddItemName,
            this.addqty});
            this.AddItemViewGrid.Location = new System.Drawing.Point(62, 55);
            this.AddItemViewGrid.Margin = new System.Windows.Forms.Padding(2);
            this.AddItemViewGrid.Name = "AddItemViewGrid";
            this.AddItemViewGrid.RowHeadersWidth = 62;
            this.AddItemViewGrid.RowTemplate.Height = 28;
            this.AddItemViewGrid.Size = new System.Drawing.Size(746, 345);
            this.AddItemViewGrid.TabIndex = 16;
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
            this.itemDataGridView.Location = new System.Drawing.Point(62, 557);
            this.itemDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 62;
            this.itemDataGridView.RowTemplate.Height = 28;
            this.itemDataGridView.Size = new System.Drawing.Size(746, 190);
            this.itemDataGridView.TabIndex = 15;
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
            this.AddItemName.Width = 83;
            // 
            // addqty
            // 
            this.addqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.addqty.HeaderText = "Quantity";
            this.addqty.MinimumWidth = 8;
            this.addqty.Name = "addqty";
            this.addqty.Width = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Set Quantity to 0 to remove the item";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 974);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.acItemTxt);
            this.Controls.Add(this.acSubmitBtn);
            this.Controls.Add(this.acCancelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acQtyTxt);
            this.Controls.Add(this.acAddBtn);
            this.Controls.Add(this.AddItemViewGrid);
            this.Controls.Add(this.itemDataGridView);
            this.Name = "EditItem";
            this.Text = "AddItemOrder";
            ((System.ComponentModel.ISupportInitialize)(this.AddItemViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox acItemTxt;
        private System.Windows.Forms.Button acSubmitBtn;
        private System.Windows.Forms.Button acCancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox acQtyTxt;
        private System.Windows.Forms.Button acAddBtn;
        private System.Windows.Forms.DataGridView AddItemViewGrid;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn addqty;
        private System.Windows.Forms.Label label7;
    }
}