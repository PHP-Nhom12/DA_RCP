namespace DA_RapChieuPhim
{
    partial class FormThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPhim = new System.Windows.Forms.RadioButton();
            this.rdbNV = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbGiaVeTheoSuat = new System.Windows.Forms.RadioButton();
            this.rdbLuongNV = new System.Windows.Forms.RadioButton();
            this.rdbVe = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rdbPhim);
            this.groupBox1.Controls.Add(this.rdbNV);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdbGiaVeTheoSuat);
            this.groupBox1.Controls.Add(this.rdbLuongNV);
            this.groupBox1.Controls.Add(this.rdbVe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // rdbPhim
            // 
            this.rdbPhim.AutoSize = true;
            this.rdbPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPhim.Location = new System.Drawing.Point(44, 105);
            this.rdbPhim.Name = "rdbPhim";
            this.rdbPhim.Size = new System.Drawing.Size(152, 24);
            this.rdbPhim.TabIndex = 5;
            this.rdbPhim.TabStop = true;
            this.rdbPhim.Text = "Thống Kế  Phim\r\n";
            this.rdbPhim.UseVisualStyleBackColor = true;
            // 
            // rdbNV
            // 
            this.rdbNV.AutoSize = true;
            this.rdbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNV.Location = new System.Drawing.Point(44, 75);
            this.rdbNV.Name = "rdbNV";
            this.rdbNV.Size = new System.Drawing.Size(196, 24);
            this.rdbNV.TabIndex = 4;
            this.rdbNV.TabStop = true;
            this.rdbNV.Text = "Thống Kế  Nhân Viên";
            this.rdbNV.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xem Báo Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbGiaVeTheoSuat
            // 
            this.rdbGiaVeTheoSuat.AutoSize = true;
            this.rdbGiaVeTheoSuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGiaVeTheoSuat.Location = new System.Drawing.Point(44, 165);
            this.rdbGiaVeTheoSuat.Name = "rdbGiaVeTheoSuat";
            this.rdbGiaVeTheoSuat.Size = new System.Drawing.Size(251, 24);
            this.rdbGiaVeTheoSuat.TabIndex = 2;
            this.rdbGiaVeTheoSuat.TabStop = true;
            this.rdbGiaVeTheoSuat.Text = "Thống Kế Giá Vé Theo Suất";
            this.rdbGiaVeTheoSuat.UseVisualStyleBackColor = true;
            // 
            // rdbLuongNV
            // 
            this.rdbLuongNV.AutoSize = true;
            this.rdbLuongNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLuongNV.Location = new System.Drawing.Point(44, 135);
            this.rdbLuongNV.Name = "rdbLuongNV";
            this.rdbLuongNV.Size = new System.Drawing.Size(246, 24);
            this.rdbLuongNV.TabIndex = 1;
            this.rdbLuongNV.TabStop = true;
            this.rdbLuongNV.Text = "Thống Kế Lương Nhân Viên";
            this.rdbLuongNV.UseVisualStyleBackColor = true;
            // 
            // rdbVe
            // 
            this.rdbVe.AutoSize = true;
            this.rdbVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVe.Location = new System.Drawing.Point(44, 45);
            this.rdbVe.Name = "rdbVe";
            this.rdbVe.Size = new System.Drawing.Size(130, 24);
            this.rdbVe.TabIndex = 0;
            this.rdbVe.TabStop = true;
            this.rdbVe.Text = "Thống Kế Vé";
            this.rdbVe.UseVisualStyleBackColor = true;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 292);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbGiaVeTheoSuat;
        private System.Windows.Forms.RadioButton rdbLuongNV;
        private System.Windows.Forms.RadioButton rdbVe;
        private System.Windows.Forms.RadioButton rdbPhim;
        private System.Windows.Forms.RadioButton rdbNV;
    }
}