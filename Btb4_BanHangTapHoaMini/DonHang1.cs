using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Btb4_BanHangTapHoaMini
{
    public partial class frm_DonHang1 : Form
    {
        public frm_DonHang1()
        {
            InitializeComponent();
        }
        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in lstVw_ThongTinDonHang.Items)
            {
                tongTien += Convert.ToDecimal(item.SubItems[3].Text);
            }
            txt_TongTienCapNhat.Text = string.Format("{0:N0} VNĐ", tongTien);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_TenSamPham.Text))
                {
                    MessageBox.Show("Chua nhap ho ten", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TenSamPham.Focus();
                    return;
                }
                int soLuong;
                decimal decDonGia, decTongTien;
                if (string.IsNullOrWhiteSpace(txt_DonGia.Text))
                {
                    MessageBox.Show("Chua nhap don gia", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_DonGia.Focus();
                    return;
                }
                else
                {
                    soLuong = Convert.ToInt32(num_SoLuong.Value); // set numberic down tu 1 -> ?
                    decDonGia = Convert.ToDecimal(txt_DonGia.Text);
                    if (decDonGia <= 0)
                    {
                        MessageBox.Show("Don gia lon hon 0");
                        txt_DonGia.SelectAll();
                        txt_DonGia.Focus();
                    }
                    else
                    {
                        decTongTien = soLuong * decDonGia;
                        txt_TongTienCapNhat.Text = string.Format("{0:N} VND", decTongTien);

                        ListViewItem lvi = new ListViewItem(txt_TenSamPham.Text);
                        lvi.SubItems.Add(soLuong.ToString());
                        lvi.SubItems.Add(decDonGia.ToString());
                        lvi.SubItems.Add(decTongTien.ToString());

                        lstVw_ThongTinDonHang.Items.Add(lvi);

                        CapNhatTongTien();

                        txt_TenSamPham.Clear();
                        num_SoLuong.Value = 1;
                        txt_DonGia.Clear();
                        txt_TenSamPham.Focus();
                    }
                }
                string thongTin = $"Ten san pham: {txt_TenSamPham.Text}\n" +
                                  $"So luong:  {num_SoLuong} \n" +
                                  $"Don gia: {txt_DonGia.Text}\n" +
                                  $"Tong tien: {txt_TongTienCapNhat.Text}";
                MessageBox.Show(thongTin, "Don hang cua ban", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "thong bao!");
            }
        }

        private void txt_TenSamPham_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenSamPham.Text))
            {
                errorProvider1.SetError(txt_TenSamPham, "Ban phai nhap ten san pham!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_TenSamPham, "");
            }
        }

        private void txt_DonGia_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DonGia.Text))
            {
                errorProvider1.SetError(txt_DonGia, "Ban phai nhap don gia cho san pham!");
                e.Cancel= true;
            }
            else
            {
                errorProvider1.SetError(txt_DonGia, "");
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tlmnuIt_XoaDongDaChon_Click(object sender, EventArgs e)
        {
            if (lstVw_ThongTinDonHang.Items.Count > 0)
            {
                lstVw_ThongTinDonHang.Items.Remove(lstVw_ThongTinDonHang.SelectedItems[0]);
                CapNhatTongTien();
            }
        }

        private void tlmnuIt_SuaSoLuong_Click(object sender, EventArgs e)
        {
            if (lstVw_ThongTinDonHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lstVw_ThongTinDonHang.SelectedItems[0];
                string soLuongHienTai = item.SubItems[1].Text;

                string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng mới:", "Sửa số lượng", soLuongHienTai);

                if (int.TryParse(input, out int newSL) && newSL > 0)
                {
                    decimal donGia = Convert.ToDecimal(item.SubItems[2].Text);

                    item.SubItems[1].Text = newSL.ToString();
                    item.SubItems[3].Text = (newSL * donGia).ToString();

                    CapNhatTongTien();
                }
            }
        }

        private void frm_DonHang1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lstVw_ThongTinDonHang.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Đơn hàng này chưa được chốt. Bạn có chắc chắn muốn hủy và đóng lại không?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

        if (result == DialogResult.No) 
        {
                    e.Cancel = true; 
                }
            }
        }
    }
}
