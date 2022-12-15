namespace QLHoSoDienTu
{
    partial class frmTimkiem
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
            this.rdbTimTen = new System.Windows.Forms.RadioButton();
            this.rdbTimThoiGian = new System.Windows.Forms.RadioButton();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstvHoSo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbTimTen = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.grbTimThoiGian = new System.Windows.Forms.GroupBox();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbChucNang.SuspendLayout();
            this.grbTimTen.SuspendLayout();
            this.grbTimThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTimTen
            // 
            this.rdbTimTen.AutoSize = true;
            this.rdbTimTen.Location = new System.Drawing.Point(12, 12);
            this.rdbTimTen.Name = "rdbTimTen";
            this.rdbTimTen.Size = new System.Drawing.Size(180, 37);
            this.rdbTimTen.TabIndex = 0;
            this.rdbTimTen.TabStop = true;
            this.rdbTimTen.Text = "Tìm theo tên";
            this.rdbTimTen.UseVisualStyleBackColor = true;
            this.rdbTimTen.CheckedChanged += new System.EventHandler(this.rdbTimTen_CheckedChanged);
            // 
            // rdbTimThoiGian
            // 
            this.rdbTimThoiGian.AutoSize = true;
            this.rdbTimThoiGian.Location = new System.Drawing.Point(12, 123);
            this.rdbTimThoiGian.Name = "rdbTimThoiGian";
            this.rdbTimThoiGian.Size = new System.Drawing.Size(245, 37);
            this.rdbTimThoiGian.TabIndex = 1;
            this.rdbTimThoiGian.TabStop = true;
            this.rdbTimThoiGian.Text = "Tìm theo thời gian";
            this.rdbTimThoiGian.UseVisualStyleBackColor = true;
            this.rdbTimThoiGian.CheckedChanged += new System.EventHandler(this.rdbTimThoiGian_CheckedChanged);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnTim);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Location = new System.Drawing.Point(12, 295);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(540, 197);
            this.grbChucNang.TabIndex = 3;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(6, 55);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(527, 49);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(7, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(527, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(905, 432);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstvHoSo
            // 
            this.lstvHoSo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvHoSo.FullRowSelect = true;
            this.lstvHoSo.HideSelection = false;
            this.lstvHoSo.Location = new System.Drawing.Point(596, 12);
            this.lstvHoSo.MultiSelect = false;
            this.lstvHoSo.Name = "lstvHoSo";
            this.lstvHoSo.Size = new System.Drawing.Size(459, 403);
            this.lstvHoSo.TabIndex = 6;
            this.lstvHoSo.UseCompatibleStateImageBehavior = false;
            this.lstvHoSo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày";
            this.columnHeader2.Width = 150;
            // 
            // grbTimTen
            // 
            this.grbTimTen.Controls.Add(this.txtTen);
            this.grbTimTen.Controls.Add(this.lblTen);
            this.grbTimTen.Location = new System.Drawing.Point(236, 12);
            this.grbTimTen.Name = "grbTimTen";
            this.grbTimTen.Size = new System.Drawing.Size(316, 100);
            this.grbTimTen.TabIndex = 7;
            this.grbTimTen.TabStop = false;
            this.grbTimTen.Text = "Tìm kiếm";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(109, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(201, 39);
            this.txtTen.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(16, 55);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(65, 33);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // grbTimThoiGian
            // 
            this.grbTimThoiGian.Controls.Add(this.lblDen);
            this.grbTimThoiGian.Controls.Add(this.lblTu);
            this.grbTimThoiGian.Controls.Add(this.dateTimePicker2);
            this.grbTimThoiGian.Controls.Add(this.dateTimePicker1);
            this.grbTimThoiGian.Location = new System.Drawing.Point(236, 123);
            this.grbTimThoiGian.Name = "grbTimThoiGian";
            this.grbTimThoiGian.Size = new System.Drawing.Size(316, 164);
            this.grbTimThoiGian.TabIndex = 8;
            this.grbTimThoiGian.TabStop = false;
            this.grbTimThoiGian.Text = "Tìm kiếm";
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(6, 127);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(69, 33);
            this.lblDen.TabIndex = 3;
            this.lblDen.Text = "Đến:";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(6, 54);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(54, 33);
            this.lblTu.TabIndex = 2;
            this.lblTu.Text = "Từ:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 121);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 39);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // frmTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 504);
            this.Controls.Add(this.grbTimThoiGian);
            this.Controls.Add(this.grbTimTen);
            this.Controls.Add(this.lstvHoSo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.rdbTimThoiGian);
            this.Controls.Add(this.rdbTimTen);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmTimkiem_Load);
            this.grbChucNang.ResumeLayout(false);
            this.grbTimTen.ResumeLayout(false);
            this.grbTimTen.PerformLayout();
            this.grbTimThoiGian.ResumeLayout(false);
            this.grbTimThoiGian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTimTen;
        private System.Windows.Forms.RadioButton rdbTimThoiGian;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lstvHoSo;
        private System.Windows.Forms.GroupBox grbTimTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.GroupBox grbTimThoiGian;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}