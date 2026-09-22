namespace BTb4_FormNhapLieuSieuThi
{
    partial class frm_FormBanHang
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
            lbl_MaSP = new Label();
            txt_MaSP = new TextBox();
            lbl_SoLuong = new Label();
            txt_SoLuong = new TextBox();
            lbl_DonGia = new Label();
            txt_DonGia = new TextBox();
            btn_Them = new Button();
            btn_XoaTrang = new Button();
            errorProvider1 = new ErrorProvider(components);
            toolTip_BanHang = new ToolTip(components);
            lstv_ListSanPham = new ListView();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_MaSP
            // 
            lbl_MaSP.AutoSize = true;
            lbl_MaSP.Location = new Point(61, 54);
            lbl_MaSP.Name = "lbl_MaSP";
            lbl_MaSP.Size = new Size(98, 20);
            lbl_MaSP.TabIndex = 0;
            lbl_MaSP.Text = "Mã sản phẩm";
            // 
            // txt_MaSP
            // 
            txt_MaSP.Location = new Point(232, 54);
            txt_MaSP.Name = "txt_MaSP";
            txt_MaSP.Size = new Size(214, 27);
            txt_MaSP.TabIndex = 1;
            txt_MaSP.Validating += txt_MaSP_Validating;
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Location = new Point(61, 124);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(69, 20);
            lbl_SoLuong.TabIndex = 2;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(232, 121);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(214, 27);
            txt_SoLuong.TabIndex = 3;
            toolTip_BanHang.SetToolTip(txt_SoLuong, "Chỉ nhập 0-9, không nhập kí tự thường hoặc đặc biệt");
            txt_SoLuong.KeyPress += txt_SoLuong_KeyPress;
            txt_SoLuong.Validating += txt_SoLuong_Validating;
            // 
            // lbl_DonGia
            // 
            lbl_DonGia.AutoSize = true;
            lbl_DonGia.Location = new Point(61, 191);
            lbl_DonGia.Name = "lbl_DonGia";
            lbl_DonGia.Size = new Size(62, 20);
            lbl_DonGia.TabIndex = 4;
            lbl_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(232, 191);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(214, 27);
            txt_DonGia.TabIndex = 5;
            toolTip_BanHang.SetToolTip(txt_DonGia, "Chỉ nhập 0-9, không nhập kí tự thường hoặc đặc biệt");
            txt_DonGia.KeyPress += txt_DonGia_KeyPress;
            txt_DonGia.Validating += txt_DonGia_Validating;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(573, 263);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_XoaTrang
            // 
            btn_XoaTrang.CausesValidation = false;
            btn_XoaTrang.Location = new Point(441, 263);
            btn_XoaTrang.Name = "btn_XoaTrang";
            btn_XoaTrang.Size = new Size(94, 29);
            btn_XoaTrang.TabIndex = 7;
            btn_XoaTrang.Text = "Xóa Trắng";
            btn_XoaTrang.UseVisualStyleBackColor = true;
            btn_XoaTrang.Click += btn_XoaTrang_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lstv_ListSanPham
            // 
            lstv_ListSanPham.Location = new Point(61, 263);
            lstv_ListSanPham.Name = "lstv_ListSanPham";
            lstv_ListSanPham.Size = new Size(353, 159);
            lstv_ListSanPham.TabIndex = 8;
            lstv_ListSanPham.UseCompatibleStateImageBehavior = false;
            // 
            // frm_FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(lstv_ListSanPham);
            Controls.Add(btn_XoaTrang);
            Controls.Add(btn_Them);
            Controls.Add(txt_DonGia);
            Controls.Add(lbl_DonGia);
            Controls.Add(txt_SoLuong);
            Controls.Add(lbl_SoLuong);
            Controls.Add(txt_MaSP);
            Controls.Add(lbl_MaSP);
            KeyPreview = true;
            Name = "frm_FormBanHang";
            Text = "FormBanHang";
            FormClosing += frm_FormBanHang_FormClosing;
            KeyDown += frm_FormBanHang_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_MaSP;
        private TextBox txt_MaSP;
        private Label lbl_SoLuong;
        private TextBox txt_SoLuong;
        private Label lbl_DonGia;
        private TextBox txt_DonGia;
        private Button btn_Them;
        private Button btn_XoaTrang;
        private ToolTip toolTip_BanHang;
        private ErrorProvider errorProvider1;
        private ListView lstv_ListSanPham;
    }
}
