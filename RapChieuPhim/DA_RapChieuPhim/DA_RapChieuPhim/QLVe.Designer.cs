namespace DA_RapChieuPhim
{
    partial class QLVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLVe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radTenThanhVien = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQuery = new DevExpress.XtraEditors.TextEdit();
            this.radTenPhong = new System.Windows.Forms.RadioButton();
            this.radTenPhim = new System.Windows.Forms.RadioButton();
            this.gcVe = new DevExpress.XtraGrid.GridControl();
            this.gvVe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColTenPhim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUpTenPhim = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColTGBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTGKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUpTenPhong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColGiaVe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenTV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUPTenTV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColMaVe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPTenTV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.radTatCa);
            this.groupBox1.Controls.Add(this.radTenThanhVien);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtQuery);
            this.groupBox1.Controls.Add(this.radTenPhong);
            this.groupBox1.Controls.Add(this.radTenPhim);
            this.groupBox1.Controls.Add(this.gcVe);
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1043, 529);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Vé";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(808, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 39);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(61, 91);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(99, 29);
            this.radTatCa.TabIndex = 8;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // radTenThanhVien
            // 
            this.radTenThanhVien.AutoSize = true;
            this.radTenThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenThanhVien.Location = new System.Drawing.Point(377, 91);
            this.radTenThanhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTenThanhVien.Name = "radTenThanhVien";
            this.radTenThanhVien.Size = new System.Drawing.Size(189, 29);
            this.radTenThanhVien.TabIndex = 6;
            this.radTenThanhVien.Text = "Tên Thành Viên";
            this.radTenThanhVien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(884, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa Vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(39, 55);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Properties.Appearance.Options.UseFont = true;
            this.txtQuery.Size = new System.Drawing.Size(735, 30);
            this.txtQuery.TabIndex = 4;
          
            // 
            // radTenPhong
            // 
            this.radTenPhong.AutoSize = true;
            this.radTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenPhong.Location = new System.Drawing.Point(199, 91);
            this.radTenPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTenPhong.Name = "radTenPhong";
            this.radTenPhong.Size = new System.Drawing.Size(139, 29);
            this.radTenPhong.TabIndex = 2;
            this.radTenPhong.Text = "Tên Phòng";
            this.radTenPhong.UseVisualStyleBackColor = true;
            // 
            // radTenPhim
            // 
            this.radTenPhim.AutoSize = true;
            this.radTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenPhim.Location = new System.Drawing.Point(609, 91);
            this.radTenPhim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radTenPhim.Name = "radTenPhim";
            this.radTenPhim.Size = new System.Drawing.Size(125, 29);
            this.radTenPhim.TabIndex = 1;
            this.radTenPhim.Text = "Tên Phim";
            this.radTenPhim.UseVisualStyleBackColor = true;
            // 
            // gcVe
            // 
            this.gcVe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcVe.Location = new System.Drawing.Point(0, 162);
            this.gcVe.MainView = this.gvVe;
            this.gcVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcVe.Name = "gcVe";
            this.gcVe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lUpTenPhong,
            this.lUPTenTV,
            this.lUpTenPhim});
            this.gcVe.Size = new System.Drawing.Size(1043, 304);
            this.gcVe.TabIndex = 0;
            this.gcVe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVe});
            // 
            // gvVe
            // 
            this.gvVe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gvVe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColTenPhim,
            this.ColTGBatDau,
            this.ColTGKetThuc,
            this.ColViTri,
            this.ColPhong,
            this.ColGiaVe,
            this.ColTenTV,
            this.ColMaVe});
            this.gvVe.GridControl = this.gcVe;
            this.gvVe.Name = "gvVe";
            this.gvVe.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVe.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvVe.OptionsBehavior.Editable = false;
            this.gvVe.OptionsBehavior.ReadOnly = true;
            this.gvVe.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvVe.OptionsView.ShowGroupPanel = false;
            this.gvVe.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvVe_RowClick);
            // 
            // ColTenPhim
            // 
            this.ColTenPhim.Caption = "Tên Phim";
            this.ColTenPhim.ColumnEdit = this.lUpTenPhim;
            this.ColTenPhim.FieldName = "MaPhim";
            this.ColTenPhim.Name = "ColTenPhim";
            this.ColTenPhim.Visible = true;
            this.ColTenPhim.VisibleIndex = 0;
            this.ColTenPhim.Width = 176;
            // 
            // lUpTenPhim
            // 
            this.lUpTenPhim.AutoHeight = false;
            this.lUpTenPhim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUpTenPhim.DisplayMember = "TenPhim";
            this.lUpTenPhim.Name = "lUpTenPhim";
            this.lUpTenPhim.ValueMember = "MaPhim";
            // 
            // ColTGBatDau
            // 
            this.ColTGBatDau.Caption = "TGBĐ";
            this.ColTGBatDau.FieldName = "TGBatDau";
            this.ColTGBatDau.Name = "ColTGBatDau";
            this.ColTGBatDau.Visible = true;
            this.ColTGBatDau.VisibleIndex = 1;
            this.ColTGBatDau.Width = 40;
            // 
            // ColTGKetThuc
            // 
            this.ColTGKetThuc.Caption = "TGKT";
            this.ColTGKetThuc.FieldName = "TGKetThuc";
            this.ColTGKetThuc.Name = "ColTGKetThuc";
            this.ColTGKetThuc.Visible = true;
            this.ColTGKetThuc.VisibleIndex = 2;
            this.ColTGKetThuc.Width = 42;
            // 
            // ColViTri
            // 
            this.ColViTri.Caption = "Vị Trí";
            this.ColViTri.FieldName = "ViTriNgoi";
            this.ColViTri.Name = "ColViTri";
            this.ColViTri.Visible = true;
            this.ColViTri.VisibleIndex = 4;
            this.ColViTri.Width = 42;
            // 
            // ColPhong
            // 
            this.ColPhong.Caption = "Phòng";
            this.ColPhong.ColumnEdit = this.lUpTenPhong;
            this.ColPhong.FieldName = "PhongChieu";
            this.ColPhong.Name = "ColPhong";
            this.ColPhong.Visible = true;
            this.ColPhong.VisibleIndex = 3;
            this.ColPhong.Width = 117;
            // 
            // lUpTenPhong
            // 
            this.lUpTenPhong.AutoHeight = false;
            this.lUpTenPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUpTenPhong.DisplayMember = "TenPhong";
            this.lUpTenPhong.Name = "lUpTenPhong";
            this.lUpTenPhong.ValueMember = "MaPhong";
            // 
            // ColGiaVe
            // 
            this.ColGiaVe.Caption = "Giá Vé";
            this.ColGiaVe.FieldName = "GiaVe";
            this.ColGiaVe.Name = "ColGiaVe";
            this.ColGiaVe.Visible = true;
            this.ColGiaVe.VisibleIndex = 6;
            this.ColGiaVe.Width = 73;
            // 
            // ColTenTV
            // 
            this.ColTenTV.Caption = "Tên Thành Viên";
            this.ColTenTV.ColumnEdit = this.lUPTenTV;
            this.ColTenTV.FieldName = "MaTV";
            this.ColTenTV.Name = "ColTenTV";
            this.ColTenTV.Visible = true;
            this.ColTenTV.VisibleIndex = 5;
            this.ColTenTV.Width = 149;
            // 
            // lUPTenTV
            // 
            this.lUPTenTV.AutoHeight = false;
            this.lUPTenTV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUPTenTV.DisplayMember = "TenTV";
            this.lUPTenTV.Name = "lUPTenTV";
            this.lUPTenTV.ValueMember = "MaTV";
            // 
            // ColMaVe
            // 
            this.ColMaVe.Caption = "Mã Vé";
            this.ColMaVe.FieldName = "MaVe";
            this.ColMaVe.Name = "ColMaVe";
            // 
            // QLVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 545);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLVe";
            this.Text = "Quản Lý Vé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPTenTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radTenThanhVien;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtQuery;
        private System.Windows.Forms.RadioButton radTenPhong;
        private System.Windows.Forms.RadioButton radTenPhim;
        private DevExpress.XtraGrid.GridControl gcVe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVe;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenPhim;
        private DevExpress.XtraGrid.Columns.GridColumn ColPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColGiaVe;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenTV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUpTenPhong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUPTenTV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUpTenPhim;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaVe;
        private DevExpress.XtraGrid.Columns.GridColumn ColTGBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn ColTGKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn ColViTri;
    }
}