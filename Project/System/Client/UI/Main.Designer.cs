namespace Client.UI
{
    partial class Main
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
            this.showContractBtn = new System.Windows.Forms.Button();
            this.ItemControlBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.posLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.restBtn = new System.Windows.Forms.Button();
            this.showPurBtn = new System.Windows.Forms.Button();
            this.messageGrid = new System.Windows.Forms.DataGridView();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showContractBtn
            // 
            this.showContractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showContractBtn.Location = new System.Drawing.Point(18, 165);
            this.showContractBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showContractBtn.Name = "showContractBtn";
            this.showContractBtn.Size = new System.Drawing.Size(288, 131);
            this.showContractBtn.TabIndex = 1;
            this.showContractBtn.Text = "Agreement";
            this.showContractBtn.UseVisualStyleBackColor = true;
            this.showContractBtn.Click += new System.EventHandler(this.ShowContract_Click);
            // 
            // ItemControlBtn
            // 
            this.ItemControlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemControlBtn.Location = new System.Drawing.Point(18, 334);
            this.ItemControlBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemControlBtn.Name = "ItemControlBtn";
            this.ItemControlBtn.Size = new System.Drawing.Size(288, 131);
            this.ItemControlBtn.TabIndex = 2;
            this.ItemControlBtn.Text = "Item";
            this.ItemControlBtn.UseVisualStyleBackColor = true;
            this.ItemControlBtn.Click += new System.EventHandler(this.ItemControlBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(177, 37);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(95, 36);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(177, 83);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(95, 36);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "label4";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(754, 37);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(175, 36);
            this.label.TabIndex = 7;
            this.label.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(942, 37);
            this.deptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(95, 36);
            this.deptLabel.TabIndex = 9;
            this.deptLabel.Text = "label2";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLabel.Location = new System.Drawing.Point(942, 83);
            this.posLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(95, 36);
            this.posLabel.TabIndex = 10;
            this.posLabel.Text = "label2";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(1024, 1032);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(170, 68);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // restBtn
            // 
            this.restBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restBtn.Location = new System.Drawing.Point(22, 488);
            this.restBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restBtn.Name = "restBtn";
            this.restBtn.Size = new System.Drawing.Size(284, 125);
            this.restBtn.TabIndex = 12;
            this.restBtn.Text = "Restaurant Order";
            this.restBtn.UseVisualStyleBackColor = true;
            this.restBtn.Click += new System.EventHandler(this.restBtn_Click);
            // 
            // showPurBtn
            // 
            this.showPurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPurBtn.Location = new System.Drawing.Point(22, 638);
            this.showPurBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPurBtn.Name = "showPurBtn";
            this.showPurBtn.Size = new System.Drawing.Size(284, 131);
            this.showPurBtn.TabIndex = 13;
            this.showPurBtn.Text = "Purchase";
            this.showPurBtn.UseVisualStyleBackColor = true;
            this.showPurBtn.Click += new System.EventHandler(this.showPurBtn_Click);
            // 
            // messageGrid
            // 
            this.messageGrid.AllowUserToAddRows = false;
            this.messageGrid.AllowUserToDeleteRows = false;
            this.messageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Message});
            this.messageGrid.Location = new System.Drawing.Point(475, 165);
            this.messageGrid.Name = "messageGrid";
            this.messageGrid.RowHeadersWidth = 62;
            this.messageGrid.RowTemplate.Height = 28;
            this.messageGrid.Size = new System.Drawing.Size(791, 737);
            this.messageGrid.TabIndex = 14;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 8;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 150;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 1118);
            this.Controls.Add(this.messageGrid);
            this.Controls.Add(this.showPurBtn);
            this.Controls.Add(this.restBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.posLabel);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemControlBtn);
            this.Controls.Add(this.showContractBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showContractBtn;
        private System.Windows.Forms.Button ItemControlBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label posLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button restBtn;
        private System.Windows.Forms.Button showPurBtn;
        private System.Windows.Forms.DataGridView messageGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
    }
}