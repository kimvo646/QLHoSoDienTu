namespace QLHoSoDienTu
{
    partial class frmTrangChu
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnVechungtoi = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTenCT = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvHoSo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(861, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(228, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm hồ sơ";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(861, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(228, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa hồ sơ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiem.Location = new System.Drawing.Point(861, 246);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(228, 49);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnVechungtoi
            // 
            this.btnVechungtoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVechungtoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVechungtoi.Location = new System.Drawing.Point(861, 330);
            this.btnVechungtoi.Name = "btnVechungtoi";
            this.btnVechungtoi.Size = new System.Drawing.Size(228, 49);
            this.btnVechungtoi.TabIndex = 5;
            this.btnVechungtoi.Text = "Thông tin";
            this.btnVechungtoi.UseVisualStyleBackColor = false;
            this.btnVechungtoi.Click += new System.EventHandler(this.btnVechungtoi_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(535, 195);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(133, 33);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên hồ sơ:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(540, 235);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(289, 39);
            this.txtTen.TabIndex = 7;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(535, 291);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(81, 33);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(540, 340);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(289, 39);
            this.dtNgay.TabIndex = 8;
            // 
            // lblTenCT
            // 
            this.lblTenCT.AutoSize = true;
            this.lblTenCT.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenCT.Location = new System.Drawing.Point(553, 34);
            this.lblTenCT.Name = "lblTenCT";
            this.lblTenCT.Size = new System.Drawing.Size(324, 90);
            this.lblTenCT.TabIndex = 9;
            this.lblTenCT.Text = "QUẢN LÍ \r\nHỒ SƠ ĐIỆN TỬ";
            this.lblTenCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên hồ sơ";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày";
            this.columnHeader2.Width = 150;
            // 
            // lstvHoSo
            // 
            this.lstvHoSo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvHoSo.FullRowSelect = true;
            this.lstvHoSo.HideSelection = false;
            this.lstvHoSo.Location = new System.Drawing.Point(21, 34);
            this.lstvHoSo.MultiSelect = false;
            this.lstvHoSo.Name = "lstvHoSo";
            this.lstvHoSo.Size = new System.Drawing.Size(480, 350);
            this.lstvHoSo.TabIndex = 4;
            this.lstvHoSo.UseCompatibleStateImageBehavior = false;
            this.lstvHoSo.View = System.Windows.Forms.View.Details;
            this.lstvHoSo.SelectedIndexChanged += new System.EventHandler(this.lstvHoSo_SelectedIndexChanged);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 396);
            this.Controls.Add(this.lblTenCT);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnVechungtoi);
            this.Controls.Add(this.lstvHoSo);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnVechungtoi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblTenCT;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstvHoSo;
    }
}

