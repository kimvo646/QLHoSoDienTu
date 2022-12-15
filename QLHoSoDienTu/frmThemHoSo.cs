using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoSoDienTu
{
    public partial class frmThemHoSo : Form
    {
        public frmThemHoSo()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* TODO
             * Kiểm tra dữ liệu
             * Lưu dữ liệu vào file */

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FileInfo f = new FileInfo(txtTen.Text,dtpNgay.Value);
            Program.treeDate.AddNode(f);
            Program.treeDate.Update(Program.Path);
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemHoSo_Load(object sender, EventArgs e)
        {
            dtpNgay.CustomFormat = "dd-MM-yyyy";
        }
    }
}
