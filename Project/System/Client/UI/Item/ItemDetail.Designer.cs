namespace Client.UI.Item
{
    partial class ItemDetail
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
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refSupID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UOMList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cateIDTxt = new System.Windows.Forms.ComboBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.virtualIDTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierIDTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemIdTxt = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockTxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(144, 36);
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(127, 27);
            this.stockTxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Current Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refSupID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UOMList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cateIDTxt);
            this.groupBox2.Controls.Add(this.priceTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.itemNameTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.virtualIDTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.supplierIDTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.itemIdTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Information";
            // 
            // refSupID
            // 
            this.refSupID.Location = new System.Drawing.Point(667, 79);
            this.refSupID.Name = "refSupID";
            this.refSupID.Size = new System.Drawing.Size(272, 27);
            this.refSupID.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Supplier Ref ID";
            // 
            // UOMList
            // 
            this.UOMList.FormattingEnabled = true;
            this.UOMList.Location = new System.Drawing.Point(667, 126);
            this.UOMList.Margin = new System.Windows.Forms.Padding(2);
            this.UOMList.Name = "UOMList";
            this.UOMList.Size = new System.Drawing.Size(272, 28);
            this.UOMList.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unit of Measurement";
            // 
            // cateIDTxt
            // 
            this.cateIDTxt.FormattingEnabled = true;
            this.cateIDTxt.Location = new System.Drawing.Point(144, 78);
            this.cateIDTxt.Name = "cateIDTxt";
            this.cateIDTxt.Size = new System.Drawing.Size(313, 28);
            this.cateIDTxt.TabIndex = 14;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(667, 182);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(272, 27);
            this.priceTxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price";
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(144, 182);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(313, 27);
            this.itemNameTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name";
            // 
            // virtualIDTxt
            // 
            this.virtualIDTxt.Location = new System.Drawing.Point(144, 124);
            this.virtualIDTxt.Name = "virtualIDTxt";
            this.virtualIDTxt.Size = new System.Drawing.Size(313, 27);
            this.virtualIDTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Virtual ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "CategoryID";
            // 
            // supplierIDTxt
            // 
            this.supplierIDTxt.Location = new System.Drawing.Point(672, 34);
            this.supplierIDTxt.Name = "supplierIDTxt";
            this.supplierIDTxt.ReadOnly = true;
            this.supplierIDTxt.Size = new System.Drawing.Size(267, 27);
            this.supplierIDTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // itemIdTxt
            // 
            this.itemIdTxt.Location = new System.Drawing.Point(144, 32);
            this.itemIdTxt.Name = "itemIdTxt";
            this.itemIdTxt.ReadOnly = true;
            this.itemIdTxt.Size = new System.Drawing.Size(313, 27);
            this.itemIdTxt.TabIndex = 0;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(767, 485);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(121, 67);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(640, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemDetail";
            this.Text = "ItemDetail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox itemIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierIDTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox virtualIDTxt;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cateIDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox UOMList;
        private System.Windows.Forms.TextBox refSupID;
        private System.Windows.Forms.Label label9;
    }
}