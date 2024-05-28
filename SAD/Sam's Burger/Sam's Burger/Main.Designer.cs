namespace Sam_s_Burger
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btn_orders = new Guna.UI2.WinForms.Guna2Button();
            this.btn_inventory = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sales = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Location = new System.Drawing.Point(260, 1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(942, 675);
            this.panel_menu.TabIndex = 4;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.BorderRadius = 15;
            this.btn_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dashboard.FillColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(28, 193);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(209, 50);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseTransparentBackground = true;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders.BorderRadius = 15;
            this.btn_orders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_orders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_orders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_orders.FillColor = System.Drawing.Color.White;
            this.btn_orders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_orders.ForeColor = System.Drawing.Color.Black;
            this.btn_orders.Location = new System.Drawing.Point(28, 276);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(209, 50);
            this.btn_orders.TabIndex = 5;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseTransparentBackground = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Transparent;
            this.btn_inventory.BorderRadius = 15;
            this.btn_inventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_inventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_inventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_inventory.FillColor = System.Drawing.Color.White;
            this.btn_inventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_inventory.ForeColor = System.Drawing.Color.Black;
            this.btn_inventory.Location = new System.Drawing.Point(28, 361);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(209, 50);
            this.btn_inventory.TabIndex = 6;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseTransparentBackground = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.Transparent;
            this.btn_sales.BorderRadius = 15;
            this.btn_sales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sales.FillColor = System.Drawing.Color.White;
            this.btn_sales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_sales.ForeColor = System.Drawing.Color.Black;
            this.btn_sales.Location = new System.Drawing.Point(28, 449);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(209, 50);
            this.btn_sales.TabIndex = 7;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseTransparentBackground = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.panel_menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private Guna.UI2.WinForms.Guna2Button btn_dashboard;
        private Guna.UI2.WinForms.Guna2Button btn_orders;
        private Guna.UI2.WinForms.Guna2Button btn_inventory;
        private Guna.UI2.WinForms.Guna2Button btn_sales;
    }
}

