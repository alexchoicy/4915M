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
            this.userName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemControlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(480, 248);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(148, 26);
            this.userName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 131);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowContract_Click);
            // 
            // ItemControlBtn
            // 
            this.ItemControlBtn.Location = new System.Drawing.Point(496, 281);
            this.ItemControlBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemControlBtn.Name = "ItemControlBtn";
            this.ItemControlBtn.Size = new System.Drawing.Size(208, 131);
            this.ItemControlBtn.TabIndex = 2;
            this.ItemControlBtn.Text = "button2";
            this.ItemControlBtn.UseVisualStyleBackColor = true;
            this.ItemControlBtn.Click += new System.EventHandler(this.ItemControlBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ItemControlBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ItemControlBtn;
    }
}