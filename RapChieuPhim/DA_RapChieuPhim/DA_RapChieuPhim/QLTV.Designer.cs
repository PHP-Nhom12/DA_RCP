namespace DA_RapChieuPhim
{
    partial class QLTV
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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.dtNS = new DevExpress.XtraEditors.DateEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTV = new DevExpress.XtraEditors.TextEdit();
            this.gcThanhVien = new DevExpress.XtraGrid.GridControl();
            this.gvThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColTenTVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLoaiTv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LUpLoaiTV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColCMNDan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColMaTV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpLoaiTV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lookUpEdit1);
            this.groupBox1.Controls.Add(this.dtNS);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtTenTV);
            this.groupBox1.Controls.Add(this.gcThanhVien);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.BtnThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Thành Viên";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(153, 77);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(202, 20);
            this.lookUpEdit1.TabIndex = 19;
            // 
            // dtNS
            // 
            this.dtNS.EditValue = null;
            this.dtNS.Location = new System.Drawing.Point(465, 77);
            this.dtNS.Name = "dtNS";
            this.dtNS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNS.Size = new System.Drawing.Size(202, 20);
            this.dtNS.TabIndex = 18;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(465, 34);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(202, 20);
            this.txtCMND.TabIndex = 16;
            // 
            // txtTenTV
            // 
            this.txtTenTV.Location = new System.Drawing.Point(153, 34);
            this.txtTenTV.Name = "txtTenTV";
            this.txtTenTV.Size = new System.Drawing.Size(202, 20);
            this.txtTenTV.TabIndex = 15;
            // 
            // gcThanhVien
            // 
            this.gcThanhVien.Location = new System.Drawing.Point(6, 194);
            this.gcThanhVien.MainView = this.gvThanhVien;
            this.gcThanhVien.Name = "gcThanhVien";
            this.gcThanhVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LUpLoaiTV});
            this.gcThanhVien.Size = new System.Drawing.Size(728, 227);
            this.gcThanhVien.TabIndex = 14;
            this.gcThanhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThanhVien});
            this.gcThanhVien.DoubleClick += new System.EventHandler(this.gcThanhVien_DoubleClick);
            // 
            // gvThanhVien
            // 
            this.gvThanhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColMaTV,
            this.ColTenTVien,
            this.ColLoaiTv,
            this.ColCMNDan,
            this.ColNS});
            this.gvThanhVien.GridControl = this.gcThanhVien;
            this.gvThanhVien.Name = "gvThanhVien";
            // 
            // ColTenTVien
            // 
            this.ColTenTVien.Caption = "Tên Thành Viên";
            this.ColTenTVien.FieldName = "TenTV";
            this.ColTenTVien.Name = "ColTenTVien";
            this.ColTenTVien.Visible = true;
            this.ColTenTVien.VisibleIndex = 1;
            // 
            // ColLoaiTv
            // 
            this.ColLoaiTv.Caption = "Loại Thành Viên";
            this.ColLoaiTv.ColumnEdit = this.LUpLoaiTV;
            this.ColLoaiTv.FieldName = "LoaiTV";
            this.ColLoaiTv.Name = "ColLoaiTv";
            this.ColLoaiTv.Visible = true;
            this.ColLoaiTv.VisibleIndex = 2;
            // 
            // LUpLoaiTV
            // 
            this.LUpLoaiTV.AutoHeight = false;
            this.LUpLoaiTV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUpLoaiTV.DisplayMember = "TenLoai";
            this.LUpLoaiTV.Name = "LUpLoaiTV";
            this.LUpLoaiTV.ValueMember = "MaLoai";
            // 
            // ColCMNDan
            // 
            this.ColCMNDan.Caption = "CMND";
            this.ColCMNDan.FieldName = "CMND";
            this.ColCMNDan.Name = "ColCMNDan";
            this.ColCMNDan.Visible = true;
            this.ColCMNDan.VisibleIndex = 3;
            // 
            // ColNS
            // 
            this.ColNS.Caption = "Ngày Sinh";
            this.ColNS.FieldName = "NgaySinh";
            this.ColNS.Name = "ColNS";
            this.ColNS.Visible = true;
            this.ColNS.VisibleIndex = 4;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(568, 132);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 35);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(467, 132);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.Appearance.Options.UseFont = true;
            this.BtnThem.Location = new System.Drawing.Point(365, 132);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 35);
            this.BtnThem.TabIndex = 9;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Thành Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Thành Viên";
            // 
            // ColMaTV
            // 
            this.ColMaTV.Caption = "Mã Thành Viên";
            this.ColMaTV.FieldName = "MaTV";
            this.ColMaTV.Name = "ColMaTV";
            this.ColMaTV.Visible = true;
            this.ColMaTV.VisibleIndex = 0;
            // 
            // QLTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 451);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLTV";
            this.Text = "QLTV";
            this.Load += new System.EventHandler(this.QLTV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpLoaiTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.DateEdit dtNS;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtTenTV;
        private DevExpress.XtraGrid.GridControl gcThanhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenTVien;
        private DevExpress.XtraGrid.Columns.GridColumn ColLoaiTv;
        private DevExpress.XtraGrid.Columns.GridColumn ColCMNDan;
        private DevExpress.XtraGrid.Columns.GridColumn ColNS;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LUpLoaiTV;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaTV;
    }
}