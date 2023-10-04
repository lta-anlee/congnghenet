namespace dotnet
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
            this.cbo_hienthi = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.lab_dt = new System.Windows.Forms.Label();
            this.btn_kq = new System.Windows.Forms.Button();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_hienthi
            // 
            this.cbo_hienthi.FormattingEnabled = true;
            this.cbo_hienthi.Location = new System.Drawing.Point(131, 112);
            this.cbo_hienthi.Name = "cbo_hienthi";
            this.cbo_hienthi.Size = new System.Drawing.Size(121, 21);
            this.cbo_hienthi.TabIndex = 1;
            this.cbo_hienthi.SelectedIndexChanged += new System.EventHandler(this.cbo_hienthi_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(40, 51);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(212, 34);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load dữ liệu lên Combobox";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lab_dt
            // 
            this.lab_dt.AutoSize = true;
            this.lab_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_dt.Location = new System.Drawing.Point(56, 113);
            this.lab_dt.Name = "lab_dt";
            this.lab_dt.Size = new System.Drawing.Size(69, 20);
            this.lab_dt.TabIndex = 3;
            this.lab_dt.Text = "Dân Tộc";
            // 
            // btn_kq
            // 
            this.btn_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kq.Location = new System.Drawing.Point(172, 160);
            this.btn_kq.Name = "btn_kq";
            this.btn_kq.Size = new System.Drawing.Size(75, 38);
            this.btn_kq.TabIndex = 5;
            this.btn_kq.Text = "Kết quả";
            this.btn_kq.UseVisualStyleBackColor = true;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hienthi.Location = new System.Drawing.Point(81, 160);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 38);
            this.btn_hienthi.TabIndex = 6;
            this.btn_hienthi.Text = "Hiển Thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 249);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.btn_kq);
            this.Controls.Add(this.lab_dt);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cbo_hienthi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_hienthi;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lab_dt;
        private System.Windows.Forms.Button btn_ht;
        private System.Windows.Forms.Button btn_kq;
        private System.Windows.Forms.Button btn_hienthi;

    }
}

