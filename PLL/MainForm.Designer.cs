namespace DA_CNPM.PLL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_SignUp = new System.Windows.Forms.Button();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_SachOnline = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.llb_Intro = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flp_P1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_P2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bt_SignUp);
            this.panel1.Controls.Add(this.bt_SignIn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_Category);
            this.panel1.Controls.Add(this.bt_Search);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.lb_SachOnline);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1483, 60);
            this.panel1.TabIndex = 1;
            // 
            // bt_SignUp
            // 
            this.bt_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_SignUp.Location = new System.Drawing.Point(1287, 8);
            this.bt_SignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_SignUp.Name = "bt_SignUp";
            this.bt_SignUp.Size = new System.Drawing.Size(112, 40);
            this.bt_SignUp.TabIndex = 6;
            this.bt_SignUp.Text = "Sign up";
            this.bt_SignUp.UseVisualStyleBackColor = false;
            this.bt_SignUp.Click += new System.EventHandler(this.bt_SignUp_Click);
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_SignIn.Location = new System.Drawing.Point(1166, 8);
            this.bt_SignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(112, 40);
            this.bt_SignIn.TabIndex = 5;
            this.bt_SignIn.Text = "Sign in";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            this.bt_SignIn.Click += new System.EventHandler(this.bt_Signin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1062, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(838, 12);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(212, 28);
            this.cb_Category.TabIndex = 3;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.cb_TheLoai_SelectedIndexChanged);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Search.Location = new System.Drawing.Point(717, 8);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(112, 42);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(339, 8);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(367, 39);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_SachOnline
            // 
            this.lb_SachOnline.AutoSize = true;
            this.lb_SachOnline.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SachOnline.ForeColor = System.Drawing.Color.Red;
            this.lb_SachOnline.Location = new System.Drawing.Point(118, 8);
            this.lb_SachOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SachOnline.Name = "lb_SachOnline";
            this.lb_SachOnline.Size = new System.Drawing.Size(187, 41);
            this.lb_SachOnline.TabIndex = 0;
            this.lb_SachOnline.Text = "SachOnline";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.llb_Intro);
            this.panel4.Location = new System.Drawing.Point(19, 864);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1467, 60);
            this.panel4.TabIndex = 4;
            // 
            // llb_Intro
            // 
            this.llb_Intro.AutoSize = true;
            this.llb_Intro.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Intro.Location = new System.Drawing.Point(33, 14);
            this.llb_Intro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_Intro.Name = "llb_Intro";
            this.llb_Intro.Size = new System.Drawing.Size(137, 29);
            this.llb_Intro.TabIndex = 0;
            this.llb_Intro.TabStop = true;
            this.llb_Intro.Text = "Introduction";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flp_P1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1474, 371);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CÓ THỂ BẠN QUAN TÂM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flp_P2);
            this.groupBox2.Location = new System.Drawing.Point(19, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1467, 391);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SÁCH PHỔ BIẾN";
            // 
            // flp_P1
            // 
            this.flp_P1.Location = new System.Drawing.Point(7, 15);
            this.flp_P1.Name = "flp_P1";
            this.flp_P1.Size = new System.Drawing.Size(1454, 340);
            this.flp_P1.TabIndex = 0;
            // 
            // flp_P2
            // 
            this.flp_P2.Location = new System.Drawing.Point(6, 25);
            this.flp_P2.Name = "flp_P2";
            this.flp_P2.Size = new System.Drawing.Size(1448, 353);
            this.flp_P2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1506, 937);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_SignUp;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_SachOnline;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel llb_Intro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flp_P1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flp_P2;
    }
}