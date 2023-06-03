namespace Client.UI.Item
{
    partial class ItemCreate
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
            this.itemIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cateIDTxt = new System.Windows.Forms.ComboBox();
            this.contactIDTxt = new System.Windows.Forms.ComboBox();
            this.SupIDTxt = new System.Windows.Forms.ComboBox();
            this.cnewSupBtn = new System.Windows.Forms.Button();
            this.cnewConBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.virtIDTxt = new System.Windows.Forms.ComboBox();
            this.sumBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cateBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemIDTxt
            // 
            this.itemIDTxt.Location = new System.Drawing.Point(100, 35);
            this.itemIDTxt.Name = "itemIDTxt";
            this.itemIDTxt.ReadOnly = true;
            this.itemIDTxt.Size = new System.Drawing.Size(111, 20);
            this.itemIDTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contract ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(100, 55);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(111, 20);
            this.itemNameTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // itemPriceTxt
            // 
            this.itemPriceTxt.Location = new System.Drawing.Point(321, 55);
            this.itemPriceTxt.Name = "itemPriceTxt";
            this.itemPriceTxt.Size = new System.Drawing.Size(111, 20);
            this.itemPriceTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Virtual ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cateIDTxt);
            this.groupBox1.Controls.Add(this.contactIDTxt);
            this.groupBox1.Controls.Add(this.SupIDTxt);
            this.groupBox1.Controls.Add(this.itemIDTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 145);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // cateIDTxt
            // 
            this.cateIDTxt.FormattingEnabled = true;
            this.cateIDTxt.Location = new System.Drawing.Point(91, 81);
            this.cateIDTxt.Name = "cateIDTxt";
            this.cateIDTxt.Size = new System.Drawing.Size(121, 21);
            this.cateIDTxt.TabIndex = 15;
            // 
            // contactIDTxt
            // 
            this.contactIDTxt.FormattingEnabled = true;
            this.contactIDTxt.Location = new System.Drawing.Point(332, 81);
            this.contactIDTxt.Name = "contactIDTxt";
            this.contactIDTxt.Size = new System.Drawing.Size(143, 21);
            this.contactIDTxt.TabIndex = 9;
            // 
            // SupIDTxt
            // 
            this.SupIDTxt.FormattingEnabled = true;
            this.SupIDTxt.Location = new System.Drawing.Point(332, 33);
            this.SupIDTxt.Name = "SupIDTxt";
            this.SupIDTxt.Size = new System.Drawing.Size(143, 21);
            this.SupIDTxt.TabIndex = 8;
            this.SupIDTxt.SelectedIndexChanged += new System.EventHandler(this.SupIDTxt_SelectedIndexChanged);
            // 
            // cnewSupBtn
            // 
            this.cnewSupBtn.Location = new System.Drawing.Point(558, 12);
            this.cnewSupBtn.Name = "cnewSupBtn";
            this.cnewSupBtn.Size = new System.Drawing.Size(133, 45);
            this.cnewSupBtn.TabIndex = 11;
            this.cnewSupBtn.Text = "Create New Supplier";
            this.cnewSupBtn.UseVisualStyleBackColor = true;
            // 
            // cnewConBtn
            // 
            this.cnewConBtn.Location = new System.Drawing.Point(558, 69);
            this.cnewConBtn.Name = "cnewConBtn";
            this.cnewConBtn.Size = new System.Drawing.Size(133, 45);
            this.cnewConBtn.TabIndex = 10;
            this.cnewConBtn.Text = "Create New Contract";
            this.cnewConBtn.UseVisualStyleBackColor = true;
            this.cnewConBtn.Click += new System.EventHandler(this.cnewConBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.virtIDTxt);
            this.groupBox2.Controls.Add(this.itemNameTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemPriceTxt);
            this.groupBox2.Location = new System.Drawing.Point(25, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 186);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // virtIDTxt
            // 
            this.virtIDTxt.FormattingEnabled = true;
            this.virtIDTxt.Location = new System.Drawing.Point(188, 138);
            this.virtIDTxt.Name = "virtIDTxt";
            this.virtIDTxt.Size = new System.Drawing.Size(121, 21);
            this.virtIDTxt.TabIndex = 14;
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(575, 404);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(97, 47);
            this.sumBtn.TabIndex = 16;
            this.sumBtn.Text = "Sumbit";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(439, 404);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 47);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // cateBtn
            // 
            this.cateBtn.Location = new System.Drawing.Point(558, 129);
            this.cateBtn.Name = "cateBtn";
            this.cateBtn.Size = new System.Drawing.Size(133, 45);
            this.cateBtn.TabIndex = 18;
            this.cateBtn.Text = "Create New Category";
            this.cateBtn.UseVisualStyleBackColor = true;
            this.cateBtn.Click += new System.EventHandler(this.cateBtn_Click);
            // 
            // ItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 488);
            this.Controls.Add(this.cateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cnewSupBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.cnewConBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemCreate";
            this.Text = "ItemCateCreate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox itemIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemPriceTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox SupIDTxt;
        private System.Windows.Forms.ComboBox contactIDTxt;
        private System.Windows.Forms.Button cnewSupBtn;
        private System.Windows.Forms.Button cnewConBtn;
        private System.Windows.Forms.ComboBox cateIDTxt;
        private System.Windows.Forms.ComboBox virtIDTxt;
        private System.Windows.Forms.Button cateBtn;
    }
}