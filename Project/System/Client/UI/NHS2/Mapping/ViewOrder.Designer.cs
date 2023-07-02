namespace Client.UI.NHS2.Mapping
{
    partial class ViewOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emergency = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emergency,
            this.orderIDDGV,
            this.restIDDGV,
            this.statusDGV,
            this.start});
            this.dataGridView1.Location = new System.Drawing.Point(28, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1205, 552);
            this.dataGridView1.TabIndex = 0;
            // 
            // emergency
            // 
            this.emergency.HeaderText = "Emergency";
            this.emergency.Name = "emergency";
            this.emergency.ReadOnly = true;
            this.emergency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // orderIDDGV
            // 
            this.orderIDDGV.HeaderText = "OrderID";
            this.orderIDDGV.Name = "orderIDDGV";
            this.orderIDDGV.ReadOnly = true;
            // 
            // restIDDGV
            // 
            this.restIDDGV.HeaderText = "Restaurant ID";
            this.restIDDGV.Name = "restIDDGV";
            this.restIDDGV.ReadOnly = true;
            this.restIDDGV.Width = 120;
            // 
            // statusDGV
            // 
            this.statusDGV.HeaderText = "Status";
            this.statusDGV.Name = "statusDGV";
            this.statusDGV.ReadOnly = true;
            this.statusDGV.Width = 700;
            // 
            // start
            // 
            this.start.HeaderText = "Start Mapping";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mapping ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(176, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(191, 30);
            this.textBox1.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(1107, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 39);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(975, 3);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(126, 37);
            this.Editbtn.TabIndex = 4;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            // 
            // ViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewOrder";
            this.Size = new System.Drawing.Size(1256, 618);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emergency;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn restIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDGV;
        private System.Windows.Forms.DataGridViewButtonColumn start;
        private System.Windows.Forms.Button Editbtn;
    }
}
