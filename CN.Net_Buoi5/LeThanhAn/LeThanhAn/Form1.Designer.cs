﻿namespace LeThanhAn
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
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_t = new System.Windows.Forms.Button();
            this.btn_n = new System.Windows.Forms.Button();
            this.btn_ch = new System.Windows.Forms.Button();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(12, 156);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(75, 23);
            this.btn_c.TabIndex = 0;
            this.btn_c.Text = "+";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_t
            // 
            this.btn_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_t.Location = new System.Drawing.Point(93, 156);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(75, 23);
            this.btn_t.TabIndex = 1;
            this.btn_t.Text = "-";
            this.btn_t.UseVisualStyleBackColor = true;
            // 
            // btn_n
            // 
            this.btn_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n.Location = new System.Drawing.Point(174, 156);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(75, 23);
            this.btn_n.TabIndex = 2;
            this.btn_n.Text = "*";
            this.btn_n.UseVisualStyleBackColor = true;
            // 
            // btn_ch
            // 
            this.btn_ch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ch.Location = new System.Drawing.Point(255, 156);
            this.btn_ch.Name = "btn_ch";
            this.btn_ch.Size = new System.Drawing.Size(75, 23);
            this.btn_ch.TabIndex = 3;
            this.btn_ch.Text = "/";
            this.btn_ch.UseVisualStyleBackColor = true;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a.Location = new System.Drawing.Point(12, 34);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(19, 20);
            this.lbl_a.TabIndex = 4;
            this.lbl_a.Text = "a";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_b.Location = new System.Drawing.Point(12, 65);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(19, 20);
            this.lbl_b.TabIndex = 5;
            this.lbl_b.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết Quả";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(93, 31);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(201, 26);
            this.txt_a.TabIndex = 8;
            this.txt_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(93, 63);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(201, 26);
            this.txt_b.TabIndex = 8;
            // 
            // txt_kq
            // 
            this.txt_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kq.Location = new System.Drawing.Point(93, 95);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(201, 26);
            this.txt_kq.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 222);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.btn_ch);
            this.Controls.Add(this.btn_n);
            this.Controls.Add(this.btn_t);
            this.Controls.Add(this.btn_c);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Button btn_ch;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_kq;
    }
}
