namespace Sam_s_Burger
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pic_motw = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_motw2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_motw3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_notif = new System.Windows.Forms.Panel();
            this.lbl_MOTW = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.btn_logout = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_motw
            // 
            this.pic_motw.ImageRotate = 0F;
            this.pic_motw.Location = new System.Drawing.Point(51, 198);
            this.pic_motw.Name = "pic_motw";
            this.pic_motw.Size = new System.Drawing.Size(158, 185);
            this.pic_motw.TabIndex = 0;
            this.pic_motw.TabStop = false;
            // 
            // pic_motw2
            // 
            this.pic_motw2.ImageRotate = 0F;
            this.pic_motw2.Location = new System.Drawing.Point(262, 198);
            this.pic_motw2.Name = "pic_motw2";
            this.pic_motw2.Size = new System.Drawing.Size(158, 185);
            this.pic_motw2.TabIndex = 1;
            this.pic_motw2.TabStop = false;
            // 
            // pic_motw3
            // 
            this.pic_motw3.ImageRotate = 0F;
            this.pic_motw3.Location = new System.Drawing.Point(475, 198);
            this.pic_motw3.Name = "pic_motw3";
            this.pic_motw3.Size = new System.Drawing.Size(158, 185);
            this.pic_motw3.TabIndex = 2;
            this.pic_motw3.TabStop = false;
            // 
            // panel_notif
            // 
            this.panel_notif.Location = new System.Drawing.Point(685, 198);
            this.panel_notif.Name = "panel_notif";
            this.panel_notif.Size = new System.Drawing.Size(218, 407);
            this.panel_notif.TabIndex = 3;
            // 
            // lbl_MOTW
            // 
            this.lbl_MOTW.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MOTW.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MOTW.Location = new System.Drawing.Point(107, 338);
            this.lbl_MOTW.Name = "lbl_MOTW";
            this.lbl_MOTW.Size = new System.Drawing.Size(454, 58);
            this.lbl_MOTW.TabIndex = 4;
            this.lbl_MOTW.Text = "MENUS OF THE WEEK";
            // 
            // dgv_report
            // 
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(65, 471);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.RowHeadersWidth = 51;
            this.dgv_report.RowTemplate.Height = 24;
            this.dgv_report.Size = new System.Drawing.Size(564, 150);
            this.dgv_report.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.Transparent;
            this.btn_logout.Location = new System.Drawing.Point(802, 49);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_logout.Size = new System.Drawing.Size(54, 51);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseTransparentBackground = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 628);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_MOTW);
            this.Controls.Add(this.dgv_report);
            this.Controls.Add(this.panel_notif);
            this.Controls.Add(this.pic_motw3);
            this.Controls.Add(this.pic_motw2);
            this.Controls.Add(this.pic_motw);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_motw3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pic_motw;
        private Guna.UI2.WinForms.Guna2PictureBox pic_motw2;
        private Guna.UI2.WinForms.Guna2PictureBox pic_motw3;
        private System.Windows.Forms.Panel panel_notif;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_MOTW;
        private System.Windows.Forms.DataGridView dgv_report;
        private Guna.UI2.WinForms.Guna2CircleButton btn_logout;
    }
}