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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_SachOnline = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.llb_Intro = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lb_UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_Category);
            this.panel1.Controls.Add(this.bt_Search);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.lb_SachOnline);
            this.panel1.Location = new System.Drawing.Point(4, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 48);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(944, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(745, 10);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(189, 24);
            this.cb_Category.TabIndex = 3;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Search.Location = new System.Drawing.Point(637, 6);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(100, 33);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(301, 6);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(327, 32);
            this.tb_Search.TabIndex = 1;
            // 
            // lb_SachOnline
            // 
            this.lb_SachOnline.AutoSize = true;
            this.lb_SachOnline.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SachOnline.ForeColor = System.Drawing.Color.Red;
            this.lb_SachOnline.Location = new System.Drawing.Point(128, 9);
            this.lb_SachOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SachOnline.Name = "lb_SachOnline";
            this.lb_SachOnline.Size = new System.Drawing.Size(125, 28);
            this.lb_SachOnline.TabIndex = 0;
            this.lb_SachOnline.Text = "SachOnline";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(1086, 18);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(74, 16);
            this.lb_UserName.TabIndex = 10;
            this.lb_UserName.Text = "UserName";
            // 
            // pn_Main
            // 
            this.pn_Main.Controls.Add(this.groupBox2);
            this.pn_Main.Controls.Add(this.groupBox1);
            this.pn_Main.Location = new System.Drawing.Point(4, 69);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1318, 629);
            this.pn_Main.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Có thể bạn quan tâm";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách phổ biến";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.llb_Intro);
            this.panel4.Location = new System.Drawing.Point(4, 712);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1318, 48);
            this.panel4.TabIndex = 5;
            // 
            // llb_Intro
            // 
            this.llb_Intro.AutoSize = true;
            this.llb_Intro.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_Intro.Location = new System.Drawing.Point(29, 11);
            this.llb_Intro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llb_Intro.Name = "llb_Intro";
            this.llb_Intro.Size = new System.Drawing.Size(89, 19);
            this.llb_Intro.TabIndex = 0;
            this.llb_Intro.TabStop = true;
            this.llb_Intro.Text = "Introduction";
            // 
            // MainFormForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 773);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormForUser";
            this.Text = "MainFormForUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_Main.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label lb_SachOnline;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel llb_Intro;
    }
}