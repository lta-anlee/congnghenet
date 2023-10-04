namespace _2001207166_LeThanhAn
{
    partial class Form4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTS_phai = new System.Windows.Forms.ToolStripMenuItem();
            this.BTS_trai = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_A = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_B = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpToolStripMenuItem,
            this.kếtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpToolStripMenuItem
            // 
            this.cậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpToolStripMenuItem,
            this.BTS_phai,
            this.BTS_trai,
            this.xóaHọcViênToolStripMenuItem});
            this.cậpToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cậpToolStripMenuItem.Name = "cậpToolStripMenuItem";
            this.cậpToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.cậpToolStripMenuItem.Text = "Cập nhật";
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.nhậpToolStripMenuItem.Text = "Nhập học viên mới";
            this.nhậpToolStripMenuItem.Click += new System.EventHandler(this.nhậpToolStripMenuItem_Click);
            // 
            // BTS_phai
            // 
            this.BTS_phai.Name = "BTS_phai";
            this.BTS_phai.Size = new System.Drawing.Size(204, 24);
            this.BTS_phai.Text = "Chuyển sang lớp B";
            this.BTS_phai.Click += new System.EventHandler(this.BTS_phai_Click);
            // 
            // BTS_trai
            // 
            this.BTS_trai.Name = "BTS_trai";
            this.BTS_trai.Size = new System.Drawing.Size(204, 24);
            this.BTS_trai.Text = "Chuyển sang lớp A";
            this.BTS_trai.Click += new System.EventHandler(this.BTS_trai_Click);
            // 
            // xóaHọcViênToolStripMenuItem
            // 
            this.xóaHọcViênToolStripMenuItem.Name = "xóaHọcViênToolStripMenuItem";
            this.xóaHọcViênToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.xóaHọcViênToolStripMenuItem.Text = "Xóa học viên";
            // 
            // kếtToolStripMenuItem
            // 
            this.kếtToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kếtToolStripMenuItem.Name = "kếtToolStripMenuItem";
            this.kếtToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.kếtToolStripMenuItem.Text = "&Kết thúc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_A);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lst_A
            // 
            this.lst_A.FormattingEnabled = true;
            this.lst_A.ItemHeight = 17;
            this.lst_A.Items.AddRange(new object[] {
            "Lê Thành An",
            "Mai Ngọc Khang",
            "Huỳnh Gia Thuận"});
            this.lst_A.Location = new System.Drawing.Point(6, 28);
            this.lst_A.Name = "lst_A";
            this.lst_A.Size = new System.Drawing.Size(188, 174);
            this.lst_A.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_B);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(243, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lst_B
            // 
            this.lst_B.FormattingEnabled = true;
            this.lst_B.ItemHeight = 17;
            this.lst_B.Items.AddRange(new object[] {
            "Châu Minh Quân",
            "Phan Chí Cường"});
            this.lst_B.Location = new System.Drawing.Point(7, 28);
            this.lst_B.Name = "lst_B";
            this.lst_B.Size = new System.Drawing.Size(187, 174);
            this.lst_B.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 312);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTS_phai;
        private System.Windows.Forms.ToolStripMenuItem BTS_trai;
        private System.Windows.Forms.ToolStripMenuItem xóaHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_A;
        private System.Windows.Forms.ListBox lst_B;
    }
}