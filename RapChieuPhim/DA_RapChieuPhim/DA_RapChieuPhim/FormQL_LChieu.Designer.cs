namespace DA_RapChieuPhim
{
    partial class FormQL_LChieu
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gcLichCHieu = new DevExpress.XtraGrid.GridControl();
            this.gvLichChieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupTphong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColPhim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupTPhim = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupMaCa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lUPCa = new DevExpress.XtraEditors.LookUpEdit();
            this.lUPtenPhim = new DevExpress.XtraEditors.LookUpEdit();
            this.lUpTenPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichCHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupMaCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPCa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPtenPhim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.gcLichCHieu);
            this.groupBox1.Controls.Add(this.lUPCa);
            this.groupBox1.Controls.Add(this.lUPtenPhim);
            this.groupBox1.Controls.Add(this.lUpTenPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(622, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "Cập Nhật";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(525, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(428, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(12, 192);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(367, 22);
            this.textEdit1.TabIndex = 11;
            // 
            // gcLichCHieu
            // 
            this.gcLichCHieu.Location = new System.Drawing.Point(0, 229);
            this.gcLichCHieu.MainView = this.gvLichChieu;
            this.gcLichCHieu.Name = "gcLichCHieu";
            this.gcLichCHieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LupTphong,
            this.LupTPhim,
            this.LupMaCa});
            this.gcLichCHieu.Size = new System.Drawing.Size(814, 270);
            this.gcLichCHieu.TabIndex = 10;
            this.gcLichCHieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLichChieu});
            // 
            // gvLichChieu
            // 
            this.gvLichChieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColTenPhong,
            this.ColPhim,
            this.ColCa,
            this.ColTG});
            this.gvLichChieu.GridControl = this.gcLichCHieu;
            this.gvLichChieu.Name = "gvLichChieu";
            // 
            // ColTenPhong
            // 
            this.ColTenPhong.Caption = "Tên Phòng";
            this.ColTenPhong.ColumnEdit = this.LupTphong;
            this.ColTenPhong.FieldName = "MaPhong";
            this.ColTenPhong.Name = "ColTenPhong";
            this.ColTenPhong.Visible = true;
            this.ColTenPhong.VisibleIndex = 0;
            // 
            // LupTphong
            // 
            this.LupTphong.AutoHeight = false;
            this.LupTphong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupTphong.DisplayMember = "TenPhong";
            this.LupTphong.Name = "LupTphong";
            this.LupTphong.ValueMember = "MaPhong";
            // 
            // ColPhim
            // 
            this.ColPhim.Caption = "Tên Phim";
            this.ColPhim.ColumnEdit = this.LupTPhim;
            this.ColPhim.FieldName = "MaPhim";
            this.ColPhim.Name = "ColPhim";
            this.ColPhim.Visible = true;
            this.ColPhim.VisibleIndex = 1;
            // 
            // LupTPhim
            // 
            this.LupTPhim.AutoHeight = false;
            this.LupTPhim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupTPhim.DisplayMember = "TenPhim";
            this.LupTPhim.Name = "LupTPhim";
            this.LupTPhim.ValueMember = "MaPhim";
            // 
            // ColCa
            // 
            this.ColCa.Caption = "Ca";
            this.ColCa.ColumnEdit = this.LupMaCa;
            this.ColCa.FieldName = "MaCa";
            this.ColCa.Name = "ColCa";
            this.ColCa.Visible = true;
            this.ColCa.VisibleIndex = 2;
            // 
            // LupMaCa
            // 
            this.LupMaCa.AutoHeight = false;
            this.LupMaCa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LupMaCa.DisplayMember = "TenCa";
            this.LupMaCa.Name = "LupMaCa";
            this.LupMaCa.ValueMember = "MaCa";
            // 
            // ColTG
            // 
            this.ColTG.Caption = "Thời Gian";
            this.ColTG.FieldName = "ThoiGian";
            this.ColTG.Name = "ColTG";
            this.ColTG.Visible = true;
            this.ColTG.VisibleIndex = 3;
            // 
            // lUPCa
            // 
            this.lUPCa.Location = new System.Drawing.Point(544, 43);
            this.lUPCa.Name = "lUPCa";
            this.lUPCa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUPCa.Properties.Appearance.Options.UseFont = true;
            this.lUPCa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUPCa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaCa", "Mã Ca"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCa", "Tên Ca")});
            this.lUPCa.Properties.NullText = "Please Selected";
            this.lUPCa.Size = new System.Drawing.Size(222, 22);
            this.lUPCa.TabIndex = 7;
            // 
            // lUPtenPhim
            // 
            this.lUPtenPhim.Location = new System.Drawing.Point(157, 80);
            this.lUPtenPhim.Name = "lUPtenPhim";
            this.lUPtenPhim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUPtenPhim.Properties.Appearance.Options.UseFont = true;
            this.lUPtenPhim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUPtenPhim.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhim", "Mã Phim"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhim", "Tên Phim")});
            this.lUPtenPhim.Properties.NullText = "Please Selected";
            this.lUPtenPhim.Size = new System.Drawing.Size(222, 22);
            this.lUPtenPhim.TabIndex = 6;
            // 
            // lUpTenPhong
            // 
            this.lUpTenPhong.Location = new System.Drawing.Point(157, 43);
            this.lUpTenPhong.Name = "lUpTenPhong";
            this.lUpTenPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUpTenPhong.Properties.Appearance.Options.UseFont = true;
            this.lUpTenPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUpTenPhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhong", "Mã Phòng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhong", "Tên Phòng")});
            this.lUpTenPhong.Properties.NullText = "Please Selected";
            this.lUpTenPhong.Size = new System.Drawing.Size(222, 22);
            this.lUpTenPhong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng";
            // 
            // FormQL_LChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 500);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQL_LChieu";
            this.Text = "FormQL_LChieu";
            this.Load += new System.EventHandler(this.FormQL_LChieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichCHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupMaCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPCa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUPtenPhim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUpTenPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcLichCHieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLichChieu;
        private DevExpress.XtraEditors.LookUpEdit lUPCa;
        private DevExpress.XtraEditors.LookUpEdit lUPtenPhim;
        private DevExpress.XtraEditors.LookUpEdit lUpTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColPhim;
        private DevExpress.XtraGrid.Columns.GridColumn ColCa;
        private DevExpress.XtraGrid.Columns.GridColumn ColTG;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupTphong;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupTPhim;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupMaCa;
    }
}