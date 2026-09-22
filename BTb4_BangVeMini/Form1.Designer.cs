namespace BTb4_BangVeMini
{
    partial class frm_FormBangVeMini
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
            pnlCanvas_mainPanel = new Panel();
            lbl_ViTri = new Label();
            lbl_TrangThai = new Label();
            SuspendLayout();
            // 
            // pnlCanvas_mainPanel
            // 
            pnlCanvas_mainPanel.Location = new Point(2, 52);
            pnlCanvas_mainPanel.Name = "pnlCanvas_mainPanel";
            pnlCanvas_mainPanel.Size = new Size(700, 334);
            pnlCanvas_mainPanel.TabIndex = 0;
            pnlCanvas_mainPanel.MouseClick += pnlCanvas_mainPanel_MouseClick;
            pnlCanvas_mainPanel.MouseDown += pnlCanvas_mainPanel_MouseDown;
            pnlCanvas_mainPanel.MouseMove += pnlCanvas_mainPanel_MouseMove;
            pnlCanvas_mainPanel.MouseUp += pnlCanvas_mainPanel_MouseUp;
            // 
            // lbl_ViTri
            // 
            lbl_ViTri.AutoSize = true;
            lbl_ViTri.Location = new Point(46, 408);
            lbl_ViTri.Name = "lbl_ViTri";
            lbl_ViTri.Size = new Size(50, 20);
            lbl_ViTri.TabIndex = 2;
            lbl_ViTri.Text = "label1";
            // 
            // lbl_TrangThai
            // 
            lbl_TrangThai.AutoSize = true;
            lbl_TrangThai.Location = new Point(640, 421);
            lbl_TrangThai.Name = "lbl_TrangThai";
            lbl_TrangThai.Size = new Size(50, 20);
            lbl_TrangThai.TabIndex = 3;
            lbl_TrangThai.Text = "label1";
            // 
            // frm_FormBangVeMini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(lbl_TrangThai);
            Controls.Add(lbl_ViTri);
            Controls.Add(pnlCanvas_mainPanel);
            Name = "frm_FormBangVeMini";
            Text = "FormBangVeMini";
            Load += frm_FormBangVeMini_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas_mainPanel;
        private Label lbl_ViTri;
        private Label lbl_TrangThai;
    }
}
