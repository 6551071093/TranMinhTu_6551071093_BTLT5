namespace Btb4_BanHangTapHoaMini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainScreen));
            mnuSp_MainScreen = new MenuStrip();
            mnuSp_File = new ToolStripMenuItem();
            mnuSpIt_DonHangMoi = new ToolStripMenuItem();
            mnuSpIt_Thoat = new ToolStripMenuItem();
            windowToolStripMenuItem = new ToolStripMenuItem();
            mnuSpIt_Cascade = new ToolStripMenuItem();
            mnuSpIt_TileHorizontal = new ToolStripMenuItem();
            mnuSpIt_TileVertical = new ToolStripMenuItem();
            tlSp_MainScreen = new ToolStrip();
            tSBtn_DonHangMoi = new ToolStripButton();
            staSp_MainScreen = new StatusStrip();
            lbl_SoDon = new ToolStripStatusLabel();
            lbl_Gio = new ToolStripStatusLabel();
            timer_Gio = new System.Windows.Forms.Timer(components);
            mnuSp_MainScreen.SuspendLayout();
            tlSp_MainScreen.SuspendLayout();
            staSp_MainScreen.SuspendLayout();
            SuspendLayout();
            // 
            // mnuSp_MainScreen
            // 
            mnuSp_MainScreen.ImageScalingSize = new Size(20, 20);
            mnuSp_MainScreen.Items.AddRange(new ToolStripItem[] { mnuSp_File, windowToolStripMenuItem });
            mnuSp_MainScreen.Location = new Point(0, 0);
            mnuSp_MainScreen.Name = "mnuSp_MainScreen";
            mnuSp_MainScreen.Size = new Size(723, 28);
            mnuSp_MainScreen.TabIndex = 1;
            mnuSp_MainScreen.Text = "menuStrip1";
            // 
            // mnuSp_File
            // 
            mnuSp_File.DropDownItems.AddRange(new ToolStripItem[] { mnuSpIt_DonHangMoi, mnuSpIt_Thoat });
            mnuSp_File.Name = "mnuSp_File";
            mnuSp_File.Size = new Size(46, 24);
            mnuSp_File.Text = "File";
            // 
            // mnuSpIt_DonHangMoi
            // 
            mnuSpIt_DonHangMoi.Name = "mnuSpIt_DonHangMoi";
            mnuSpIt_DonHangMoi.Size = new Size(187, 26);
            mnuSpIt_DonHangMoi.Text = "Đơn hàng mới";
            mnuSpIt_DonHangMoi.Click += mnuSpIt_DonHangMoi_Click;
            // 
            // mnuSpIt_Thoat
            // 
            mnuSpIt_Thoat.Name = "mnuSpIt_Thoat";
            mnuSpIt_Thoat.Size = new Size(187, 26);
            mnuSpIt_Thoat.Text = "Thoát";
            mnuSpIt_Thoat.Click += mnuSpIt_Thoat_Click;
            // 
            // windowToolStripMenuItem
            // 
            windowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuSpIt_Cascade, mnuSpIt_TileHorizontal, mnuSpIt_TileVertical });
            windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            windowToolStripMenuItem.Size = new Size(78, 24);
            windowToolStripMenuItem.Text = "Window";
            // 
            // mnuSpIt_Cascade
            // 
            mnuSpIt_Cascade.Name = "mnuSpIt_Cascade";
            mnuSpIt_Cascade.Size = new Size(190, 26);
            mnuSpIt_Cascade.Text = "Cascade";
            mnuSpIt_Cascade.Click += mnuSpIt_Cascade_Click;
            // 
            // mnuSpIt_TileHorizontal
            // 
            mnuSpIt_TileHorizontal.Name = "mnuSpIt_TileHorizontal";
            mnuSpIt_TileHorizontal.Size = new Size(190, 26);
            mnuSpIt_TileHorizontal.Text = "Tile Horizontal";
            mnuSpIt_TileHorizontal.Click += mnuSpIt_TileHorizontal_Click;
            // 
            // mnuSpIt_TileVertical
            // 
            mnuSpIt_TileVertical.Name = "mnuSpIt_TileVertical";
            mnuSpIt_TileVertical.Size = new Size(190, 26);
            mnuSpIt_TileVertical.Text = "Tile Vertical";
            mnuSpIt_TileVertical.Click += mnuSpIt_TileVertical_Click;
            // 
            // tlSp_MainScreen
            // 
            tlSp_MainScreen.ImageScalingSize = new Size(20, 20);
            tlSp_MainScreen.Items.AddRange(new ToolStripItem[] { tSBtn_DonHangMoi });
            tlSp_MainScreen.Location = new Point(0, 28);
            tlSp_MainScreen.Name = "tlSp_MainScreen";
            tlSp_MainScreen.Size = new Size(723, 27);
            tlSp_MainScreen.TabIndex = 2;
            tlSp_MainScreen.Text = "toolStrip1";
            // 
            // tSBtn_DonHangMoi
            // 
            tSBtn_DonHangMoi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSBtn_DonHangMoi.Image = (Image)resources.GetObject("tSBtn_DonHangMoi.Image");
            tSBtn_DonHangMoi.ImageTransparentColor = Color.Magenta;
            tSBtn_DonHangMoi.Name = "tSBtn_DonHangMoi";
            tSBtn_DonHangMoi.Size = new Size(29, 24);
            tSBtn_DonHangMoi.Text = "toolStripButton1";
            tSBtn_DonHangMoi.ToolTipText = "Đơn Hàng Mới";
            tSBtn_DonHangMoi.Click += tSBtn_DonHangMoi_Click;
            // 
            // staSp_MainScreen
            // 
            staSp_MainScreen.ImageScalingSize = new Size(20, 20);
            staSp_MainScreen.Items.AddRange(new ToolStripItem[] { lbl_SoDon, lbl_Gio });
            staSp_MainScreen.Location = new Point(0, 424);
            staSp_MainScreen.Name = "staSp_MainScreen";
            staSp_MainScreen.Size = new Size(723, 26);
            staSp_MainScreen.SizingGrip = false;
            staSp_MainScreen.TabIndex = 3;
            staSp_MainScreen.Text = "statusStrip1";
            // 
            // lbl_SoDon
            // 
            lbl_SoDon.Name = "lbl_SoDon";
            lbl_SoDon.Size = new Size(354, 20);
            lbl_SoDon.Spring = true;
            lbl_SoDon.Text = "Số Đơn";
            lbl_SoDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_Gio
            // 
            lbl_Gio.Name = "lbl_Gio";
            lbl_Gio.Size = new Size(354, 20);
            lbl_Gio.Spring = true;
            lbl_Gio.Text = "Giờ";
            lbl_Gio.TextAlign = ContentAlignment.MiddleRight;
            lbl_Gio.TextChanged += timer_Gio_Tick;
            // 
            // timer_Gio
            // 
            timer_Gio.Enabled = true;
            timer_Gio.Interval = 1000;
            timer_Gio.Tick += timer_Gio_Tick;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(staSp_MainScreen);
            Controls.Add(tlSp_MainScreen);
            Controls.Add(mnuSp_MainScreen);
            IsMdiContainer = true;
            MainMenuStrip = mnuSp_MainScreen;
            Name = "frm_MainScreen";
            Text = "MiniStop";
            Load += frm_MainScreen_Load;
            MdiChildActivate += frm_MainScreen_Load;
            mnuSp_MainScreen.ResumeLayout(false);
            mnuSp_MainScreen.PerformLayout();
            tlSp_MainScreen.ResumeLayout(false);
            tlSp_MainScreen.PerformLayout();
            staSp_MainScreen.ResumeLayout(false);
            staSp_MainScreen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuSp_MainScreen;
        private ToolStripMenuItem mnuSp_File;
        private ToolStripMenuItem mnuSpIt_DonHangMoi;
        private ToolStripMenuItem mnuSpIt_Thoat;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem mnuSpIt_Cascade;
        private ToolStripMenuItem mnuSpIt_TileHorizontal;
        private ToolStripMenuItem mnuSpIt_TileVertical;
        private ToolStrip tlSp_MainScreen;
        private ToolStripButton tSBtn_DonHangMoi;
        private StatusStrip staSp_MainScreen;
        private ToolStripStatusLabel lbl_SoDon;
        private ToolStripStatusLabel lbl_Gio;
        private System.Windows.Forms.Timer timer_Gio;
    }
}
