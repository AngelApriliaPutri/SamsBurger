namespace Sam_s_Burger
{
    partial class POS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.lbl_total = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_orders = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(509, 618);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(112, 25);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "Total items:";
            // 
            // lbl_orders
            // 
            this.lbl_orders.BackColor = System.Drawing.Color.Transparent;
            this.lbl_orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.Location = new System.Drawing.Point(637, 618);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(14, 25);
            this.lbl_orders.TabIndex = 2;
            this.lbl_orders.Text = "0";
            this.lbl_orders.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.Transparent;
            this.btn_checkout.BorderRadius = 10;
            this.btn_checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_checkout.FillColor = System.Drawing.Color.Firebrick;
            this.btn_checkout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Location = new System.Drawing.Point(704, 608);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(180, 45);
            this.btn_checkout.TabIndex = 0;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
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
            this.btn_logout.Location = new System.Drawing.Point(817, 45);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_logout.Size = new System.Drawing.Size(54, 51);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseTransparentBackground = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.btn_checkout);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.POS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_total;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_orders;
        private Guna.UI2.WinForms.Guna2Button btn_checkout;
        private Guna.UI2.WinForms.Guna2CircleButton btn_logout;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}