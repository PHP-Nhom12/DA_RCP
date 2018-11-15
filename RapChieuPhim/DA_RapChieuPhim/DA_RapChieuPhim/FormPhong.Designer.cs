namespace DA_RapChieuPhim
{
    partial class FormPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lUpLoaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSLCho = new DevExpress.XtraEditors.TextEdit();
            this.txtTenPhong = new DevExpress.XtraEditors.TextEdit();
            this.txtMPhong = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUpLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLCho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lUpLoaiPhong);
            this.groupBox1.Controls.Add(this.gcPhong);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSLCho);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtMPhong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 419);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lUpLoaiPhong
            // 
            this.lUpLoaiPhong.Location = new System.Drawing.Point(511, 41);
            this.lUpLoaiPhong.Name = "lUpLoaiPhong";
            this.lUpLoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUpLoaiPhong.Size = new System.Drawing.Size(200, 20);
            this.lUpLoaiPhong.TabIndex = 12;
            // 
            // gcPhong
            // 
            this.gcPhong.Location = new System.Drawing.Point(0, 219);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(787, 200);
            this.gcPhong.TabIndex = 11;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            this.gcPhong.DoubleClick += new System.EventHandler(this.gcPhong_DoubleClick);
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColMaPhong,
            this.ColTenPhong,
            this.ColLoaiPhong,
            this.ColSL});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPhong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.OptionsBehavior.ReadOnly = true;
            this.gvPhong.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvPhong.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPhong_RowClick);
            // 
            // ColMaPhong
            // 
            this.ColMaPhong.Caption = "Mã Phòng";
            this.ColMaPhong.FieldName = "MaPhong";
            this.ColMaPhong.Name = "ColMaPhong";
            this.ColMaPhong.Visible = true;
            this.ColMaPhong.VisibleIndex = 0;
            // 
            // ColTenPhong
            // 
            this.ColTenPhong.Caption = "Tên Phòng";
            this.ColTenPhong.FieldName = "TenPhong";
            this.ColTenPhong.Name = "ColTenPhong";
            this.ColTenPhong.Visible = true;
            this.ColTenPhong.VisibleIndex = 1;
            // 
            // ColLoaiPhong
            // 
            this.ColLoaiPhong.Caption = "Loại Phòng";
            this.ColLoaiPhong.FieldName = "LoaiPhong";
            this.ColLoaiPhong.Name = "ColLoaiPhong";
            this.ColLoaiPhong.Visible = true;
            this.ColLoaiPhong.VisibleIndex = 2;
            // 
            // ColSL
            // 
            this.ColSL.Caption = "Số Lượng Chổ";
            this.ColSL.FieldName = "SLCho";
            this.ColSL.Name = "ColSL";
            this.ColSL.Visible = true;
            this.ColSL.VisibleIndex = 3;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(568, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cập Nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(454, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSLCho
            // 
            this.txtSLCho.Location = new System.Drawing.Point(511, 93);
            this.txtSLCho.Name = "txtSLCho";
            this.txtSLCho.Size = new System.Drawing.Size(200, 20);
            this.txtSLCho.TabIndex = 6;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(137, 93);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(210, 20);
            this.txtTenPhong.TabIndex = 5;
            // 
            // txtMPhong
            // 
            this.txtMPhong.Location = new System.Drawing.Point(137, 41);
            this.txtMPhong.Name = "txtMPhong";
            this.txtMPhong.Size = new System.Drawing.Size(210, 20);
            this.txtMPhong.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Chổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Phòng";
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.Load += new System.EventHandler(this.FormPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUpLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLCho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMPhong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColTenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn ColSL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit txtSLCho;
        private DevExpress.XtraEditors.TextEdit txtTenPhong;
        private DevExpress.XtraEditors.TextEdit txtMPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lUpLoaiPhong;
    }
}