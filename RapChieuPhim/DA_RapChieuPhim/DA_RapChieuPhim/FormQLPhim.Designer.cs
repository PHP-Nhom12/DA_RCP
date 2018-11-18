namespace DA_RapChieuPhim
{
    partial class FormQLPhim
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
            this.lueTheLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.lueTenPhim = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColTG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupMaCa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColCa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupTPhim = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColPhim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LupTphong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ColTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvLichChieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcLichCHieu = new DevExpress.XtraGrid.GridControl();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lueTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupMaCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichCHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lueTheLoai
            // 
            this.lueTheLoai.Location = new System.Drawing.Point(157, 84);
            this.lueTheLoai.Name = "lueTheLoai";
            this.lueTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTheLoai.Properties.Appearance.Options.UseFont = true;
            this.lueTheLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTheLoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaCa", "Mã Ca"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCa", "Tên Ca")});
            this.lueTheLoai.Properties.NullText = "Please Selected";
            this.lueTheLoai.Size = new System.Drawing.Size(222, 22);
            this.lueTheLoai.TabIndex = 7;
            // 
            // lueTenPhim
            // 
            this.lueTenPhim.Location = new System.Drawing.Point(157, 43);
            this.lueTenPhim.Name = "lueTenPhim";
            this.lueTenPhim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueTenPhim.Properties.Appearance.Options.UseFont = true;
            this.lueTenPhim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueTenPhim.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhong", "Mã Phòng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhong", "Tên Phòng")});
            this.lueTenPhim.Properties.NullText = "Please Selected";
            this.lueTenPhim.Size = new System.Drawing.Size(222, 22);
            this.lueTenPhim.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phim";
            // 
            // ColTG
            // 
            this.ColTG.Caption = "Thời Lượng";
            this.ColTG.FieldName = "ThoiGian";
            this.ColTG.Name = "ColTG";
            this.ColTG.Visible = true;
            this.ColTG.VisibleIndex = 3;
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
            // ColCa
            // 
            this.ColCa.Caption = "Thể Loại";
            this.ColCa.ColumnEdit = this.LupMaCa;
            this.ColCa.FieldName = "MaCa";
            this.ColCa.Name = "ColCa";
            this.ColCa.Visible = true;
            this.ColCa.VisibleIndex = 2;
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
            // ColPhim
            // 
            this.ColPhim.Caption = "Nội dung Phim";
            this.ColPhim.Name = "ColPhim";
            this.ColPhim.Visible = true;
            this.ColPhim.VisibleIndex = 1;
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
            // ColTenPhong
            // 
            this.ColTenPhong.Caption = "Tên Phim";
            this.ColTenPhong.Name = "ColTenPhong";
            this.ColTenPhong.Visible = true;
            this.ColTenPhong.VisibleIndex = 0;
            // 
            // gvLichChieu
            // 
            this.gvLichChieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColTenPhong,
            this.ColPhim,
            this.ColCa,
            this.ColTG,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvLichChieu.GridControl = this.gcLichCHieu;
            this.gvLichChieu.Name = "gvLichChieu";
            this.gvLichChieu.OptionsView.ShowGroupPanel = false;
            // 
            // gcLichCHieu
            // 
            this.gcLichCHieu.Location = new System.Drawing.Point(43, 287);
            this.gcLichCHieu.MainView = this.gvLichChieu;
            this.gcLichCHieu.Name = "gcLichCHieu";
            this.gcLichCHieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LupTphong,
            this.LupTPhim,
            this.LupMaCa});
            this.gcLichCHieu.Size = new System.Drawing.Size(783, 239);
            this.gcLichCHieu.TabIndex = 10;
            this.gcLichCHieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLichChieu});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Thời Lượng";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(735, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 35);
            this.button5.TabIndex = 16;
            this.button5.Text = "Cập Nhật";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Năm sản xuất";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(638, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(541, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(300, 259);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(367, 22);
            this.textEdit1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội Dung\r\nTóm Tắt";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.gcLichCHieu);
            this.groupBox1.Controls.Add(this.lueTheLoai);
            this.groupBox1.Controls.Add(this.lueTenPhim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Phim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 51);
            this.textBox1.TabIndex = 31;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Năm sản xuất";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đạo diễn";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhà sản xuất";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mác";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày nhập";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(157, 128);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(222, 20);
            this.numericUpDown1.TabIndex = 32;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(622, 43);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(203, 20);
            this.numericUpDown2.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(622, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Đạo diễn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nhà sản xuất";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(622, 126);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 20);
            this.textBox3.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mác";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(623, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // FormQLPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 556);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLPhim";
            this.Text = "Quản Lý Phim";
            ((System.ComponentModel.ISupportInitialize)(this.lueTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueTenPhim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupMaCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LupTphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichCHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueTheLoai;
        private DevExpress.XtraEditors.LookUpEdit lueTenPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ColTG;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupMaCa;
        private DevExpress.XtraGrid.Columns.GridColumn ColCa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupTPhim;
        private DevExpress.XtraGrid.Columns.GridColumn ColPhim;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LupTphong;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLichChieu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gcLichCHieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;

    }
}