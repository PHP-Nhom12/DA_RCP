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
            this.ColVitri = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 430);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Vé";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(606, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 32);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(46, 74);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(80, 24);
            this.radTatCa.TabIndex = 8;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // radTenThanhVien
            // 
            this.radTenThanhVien.AutoSize = true;
            this.radTenThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenThanhVien.Location = new System.Drawing.Point(283, 74);
            this.radTenThanhVien.Name = "radTenThanhVien";
            this.radTenThanhVien.Size = new System.Drawing.Size(153, 24);
            this.radTenThanhVien.TabIndex = 6;
            this.radTenThanhVien.Text = "Tên Thành Viên";
            this.radTenThanhVien.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa Vé";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(29, 45);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.Properties.Appearance.Options.UseFont = true;
            this.txtQuery.Size = new System.Drawing.Size(551, 24);
            this.txtQuery.TabIndex = 4;
            // 
            // radTenPhong
            // 
            this.radTenPhong.AutoSize = true;
            this.radTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenPhong.Location = new System.Drawing.Point(149, 74);
            this.radTenPhong.Name = "radTenPhong";
            this.radTenPhong.Size = new System.Drawing.Size(113, 24);
            this.radTenPhong.TabIndex = 2;
            this.radTenPhong.Text = "Tên Phòng";
            this.radTenPhong.UseVisualStyleBackColor = true;
            // 
            // radTenPhim
            // 
            this.radTenPhim.AutoSize = true;
            this.radTenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTenPhim.Location = new System.Drawing.Point(457, 74);
            this.radTenPhim.Name = "radTenPhim";
            this.radTenPhim.Size = new System.Drawing.Size(101, 24);
            this.radTenPhim.TabIndex = 1;
            this.radTenPhim.Text = "Tên Phim";
            this.radTenPhim.UseVisualStyleBackColor = true;
            // 
            // gcVe
            // 
            this.gcVe.Location = new System.Drawing.Point(0, 132);
            this.gcVe.MainView = this.gvVe;
            this.gcVe.Name = "gcVe";
            this.gcVe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lUpTenPhong,
            this.lUPTenTV,
            this.lUpTenPhim});
            this.gcVe.Size = new System.Drawing.Size(782, 247);
            this.gcVe.TabIndex = 0;
            this.gcVe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVe});
            // 
            // gvVe
            // 
            this.gvVe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColTenPhim,
            this.ColVitri,
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
            // ColVitri
            // 
            this.ColVitri.Caption = "Ghế Ngồi";
            this.ColVitri.FieldName = "ViTriNgoi";
            this.ColVitri.Name = "ColVitri";
            this.ColVitri.Visible = true;
            this.ColVitri.VisibleIndex = 1;
            // 
            // ColPhong
            // 
            this.ColPhong.Caption = "Phòng";
            this.ColPhong.ColumnEdit = this.lUpTenPhong;
            this.ColPhong.FieldName = "PhongChieu";
            this.ColPhong.Name = "ColPhong";
            this.ColPhong.Visible = true;
            this.ColPhong.VisibleIndex = 2;
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
            this.ColGiaVe.VisibleIndex = 3;
            // 
            // ColTenTV
            // 
            this.ColTenTV.Caption = "Tên Thành Viên";
            this.ColTenTV.ColumnEdit = this.lUPTenTV;
            this.ColTenTV.FieldName = "MaTV";
            this.ColTenTV.Name = "ColTenTV";
            this.ColTenTV.Visible = true;
            this.ColTenTV.VisibleIndex = 4;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 443);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private DevExpress.XtraGrid.Columns.GridColumn ColVitri;
        private DevExpress.XtraGrid.Columns.GridColumn ColPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColGiaVe;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenTV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUpTenPhong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUPTenTV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lUpTenPhim;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaVe;
    }
}