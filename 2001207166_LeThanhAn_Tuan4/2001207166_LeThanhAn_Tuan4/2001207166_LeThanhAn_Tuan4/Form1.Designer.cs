namespace _2001207166_LeThanhAn_Tuan4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rdo_cong = new System.Windows.Forms.RadioButton();
            this.rdo_tru = new System.Windows.Forms.RadioButton();
            this.rdo_nhan = new System.Windows.Forms.RadioButton();
            this.rdo_chia = new System.Windows.Forms.RadioButton();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "a=";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(51, 23);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 20);
            this.txt_a.TabIndex = 1;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            this.txt_a.Leave += new System.EventHandler(this.txt_a_Leave);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(204, 23);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(100, 20);
            this.txt_b.TabIndex = 2;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            this.txt_b.Leave += new System.EventHandler(this.txt_b_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết Quả";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 5;
            // 
            // rdo_cong
            // 
            this.rdo_cong.AutoSize = true;
            this.rdo_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_cong.Location = new System.Drawing.Point(51, 118);
            this.rdo_cong.Name = "rdo_cong";
            this.rdo_cong.Size = new System.Drawing.Size(36, 24);
            this.rdo_cong.TabIndex = 6;
            this.rdo_cong.TabStop = true;
            this.rdo_cong.Text = "+";
            this.rdo_cong.UseVisualStyleBackColor = true;
            this.rdo_cong.CheckedChanged += new System.EventHandler(this.btn_cong_CheckedChanged);
            this.rdo_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // rdo_tru
            // 
            this.rdo_tru.AutoSize = true;
            this.rdo_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_tru.Location = new System.Drawing.Point(107, 118);
            this.rdo_tru.Name = "rdo_tru";
            this.rdo_tru.Size = new System.Drawing.Size(32, 24);
            this.rdo_tru.TabIndex = 7;
            this.rdo_tru.TabStop = true;
            this.rdo_tru.Text = "-";
            this.rdo_tru.UseVisualStyleBackColor = true;
            // 
            // rdo_nhan
            // 
            this.rdo_nhan.AutoSize = true;
            this.rdo_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nhan.Location = new System.Drawing.Point(164, 118);
            this.rdo_nhan.Name = "rdo_nhan";
            this.rdo_nhan.Size = new System.Drawing.Size(34, 24);
            this.rdo_nhan.TabIndex = 8;
            this.rdo_nhan.TabStop = true;
            this.rdo_nhan.Text = "x";
            this.rdo_nhan.UseVisualStyleBackColor = true;
            // 
            // rdo_chia
            // 
            this.rdo_chia.AutoSize = true;
            this.rdo_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_chia.Location = new System.Drawing.Point(225, 118);
            this.rdo_chia.Name = "rdo_chia";
            this.rdo_chia.Size = new System.Drawing.Size(31, 24);
            this.rdo_chia.TabIndex = 9;
            this.rdo_chia.TabStop = true;
            this.rdo_chia.Text = "/";
            this.rdo_chia.UseVisualStyleBackColor = true;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinh.Location = new System.Drawing.Point(123, 148);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(75, 28);
            this.btn_tinh.TabIndex = 10;
            this.btn_tinh.Text = "Tính";
            this.btn_tinh.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 192);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.rdo_chia);
            this.Controls.Add(this.rdo_nhan);
            this.Controls.Add(this.rdo_tru);
            this.Controls.Add(this.rdo_cong);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cộng trừ nhân chia Radio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rdo_cong;
        private System.Windows.Forms.RadioButton rdo_tru;
        private System.Windows.Forms.RadioButton rdo_nhan;
        private System.Windows.Forms.RadioButton rdo_chia;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

