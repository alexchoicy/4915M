namespace Client.UI.Purchase
{
    partial class PurchaseHistory
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
            this.hisDGV = new System.Windows.Forms.DataGridView();
            this.pIDDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purTypeDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailBtnDataGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.siSearchBox = new System.Windows.Forms.TextBox();
            this.siCateBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hisDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // hisDGV
            // 
            this.hisDGV.AllowUserToAddRows = false;
            this.hisDGV.AllowUserToDeleteRows = false;
            this.hisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hisDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGrid,
            this.supIDDataGrid,
            this.purTypeDataGrid,
            this.dateDataGrid,
            this.detailBtnDataGrid});
            this.hisDGV.Location = new System.Drawing.Point(40, 72);
            this.hisDGV.Name = "hisDGV";
            this.hisDGV.Size = new System.Drawing.Size(1018, 507);
            this.hisDGV.TabIndex = 0;
            this.hisDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pIDDataGrid
            // 
            this.pIDDataGrid.HeaderText = "Purchase ID";
            this.pIDDataGrid.Name = "pIDDataGrid";
            this.pIDDataGrid.ReadOnly = true;
            // 
            // supIDDataGrid
            // 
            this.supIDDataGrid.HeaderText = "Supplier ID";
            this.supIDDataGrid.Name = "supIDDataGrid";
            this.supIDDataGrid.ReadOnly = true;
            // 
            // purTypeDataGrid
            // 
            this.purTypeDataGrid.HeaderText = "Type";
            this.purTypeDataGrid.Name = "purTypeDataGrid";
            this.purTypeDataGrid.ReadOnly = true;
            // 
            // dateDataGrid
            // 
            this.dateDataGrid.HeaderText = "Date";
            this.dateDataGrid.Name = "dateDataGrid";
            this.dateDataGrid.ReadOnly = true;
            // 
            // detailBtnDataGrid
            // 
            this.detailBtnDataGrid.HeaderText = "Detail";
            this.detailBtnDataGrid.Name = "detailBtnDataGrid";
            this.detailBtnDataGrid.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // siSearchBox
            // 
            this.siSearchBox.Location = new System.Drawing.Point(108, 26);
            this.siSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.siSearchBox.Name = "siSearchBox";
            this.siSearchBox.Size = new System.Drawing.Size(125, 20);
            this.siSearchBox.TabIndex = 10;
            // 
            // siCateBox
            // 
            this.siCateBox.FormattingEnabled = true;
            this.siCateBox.Location = new System.Drawing.Point(325, 26);
            this.siCateBox.Name = "siCateBox";
            this.siCateBox.Size = new System.Drawing.Size(121, 21);
            this.siCateBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siCateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siSearchBox);
            this.Controls.Add(this.hisDGV);
            this.Name = "PurchaseHistory";
            this.Text = "PurchaseHistory";
            ((System.ComponentModel.ISupportInitialize)(this.hisDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hisDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn purTypeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn detailBtnDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox siSearchBox;
        private System.Windows.Forms.ComboBox siCateBox;
        private System.Windows.Forms.Label label2;
    }
}