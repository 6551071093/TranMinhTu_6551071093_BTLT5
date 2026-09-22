namespace BTb4_CafeStatusDemo
{
    partial class frm_MainSreen
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
            mnuSp_MainScreen = new MenuStrip();
            mnu_HeThong = new ToolStripMenuItem();
            mnuIt_DoiMauNen = new ToolStripMenuItem();
            mnuIt_Thoat = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lbl_GioHienTai = new ToolStripStatusLabel();
            lbl_TenQuan = new ToolStripStatusLabel();
            lbl_TrangThai = new ToolStripStatusLabel();
            timer_GioHienTai = new System.Windows.Forms.Timer(components);
            mnuSp_MainScreen.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuSp_MainScreen
            // 
            mnuSp_MainScreen.ImageScalingSize = new Size(20, 20);
            mnuSp_MainScreen.Items.AddRange(new ToolStripItem[] { mnu_HeThong });
            mnuSp_MainScreen.Location = new Point(0, 0);
            mnuSp_MainScreen.Name = "mnuSp_MainScreen";
            mnuSp_MainScreen.Size = new Size(754, 28);
            mnuSp_MainScreen.TabIndex = 0;
            mnuSp_MainScreen.Text = "menuStrip1";
            // 
            // mnu_HeThong
            // 
            mnu_HeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuIt_DoiMauNen, mnuIt_Thoat });
            mnu_HeThong.Name = "mnu_HeThong";
            mnu_HeThong.Size = new Size(88, 24);
            mnu_HeThong.Text = "Hệ Thống";
            // 
            // mnuIt_DoiMauNen
            // 
            mnuIt_DoiMauNen.Name = "mnuIt_DoiMauNen";
            mnuIt_DoiMauNen.Size = new Size(224, 26);
            mnuIt_DoiMauNen.Text = "Đổi màu nền";
            mnuIt_DoiMauNen.Click += mnuIt_DoiMauNen_Click;
            // 
            // mnuIt_Thoat
            // 
            mnuIt_Thoat.Name = "mnuIt_Thoat";
            mnuIt_Thoat.Size = new Size(224, 26);
            mnuIt_Thoat.Text = "Thoát";
            mnuIt_Thoat.Click += mnuIt_Thoat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lbl_GioHienTai, lbl_TenQuan, lbl_TrangThai });
            statusStrip1.Location = new Point(0, 443);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(754, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_GioHienTai
            // 
            lbl_GioHienTai.AutoToolTip = true;
            lbl_GioHienTai.Name = "lbl_GioHienTai";
            lbl_GioHienTai.Size = new Size(260, 20);
            lbl_GioHienTai.Spring = true;
            lbl_GioHienTai.Text = "Giờ Hiện Tại";
            lbl_GioHienTai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_TenQuan
            // 
            lbl_TenQuan.AutoToolTip = true;
            lbl_TenQuan.Name = "lbl_TenQuan";
            lbl_TenQuan.Size = new Size(260, 20);
            lbl_TenQuan.Spring = true;
            lbl_TenQuan.Text = "CAFE ÁNH DƯƠNG";
            // 
            // lbl_TrangThai
            // 
            lbl_TrangThai.AutoSize = false;
            lbl_TrangThai.Name = "lbl_TrangThai";
            lbl_TrangThai.Size = new Size(218, 20);
            lbl_TrangThai.Text = "Trạng Thái";
            lbl_TrangThai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer_GioHienTai
            // 
            timer_GioHienTai.Enabled = true;
            timer_GioHienTai.Interval = 1000;
            timer_GioHienTai.Tick += timer_GioHienTai_Tick;
            // 
            // frm_MainSreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(754, 469);
            Controls.Add(statusStrip1);
            Controls.Add(mnuSp_MainScreen);
            MainMenuStrip = mnuSp_MainScreen;
            Name = "frm_MainSreen";
            Text = "Cà Phê Ánh Dương";
            mnuSp_MainScreen.ResumeLayout(false);
            mnuSp_MainScreen.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuSp_MainScreen;
        private ToolStripMenuItem mnu_HeThong;
        private ToolStripMenuItem mnuIt_DoiMauNen;
        private ToolStripMenuItem mnuIt_Thoat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_GioHienTai;
        private ToolStripStatusLabel lbl_TenQuan;
        private ToolStripStatusLabel lbl_TrangThai;
        private System.Windows.Forms.Timer timer_GioHienTai;
    }
}
