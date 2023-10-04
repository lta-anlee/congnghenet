namespace Form1
{
    partial class Form1
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
            this.list_trai = new System.Windows.Forms.ListBox();
            this.list_phai = new System.Windows.Forms.ListBox();
            this.btn_p = new System.Windows.Forms.Button();
            this.btn_hp = new System.Windows.Forms.Button();
            this.btn_t = new System.Windows.Forms.Button();
            this.btn_ht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_trai
            // 
            this.list_trai.FormattingEnabled = true;
            this.list_trai.Items.AddRange(new object[] {
            "Cốc",
            "Ổi",
            "Xoài",
            "Me",
            "Mận",
            "Cam",
            "Quýt"});
            this.list_trai.Location = new System.Drawing.Point(29, 26);
            this.list_trai.Name = "list_trai";
            this.list_trai.Size = new System.Drawing.Size(120, 212);
            this.list_trai.TabIndex = 0;
            // 
            // list_phai
            // 
            this.list_phai.FormattingEnabled = true;
            this.list_phai.Location = new System.Drawing.Point(236, 26);
            this.list_phai.Name = "list_phai";
            this.list_phai.Size = new System.Drawing.Size(120, 212);
            this.list_phai.TabIndex = 0;
            // 
            // btn_p
            // 
            this.btn_p.Location = new System.Drawing.Point(155, 41);
            this.btn_p.Name = "btn_p";
            this.btn_p.Size = new System.Drawing.Size(75, 23);
            this.btn_p.TabIndex = 1;
            this.btn_p.Text = ">";
            this.btn_p.UseVisualStyleBackColor = true;
            this.btn_p.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_hp
            // 
            this.btn_hp.Location = new System.Drawing.Point(155, 93);
            this.btn_hp.Name = "btn_hp";
            this.btn_hp.Size = new System.Drawing.Size(75, 23);
            this.btn_hp.TabIndex = 1;
            this.btn_hp.Text = ">>";
            this.btn_hp.UseVisualStyleBackColor = true;
            this.btn_hp.Click += new System.EventHandler(this.btn_hp_Click);
            // 
            // btn_t
            // 
            this.btn_t.Location = new System.Drawing.Point(155, 144);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(75, 23);
            this.btn_t.TabIndex = 1;
            this.btn_t.Text = "<";
            this.btn_t.UseVisualStyleBackColor = true;
            this.btn_t.Click += new System.EventHandler(this.btn_t_Click);
            // 
            // btn_ht
            // 
            this.btn_ht.Location = new System.Drawing.Point(155, 203);
            this.btn_ht.Name = "btn_ht";
            this.btn_ht.Size = new System.Drawing.Size(75, 23);
            this.btn_ht.TabIndex = 1;
            this.btn_ht.Text = "<<";
            this.btn_ht.UseVisualStyleBackColor = true;
            this.btn_ht.Click += new System.EventHandler(this.btn_ht_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 321);
            this.Controls.Add(this.btn_ht);
            this.Controls.Add(this.btn_t);
            this.Controls.Add(this.btn_hp);
            this.Controls.Add(this.btn_p);
            this.Controls.Add(this.list_phai);
            this.Controls.Add(this.list_trai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_trai;
        private System.Windows.Forms.ListBox list_phai;
        private System.Windows.Forms.Button btn_p;
        private System.Windows.Forms.Button btn_hp;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.Button btn_ht;
    }
}

