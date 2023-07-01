namespace Client.UI.Order
{
    partial class OrderDetail
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
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.itemIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemqtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.remarkTxt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emCheck = new System.Windows.Forms.CheckBox();
            this.subBtn = new System.Windows.Forms.Button();
            this.canBtn = new System.Windows.Forms.Button();
            this.rmBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDGV
            // 
            this.orderDGV.AllowUserToAddRows = false;
            this.orderDGV.AllowUserToDeleteRows = false;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDGV,
            this.ItemNameDGV,
            this.ItemqtyDGV});
            this.orderDGV.Location = new System.Drawing.Point(53, 529);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.Size = new System.Drawing.Size(1030, 519);
            this.orderDGV.TabIndex = 0;
            // 
            // itemIDDGV
            // 
            this.itemIDDGV.HeaderText = "Item ID";
            this.itemIDDGV.Name = "itemIDDGV";
            this.itemIDDGV.ReadOnly = true;
            // 
            // ItemNameDGV
            // 
            this.ItemNameDGV.HeaderText = "Item Name";
            this.ItemNameDGV.Name = "ItemNameDGV";
            this.ItemNameDGV.ReadOnly = true;
            // 
            // ItemqtyDGV
            // 
            this.ItemqtyDGV.HeaderText = "Quantity";
            this.ItemqtyDGV.Name = "ItemqtyDGV";
            this.ItemqtyDGV.ReadOnly = true;
            // 
            // orderIDTxt
            // 
            this.orderIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTxt.Location = new System.Drawing.Point(153, 37);
            this.orderIDTxt.Name = "orderIDTxt";
            this.orderIDTxt.ReadOnly = true;
            this.orderIDTxt.Size = new System.Drawing.Size(233, 30);
            this.orderIDTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // statusTxt
            // 
            this.statusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.Location = new System.Drawing.Point(153, 96);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(233, 30);
            this.statusTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // dateTxt
            // 
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(153, 153);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(233, 30);
            this.dateTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time";
            // 
            // timeTxt
            // 
            this.timeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTxt.Location = new System.Drawing.Point(520, 151);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.ReadOnly = true;
            this.timeTxt.Size = new System.Drawing.Size(233, 30);
            this.timeTxt.TabIndex = 7;
            // 
            // remarkTxt
            // 
            this.remarkTxt.Location = new System.Drawing.Point(153, 294);
            this.remarkTxt.Name = "remarkTxt";
            this.remarkTxt.ReadOnly = true;
            this.remarkTxt.Size = new System.Drawing.Size(669, 192);
            this.remarkTxt.TabIndex = 9;
            this.remarkTxt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Remark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Emergency";
            // 
            // emCheck
            // 
            this.emCheck.AutoSize = true;
            this.emCheck.Enabled = false;
            this.emCheck.Location = new System.Drawing.Point(172, 229);
            this.emCheck.Name = "emCheck";
            this.emCheck.Size = new System.Drawing.Size(15, 14);
            this.emCheck.TabIndex = 12;
            this.emCheck.UseVisualStyleBackColor = true;
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(916, 1069);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(167, 63);
            this.subBtn.TabIndex = 14;
            this.subBtn.Text = "Submit";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Visible = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // canBtn
            // 
            this.canBtn.Location = new System.Drawing.Point(733, 1069);
            this.canBtn.Name = "canBtn";
            this.canBtn.Size = new System.Drawing.Size(167, 63);
            this.canBtn.TabIndex = 15;
            this.canBtn.Text = "Cancel";
            this.canBtn.UseVisualStyleBackColor = true;
            this.canBtn.Visible = false;
            this.canBtn.Click += new System.EventHandler(this.canBtn_Click);
            // 
            // rmBtn
            // 
            this.rmBtn.Location = new System.Drawing.Point(916, 24);
            this.rmBtn.Name = "rmBtn";
            this.rmBtn.Size = new System.Drawing.Size(167, 63);
            this.rmBtn.TabIndex = 16;
            this.rmBtn.Text = "Remove Order";
            this.rmBtn.UseVisualStyleBackColor = true;
            this.rmBtn.Visible = false;
            this.rmBtn.Click += new System.EventHandler(this.mrBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(53, 1069);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(167, 63);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit Order";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Visible = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 1144);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.rmBtn);
            this.Controls.Add(this.canBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.emCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remarkTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderIDTxt);
            this.Controls.Add(this.orderDGV);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.TextBox orderIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.RichTextBox remarkTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox emCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemqtyDGV;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button canBtn;
        private System.Windows.Forms.Button rmBtn;
        private System.Windows.Forms.Button editBtn;
    }
}