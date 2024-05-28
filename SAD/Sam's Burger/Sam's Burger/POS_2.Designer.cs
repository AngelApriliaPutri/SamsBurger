namespace Sam_s_Burger
{
    partial class POS_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS_2));
            this.btn_payment = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_rp = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_total = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_pemesan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_payment.BorderRadius = 10;
            this.btn_payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_payment.FillColor = System.Drawing.Color.Firebrick;
            this.btn_payment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Location = new System.Drawing.Point(592, 593);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(180, 45);
            this.btn_payment.TabIndex = 1;
            this.btn_payment.Text = "Payment";
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(313, 602);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(110, 25);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Total price:";
            this.lbl_price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rp
            // 
            this.lbl_rp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rp.Location = new System.Drawing.Point(442, 602);
            this.lbl_rp.Name = "lbl_rp";
            this.lbl_rp.Size = new System.Drawing.Size(34, 25);
            this.lbl_rp.TabIndex = 3;
            this.lbl_rp.Text = "Rp.";
            this.lbl_rp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(495, 602);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(14, 25);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "0";
            this.lbl_total.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_txt
            // 
            this.name_txt.BackColor = System.Drawing.Color.Transparent;
            this.name_txt.BorderRadius = 10;
            this.name_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_txt.DefaultText = "";
            this.name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_txt.Location = new System.Drawing.Point(74, 590);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_txt.Name = "name_txt";
            this.name_txt.PasswordChar = '\0';
            this.name_txt.PlaceholderText = "Nama";
            this.name_txt.SelectedText = "";
            this.name_txt.Size = new System.Drawing.Size(179, 48);
            this.name_txt.TabIndex = 10;
            // 
            // lbl_pemesan
            // 
            this.lbl_pemesan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pemesan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pemesan.Location = new System.Drawing.Point(74, 548);
            this.lbl_pemesan.Name = "lbl_pemesan";
            this.lbl_pemesan.Size = new System.Drawing.Size(167, 25);
            this.lbl_pemesan.TabIndex = 11;
            this.lbl_pemesan.Text = "Nama pemesan:";
            this.lbl_pemesan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(785, 65);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_back.Size = new System.Drawing.Size(54, 51);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Logout";
            this.btn_back.UseTransparentBackground = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // POS_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 665);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_pemesan);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_rp);
            this.Controls.Add(this.btn_payment);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POS_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.POS_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_payment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_price;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_rp;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_total;
        private Guna.UI2.WinForms.Guna2TextBox name_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_pemesan;
        private Guna.UI2.WinForms.Guna2CircleButton btn_back;
    }
}