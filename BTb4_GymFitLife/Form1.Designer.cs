namespace BTb4_GymFitLife
{
    partial class frm_MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_HoTen = new Label();
            lbl_SoDienThoai = new Label();
            lbl_Email = new Label();
            txt_HoTen = new TextBox();
            txt_SDT = new TextBox();
            txt_Email = new TextBox();
            dtp_NgaySinh = new DateTimePicker();
            lbl_NggaySinh = new Label();
            cbo_GoiTap = new ComboBox();
            lbl_GoiTap = new Label();
            num_SoBuoiTap = new NumericUpDown();
            lbl_SoBuoiTap = new Label();
            btn_DangKy = new Button();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)num_SoBuoiTap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(68, 42);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(56, 20);
            lbl_HoTen.TabIndex = 0;
            lbl_HoTen.Text = "Họ Tên";
            // 
            // lbl_SoDienThoai
            // 
            lbl_SoDienThoai.AutoSize = true;
            lbl_SoDienThoai.Location = new Point(68, 112);
            lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            lbl_SoDienThoai.Size = new Size(102, 20);
            lbl_SoDienThoai.TabIndex = 1;
            lbl_SoDienThoai.Text = "Số Điện Thoại";
            lbl_SoDienThoai.Click += lbl_SoDienThoai_Click;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(68, 174);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(46, 20);
            lbl_Email.TabIndex = 2;
            lbl_Email.Text = "Email";
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(245, 42);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(125, 27);
            txt_HoTen.TabIndex = 3;
            toolTip1.SetToolTip(txt_HoTen, "Chỉ Nhập ký tự, không nhập số hay kí tự đặc biệt");
            txt_HoTen.Validating += txt_HoTen_Validating;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(245, 105);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(125, 27);
            txt_SDT.TabIndex = 4;
            toolTip1.SetToolTip(txt_SDT, "Chỉ nhập đủ 10 số không chứa khoảng trắng hay ký tự đặc biệt");
            txt_SDT.Validating += txt_SDT_Validating;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(245, 174);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(125, 27);
            txt_Email.TabIndex = 5;
            toolTip1.SetToolTip(txt_Email, "Email dùng để nhận thông báo lịch tập và khuyến mã");
            txt_Email.Validating += txt_Email_Validating;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Location = new Point(245, 244);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(250, 27);
            dtp_NgaySinh.TabIndex = 6;
            // 
            // lbl_NggaySinh
            // 
            lbl_NggaySinh.AutoSize = true;
            lbl_NggaySinh.Location = new Point(68, 244);
            lbl_NggaySinh.Name = "lbl_NggaySinh";
            lbl_NggaySinh.Size = new Size(76, 20);
            lbl_NggaySinh.TabIndex = 7;
            lbl_NggaySinh.Text = "Ngày Sinh";
            lbl_NggaySinh.Click += lbl_NggaySinh_Click;
            // 
            // cbo_GoiTap
            // 
            cbo_GoiTap.FormattingEnabled = true;
            cbo_GoiTap.Items.AddRange(new object[] { "1. Basic", "2. VIP", "3. Premium" });
            cbo_GoiTap.Location = new Point(245, 316);
            cbo_GoiTap.Name = "cbo_GoiTap";
            cbo_GoiTap.Size = new Size(254, 28);
            cbo_GoiTap.TabIndex = 8;
            cbo_GoiTap.Text = "--- Chọn Gói tập ---";
            toolTip1.SetToolTip(cbo_GoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            // 
            // lbl_GoiTap
            // 
            lbl_GoiTap.AutoSize = true;
            lbl_GoiTap.Location = new Point(68, 316);
            lbl_GoiTap.Name = "lbl_GoiTap";
            lbl_GoiTap.Size = new Size(61, 20);
            lbl_GoiTap.TabIndex = 9;
            lbl_GoiTap.Text = "Gói Tập";
            // 
            // num_SoBuoiTap
            // 
            num_SoBuoiTap.Location = new Point(245, 383);
            num_SoBuoiTap.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            num_SoBuoiTap.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_SoBuoiTap.Name = "num_SoBuoiTap";
            num_SoBuoiTap.Size = new Size(150, 27);
            num_SoBuoiTap.TabIndex = 10;
            num_SoBuoiTap.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_SoBuoiTap
            // 
            lbl_SoBuoiTap.AutoSize = true;
            lbl_SoBuoiTap.Location = new Point(68, 383);
            lbl_SoBuoiTap.Name = "lbl_SoBuoiTap";
            lbl_SoBuoiTap.Size = new Size(89, 20);
            lbl_SoBuoiTap.TabIndex = 11;
            lbl_SoBuoiTap.Text = "Số Buổi Tập";
            // 
            // btn_DangKy
            // 
            btn_DangKy.Location = new Point(631, 389);
            btn_DangKy.Name = "btn_DangKy";
            btn_DangKy.Size = new Size(94, 29);
            btn_DangKy.TabIndex = 12;
            btn_DangKy.Text = "Đăng ký";
            btn_DangKy.UseVisualStyleBackColor = true;
            btn_DangKy.Click += btn_DangKy_Click;
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 450);
            Controls.Add(btn_DangKy);
            Controls.Add(lbl_SoBuoiTap);
            Controls.Add(num_SoBuoiTap);
            Controls.Add(lbl_GoiTap);
            Controls.Add(cbo_GoiTap);
            Controls.Add(lbl_NggaySinh);
            Controls.Add(dtp_NgaySinh);
            Controls.Add(txt_Email);
            Controls.Add(txt_SDT);
            Controls.Add(txt_HoTen);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_SoDienThoai);
            Controls.Add(lbl_HoTen);
            Name = "frm_MainScreen";
            Text = "GymFitLife";
            ((System.ComponentModel.ISupportInitialize)num_SoBuoiTap).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_HoTen;
        private Label lbl_SoDienThoai;
        private Label lbl_Email;
        private TextBox txt_HoTen;
        private TextBox txt_SDT;
        private TextBox txt_Email;
        private DateTimePicker dtp_NgaySinh;
        private Label lbl_NggaySinh;
        private ComboBox cbo_GoiTap;
        private Label lbl_GoiTap;
        private NumericUpDown num_SoBuoiTap;
        private Label lbl_SoBuoiTap;
        private Button btn_DangKy;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
    }
}
