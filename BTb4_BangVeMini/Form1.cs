namespace BTb4_BangVeMini
{
    public partial class frm_FormBangVeMini : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        public frm_FormBangVeMini()
        {
            InitializeComponent();
            lbl_TrangThai.Text = "San sang";
        }

        private void frm_FormBangVeMini_Load(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_ViTri.Text = $"Tọa độ: X={e.X}, Y={e.Y}";

            if (isDrawing)
            {
                using (Graphics g = pnlCanvas_mainPanel.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 2f))
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }
                previousPoint = e.Location;
            }
        }

        private void pnlCanvas_mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location;
                lbl_TrangThai.Text = "Đang vẽ...";
            }
        }

        private void pnlCanvas_mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lbl_TrangThai.Text = "Sẵn sàng";
            }
        }

        private void pnlCanvas_mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Lệnh Invalidate() ép Panel tự vẽ lại từ đầu (xóa sạch các nét Graphics tạm thời)
                pnlCanvas_mainPanel.Invalidate();
            }
        }
    }
}
