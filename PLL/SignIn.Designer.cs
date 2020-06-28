namespace DA_CNPM.PLL
{
    partial class SignIn
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
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.tb_PassWord = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.lb_SachOnline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(13, 130);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(111, 29);
            this.lb_Password.TabIndex = 12;
            this.lb_Password.Text = "Password";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.Location = new System.Drawing.Point(13, 93);
            this.lb_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(125, 29);
            this.lb_UserName.TabIndex = 11;
            this.lb_UserName.Text = "User Name";
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.bt_SignIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SignIn.ForeColor = System.Drawing.Color.White;
            this.bt_SignIn.Location = new System.Drawing.Point(163, 189);
            this.bt_SignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(112, 45);
            this.bt_SignIn.TabIndex = 10;
            this.bt_SignIn.Text = "Sign in";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            // 
            // tb_PassWord
            // 
            this.tb_PassWord.Location = new System.Drawing.Point(187, 133);
            this.tb_PassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_PassWord.Name = "tb_PassWord";
            this.tb_PassWord.Size = new System.Drawing.Size(232, 26);
            this.tb_PassWord.TabIndex = 9;
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(187, 93);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(232, 26);
            this.tb_UserName.TabIndex = 8;
            // 
            // lb_SachOnline
            // 
            this.lb_SachOnline.AutoSize = true;
            this.lb_SachOnline.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SachOnline.ForeColor = System.Drawing.Color.Red;
            this.lb_SachOnline.Location = new System.Drawing.Point(140, 18);
            this.lb_SachOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SachOnline.Name = "lb_SachOnline";
            this.lb_SachOnline.Size = new System.Drawing.Size(187, 41);
            this.lb_SachOnline.TabIndex = 7;
            this.lb_SachOnline.Text = "SachOnline";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(438, 263);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.bt_SignIn);
            this.Controls.Add(this.tb_PassWord);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_SachOnline);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.TextBox tb_PassWord;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label lb_SachOnline;
    }
}