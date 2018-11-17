namespace DA_RapChieuPhim
{
    partial class FormDatVe
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
            this.lueVoucher = new DevExpress.XtraEditors.LookUpEdit();
            this.lueGhe = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTenPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTenPhim = new DevExpress.XtraEditors.LookUpEdit();
            this.lueCa = new DevExpress.XtraEditors.LookUpEdit();
            this.lueMaTV = new DevExpress.XtraEditors.LookUpEdit();
            this.chbVoucher = new DevExpress.XtraEditors.CheckEdit();
            this.dateNgay = new DevExpress.XtraEditors.DateEdit();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGhe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaTV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioKetThuc);
            this.groupBox1.Controls.Add(this.txtGioBatDau);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lueVoucher);
            this.groupBox1.Controls.Add(this.lueGhe);
            this.groupBox1.Controls.Add(this.lueTenPhong);
            this.groupBox1.Controls.Add(this.lueTenPhim);
            this.groupBox1.Controls.Add(this.lueCa);
            this.groupBox1.Controls.Add(this.lueMaTV);
            this.groupBox1.Controls.Add(this.chbVoucher);
            this.groupBox1.Controls.Add(this.dateNgay);
            this.groupBox1.Controls.Add(this.btnDatVe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Vé";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lueVoucher
            // 
            this.lueVoucher.Location = new System.Drawing.Point(529, 227);
            this.lueVoucher.Name = "lueVoucher";
            this.lueVoucher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueVoucher.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaVoucher", "Mã Voucher"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenVoucher", "Tên Voucher"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TiLe", "Tỉ Lệ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HanSuDung", "Hạn SD")});
            this.lueVoucher.Properties.NullText = "";
            this.lueVoucher.Size = new System.Drawing.Size(185, 20);
            this.lueVoucher.TabIndex = 22;
            this.lueVoucher.EditValueChanged += new System.EventHandler(this.lueVoucher_EditValueChanged);
            // 
            // lueGhe
            // 
            this.lueGhe.Location = new System.Drawing.Point(144, 350);
            this.lueGhe.Name = "lueGhe";
            this.lueGhe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGhe.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaGhe", "Mã Ghế")});
            this.lueGhe.Properties.NullText = "";
            this.lueGhe.Size = new System.Drawing.Size(185, 20);
            this.lueGhe.TabIndex = 21;
            this.lueGhe.EditValueChanged += new System.EventHandler(this.lueGhe_EditValueChanged_1);
            // 
            // lueTenPhong
            // 
            this.lueTenPhong.Location = new System.Drawing.Point(144, 306);
            this.lueTenPhong.Name = "lueTenPhong";
            this.lueTenPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenPhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhong", "Tên Phòng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SLCho", "Số Ghế")});
            this.lueTenPhong.Properties.NullText = "";
            this.lueTenPhong.Size = new System.Drawing.Size(185, 20);
            this.lueTenPhong.TabIndex = 20;
            this.lueTenPhong.EditValueChanged += new System.EventHandler(this.lueTenPhong_EditValueChanged);
            // 
            // lueTenPhim
            // 
            this.lueTenPhim.Location = new System.Drawing.Point(144, 266);
            this.lueTenPhim.Name = "lueTenPhim";
            this.lueTenPhim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenPhim.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mac", "Mác"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhim", "Tên Phim"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NDPhim", "Mô Tả")});
            this.lueTenPhim.Properties.DisplayFormat.FormatString = "P";
            this.lueTenPhim.Properties.NullText = "";
            this.lueTenPhim.Size = new System.Drawing.Size(185, 20);
            this.lueTenPhim.TabIndex = 19;
            this.lueTenPhim.EditValueChanged += new System.EventHandler(this.lueTenPhim_EditValueChanged);
            // 
            // lueCa
            // 
            this.lueCa.Location = new System.Drawing.Point(144, 224);
            this.lueCa.Name = "lueCa";
            this.lueCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCa", "Tên Ca"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HeSo", "Hệ Số")});
            this.lueCa.Properties.NullText = "";
            this.lueCa.Size = new System.Drawing.Size(185, 20);
            this.lueCa.TabIndex = 18;
            this.lueCa.EditValueChanged += new System.EventHandler(this.lueCa_EditValueChanged_1);
            // 
            // lueMaTV
            // 
            this.lueMaTV.Location = new System.Drawing.Point(529, 190);
            this.lueMaTV.Name = "lueMaTV";
            this.lueMaTV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMaTV.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTV", "Tên Thành Viên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CMND", "CMND"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgaySinh", "Ngày Sinh")});
            this.lueMaTV.Properties.NullText = "";
            this.lueMaTV.Size = new System.Drawing.Size(185, 20);
            this.lueMaTV.TabIndex = 17;
            this.lueMaTV.EditValueChanged += new System.EventHandler(this.lueMaTV_EditValueChanged);
            // 
            // chbVoucher
            // 
            this.chbVoucher.Location = new System.Drawing.Point(434, 224);
            this.chbVoucher.Name = "chbVoucher";
            this.chbVoucher.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.chbVoucher.Properties.Appearance.Options.UseFont = true;
            this.chbVoucher.Properties.Caption = "Voucher";
            this.chbVoucher.Size = new System.Drawing.Size(82, 22);
            this.chbVoucher.TabIndex = 16;
            this.chbVoucher.CheckedChanged += new System.EventHandler(this.chbVoucher_CheckedChanged);
            // 
            // dateNgay
            // 
            this.dateNgay.EditValue = null;
            this.dateNgay.Location = new System.Drawing.Point(144, 190);
            this.dateNgay.Name = "dateNgay";
            this.dateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgay.Size = new System.Drawing.Size(185, 20);
            this.dateNgay.TabIndex = 15;
            this.dateNgay.EditValueChanged += new System.EventHandler(this.dateNgay_EditValueChanged);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(472, 340);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(127, 37);
            this.btnDatVe.TabIndex = 14;
            this.btnDatVe.Text = "In Vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Thành Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giờ Bắt Đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(549, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Giờ Kết Thúc";
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Location = new System.Drawing.Point(419, 287);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(100, 20);
            this.txtGioBatDau.TabIndex = 27;
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(552, 286);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(100, 20);
            this.txtGioKetThuc.TabIndex = 28;
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 512);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatVe";
            this.Text = "Đặt Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGhe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaTV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chbVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatVe;
        private DevExpress.XtraEditors.DateEdit dateNgay;
        private DevExpress.XtraEditors.CheckEdit chbVoucher;
        private DevExpress.XtraEditors.LookUpEdit lueMaTV;
        private DevExpress.XtraEditors.LookUpEdit lueVoucher;
        private DevExpress.XtraEditors.LookUpEdit lueGhe;
        private DevExpress.XtraEditors.LookUpEdit lueTenPhong;
        private DevExpress.XtraEditors.LookUpEdit lueTenPhim;
        private DevExpress.XtraEditors.LookUpEdit lueCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.TextBox txtGioBatDau;
    }
}