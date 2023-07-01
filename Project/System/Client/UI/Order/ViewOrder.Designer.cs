namespace Client.UI.Order
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.lockCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderIDDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detailBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDGV
            // 
            this.orderDGV.AllowUserToAddRows = false;
            this.orderDGV.AllowUserToDeleteRows = false;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lockCheck,
            this.orderIDDGV,
            this.statusDGV,
            this.dateDGV,
            this.timeDGV,
            this.emCheck,
            this.detailBtn});
            this.orderDGV.Location = new System.Drawing.Point(37, 120);
            this.orderDGV.MultiSelect = false;
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.ReadOnly = true;
            this.orderDGV.Size = new System.Drawing.Size(1022, 497);
            this.orderDGV.TabIndex = 0;
            this.orderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDGV_CellContentClick);
            // 
            // lockCheck
            // 
            this.lockCheck.HeaderText = "Mapping Lock";
            this.lockCheck.Name = "lockCheck";
            this.lockCheck.ReadOnly = true;
            // 
            // orderIDDGV
            // 
            this.orderIDDGV.HeaderText = "Order ID";
            this.orderIDDGV.Name = "orderIDDGV";
            this.orderIDDGV.ReadOnly = true;
            // 
            // statusDGV
            // 
            this.statusDGV.HeaderText = "Status";
            this.statusDGV.Name = "statusDGV";
            this.statusDGV.ReadOnly = true;
            // 
            // dateDGV
            // 
            this.dateDGV.HeaderText = "Create Date";
            this.dateDGV.Name = "dateDGV";
            this.dateDGV.ReadOnly = true;
            // 
            // timeDGV
            // 
            this.timeDGV.HeaderText = "Create Time";
            this.timeDGV.Name = "timeDGV";
            this.timeDGV.ReadOnly = true;
            // 
            // emCheck
            // 
            this.emCheck.HeaderText = "Emergency";
            this.emCheck.Name = "emCheck";
            this.emCheck.ReadOnly = true;
            // 
            // detailBtn
            // 
            this.detailBtn.HeaderText = "Detail";
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(147, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ViewOrder
            // 
            this.ClientSize = new System.Drawing.Size(1129, 650);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderDGV);
            this.Name = "ViewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDGV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emCheck;
        private System.Windows.Forms.DataGridViewButtonColumn detailBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}