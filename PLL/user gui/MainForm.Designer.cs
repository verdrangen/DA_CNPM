﻿namespace GUI_DOAN
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SachOnline = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.cb_TheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yêuThíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llb_Intro = new System.Windows.Forms.LinkLabel();
            this.bt_Signin = new System.Windows.Forms.Button();
            this.bt_SignUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bt_SignUp);
            this.panel1.Controls.Add(this.bt_Signin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_TheLoai);
            this.panel1.Controls.Add(this.bt_Search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lb_SachOnline);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 39);
            this.panel1.TabIndex = 0;
            // 
            // lb_SachOnline
            // 
            this.lb_SachOnline.AutoSize = true;
            this.lb_SachOnline.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SachOnline.ForeColor = System.Drawing.Color.Red;
            this.lb_SachOnline.Location = new System.Drawing.Point(79, 5);
            this.lb_SachOnline.Name = "lb_SachOnline";
            this.lb_SachOnline.Size = new System.Drawing.Size(125, 28);
            this.lb_SachOnline.TabIndex = 0;
            this.lb_SachOnline.Text = "SachOnline";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.llb_Intro);
            this.panel4.Location = new System.Drawing.Point(3, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(945, 39);
            this.panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 27);
            this.textBox1.TabIndex = 1;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Search.Location = new System.Drawing.Point(478, 5);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 27);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // cb_TheLoai
            // 
            this.cb_TheLoai.FormattingEnabled = true;
            this.cb_TheLoai.Location = new System.Drawing.Point(559, 8);
            this.cb_TheLoai.Name = "cb_TheLoai";
            this.cb_TheLoai.Size = new System.Drawing.Size(143, 21);
            this.cb_TheLoai.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(708, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.hotToolStripMenuItem,
            this.yêuThíchToolStripMenuItem,
            this.lịchSửToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(127, 92);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // hotToolStripMenuItem
            // 
            this.hotToolStripMenuItem.Name = "hotToolStripMenuItem";
            this.hotToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hotToolStripMenuItem.Text = "Hot";
            // 
            // yêuThíchToolStripMenuItem
            // 
            this.yêuThíchToolStripMenuItem.Name = "yêuThíchToolStripMenuItem";
            this.yêuThíchToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.yêuThíchToolStripMenuItem.Text = "Yêu Thích";
            // 
            // lịchSửToolStripMenuItem
            // 
            this.lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            this.lịchSửToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.lịchSửToolStripMenuItem.Text = "Lịch sử";
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
            // 
            // bt_Signin
            // 
            this.bt_Signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Signin.Location = new System.Drawing.Point(777, 5);
            this.bt_Signin.Name = "bt_Signin";
            this.bt_Signin.Size = new System.Drawing.Size(75, 26);
            this.bt_Signin.TabIndex = 5;
            this.bt_Signin.Text = "Sign in";
            this.bt_Signin.UseVisualStyleBackColor = false;
            // 
            // bt_SignUp
            // 
            this.bt_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_SignUp.Location = new System.Drawing.Point(858, 5);
            this.bt_SignUp.Name = "bt_SignUp";
            this.bt_SignUp.Size = new System.Drawing.Size(75, 26);
            this.bt_SignUp.TabIndex = 6;
            this.bt_SignUp.Text = "Sign up";
            this.bt_SignUp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 539);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TheLoai;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_SachOnline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel llb_Intro;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yêuThíchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửToolStripMenuItem;
        private System.Windows.Forms.Button bt_SignUp;
        private System.Windows.Forms.Button bt_Signin;
    }
}

