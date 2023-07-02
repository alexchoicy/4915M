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
            this.DateTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeBtn = new System.Windows.Forms.Button();
            this.updateMesBtn = new System.Windows.Forms.Button();
            this.restID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mapBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showContractBtn
            // 
            this.showContractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showContractBtn.Location = new System.Drawing.Point(16, 139);
            this.showContractBtn.Name = "showContractBtn";
            this.showContractBtn.Size = new System.Drawing.Size(192, 85);
            this.showContractBtn.TabIndex = 1;
            this.showContractBtn.Text = "Agreement";
            this.showContractBtn.UseVisualStyleBackColor = true;
            this.showContractBtn.Click += new System.EventHandler(this.ShowContract_Click);
            // 
            // ItemControlBtn
            // 
            this.ItemControlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemControlBtn.Location = new System.Drawing.Point(16, 249);
            this.ItemControlBtn.Name = "ItemControlBtn";
            this.ItemControlBtn.Size = new System.Drawing.Size(192, 85);
            this.ItemControlBtn.TabIndex = 2;
            this.ItemControlBtn.Text = "Item";
            this.ItemControlBtn.UseVisualStyleBackColor = true;
            this.ItemControlBtn.Click += new System.EventHandler(this.ItemControlBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(171, 24);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(64, 25);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(171, 54);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(64, 25);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "label4";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(503, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(119, 25);
            this.label.TabIndex = 7;
            this.label.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(628, 24);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(64, 25);
            this.deptLabel.TabIndex = 9;
            this.deptLabel.Text = "label2";
            // 
            // posLabel
            // 
            this.posLabel.AutoSize = true;
            this.posLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posLabel.Location = new System.Drawing.Point(628, 54);
            this.posLabel.Name = "posLabel";
            this.posLabel.Size = new System.Drawing.Size(64, 25);
            this.posLabel.TabIndex = 10;
            this.posLabel.Text = "label2";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(697, 833);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(113, 44);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // restBtn
            // 
            this.restBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restBtn.Location = new System.Drawing.Point(19, 349);
            this.restBtn.Name = "restBtn";
            this.restBtn.Size = new System.Drawing.Size(189, 81);
            this.restBtn.TabIndex = 12;
            this.restBtn.Text = "Restaurant Order";
            this.restBtn.UseVisualStyleBackColor = true;
            this.restBtn.Click += new System.EventHandler(this.restBtn_Click);
            // 
            // showPurBtn
            // 
            this.showPurBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPurBtn.Location = new System.Drawing.Point(16, 564);
            this.showPurBtn.Name = "showPurBtn";
            this.showPurBtn.Size = new System.Drawing.Size(189, 85);
            this.showPurBtn.TabIndex = 13;
            this.showPurBtn.Text = "Purchase";
            this.showPurBtn.UseVisualStyleBackColor = true;
            // 
            // messageGrid
            // 
            this.messageGrid.AllowUserToAddRows = false;
            this.messageGrid.AllowUserToDeleteRows = false;
            this.messageGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeDGV,
            this.messageDGV});
            this.messageGrid.Location = new System.Drawing.Point(283, 139);
            this.messageGrid.Name = "messageGrid";
            this.messageGrid.RowHeadersWidth = 62;
            this.messageGrid.RowTemplate.Height = 28;
            this.messageGrid.Size = new System.Drawing.Size(527, 479);
            this.messageGrid.TabIndex = 14;
            // 
            // DateTimeDGV
            // 
            this.DateTimeDGV.HeaderText = "DateTime";
            this.DateTimeDGV.Name = "DateTimeDGV";
            this.DateTimeDGV.ReadOnly = true;
            // 
            // messageDGV
            // 
            this.messageDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDGV.HeaderText = "Message";
            this.messageDGV.Name = "messageDGV";
            this.messageDGV.ReadOnly = true;
            this.messageDGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeBtn
            // 
            this.DeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeBtn.Location = new System.Drawing.Point(16, 672);
            this.DeBtn.Name = "DeBtn";
            this.DeBtn.Size = new System.Drawing.Size(189, 85);
            this.DeBtn.TabIndex = 15;
            this.DeBtn.Text = "Delivery";
            this.DeBtn.UseVisualStyleBackColor = true;
            this.DeBtn.Click += new System.EventHandler(this.DeBtn_Click);
            // 
            // updateMesBtn
            // 
            this.updateMesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMesBtn.Location = new System.Drawing.Point(816, 161);
            this.updateMesBtn.Name = "updateMesBtn";
            this.updateMesBtn.Size = new System.Drawing.Size(118, 63);
            this.updateMesBtn.TabIndex = 16;
            this.updateMesBtn.Text = "Update Message";
            this.updateMesBtn.UseVisualStyleBackColor = true;
            this.updateMesBtn.Click += new System.EventHandler(this.updateMesBtn_Click);
            // 
            // restID
            // 
            this.restID.AutoSize = true;
            this.restID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restID.Location = new System.Drawing.Point(171, 97);
            this.restID.Name = "restID";
            this.restID.Size = new System.Drawing.Size(64, 25);
            this.restID.TabIndex = 18;
            this.restID.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Restaurant ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Restaurant ID:";
            // 
            // mapBtn
            // 
            this.mapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapBtn.Location = new System.Drawing.Point(19, 456);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(189, 81);
            this.mapBtn.TabIndex = 19;
            this.mapBtn.Text = "Mapping";
            this.mapBtn.UseVisualStyleBackColor = true;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 889);
            this.Controls.Add(this.mapBtn);
            this.Controls.Add(this.restID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateMesBtn);
            this.Controls.Add(this.DeBtn);
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
        private System.Windows.Forms.Button DeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDGV;
        private System.Windows.Forms.Button updateMesBtn;
        private System.Windows.Forms.Label restID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mapBtn;
    }
}