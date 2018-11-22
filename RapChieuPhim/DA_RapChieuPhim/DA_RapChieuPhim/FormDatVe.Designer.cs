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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatVe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbThoiLuong = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbDaoDien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNamSX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTheLoai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbNhaSX = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNDPhim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongThanhToan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvDSGhe = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvDSPhim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.lueVoucher = new DevExpress.XtraEditors.LookUpEdit();
            this.lueMaTV = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imlChair = new System.Windows.Forms.ImageList();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaTV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbTongThanhToan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvDSGhe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lvDSPhim);
            this.groupBox1.Controls.Add(this.cbbNgay);
            this.groupBox1.Controls.Add(this.lueVoucher);
            this.groupBox1.Controls.Add(this.lueMaTV);
            this.groupBox1.Controls.Add(this.btnDatVe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đặt Vé";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbThoiLuong);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lbDaoDien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbNamSX);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbTheLoai);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbNhaSX);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbNDPhim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(352, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 128);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết Phim";
            // 
            // lbThoiLuong
            // 
            this.lbThoiLuong.AutoSize = true;
            this.lbThoiLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiLuong.Location = new System.Drawing.Point(623, 96);
            this.lbThoiLuong.Name = "lbThoiLuong";
            this.lbThoiLuong.Size = new System.Drawing.Size(116, 18);
            this.lbThoiLuong.TabIndex = 50;
            this.lbThoiLuong.Text = "Chưa chọn phim";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(533, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "Thể loại:";
            // 
            // lbDaoDien
            // 
            this.lbDaoDien.AutoSize = true;
            this.lbDaoDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaoDien.Location = new System.Drawing.Point(623, 64);
            this.lbDaoDien.Name = "lbDaoDien";
            this.lbDaoDien.Size = new System.Drawing.Size(116, 18);
            this.lbDaoDien.TabIndex = 48;
            this.lbDaoDien.Text = "Chưa chọn phim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(514, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "Thời lượng:";
            // 
            // lbNamSX
            // 
            this.lbNamSX.AutoSize = true;
            this.lbNamSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamSX.Location = new System.Drawing.Point(158, 64);
            this.lbNamSX.Name = "lbNamSX";
            this.lbNamSX.Size = new System.Drawing.Size(116, 18);
            this.lbNamSX.TabIndex = 46;
            this.lbNamSX.Text = "Chưa chọn phim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "Năm sản xuất:";
            // 
            // lbTheLoai
            // 
            this.lbTheLoai.AutoSize = true;
            this.lbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheLoai.Location = new System.Drawing.Point(623, 33);
            this.lbTheLoai.Name = "lbTheLoai";
            this.lbTheLoai.Size = new System.Drawing.Size(116, 18);
            this.lbTheLoai.TabIndex = 44;
            this.lbTheLoai.Text = "Chưa chọn phim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 18);
            this.label13.TabIndex = 43;
            this.label13.Text = "Nhà sản xuất:";
            // 
            // lbNhaSX
            // 
            this.lbNhaSX.AutoSize = true;
            this.lbNhaSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaSX.Location = new System.Drawing.Point(158, 96);
            this.lbNhaSX.Name = "lbNhaSX";
            this.lbNhaSX.Size = new System.Drawing.Size(116, 18);
            this.lbNhaSX.TabIndex = 42;
            this.lbNhaSX.Text = "Chưa chọn phim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(523, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 41;
            this.label10.Text = "Đạo Diễn:";
            // 
            // lbNDPhim
            // 
            this.lbNDPhim.AutoSize = true;
            this.lbNDPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNDPhim.Location = new System.Drawing.Point(158, 33);
            this.lbNDPhim.Name = "lbNDPhim";
            this.lbNDPhim.Size = new System.Drawing.Size(116, 18);
            this.lbNDPhim.TabIndex = 40;
            this.lbNDPhim.Text = "Chưa chọn phim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nội Dung Phim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(375, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Chọn Ghế";
            // 
            // lbTongThanhToan
            // 
            this.lbTongThanhToan.AutoSize = true;
            this.lbTongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThanhToan.ForeColor = System.Drawing.Color.Red;
            this.lbTongThanhToan.Location = new System.Drawing.Point(892, 491);
            this.lbTongThanhToan.Name = "lbTongThanhToan";
            this.lbTongThanhToan.Size = new System.Drawing.Size(31, 18);
            this.lbTongThanhToan.TabIndex = 36;
            this.lbTongThanhToan.Text = "0 đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(722, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tổng Thanh Toán: ";
            // 
            // lvDSGhe
            // 
            this.lvDSGhe.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDSGhe.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvDSGhe.FullRowSelect = true;
            this.lvDSGhe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvDSGhe.HideSelection = false;
            this.lvDSGhe.Location = new System.Drawing.Point(352, 112);
            this.lvDSGhe.Name = "lvDSGhe";
            this.lvDSGhe.Size = new System.Drawing.Size(808, 230);
            this.lvDSGhe.SmallImageList = this.imlChair;
            this.lvDSGhe.TabIndex = 34;
            this.lvDSGhe.UseCompatibleStateImageBehavior = false;
            this.lvDSGhe.View = System.Windows.Forms.View.SmallIcon;
            this.lvDSGhe.SelectedIndexChanged += new System.EventHandler(this.lvDSGhe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chọn Phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(830, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Voucher";
            // 
            // lvDSPhim
            // 
            this.lvDSPhim.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDSPhim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.lvDSPhim.FullRowSelect = true;
            this.lvDSPhim.GridLines = true;
            this.lvDSPhim.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDSPhim.HideSelection = false;
            this.lvDSPhim.Location = new System.Drawing.Point(29, 112);
            this.lvDSPhim.MultiSelect = false;
            this.lvDSPhim.Name = "lvDSPhim";
            this.lvDSPhim.Size = new System.Drawing.Size(314, 397);
            this.lvDSPhim.TabIndex = 30;
            this.lvDSPhim.UseCompatibleStateImageBehavior = false;
            this.lvDSPhim.View = System.Windows.Forms.View.Details;
            this.lvDSPhim.SelectedIndexChanged += new System.EventHandler(this.lvDSPhim_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mác";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BĐ";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KT";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Ghế";
            this.columnHeader6.Width = 50;
            // 
            // cbbNgay
            // 
            this.cbbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgay.FormattingEnabled = true;
            this.cbbNgay.Location = new System.Drawing.Point(78, 41);
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.Size = new System.Drawing.Size(251, 24);
            this.cbbNgay.TabIndex = 29;
            this.cbbNgay.SelectedIndexChanged += new System.EventHandler(this.cbbNgay_SelectedIndexChanged);
            // 
            // lueVoucher
            // 
            this.lueVoucher.Location = new System.Drawing.Point(906, 42);
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
            // lueMaTV
            // 
            this.lueMaTV.Location = new System.Drawing.Point(566, 42);
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
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatVe.Location = new System.Drawing.Point(1033, 482);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(127, 37);
            this.btnDatVe.TabIndex = 14;
            this.btnDatVe.Text = "Đặt Vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(441, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã Thành Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(26, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày";
            // 
            // imlChair
            // 
            this.imlChair.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlChair.ImageStream")));
            this.imlChair.TransparentColor = System.Drawing.Color.Transparent;
            this.imlChair.Images.SetKeyName(0, "seat.png");
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 539);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatVe";
            this.Text = "Đặt Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaTV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDatVe;
        private DevExpress.XtraEditors.LookUpEdit lueMaTV;
        private DevExpress.XtraEditors.LookUpEdit lueVoucher;
        private System.Windows.Forms.ComboBox cbbNgay;
        private System.Windows.Forms.Label lbTongThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvDSGhe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvDSPhim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNamSX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTheLoai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbNhaSX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNDPhim;
        private System.Windows.Forms.Label lbThoiLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbDaoDien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imlChair;
    }
}