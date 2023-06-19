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
            this.siCateBox = new System.Windows.Forms.ComboBox();
            this.siCreateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.openCateBtn = new System.Windows.Forms.Button();
            this.gvitemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMDatagrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vgCateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDetailBtn = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.UOMDatagrid,
            this.vgCateID,
            this.gvDetailBtn});
            this.ItemDataGridView.Location = new System.Drawing.Point(34, 142);
            this.ItemDataGridView.Name = "ItemDataGridView";
            this.ItemDataGridView.RowHeadersWidth = 62;
            this.ItemDataGridView.RowTemplate.Height = 28;
            this.ItemDataGridView.Size = new System.Drawing.Size(1364, 618);
            this.ItemDataGridView.TabIndex = 0;
            this.ItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemDataGridView_CellContentClick);
            // 
            // siSearchBox
            // 
            this.siSearchBox.Location = new System.Drawing.Point(152, 40);
            this.siSearchBox.Name = "siSearchBox";
            this.siSearchBox.Size = new System.Drawing.Size(186, 26);
            this.siSearchBox.TabIndex = 2;
            this.siSearchBox.TextChanged += new System.EventHandler(this.siSearchBox_TextChanged);
            // 
            // siCateBox
            // 
            this.siCateBox.FormattingEnabled = true;
            this.siCateBox.Location = new System.Drawing.Point(495, 40);
            this.siCateBox.Name = "siCateBox";
            this.siCateBox.Size = new System.Drawing.Size(178, 28);
            this.siCateBox.TabIndex = 3;
            // 
            // siCreateBtn
            // 
            this.siCreateBtn.Location = new System.Drawing.Point(1148, 18);
            this.siCreateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siCreateBtn.Name = "siCreateBtn";
            this.siCreateBtn.Size = new System.Drawing.Size(250, 75);
            this.siCreateBtn.TabIndex = 4;
            this.siCreateBtn.Text = "Create Item";
            this.siCreateBtn.UseVisualStyleBackColor = true;
            this.siCreateBtn.Click += new System.EventHandler(this.siCreateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "category Filter";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1148, 803);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(250, 83);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back To Main";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // openCateBtn
            // 
            this.openCateBtn.Location = new System.Drawing.Point(888, 18);
            this.openCateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openCateBtn.Name = "openCateBtn";
            this.openCateBtn.Size = new System.Drawing.Size(250, 75);
            this.openCateBtn.TabIndex = 8;
            this.openCateBtn.Text = "Category";
            this.openCateBtn.UseVisualStyleBackColor = true;
            this.openCateBtn.Click += new System.EventHandler(this.openCateBtn_Click);
            // 
            // gvitemID
            // 
            this.gvitemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvitemID.HeaderText = "Item ID";
            this.gvitemID.MinimumWidth = 8;
            this.gvitemID.Name = "gvitemID";
            this.gvitemID.ReadOnly = true;
            this.gvitemID.Width = 98;
            // 
            // gvSupplierID
            // 
            this.gvSupplierID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvSupplierID.HeaderText = "Supplier ID";
            this.gvSupplierID.MinimumWidth = 8;
            this.gvSupplierID.Name = "gvSupplierID";
            this.gvSupplierID.ReadOnly = true;
            this.gvSupplierID.Width = 124;
            // 
            // gvItemName
            // 
            this.gvItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gvItemName.HeaderText = "Item Name";
            this.gvItemName.MinimumWidth = 8;
            this.gvItemName.Name = "gvItemName";
            this.gvItemName.ReadOnly = true;
            // 
            // gvQuantity
            // 
            this.gvQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvQuantity.HeaderText = "Current Quantity";
            this.gvQuantity.MinimumWidth = 8;
            this.gvQuantity.Name = "gvQuantity";
            this.gvQuantity.ReadOnly = true;
            this.gvQuantity.Width = 148;
            // 
            // UOMDatagrid
            // 
            this.UOMDatagrid.HeaderText = "UOM";
            this.UOMDatagrid.MinimumWidth = 8;
            this.UOMDatagrid.Name = "UOMDatagrid";
            this.UOMDatagrid.ReadOnly = true;
            this.UOMDatagrid.Width = 150;
            // 
            // vgCateID
            // 
            this.vgCateID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vgCateID.HeaderText = "Category ID";
            this.vgCateID.MinimumWidth = 8;
            this.vgCateID.Name = "vgCateID";
            this.vgCateID.ReadOnly = true;
            this.vgCateID.Width = 120;
            // 
            // gvDetailBtn
            // 
            this.gvDetailBtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gvDetailBtn.HeaderText = "Detail";
            this.gvDetailBtn.MinimumWidth = 8;
            this.gvDetailBtn.Name = "gvDetailBtn";
            this.gvDetailBtn.ReadOnly = true;
            this.gvDetailBtn.Text = "Detail";
            this.gvDetailBtn.Width = 56;
            // 
            // showItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 905);
            this.Controls.Add(this.openCateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siCreateBtn);
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
        private System.Windows.Forms.ComboBox siCateBox;
        private System.Windows.Forms.Button siCreateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button openCateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvitemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vgCateID;
        private System.Windows.Forms.DataGridViewButtonColumn gvDetailBtn;
    }
}