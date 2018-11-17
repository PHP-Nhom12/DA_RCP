namespace DA_RapChieuPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLPhong = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLVe = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLyLChieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLTV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLyPhim = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PnThongtin = new System.Windows.Forms.Panel();
            this.btnDNDX = new DevExpress.XtraEditors.SimpleButton();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picHinhNV = new System.Windows.Forms.PictureBox();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.PnThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDoiMK,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnQLNV,
            this.btnQLPhong,
            this.btnQLVe,
            this.btnQLyLChieu,
            this.btnQLTV,
            this.btnThoat,
            this.barButtonItem1,
            this.barButtonItem5,
            this.btnQuanLyPhim});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(754, 147);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi Mật Khẩu";
            this.btnDoiMK.Id = 1;
            this.btnDoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.ImageOptions.Image")));
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Quản lý";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Quản Lý";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnQLNV
            // 
            this.btnQLNV.Caption = "Quản Lý Nhân Viên";
            this.btnQLNV.Id = 5;
            this.btnQLNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLNV.ImageOptions.Image")));
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLNV_ItemClick);
            // 
            // btnQLPhong
            // 
            this.btnQLPhong.Caption = "Quản Lý Phòng";
            this.btnQLPhong.Id = 6;
            this.btnQLPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLPhong.ImageOptions.Image")));
            this.btnQLPhong.Name = "btnQLPhong";
            this.btnQLPhong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLPhong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLPhong_ItemClick);
            // 
            // btnQLVe
            // 
            this.btnQLVe.Caption = "Quản Lý Vé";
            this.btnQLVe.Id = 7;
            this.btnQLVe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLVe.ImageOptions.Image")));
            this.btnQLVe.Name = "btnQLVe";
            this.btnQLVe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLVe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLVe_ItemClick);
            // 
            // btnQLyLChieu
            // 
            this.btnQLyLChieu.Caption = "Quản Lý Lịch Chiếu";
            this.btnQLyLChieu.Id = 8;
            this.btnQLyLChieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLyLChieu.ImageOptions.Image")));
            this.btnQLyLChieu.Name = "btnQLyLChieu";
            this.btnQLyLChieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLyLChieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLyLChieu_ItemClick);
            // 
            // btnQLTV
            // 
            this.btnQLTV.Caption = "Quản Lý Thành Viên";
            this.btnQLTV.Id = 9;
            this.btnQLTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLTV.ImageOptions.Image")));
            this.btnQLTV.Name = "btnQLTV";
            this.btnQLTV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQLTV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLTV_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 10;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thống Kê";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Đặt Vé";
            this.barButtonItem5.Id = 12;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // btnQuanLyPhim
            // 
            this.btnQuanLyPhim.Caption = "Quản Lý Phim";
            this.btnQuanLyPhim.Id = 13;
            this.btnQuanLyPhim.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.btnQuanLyPhim.Name = "btnQuanLyPhim";
            this.btnQuanLyPhim.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLPhong);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLVe);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQuanLyPhim);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLyLChieu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLTV);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức Năng";
            // 
            // PnThongtin
            // 
            this.PnThongtin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnThongtin.Controls.Add(this.btnDNDX);
            this.PnThongtin.Controls.Add(this.lblChucVu);
            this.PnThongtin.Controls.Add(this.lblHoTen);
            this.PnThongtin.Controls.Add(this.label2);
            this.PnThongtin.Controls.Add(this.label1);
            this.PnThongtin.Controls.Add(this.picHinhNV);
            this.PnThongtin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnThongtin.ForeColor = System.Drawing.Color.DarkRed;
            this.PnThongtin.Location = new System.Drawing.Point(0, 147);
            this.PnThongtin.Name = "PnThongtin";
            this.PnThongtin.Size = new System.Drawing.Size(192, 365);
            this.PnThongtin.TabIndex = 1;
            // 
            // btnDNDX
            // 
            this.btnDNDX.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNDX.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDNDX.Appearance.Options.UseFont = true;
            this.btnDNDX.Appearance.Options.UseForeColor = true;
            this.btnDNDX.Location = new System.Drawing.Point(27, 307);
            this.btnDNDX.Name = "btnDNDX";
            this.btnDNDX.Size = new System.Drawing.Size(131, 52);
            this.btnDNDX.TabIndex = 5;
            this.btnDNDX.Text = "simpleButton1";
            this.btnDNDX.Click += new System.EventHandler(this.btnDNDX_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(17, 262);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(55, 18);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "label4";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(20, 193);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(55, 18);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(62, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và Tên";
            // 
            // picHinhNV
            // 
            this.picHinhNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHinhNV.Location = new System.Drawing.Point(27, 17);
            this.picHinhNV.Name = "picHinhNV";
            this.picHinhNV.Size = new System.Drawing.Size(131, 126);
            this.picHinhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhNV.TabIndex = 0;
            this.picHinhNV.TabStop = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.PnThongtin);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Rạp Chiếu Phim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.PnThongtin.ResumeLayout(false);
            this.PnThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel PnThongtin;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.SimpleButton btnDNDX;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picHinhNV;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnQLNV;
        private DevExpress.XtraBars.BarButtonItem btnQLPhong;
        private DevExpress.XtraBars.BarButtonItem btnQLVe;
        private DevExpress.XtraBars.BarButtonItem btnQLyLChieu;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnQLTV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnQuanLyPhim;
    }
}

