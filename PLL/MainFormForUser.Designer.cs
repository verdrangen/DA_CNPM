namespace DA_CNPM
{
    partial class MainFormForUser
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
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_SachOnline = new System.Windows.Forms.Label();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.llb_Intro = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.user_toolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_user_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_user_bookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_user_support = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Search.Location = new System.Drawing.Point(579, 13);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 27);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(327, 16);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(246, 20);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_SachOnline
            // 
            this.lb_SachOnline.AutoSize = true;
            this.lb_SachOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb_SachOnline.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SachOnline.ForeColor = System.Drawing.Color.Red;
            this.lb_SachOnline.Location = new System.Drawing.Point(43, 9);
            this.lb_SachOnline.Name = "lb_SachOnline";
            this.lb_SachOnline.Size = new System.Drawing.Size(125, 28);
            this.lb_SachOnline.TabIndex = 0;
            this.lb_SachOnline.Text = "SachOnline";
            // 
            // pn_Main
            // 
            this.pn_Main.AutoScroll = true;
            this.pn_Main.Location = new System.Drawing.Point(0, 51);
            this.pn_Main.Margin = new System.Windows.Forms.Padding(2);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(995, 522);
            this.pn_Main.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.llb_Intro);
            this.panel4.Location = new System.Drawing.Point(0, 578);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 39);
            this.panel4.TabIndex = 5;
            // 
            // llb_Intro
            // 
            this.llb_Intro.AutoSize = true;
            this.llb_Intro.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Intro.Location = new System.Drawing.Point(22, 9);
            this.llb_Intro.Name = "llb_Intro";
            this.llb_Intro.Size = new System.Drawing.Size(89, 19);
            this.llb_Intro.TabIndex = 0;
            this.llb_Intro.TabStop = true;
            this.llb_Intro.Text = "Introduction";
            this.llb_Intro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Intro_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_toolstrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(995, 49);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // user_toolstrip
            // 
            this.user_toolstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.user_toolstrip.CheckOnClick = true;
            this.user_toolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_user_info,
            this.toolstrip_user_bookmark,
            this.toolstrip_user_support});
            this.user_toolstrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_toolstrip.Name = "user_toolstrip";
            this.user_toolstrip.Size = new System.Drawing.Size(63, 47);
            this.user_toolstrip.Text = "Cá nhân";
            // 
            // toolstrip_user_info
            // 
            this.toolstrip_user_info.Name = "toolstrip_user_info";
            this.toolstrip_user_info.Size = new System.Drawing.Size(177, 22);
            this.toolstrip_user_info.Text = "Thông tin tài khoản";
            // 
            // toolstrip_user_bookmark
            // 
            this.toolstrip_user_bookmark.Name = "toolstrip_user_bookmark";
            this.toolstrip_user_bookmark.Size = new System.Drawing.Size(177, 22);
            this.toolstrip_user_bookmark.Text = "Sách đã lưu";
            // 
            // toolstrip_user_support
            // 
            this.toolstrip_user_support.Name = "toolstrip_user_support";
            this.toolstrip_user_support.Size = new System.Drawing.Size(177, 22);
            this.toolstrip_user_support.Text = "Báo cáo vấn đề";
            // 
            // MainFormForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 622);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lb_SachOnline);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainFormForUser";
            this.Text = "MainFormForUser";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_SachOnline;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel llb_Intro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem user_toolstrip;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_user_info;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_user_bookmark;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_user_support;
    }
}