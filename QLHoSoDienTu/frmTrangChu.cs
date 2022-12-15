using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHoSoDienTu
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHoSo frmThemHoSo = new frmThemHoSo();
            frmThemHoSo.ShowDialog();
            frmTrangChu_Load(sender, e);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            frmTimkiem frmTimkiem = new frmTimkiem();
            frmTimkiem.ShowDialog();
            frmTrangChu_Load(sender, e);

        }

        private void btnVechungtoi_Click(object sender, EventArgs e)
        {
            frmThongTin frmThongTin = new frmThongTin();    
            frmThongTin.ShowDialog();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            dtNgay.CustomFormat = "dd-MM-yyyy";
            Program.treeDate = new TreeDate(Program.Path);
            lstvHoSo.Items.Clear();

            Program.treeDate.InOrderTraverse(Program.treeDate._Root);
            foreach (FileInfo f in Program.treeDate._TraverseList)
            {
                ListViewItem i = new ListViewItem(f._Name);
                i.SubItems.Add(f._Date.ToString("dd/MM/yyyy"));
                lstvHoSo.Items.Add(i); 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvHoSo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo f = new FileInfo();
            foreach (ListViewItem l in lstvHoSo.SelectedItems)
            {
                f = new FileInfo(l.SubItems[0].Text, DateTime.ParseExact(l.SubItems[1].Text, "dd/MM/yyyy", null));
                break;
            }

            Program.treeDate.DeleteNode(f);
            frmTrangChu_Load(sender, e);
        }

        private void lstvHoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem l in lstvHoSo.SelectedItems)
            {
                txtTen.Text = l.SubItems[0].Text;
                dtNgay.Value = DateTime.ParseExact(l.SubItems[1].Text, "dd/MM/yyyy", null);
                break;
            }
            
        }
    }
}
