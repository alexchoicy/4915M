namespace Client.UI.Item
{
    partial class showItem
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
            this.ItemDataGridView = new System.Windows.Forms.DataGridView();
            this.siSearchBox = new System.Windows.Forms.TextBox();
            this.gvitemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vgCateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDetailBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.siCateBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemDataGridView
            // 
            this.ItemDataGridView.AllowUserToAddRows = false;
            this.ItemDataGridView.AllowUserToDeleteRows = false;
            this.ItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvitemID,
            this.gvSupplierID,
            this.gvItemName,
            this.gvQuantity,
            this.vgCateID,
            this.gvDetailBtn});
            this.ItemDataGridView.Location = new System.Drawing.Point(35, 101);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.RowHeadersWidth = 62;
            this.ItemDataGridView.RowTemplate.Height = 28;
            this.ItemDataGridView.Size = new System.Drawing.Size(1364, 619);
            this.ItemDataGridView.TabIndex = 0;
            // 
            // siSearchBox
            // 
            this.siSearchBox.Location = new System.Drawing.Point(35, 41);
            this.siSearchBox.Name = "siSearchBox";
            this.siSearchBox.Size = new System.Drawing.Size(185, 26);
            this.siSearchBox.TabIndex = 2;
            // 
            // gvitemID
            // 
            this.gvitemID.HeaderText = "Item ID";
            this.gvitemID.MinimumWidth = 8;
            this.gvitemID.Name = "gvitemID";
            this.gvitemID.ReadOnly = true;
            this.gvitemID.Width = 150;
            // 
            // gvSupplierID
            // 
            this.gvSupplierID.HeaderText = "Supplier ID";
            this.gvSupplierID.MinimumWidth = 8;
            this.gvSupplierID.Name = "gvSupplierID";
            this.gvSupplierID.ReadOnly = true;
            this.gvSupplierID.Width = 150;
            // 
            // gvItemName
            // 
            this.gvItemName.HeaderText = "Item Name";
            this.gvItemName.MinimumWidth = 8;
            this.gvItemName.Name = "gvItemName";
            this.gvItemName.ReadOnly = true;
            this.gvItemName.Width = 150;
            // 
            // gvQuantity
            // 
            this.gvQuantity.HeaderText = "Current Quantity";
            this.gvQuantity.MinimumWidth = 8;
            this.gvQuantity.Name = "gvQuantity";
            this.gvQuantity.Width = 150;
            // 
            // vgCateID
            // 
            this.vgCateID.HeaderText = "Category ID";
            this.vgCateID.MinimumWidth = 8;
            this.vgCateID.Name = "vgCateID";
            this.vgCateID.Width = 150;
            // 
            // gvDetailBtn
            // 
            this.gvDetailBtn.HeaderText = "Detail";
            this.gvDetailBtn.MinimumWidth = 8;
            this.gvDetailBtn.Name = "gvDetailBtn";
            this.gvDetailBtn.ReadOnly = true;
            this.gvDetailBtn.Text = "Detail";
            this.gvDetailBtn.Width = 150;
            // 
            // siCateBox
            // 
            this.siCateBox.FormattingEnabled = true;
            this.siCateBox.Location = new System.Drawing.Point(226, 39);
            this.siCateBox.Name = "siCateBox";
            this.siCateBox.Size = new System.Drawing.Size(178, 28);
            this.siCateBox.TabIndex = 3;
            // 
            // showItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 904);
            this.Controls.Add(this.siCateBox);
            this.Controls.Add(this.siSearchBox);
            this.Controls.Add(this.ItemDataGridView);
            this.Name = "showItem";
            this.Text = "showItem";
            ((System.ComponentModel.ISupportInitialize)(this.ItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemDataGridView;
        private System.Windows.Forms.TextBox siSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvitemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn vgCateID;
        private System.Windows.Forms.DataGridViewButtonColumn gvDetailBtn;
        private System.Windows.Forms.ComboBox siCateBox;
    }
}