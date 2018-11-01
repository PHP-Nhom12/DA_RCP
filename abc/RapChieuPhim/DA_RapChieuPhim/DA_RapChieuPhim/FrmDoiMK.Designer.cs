namespace DA_RapChieuPhim
{
    partial class FormDoiMK
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(169, 116);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(234, 20);
            this.txtMKC.TabIndex = 3;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(169, 73);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(234, 20);
            this.txtMKM.TabIndex = 4;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(188, 165);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(119, 44);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMKC);
            this.groupBox1.Controls.Add(this.txtMKM);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 277);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi Mật Khẩu";
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 312);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoiMK";
            this.Text = "FrmDoiMK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}