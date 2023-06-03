namespace Client.UI.Item.Category
{
    partial class cateDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reMarkTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cateNameTxt = new System.Windows.Forms.TextBox();
            this.cateIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RestView = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeRestBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemDataView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestTypeBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addRestBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reMarkTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cateNameTxt);
            this.groupBox1.Controls.Add(this.cateIDTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remark";
            // 
            // reMarkTxt
            // 
            this.reMarkTxt.Location = new System.Drawing.Point(84, 56);
            this.reMarkTxt.Name = "reMarkTxt";
            this.reMarkTxt.Size = new System.Drawing.Size(496, 56);
            this.reMarkTxt.TabIndex = 4;
            this.reMarkTxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CateName";
            // 
            // cateNameTxt
            // 
            this.cateNameTxt.Location = new System.Drawing.Point(302, 25);
            this.cateNameTxt.Name = "cateNameTxt";
            this.cateNameTxt.ReadOnly = true;
            this.cateNameTxt.Size = new System.Drawing.Size(278, 20);
            this.cateNameTxt.TabIndex = 2;
            // 
            // cateIDTxt
            // 
            this.cateIDTxt.Location = new System.Drawing.Point(84, 25);
            this.cateIDTxt.Name = "cateIDTxt";
            this.cateIDTxt.ReadOnly = true;
            this.cateIDTxt.Size = new System.Drawing.Size(122, 20);
            this.cateIDTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CateID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.RestView);
            this.groupBox2.Controls.Add(this.itemDataView);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resturant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items";
            // 
            // RestView
            // 
            this.RestView.AllowUserToAddRows = false;
            this.RestView.AllowUserToDeleteRows = false;
            this.RestView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.RestName,
            this.removeRestBtn});
            this.RestView.Location = new System.Drawing.Point(442, 46);
            this.RestView.Name = "RestView";
            this.RestView.Size = new System.Drawing.Size(466, 262);
            this.RestView.TabIndex = 1;
            this.RestView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestView_CellContentClick);
            // 
            // TypeID
            // 
            this.TypeID.HeaderText = "Type ID";
            this.TypeID.Name = "TypeID";
            this.TypeID.ReadOnly = true;
            // 
            // RestName
            // 
            this.RestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RestName.HeaderText = "Resturant Type Name";
            this.RestName.Name = "RestName";
            this.RestName.ReadOnly = true;
            // 
            // removeRestBtn
            // 
            this.removeRestBtn.HeaderText = "";
            this.removeRestBtn.Name = "removeRestBtn";
            this.removeRestBtn.ReadOnly = true;
            this.removeRestBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeRestBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // itemDataView
            // 
            this.itemDataView.AllowUserToAddRows = false;
            this.itemDataView.AllowUserToDeleteRows = false;
            this.itemDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.SupplierID,
            this.itemsName});
            this.itemDataView.Location = new System.Drawing.Point(6, 46);
            this.itemDataView.Name = "itemDataView";
            this.itemDataView.Size = new System.Drawing.Size(430, 262);
            this.itemDataView.TabIndex = 0;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // SupplierID
            // 
            this.SupplierID.HeaderText = "Supplier ID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            // 
            // itemsName
            // 
            this.itemsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemsName.HeaderText = "Item Name";
            this.itemsName.Name = "itemsName";
            this.itemsName.ReadOnly = true;
            // 
            // RestTypeBox
            // 
            this.RestTypeBox.FormattingEnabled = true;
            this.RestTypeBox.Location = new System.Drawing.Point(503, 28);
            this.RestTypeBox.Name = "RestTypeBox";
            this.RestTypeBox.Size = new System.Drawing.Size(121, 21);
            this.RestTypeBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addRestBtn);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.RestTypeBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 484);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // addRestBtn
            // 
            this.addRestBtn.Location = new System.Drawing.Point(661, 26);
            this.addRestBtn.Name = "addRestBtn";
            this.addRestBtn.Size = new System.Drawing.Size(75, 23);
            this.addRestBtn.TabIndex = 4;
            this.addRestBtn.Text = "add";
            this.addRestBtn.UseVisualStyleBackColor = true;
            this.addRestBtn.Click += new System.EventHandler(this.addRestBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "add Resturant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Change Item Category in Item->Detail";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(799, 626);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(121, 67);
            this.updateBtn.TabIndex = 3;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cateDetail";
            this.Text = "cateDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView itemDataView;
        private System.Windows.Forms.DataGridView RestView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox reMarkTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cateNameTxt;
        private System.Windows.Forms.TextBox cateIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsName;
        private System.Windows.Forms.ComboBox RestTypeBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRestBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestName;
        private System.Windows.Forms.DataGridViewButtonColumn removeRestBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
    }
}