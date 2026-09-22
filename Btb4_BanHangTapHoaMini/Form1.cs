namespace Btb4_BanHangTapHoaMini
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }



        private void mnuSpIt_DonHangMoi_Click(object sender, EventArgs e)
        {
            frm_DonHang1 DonHang1 = new frm_DonHang1();
            DonHang1.MdiParent = this;
            DonHang1.Show();
        }

        private void tSBtn_DonHangMoi_Click(object sender, EventArgs e)
        {
            frm_DonHang1 donHang1 = new frm_DonHang1();
            donHang1.MdiParent = this;
            donHang1.Show();
        }

        private void mnuSpIt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSpIt_Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuSpIt_TileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuSpIt_TileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void timer_Gio_Tick(object sender, EventArgs e)
        {
            lbl_Gio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frm_MainScreen_Load(object sender, EventArgs e)
        {
            lbl_SoDon.Text = $"So don dang mo: {this.MdiChildren.Length}";
        }
    }
}
