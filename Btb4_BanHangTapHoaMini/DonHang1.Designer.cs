namespace Btb4_BanHangTapHoaMini
{
    partial class frm_DonHang1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_TenSanPham = new Label();
            txt_TenSamPham = new TextBox();
            lbl_SoLuong = new Label();
            num_SoLuong = new NumericUpDown();
            lbl_DonGia = new Label();
            txt_DonGia = new TextBox();
            btn_Them = new Button();
            lbl_TongTienCapNhat = new Label();
            txt_TongTienCapNhat = new TextBox();
            lstVw_ThongTinDonHang = new ListView();
            cms_SuaThongTin = new ContextMenuStrip(components);
            tlmnuIt_XoaDongDaChon = new ToolStripMenuItem();
            tlmnuIt_SuaSoLuong = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)num_SoLuong).BeginInit();
            cms_SuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbl_TenSanPham
            // 
            lbl_TenSanPham.AutoSize = true;
            lbl_TenSanPham.Location = new Point(51, 65);
            lbl_TenSanPham.Name = "lbl_TenSanPham";
            lbl_TenSanPham.Size = new Size(100, 20);
            lbl_TenSanPham.TabIndex = 0;
            lbl_TenSanPham.Text = "Tên sản phẩm";
            // 
            // txt_TenSamPham
            // 
            txt_TenSamPham.Location = new Point(217, 65);
            txt_TenSamPham.Name = "txt_TenSamPham";
            txt_TenSamPham.Size = new Size(251, 27);
            txt_TenSamPham.TabIndex = 1;
            toolTip1.SetToolTip(txt_TenSamPham, "Không được để trống");
            txt_TenSamPham.Validating += txt_TenSamPham_Validating;
            // 
            // lbl_SoLuong
            // 
            lbl_SoLuong.AutoSize = true;
            lbl_SoLuong.Location = new Point(51, 138);
            lbl_SoLuong.Name = "lbl_SoLuong";
            lbl_SoLuong.Size = new Size(69, 20);
            lbl_SoLuong.TabIndex = 2;
            lbl_SoLuong.Text = "Số lượng";
            // 
            // num_SoLuong
            // 
            num_SoLuong.Location = new Point(217, 138);
            num_SoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_SoLuong.Name = "num_SoLuong";
            num_SoLuong.Size = new Size(251, 27);
            num_SoLuong.TabIndex = 3;
            num_SoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_DonGia
            // 
            lbl_DonGia.AutoSize = true;
            lbl_DonGia.Location = new Point(51, 211);
            lbl_DonGia.Name = "lbl_DonGia";
            lbl_DonGia.Size = new Size(62, 20);
            lbl_DonGia.TabIndex = 4;
            lbl_DonGia.Text = "Đơn giá";
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(217, 211);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(251, 27);
            txt_DonGia.TabIndex = 5;
            toolTip1.SetToolTip(txt_DonGia, "Chỉ được điền số dương");
            txt_DonGia.KeyPress += txt_DonGia_KeyPress;
            txt_DonGia.Validating += txt_DonGia_Validating;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(543, 282);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 6;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // lbl_TongTienCapNhat
            // 
            lbl_TongTienCapNhat.AutoSize = true;
            lbl_TongTienCapNhat.Location = new Point(51, 285);
            lbl_TongTienCapNhat.Name = "lbl_TongTienCapNhat";
            lbl_TongTienCapNhat.Size = new Size(133, 20);
            lbl_TongTienCapNhat.TabIndex = 7;
            lbl_TongTienCapNhat.Text = "Tổng tiền cập nhật";
            // 
            // txt_TongTienCapNhat
            // 
            txt_TongTienCapNhat.Location = new Point(217, 282);
            txt_TongTienCapNhat.Name = "txt_TongTienCapNhat";
            txt_TongTienCapNhat.ReadOnly = true;
            txt_TongTienCapNhat.Size = new Size(251, 27);
            txt_TongTienCapNhat.TabIndex = 8;
            // 
            // lstVw_ThongTinDonHang
            // 
            lstVw_ThongTinDonHang.ContextMenuStrip = cms_SuaThongTin;
            lstVw_ThongTinDonHang.Location = new Point(51, 343);
            lstVw_ThongTinDonHang.Name = "lstVw_ThongTinDonHang";
            lstVw_ThongTinDonHang.Size = new Size(586, 85);
            lstVw_ThongTinDonHang.TabIndex = 9;
            lstVw_ThongTinDonHang.UseCompatibleStateImageBehavior = false;
            // 
            // cms_SuaThongTin
            // 
            cms_SuaThongTin.ImageScalingSize = new Size(20, 20);
            cms_SuaThongTin.Items.AddRange(new ToolStripItem[] { tlmnuIt_XoaDongDaChon, tlmnuIt_SuaSoLuong });
            cms_SuaThongTin.Name = "cms_SuaThongTin";
            cms_SuaThongTin.Size = new Size(201, 52);
            // 
            // tlmnuIt_XoaDongDaChon
            // 
            tlmnuIt_XoaDongDaChon.Name = "tlmnuIt_XoaDongDaChon";
            tlmnuIt_XoaDongDaChon.Size = new Size(200, 24);
            tlmnuIt_XoaDongDaChon.Text = "Xóa dòng đã chọn";
            tlmnuIt_XoaDongDaChon.Click += tlmnuIt_XoaDongDaChon_Click;
            // 
            // tlmnuIt_SuaSoLuong
            // 
            tlmnuIt_SuaSoLuong.Name = "tlmnuIt_SuaSoLuong";
            tlmnuIt_SuaSoLuong.Size = new Size(200, 24);
            tlmnuIt_SuaSoLuong.Text = "Sửa Số Lượng";
            tlmnuIt_SuaSoLuong.Click += tlmnuIt_SuaSoLuong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frm_DonHang1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 450);
            Controls.Add(lstVw_ThongTinDonHang);
            Controls.Add(txt_TongTienCapNhat);
            Controls.Add(lbl_TongTienCapNhat);
            Controls.Add(btn_Them);
            Controls.Add(txt_DonGia);
            Controls.Add(lbl_DonGia);
            Controls.Add(num_SoLuong);
            Controls.Add(lbl_SoLuong);
            Controls.Add(txt_TenSamPham);
            Controls.Add(lbl_TenSanPham);
            Name = "frm_DonHang1";
            Text = "DonHang1";
            FormClosing += frm_DonHang1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)num_SoLuong).EndInit();
            cms_SuaThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenSanPham;
        private TextBox txt_TenSamPham;
        private Label lbl_SoLuong;
        private NumericUpDown num_SoLuong;
        private Label lbl_DonGia;
        private TextBox txt_DonGia;
        private Button btn_Them;
        private Label lbl_TongTienCapNhat;
        private TextBox txt_TongTienCapNhat;
        private ListView lstVw_ThongTinDonHang;
        private ContextMenuStrip cms_SuaThongTin;
        private ToolStripMenuItem tlmnuIt_XoaDongDaChon;
        private ToolStripMenuItem tlmnuIt_SuaSoLuong;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
    }
}