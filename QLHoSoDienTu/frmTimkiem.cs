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
    public partial class frmTimkiem : Form
    {
        List<FileInfo> list = null;

        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbTimTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTimTen.Checked)
            {
                grbTimTen.Enabled = true;
                grbTimThoiGian.Enabled = false;
            }
        }

        private void rdbTimThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTimThoiGian.Checked)
            {
                grbTimThoiGian.Enabled=true;
                grbTimTen.Enabled=false;
            }
        }

        private void frmTimkiem_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";

            dateTimePicker1.Value= DateTime.Today;
            dateTimePicker2.Value= DateTime.Today;

            rdbTimTen.Checked=true;
            rdbTimTen_CheckedChanged(sender, e);
            lstvHoSo.Items.Clear();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            lstvHoSo.Items.Clear();
            if (rdbTimTen.Checked) 
            {
                if (txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên. Vui lòng nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.treeName = new TreeName(Program.Path);
                list = Program.treeName.FindName(txtTen.Text);
                if (list == null)
                {
                    MessageBox.Show("Không tìm thấy hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    foreach (FileInfo f in list)
                    {
                        ListViewItem l = new ListViewItem(f._Name);
                        l.SubItems.Add(f._Date.ToString("dd/MM/yyyy"));
                        lstvHoSo.Items.Add(l);
                    }
                }

            }
            else if (rdbTimThoiGian.Checked)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("Thời gian không hợp lệ, vui lòng chọn lại thời gian!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.treeDate = new TreeDate (Program.Path);
                list = Program.treeDate.FineDate(Program.treeDate._Root,dateTimePicker1.Value, dateTimePicker2.Value);
                if (list == null)
                {
                    MessageBox.Show("Không tìm thấy hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    foreach (FileInfo f in list)
                    {
                        ListViewItem l = new ListViewItem(f._Name);
                        l.SubItems.Add(f._Date.ToString("dd/MM/yyyy"));
                        lstvHoSo.Items.Add(l);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvHoSo.SelectedItems.Count==0)
            {
                MessageBox.Show("Bạn chưa chọn hồ sơ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem l = lstvHoSo.SelectedItems[0];
            FileInfo f = new FileInfo(l.SubItems[0].Text, Convert.ToDateTime(l.SubItems[1].Text));
            Program.treeDate.DeleteNode(f);
            l.Remove();            
        }
    }
}
