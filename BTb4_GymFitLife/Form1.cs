namespace BTb4_GymFitLife
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void lbl_SoDienThoai_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NggaySinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
                {
                    MessageBox.Show("Chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_HoTen.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_SDT.Text))
                {
                    MessageBox.Show("Chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_SDT.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txt_Email.Text))
                {
                    MessageBox.Show("Chưa nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Email.Focus();
                    return;
                }
                else
                {
                    string thongTin = $"Họ tên: {txt_HoTen.Text}\n" +
                                      $"SĐT: {txt_SDT.Text}\n" +
                                      $"Gói tập: {cbo_GoiTap.Text}\n" +
                                      $"Số buổi/tuần: {num_SoBuoiTap.Value}";

                    MessageBox.Show(
                        thongTin,
                        "Thông tin đăng ký",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo Hệ Thống");
            }

        }

        private void txt_HoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HoTen.Text))
            {
                errorProvider1.SetError(txt_HoTen, "Bạn phải nhập họ tên!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_HoTen, "");
            }
        }

        private void txt_SDT_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SDT.Text))
            {
                errorProvider1.SetError(txt_SDT, "Bạn phải nhập số điện thoại!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_SDT, "");
            }
        }

        private void txt_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                errorProvider1.SetError(txt_Email, "Bạn phải nhập họ tên!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txt_Email, "");
            }
        }
    }
}
