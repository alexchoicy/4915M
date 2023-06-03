namespace Client.UI.Item.Category
{
    partial class ShowCate
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
            this.CateView = new System.Windows.Forms.DataGridView();
            this.cateBox = new System.Windows.Forms.ComboBox();
            this.createCateBtn = new System.Windows.Forms.Button();
            this.cateIDView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateNameView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CateView)).BeginInit();
            this.SuspendLayout();
            // 
            // CateView
            // 
            this.CateView.AllowUserToAddRows = false;
            this.CateView.AllowUserToDeleteRows = false;
            this.CateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CateView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cateIDView,
            this.cateNameView,
            this.btnView});
            this.CateView.Location = new System.Drawing.Point(34, 81);
            this.CateView.Name = "CateView";
            this.CateView.Size = new System.Drawing.Size(741, 357);
            this.CateView.TabIndex = 0;
            this.CateView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CateView_CellContentClick);
            // 
            // cateBox
            // 
            this.cateBox.FormattingEnabled = true;
            this.cateBox.Location = new System.Drawing.Point(34, 34);
            this.cateBox.Name = "cateBox";
            this.cateBox.Size = new System.Drawing.Size(121, 21);
            this.cateBox.TabIndex = 1;
            this.cateBox.SelectedIndexChanged += new System.EventHandler(this.cateBox_SelectedIndexChanged);
            // 
            // createCateBtn
            // 
            this.createCateBtn.Location = new System.Drawing.Point(611, 12);
            this.createCateBtn.Name = "createCateBtn";
            this.createCateBtn.Size = new System.Drawing.Size(164, 63);
            this.createCateBtn.TabIndex = 2;
            this.createCateBtn.Text = "Create Category";
            this.createCateBtn.UseVisualStyleBackColor = true;
            this.createCateBtn.Click += new System.EventHandler(this.createCateBtn_Click);
            // 
            // cateIDView
            // 
            this.cateIDView.HeaderText = "Category ID";
            this.cateIDView.Name = "cateIDView";
            this.cateIDView.ReadOnly = true;
            // 
            // cateNameView
            // 
            this.cateNameView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cateNameView.HeaderText = "Name";
            this.cateNameView.MinimumWidth = 30;
            this.cateNameView.Name = "cateNameView";
            this.cateNameView.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.HeaderText = "";
            this.btnView.Name = "btnView";
            this.btnView.ReadOnly = true;
            // 
            // ShowCate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createCateBtn);
            this.Controls.Add(this.cateBox);
            this.Controls.Add(this.CateView);
            this.Name = "ShowCate";
            this.Text = "ShowCate";
            ((System.ComponentModel.ISupportInitialize)(this.CateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CateView;
        private System.Windows.Forms.ComboBox cateBox;
        private System.Windows.Forms.Button createCateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateIDView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateNameView;
        private System.Windows.Forms.DataGridViewButtonColumn btnView;
    }
}