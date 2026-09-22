namespace BTb4_CafeStatusDemo
{
    public partial class frm_MainSreen : Form
    {
        public frm_MainSreen()
        {
            InitializeComponent();
        }

        private void timer_GioHienTai_Tick(object sender, EventArgs e)
        {
            lbl_GioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 22)
            {
                lbl_TrangThai.Text = "Đang mở cửa";
                lbl_TrangThai.ForeColor = Color.Green;
            }
            else
            {
                lbl_TrangThai.Text = "Đang đóng cửa";
                lbl_TrangThai.ForeColor = Color.Red;
            }
        }

        private void mnuIt_DoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                if (colorDlg.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDlg.Color;
                }
            }
        }

        private void mnuIt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
