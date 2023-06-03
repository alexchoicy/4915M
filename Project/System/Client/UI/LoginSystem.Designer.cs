namespace Client.UI
{
    partial class LoginSystem
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resetPwBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.getIdTxt = new System.Windows.Forms.TextBox();
            this.getPwTxt = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetPwBtn
            // 
            this.resetPwBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetPwBtn.Location = new System.Drawing.Point(146, 150);
            this.resetPwBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetPwBtn.Name = "resetPwBtn";
            this.resetPwBtn.Size = new System.Drawing.Size(128, 46);
            this.resetPwBtn.TabIndex = 0;
            this.resetPwBtn.Text = "Forget Password";
            this.resetPwBtn.UseVisualStyleBackColor = true;
            this.resetPwBtn.Click += new System.EventHandler(this.resetPwBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LoginBtn.Location = new System.Drawing.Point(375, 150);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(128, 46);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.Welcome.Location = new System.Drawing.Point(111, 44);
            this.Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(372, 21);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Welcome to Yummy Restaurants Group Limited ";
            this.Welcome.Click += new System.EventHandler(this.We_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ID.Location = new System.Drawing.Point(158, 41);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(92, 19);
            this.ID.TabIndex = 3;
            this.ID.Text = "Employee ID:";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Password.Location = new System.Drawing.Point(177, 82);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 19);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // getIdTxt
            // 
            this.getIdTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.getIdTxt.Location = new System.Drawing.Point(252, 38);
            this.getIdTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.getIdTxt.Name = "getIdTxt";
            this.getIdTxt.Size = new System.Drawing.Size(189, 26);
            this.getIdTxt.TabIndex = 5;
            this.getIdTxt.TextChanged += new System.EventHandler(this.getIDTxt_TextChanged);
            // 
            // getPwTxt
            // 
            this.getPwTxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.getPwTxt.Location = new System.Drawing.Point(252, 80);
            this.getPwTxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.getPwTxt.Name = "getPwTxt";
            this.getPwTxt.Size = new System.Drawing.Size(189, 26);
            this.getPwTxt.TabIndex = 6;
            this.getPwTxt.TextChanged += new System.EventHandler(this.getPwTxt_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Welcome);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resetPwBtn);
            this.splitContainer1.Panel2.Controls.Add(this.getPwTxt);
            this.splitContainer1.Panel2.Controls.Add(this.LoginBtn);
            this.splitContainer1.Panel2.Controls.Add(this.getIdTxt);
            this.splitContainer1.Panel2.Controls.Add(this.ID);
            this.splitContainer1.Panel2.Controls.Add(this.Password);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(598, 416);
            this.splitContainer1.SplitterDistance = 112;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 7;
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 416);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LoginSystem";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginSystem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetPwBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox getIdTxt;
        private System.Windows.Forms.TextBox getPwTxt;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

