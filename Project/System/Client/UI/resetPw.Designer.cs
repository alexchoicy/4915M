namespace Client.UI
{
    partial class resetPw
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
            this.Welcome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.newPw = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.getIDTxt = new System.Windows.Forms.TextBox();
            this.NewPwTxt = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.reconfirmPwTxt = new System.Windows.Forms.TextBox();
            this.reconfirmPw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Welcome.Location = new System.Drawing.Point(187, 36);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(479, 27);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to Yummy Restaurants Group Limited ";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ID.Location = new System.Drawing.Point(233, 50);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(120, 22);
            this.ID.TabIndex = 1;
            this.ID.Text = "Employee ID:";
            // 
            // newPw
            // 
            this.newPw.AutoSize = true;
            this.newPw.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.newPw.Location = new System.Drawing.Point(169, 104);
            this.newPw.Name = "newPw";
            this.newPw.Size = new System.Drawing.Size(184, 22);
            this.newPw.TabIndex = 2;
            this.newPw.Text = "Enter New Password:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.CancelBtn.Location = new System.Drawing.Point(299, 243);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(96, 38);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitBtn.Location = new System.Drawing.Point(570, 243);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(96, 38);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit ";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // getIDTxt
            // 
            this.getIDTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.getIDTxt.Location = new System.Drawing.Point(359, 42);
            this.getIDTxt.Name = "getIDTxt";
            this.getIDTxt.Size = new System.Drawing.Size(277, 30);
            this.getIDTxt.TabIndex = 5;
            this.getIDTxt.TextChanged += new System.EventHandler(this.getIDTxt_TextChanged);
            // 
            // NewPwTxt
            // 
            this.NewPwTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NewPwTxt.Location = new System.Drawing.Point(359, 96);
            this.NewPwTxt.Name = "NewPwTxt";
            this.NewPwTxt.Size = new System.Drawing.Size(277, 30);
            this.NewPwTxt.TabIndex = 6;
            this.NewPwTxt.TextChanged += new System.EventHandler(this.NewPwTxt_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Welcome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reconfirmPwTxt);
            this.splitContainer1.Panel2.Controls.Add(this.reconfirmPw);
            this.splitContainer1.Panel2.Controls.Add(this.NewPwTxt);
            this.splitContainer1.Panel2.Controls.Add(this.ID);
            this.splitContainer1.Panel2.Controls.Add(this.getIDTxt);
            this.splitContainer1.Panel2.Controls.Add(this.newPw);
            this.splitContainer1.Panel2.Controls.Add(this.SubmitBtn);
            this.splitContainer1.Panel2.Controls.Add(this.CancelBtn);
            this.splitContainer1.Size = new System.Drawing.Size(878, 512);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 7;
            // 
            // reconfirmPwTxt
            // 
            this.reconfirmPwTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.reconfirmPwTxt.Location = new System.Drawing.Point(359, 156);
            this.reconfirmPwTxt.Name = "reconfirmPwTxt";
            this.reconfirmPwTxt.Size = new System.Drawing.Size(277, 30);
            this.reconfirmPwTxt.TabIndex = 8;
            this.reconfirmPwTxt.TextChanged += new System.EventHandler(this.reconfirmPwTxt_TextChanged);
            // 
            // reconfirmPw
            // 
            this.reconfirmPw.AutoSize = true;
            this.reconfirmPw.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.reconfirmPw.Location = new System.Drawing.Point(169, 159);
            this.reconfirmPw.Name = "reconfirmPw";
            this.reconfirmPw.Size = new System.Drawing.Size(182, 22);
            this.reconfirmPw.TabIndex = 7;
            this.reconfirmPw.Text = "Reconfirm Password:";
            this.reconfirmPw.Click += new System.EventHandler(this.reconfirmPw_Click);
            // 
            // resetPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 512);
            this.Controls.Add(this.splitContainer1);
            this.Name = "resetPw";
            this.Text = "Reset Password";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label newPw;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox getIDTxt;
        private System.Windows.Forms.TextBox NewPwTxt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox reconfirmPwTxt;
        private System.Windows.Forms.Label reconfirmPw;
    }
}