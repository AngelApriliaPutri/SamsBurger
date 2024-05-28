namespace Sam_s_Burger
{
    partial class Stock_Opname
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Opname));
            this.btn_remove = new Guna.UI2.WinForms.Guna2Button();
            this.stock_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.close_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Transparent;
            this.btn_remove.BorderRadius = 10;
            this.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_remove.FillColor = System.Drawing.Color.Firebrick;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(222, 230);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(124, 47);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
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
            this.stock_txt.Location = new System.Drawing.Point(58, 137);
            this.stock_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.PasswordChar = '\0';
            this.stock_txt.PlaceholderText = "E.g. 100";
            this.stock_txt.SelectedText = "";
            this.stock_txt.Size = new System.Drawing.Size(318, 48);
            this.stock_txt.TabIndex = 4;
            this.stock_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_txt_KeyPress);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(88, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(258, 39);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Stock Opname";
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.AutoSize = true;
            this.lbl_remaining.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remaining.Location = new System.Drawing.Point(58, 192);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(105, 21);
            this.lbl_remaining.TabIndex = 6;
            this.lbl_remaining.Text = "Remaining: ";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemid.Location = new System.Drawing.Point(183, 91);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(70, 21);
            this.lbl_itemid.TabIndex = 7;
            this.lbl_itemid.Text = "item_id";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BorderRadius = 10;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.Firebrick;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(95, 230);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 47);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.close_btn.Location = new System.Drawing.Point(402, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close_btn.Size = new System.Drawing.Size(36, 35);
            this.close_btn.TabIndex = 9;
            this.close_btn.Text = "close_btn";
            this.close_btn.UseTransparentBackground = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Stock_Opname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 307);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_itemid);
            this.Controls.Add(this.lbl_remaining);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.btn_remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_Opname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Stock_Opname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2TextBox stock_txt;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_remaining;
        private System.Windows.Forms.Label lbl_itemid;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2CircleButton close_btn;
        private System.Windows.Forms.Timer timer1;
    }
}