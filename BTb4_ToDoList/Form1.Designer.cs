namespace BTb4_ToDoList
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
            lbl_TenCongViec = new Label();
            txt_CongViecMoi = new TextBox();
            lst_CongViec = new ListBox();
            cms_CongViec = new ContextMenuStrip(components);
            mnuIt_HoanThanh = new ToolStripMenuItem();
            mnuIt_XoaCongViecNay = new ToolStripMenuItem();
            mnuIt_XoaTatCa = new ToolStripMenuItem();
            lbl_CongViec = new Label();
            btn_Them = new Button();
            cms_CongViec.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_TenCongViec
            // 
            lbl_TenCongViec.AutoSize = true;
            lbl_TenCongViec.Location = new Point(0, 36);
            lbl_TenCongViec.Name = "lbl_TenCongViec";
            lbl_TenCongViec.Size = new Size(99, 20);
            lbl_TenCongViec.TabIndex = 0;
            lbl_TenCongViec.Text = "Tên công việc";
            // 
            // txt_CongViecMoi
            // 
            txt_CongViecMoi.Location = new Point(180, 33);
            txt_CongViecMoi.Name = "txt_CongViecMoi";
            txt_CongViecMoi.Size = new Size(266, 27);
            txt_CongViecMoi.TabIndex = 1;
            // 
            // lst_CongViec
            // 
            lst_CongViec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lst_CongViec.ContextMenuStrip = cms_CongViec;
            lst_CongViec.FormattingEnabled = true;
            lst_CongViec.Location = new Point(0, 131);
            lst_CongViec.Name = "lst_CongViec";
            lst_CongViec.Size = new Size(798, 304);
            lst_CongViec.TabIndex = 2;
            // 
            // cms_CongViec
            // 
            cms_CongViec.ImageScalingSize = new Size(20, 20);
            cms_CongViec.Items.AddRange(new ToolStripItem[] { mnuIt_HoanThanh, mnuIt_XoaCongViecNay, mnuIt_XoaTatCa });
            cms_CongViec.Name = "cms_CongViec";
            cms_CongViec.Size = new Size(221, 76);
            cms_CongViec.Text = "Công Việc";
            // 
            // mnuIt_HoanThanh
            // 
            mnuIt_HoanThanh.Name = "mnuIt_HoanThanh";
            mnuIt_HoanThanh.Size = new Size(220, 24);
            mnuIt_HoanThanh.Text = "Đánh dấu hoàn thành";
            mnuIt_HoanThanh.Click += mnuIt_HoanThanh_Click;
            // 
            // mnuIt_XoaCongViecNay
            // 
            mnuIt_XoaCongViecNay.Name = "mnuIt_XoaCongViecNay";
            mnuIt_XoaCongViecNay.Size = new Size(220, 24);
            mnuIt_XoaCongViecNay.Text = "Xóa Công Việc này";
            mnuIt_XoaCongViecNay.Click += mnuIt_XoaCongViecNay_Click;
            // 
            // mnuIt_XoaTatCa
            // 
            mnuIt_XoaTatCa.Name = "mnuIt_XoaTatCa";
            mnuIt_XoaTatCa.Size = new Size(220, 24);
            mnuIt_XoaTatCa.Text = "Xóa tất cả";
            mnuIt_XoaTatCa.Click += mnuIt_XoaTatCa_Click;
            // 
            // lbl_CongViec
            // 
            lbl_CongViec.AutoSize = true;
            lbl_CongViec.Location = new Point(0, 107);
            lbl_CongViec.Name = "lbl_CongViec";
            lbl_CongViec.Size = new Size(74, 20);
            lbl_CongViec.TabIndex = 3;
            lbl_CongViec.Text = "Công việc";
            lbl_CongViec.Click += lbl_CongViec_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(585, 36);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // frm_MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Them);
            Controls.Add(lbl_CongViec);
            Controls.Add(lst_CongViec);
            Controls.Add(txt_CongViecMoi);
            Controls.Add(lbl_TenCongViec);
            Name = "frm_MainScreen";
            Text = "To-Do-List";
            cms_CongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenCongViec;
        private TextBox txt_CongViecMoi;
        private ListBox lst_CongViec;
        private Label lbl_CongViec;
        private ContextMenuStrip cms_CongViec;
        private ToolStripMenuItem mnuIt_HoanThanh;
        private ToolStripMenuItem mnuIt_XoaCongViecNay;
        private ToolStripMenuItem mnuIt_XoaTatCa;
        private Button btn_Them;
    }
}
