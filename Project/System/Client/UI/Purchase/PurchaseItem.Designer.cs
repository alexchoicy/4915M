namespace Client.UI.Purchase
{
    partial class PurchaseItem
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
            this.itemDataGrid = new System.Windows.Forms.DataGridView();
            this.selectItem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemIDGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQtyDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.siSearchBox = new System.Windows.Forms.TextBox();
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.spoBtn = new System.Windows.Forms.Button();
            this.BPAcreateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemDataGrid
            // 
            this.itemDataGrid.AllowUserToAddRows = false;
            this.itemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectItem,
            this.itemIDGrid,
            this.itemNameDataGrid,
            this.itemQtyDataGrid});
            this.itemDataGrid.Location = new System.Drawing.Point(39, 92);
            this.itemDataGrid.Name = "itemDataGrid";
            this.itemDataGrid.Size = new System.Drawing.Size(776, 318);
            this.itemDataGrid.TabIndex = 0;
            // 
            // selectItem
            // 
            this.selectItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectItem.Frozen = true;
            this.selectItem.HeaderText = "Select";
            this.selectItem.Name = "selectItem";
            this.selectItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectItem.Width = 43;
            // 
            // itemIDGrid
            // 
            this.itemIDGrid.Frozen = true;
            this.itemIDGrid.HeaderText = "Item ID";
            this.itemIDGrid.Name = "itemIDGrid";
            this.itemIDGrid.ReadOnly = true;
            // 
            // itemNameDataGrid
            // 
            this.itemNameDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemNameDataGrid.Frozen = true;
            this.itemNameDataGrid.HeaderText = "Item Name";
            this.itemNameDataGrid.Name = "itemNameDataGrid";
            this.itemNameDataGrid.ReadOnly = true;
            this.itemNameDataGrid.Width = 496;
            // 
            // itemQtyDataGrid
            // 
            this.itemQtyDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemQtyDataGrid.Frozen = true;
            this.itemQtyDataGrid.HeaderText = "Item Quantity";
            this.itemQtyDataGrid.Name = "itemQtyDataGrid";
            this.itemQtyDataGrid.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // siSearchBox
            // 
            this.siSearchBox.Location = new System.Drawing.Point(89, 32);
            this.siSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.siSearchBox.Name = "siSearchBox";
            this.siSearchBox.Size = new System.Drawing.Size(125, 20);
            this.siSearchBox.TabIndex = 8;
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Location = new System.Drawing.Point(707, 24);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(108, 37);
            this.selectAllBtn.TabIndex = 10;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(707, 560);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(108, 61);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.spoBtn);
            this.Options.Controls.Add(this.BPAcreateBtn);
            this.Options.Location = new System.Drawing.Point(39, 442);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(668, 100);
            this.Options.TabIndex = 12;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // spoBtn
            // 
            this.spoBtn.Location = new System.Drawing.Point(384, 19);
            this.spoBtn.Name = "spoBtn";
            this.spoBtn.Size = new System.Drawing.Size(136, 65);
            this.spoBtn.TabIndex = 2;
            this.spoBtn.Text = "Standard Purchase Order";
            this.spoBtn.UseVisualStyleBackColor = true;
            this.spoBtn.Click += new System.EventHandler(this.spoBtn_Click);
            // 
            // BPAcreateBtn
            // 
            this.BPAcreateBtn.Location = new System.Drawing.Point(526, 19);
            this.BPAcreateBtn.Name = "BPAcreateBtn";
            this.BPAcreateBtn.Size = new System.Drawing.Size(136, 65);
            this.BPAcreateBtn.TabIndex = 0;
            this.BPAcreateBtn.Text = "Blanket Purchase Release";
            this.BPAcreateBtn.UseVisualStyleBackColor = true;
            this.BPAcreateBtn.Click += new System.EventHandler(this.BPAcreateBtn_Click);
            // 
            // PurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 633);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.selectAllBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siSearchBox);
            this.Controls.Add(this.itemDataGrid);
            this.Name = "PurchaseItem";
            this.Text = "PurchaseItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGrid)).EndInit();
            this.Options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siSearchBox;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.Button BPAcreateBtn;
        private System.Windows.Forms.Button spoBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQtyDataGrid;
    }
}