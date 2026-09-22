namespace BTb4_FormNhapLieuSieuThi
{
    public partial class frm_FormBanHang : Form
    {
        public frm_FormBanHang()
        {
            InitializeComponent();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_MaSP.Text))
                {
                    MessageBox.Show("Chua nhap ma san pham", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_MaSP.Focus();
                    return;
                }
                int soLuong;
                decimal decDonGia;
                if (string.IsNullOrWhiteSpace(txt_SoLuong.Text))
                {
                    MessageBox.Show("Chua nhap so luong", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SoLuong.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_DonGia.Text))
                {
                    MessageBox.Show("Chua nhap don gia", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_DonGia.Focus();
                    return;
                }
                else
                {
                    soLuong = Convert.ToInt32(txt_SoLuong.Text);
                    decDonGia = Convert.ToDecimal(txt_DonGia.Text);
                    if (soLuong <= 0)
                    {
                        MessageBox.Show("so luong phai nguyen duong!");
                        txt_SoLuong.SelectAll();
                        txt_SoLuong.Focus();
                    }
                    if (decDonGia <= 0)
                    {
                        MessageBox.Show("Don gia phai nguyen duong!");
                        txt_DonGia.SelectAll();
                        txt_DonGia.Focus();
                    }
                    else
                    {
                        ListViewItem lv_SanPham = new ListViewItem(txt_MaSP.Text);
                        lv_SanPham.SubItems.Add(soLuong.ToString());
                        lv_SanPham.SubItems.Add(decDonGia.ToString());

                        lstv_ListSanPham.Items.Add(lv_SanPham);

                        string thongTin = $"Ma san pham: {txt_MaSP.Text}\n" +
                                  $"So luong: {txt_SoLuong.Text}\n" +
                                  $"Don gia: {txt_DonGia.Text}";
                        MessageBox.Show(thongTin, "San pham nhap vao: ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txt_MaSP.Clear();
                        txt_SoLuong.Clear();
                        txt_DonGia.Clear();
                        txt_MaSP.Focus();

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Thong bao!");
            }
        }
        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_MaSP_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaSP.Text))
            {
                errorProvider1.SetError(txt_MaSP, "Ban phai nhap ma san pham!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_MaSP, "");
            }
        }

        private void txt_SoLuong_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SoLuong.Text))
            {
                errorProvider1.SetError(txt_SoLuong, "Ban phai nhap so luong!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_SoLuong, "");
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_DonGia_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_DonGia.Text))
            {
                errorProvider1.SetError(txt_DonGia, "Ban phai nhap don hang!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_DonGia, "");
            }
        }

        private void frm_FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_Them.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_XoaTrang.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_XoaTrang_Click(object sender, EventArgs e)
        {
            txt_MaSP.Clear();
            txt_SoLuong.Clear();
            txt_DonGia.Clear();
            errorProvider1.Clear();
            txt_MaSP.Focus();
        }

        private void frm_FormBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Có chắc bạn muốn thoát ứng dụng không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl== DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
