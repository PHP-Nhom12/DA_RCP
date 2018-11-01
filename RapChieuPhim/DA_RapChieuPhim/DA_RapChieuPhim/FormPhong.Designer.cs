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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
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
            this.groupBox1.Controls.Add(this.gcPhong);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxEdit1);
            this.groupBox1.Controls.Add(this.textEdit3);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Controls.Add(this.textEdit1);
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(137, 41);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(210, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(137, 93);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(210, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(511, 93);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(200, 20);
            this.textEdit3.TabIndex = 6;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(511, 41);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(200, 20);
            this.comboBoxEdit1.TabIndex = 7;
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
            // 
            // ColMaPhong
            // 
            this.ColMaPhong.Caption = "Mã Phòng";
            this.ColMaPhong.Name = "ColMaPhong";
            this.ColMaPhong.Visible = true;
            this.ColMaPhong.VisibleIndex = 0;
            // 
            // ColTenPhong
            // 
            this.ColTenPhong.Caption = "Tên Phòng";
            this.ColTenPhong.Name = "ColTenPhong";
            this.ColTenPhong.Visible = true;
            this.ColTenPhong.VisibleIndex = 1;
            // 
            // ColLoaiPhong
            // 
            this.ColLoaiPhong.Caption = "Loại Phòng";
            this.ColLoaiPhong.Name = "ColLoaiPhong";
            this.ColLoaiPhong.Visible = true;
            this.ColLoaiPhong.VisibleIndex = 2;
            // 
            // ColSL
            // 
            this.ColSL.Caption = "Số Lượng Chổ";
            this.ColSL.Name = "ColSL";
            this.ColSL.Visible = true;
            this.ColSL.VisibleIndex = 3;
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}