namespace _2001207166_LeThanhAn_Tuan4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radptb2 = new System.Windows.Forms.RadioButton();
            this.radptb1 = new System.Windows.Forms.RadioButton();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_giai = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radptb2);
            this.groupBox1.Controls.Add(this.radptb1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // radptb2
            // 
            this.radptb2.AutoSize = true;
            this.radptb2.Location = new System.Drawing.Point(17, 60);
            this.radptb2.Name = "radptb2";
            this.radptb2.Size = new System.Drawing.Size(160, 22);
            this.radptb2.TabIndex = 1;
            this.radptb2.TabStop = true;
            this.radptb2.Text = "Phương trình bậc hai";
            this.radptb2.UseVisualStyleBackColor = true;
            // 
            // radptb1
            // 
            this.radptb1.AutoSize = true;
            this.radptb1.Location = new System.Drawing.Point(17, 32);
            this.radptb1.Name = "radptb1";
            this.radptb1.Size = new System.Drawing.Size(165, 22);
            this.radptb1.TabIndex = 0;
            this.radptb1.TabStop = true;
            this.radptb1.Text = "Phương trình bật nhất";
            this.radptb1.UseVisualStyleBackColor = true;
            this.radptb1.CheckedChanged += new System.EventHandler(this.radptb1_CheckedChanged);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(56, 238);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(55, 18);
            this.lbla.TabIndex = 2;
            this.lbla.Text = "Nhập a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(56, 292);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(55, 18);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "Nhập b";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Enabled = false;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(56, 345);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(55, 18);
            this.lblc.TabIndex = 4;
            this.lblc.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(117, 236);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(217, 20);
            this.txt_a.TabIndex = 6;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(117, 290);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(217, 20);
            this.txt_b.TabIndex = 7;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_c
            // 
            this.txt_c.Enabled = false;
            this.txt_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_c.Location = new System.Drawing.Point(117, 339);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(217, 24);
            this.txt_c.TabIndex = 8;
            this.txt_c.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(117, 390);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(304, 80);
            this.txt_kq.TabIndex = 9;
            // 
            // btn_giai
            // 
            this.btn_giai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giai.Location = new System.Drawing.Point(349, 236);
            this.btn_giai.Name = "btn_giai";
            this.btn_giai.Size = new System.Drawing.Size(75, 57);
            this.btn_giai.TabIndex = 10;
            this.btn_giai.Text = "Giải";
            this.btn_giai.UseVisualStyleBackColor = true;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(349, 306);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 57);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 517);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_giai);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radptb2;
        private System.Windows.Forms.RadioButton radptb1;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_giai;
        private System.Windows.Forms.Button btn_thoat;
    }
}