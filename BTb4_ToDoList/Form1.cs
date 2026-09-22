namespace BTb4_ToDoList
{
    public partial class frm_MainScreen : Form
    {
        public frm_MainScreen()
        {
            InitializeComponent();
        }

        private void lbl_CongViec_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            string task = txt_CongViecMoi.Text.Trim();
            if (!string.IsNullOrWhiteSpace(task))
            {
                lst_CongViec.Items.Add(task);
                txt_CongViecMoi.Clear();
                txt_CongViecMoi.Focus();
            }

        }

        private void mnuIt_HoanThanh_Click(object sender, EventArgs e)
        {
            if (lst_CongViec.SelectedItem != null)
            {
                string currentTask = lst_CongViec.SelectedItem.ToString();

                if (!currentTask.StartsWith("[Hoàn thành] "))
                {
                    // Cập nhật lại giá trị tại vị trí đang chọn
                    lst_CongViec.Items[lst_CongViec.SelectedIndex] = "[Hoàn thành] " + currentTask;
                }
            }
        }

        private void mnuIt_XoaCongViecNay_Click(object sender, EventArgs e)
        {
            if (lst_CongViec.SelectedItem != null)
            {
                lst_CongViec.Items.RemoveAt(lst_CongViec.SelectedIndex);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn một công việc để xóa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void mnuIt_XoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách công việc không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                lst_CongViec.Items.Clear();
            }
        }
    }
}
