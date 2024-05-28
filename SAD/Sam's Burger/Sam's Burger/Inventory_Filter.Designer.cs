namespace Sam_s_Burger
{
    partial class Inventory_Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_Filter));
            this.btn_filter = new Guna.UI2.WinForms.Guna2Button();
            this.stock_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.close_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.Transparent;
            this.btn_filter.BorderRadius = 10;
            this.btn_filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_filter.FillColor = System.Drawing.Color.Firebrick;
            this.btn_filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.Location = new System.Drawing.Point(153, 199);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(124, 57);
            this.btn_filter.TabIndex = 2;
            this.btn_filter.Text = "Filter";
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // stock_txt
            // 
            this.stock_txt.BackColor = System.Drawing.Color.Transparent;
            this.stock_txt.BorderRadius = 10;
            this.stock_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_txt.DefaultText = "";
            this.stock_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stock_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stock_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stock_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_txt.Location = new System.Drawing.Point(55, 129);
            this.stock_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.PasswordChar = '\0';
            this.stock_txt.PlaceholderText = "E.g. 100";
            this.stock_txt.SelectedText = "";
            this.stock_txt.Size = new System.Drawing.Size(318, 48);
            this.stock_txt.TabIndex = 3;
            this.stock_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_txt_KeyPress);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(172, 47);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(91, 39);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Filter";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(57, 104);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(185, 21);
            this.lbl_max.TabIndex = 5;
            this.lbl_max.Text = "Enter maximum stock";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_btn.BackgroundImage")));
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.close_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.close_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.close_btn.FillColor = System.Drawing.Color.Transparent;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.close_btn.ForeColor = System.Drawing.Color.Transparent;
            this.close_btn.Location = new System.Drawing.Point(401, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close_btn.Size = new System.Drawing.Size(36, 35);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "close_btn";
            this.close_btn.UseTransparentBackground = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Inventory_Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 307);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.btn_filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_filter;
        private Guna.UI2.WinForms.Guna2TextBox stock_txt;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_max;
        private Guna.UI2.WinForms.Guna2CircleButton close_btn;
    }
}