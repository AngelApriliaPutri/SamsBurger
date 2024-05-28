namespace Sam_s_Burger
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.date_time = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.search_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btn_reset = new Guna.UI2.WinForms.Guna2Button();
            this.panel_sales = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // date_time
            // 
            this.date_time.BackColor = System.Drawing.Color.Transparent;
            this.date_time.BorderRadius = 10;
            this.date_time.BorderThickness = 2;
            this.date_time.Checked = true;
            this.date_time.FillColor = System.Drawing.Color.White;
            this.date_time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_time.Location = new System.Drawing.Point(65, 127);
            this.date_time.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_time.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(347, 36);
            this.date_time.TabIndex = 0;
            this.date_time.UseTransparentBackground = true;
            this.date_time.Value = new System.DateTime(2023, 12, 15, 12, 22, 57, 0);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_btn.FillColor = System.Drawing.Color.Transparent;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_btn.ForeColor = System.Drawing.Color.Transparent;
            this.search_btn.Location = new System.Drawing.Point(427, 128);
            this.search_btn.Name = "search_btn";
            this.search_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.search_btn.Size = new System.Drawing.Size(40, 35);
            this.search_btn.TabIndex = 12;
            this.search_btn.Text = "guna2CircleButton1";
            this.search_btn.UseTransparentBackground = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.BorderRadius = 10;
            this.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reset.FillColor = System.Drawing.Color.Firebrick;
            this.btn_reset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(489, 124);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(142, 39);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // panel_sales
            // 
            this.panel_sales.AutoScroll = true;
            this.panel_sales.BackColor = System.Drawing.Color.Transparent;
            this.panel_sales.Location = new System.Drawing.Point(1, 193);
            this.panel_sales.Name = "panel_sales";
            this.panel_sales.Size = new System.Drawing.Size(923, 435);
            this.panel_sales.TabIndex = 15;
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
            this.btn_logout.Location = new System.Drawing.Point(810, 66);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_logout.Size = new System.Drawing.Size(54, 51);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseTransparentBackground = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 628);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panel_sales);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.date_time);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker date_time;
        private Guna.UI2.WinForms.Guna2CircleButton search_btn;
        private Guna.UI2.WinForms.Guna2Button btn_reset;
        private Guna.UI2.WinForms.Guna2Panel panel_sales;
        private Guna.UI2.WinForms.Guna2CircleButton btn_logout;
    }
}