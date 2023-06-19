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
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cateIDTxt = new System.Windows.Forms.ComboBox();
            this.SupIDTxt = new System.Windows.Forms.ComboBox();
            this.cnewSupBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.virtIDTxt = new System.Windows.Forms.ComboBox();
            this.sumBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cateBtn = new System.Windows.Forms.Button();
            this.UomList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemIDTxt
            // 
            this.itemIDTxt.Location = new System.Drawing.Point(150, 54);
            this.itemIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemIDTxt.Name = "itemIDTxt";
            this.itemIDTxt.ReadOnly = true;
            this.itemIDTxt.Size = new System.Drawing.Size(164, 26);
            this.itemIDTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CategoryID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(150, 85);
            this.itemNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(164, 26);
            this.itemNameTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // itemPriceTxt
            // 
            this.itemPriceTxt.Location = new System.Drawing.Point(565, 89);
            this.itemPriceTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemPriceTxt.Name = "itemPriceTxt";
            this.itemPriceTxt.Size = new System.Drawing.Size(164, 26);
            this.itemPriceTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Virtual ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cateIDTxt);
            this.groupBox1.Controls.Add(this.SupIDTxt);
            this.groupBox1.Controls.Add(this.itemIDTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(38, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(746, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // cateIDTxt
            // 
            this.cateIDTxt.FormattingEnabled = true;
            this.cateIDTxt.Location = new System.Drawing.Point(136, 125);
            this.cateIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cateIDTxt.Name = "cateIDTxt";
            this.cateIDTxt.Size = new System.Drawing.Size(180, 28);
            this.cateIDTxt.TabIndex = 15;
            // 
            // SupIDTxt
            // 
            this.SupIDTxt.FormattingEnabled = true;
            this.SupIDTxt.Location = new System.Drawing.Point(498, 51);
            this.SupIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SupIDTxt.Name = "SupIDTxt";
            this.SupIDTxt.Size = new System.Drawing.Size(212, 28);
            this.SupIDTxt.TabIndex = 8;
            this.SupIDTxt.SelectedIndexChanged += new System.EventHandler(this.SupIDTxt_SelectedIndexChanged);
            // 
            // cnewSupBtn
            // 
            this.cnewSupBtn.Location = new System.Drawing.Point(837, 18);
            this.cnewSupBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cnewSupBtn.Name = "cnewSupBtn";
            this.cnewSupBtn.Size = new System.Drawing.Size(200, 69);
            this.cnewSupBtn.TabIndex = 11;
            this.cnewSupBtn.Text = "Create New Supplier";
            this.cnewSupBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UomList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.virtIDTxt);
            this.groupBox2.Controls.Add(this.itemNameTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.itemPriceTxt);
            this.groupBox2.Location = new System.Drawing.Point(38, 275);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(746, 286);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // virtIDTxt
            // 
            this.virtIDTxt.FormattingEnabled = true;
            this.virtIDTxt.Location = new System.Drawing.Point(174, 212);
            this.virtIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.virtIDTxt.Name = "virtIDTxt";
            this.virtIDTxt.Size = new System.Drawing.Size(180, 28);
            this.virtIDTxt.TabIndex = 14;
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(862, 622);
            this.sumBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(146, 72);
            this.sumBtn.TabIndex = 16;
            this.sumBtn.Text = "Sumbit";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(658, 622);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(152, 72);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // cateBtn
            // 
            this.cateBtn.Location = new System.Drawing.Point(837, 122);
            this.cateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cateBtn.Name = "cateBtn";
            this.cateBtn.Size = new System.Drawing.Size(200, 69);
            this.cateBtn.TabIndex = 18;
            this.cateBtn.Text = "Create New Category";
            this.cateBtn.UseVisualStyleBackColor = true;
            this.cateBtn.Click += new System.EventHandler(this.cateBtn_Click);
            // 
            // UomList
            // 
            this.UomList.FormattingEnabled = true;
            this.UomList.Items.AddRange(new object[] {
            "KG"});
            this.UomList.Location = new System.Drawing.Point(546, 214);
            this.UomList.Name = "UomList";
            this.UomList.Size = new System.Drawing.Size(193, 28);
            this.UomList.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Unit of Measurement";
            // 
            // ItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 751);
            this.Controls.Add(this.cateBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cnewSupBtn);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button cnewSupBtn;
        private System.Windows.Forms.ComboBox cateIDTxt;
        private System.Windows.Forms.ComboBox virtIDTxt;
        private System.Windows.Forms.Button cateBtn;
        private System.Windows.Forms.ComboBox UomList;
        private System.Windows.Forms.Label label4;
    }
}