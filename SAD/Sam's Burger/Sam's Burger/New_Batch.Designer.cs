namespace Sam_s_Burger
{
    partial class New_Batch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Batch));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.price_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_exp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_available = new System.Windows.Forms.Label();
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.close_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(96, 45);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(224, 34);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Add new batch";
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.Location = new System.Drawing.Point(149, 79);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(112, 21);
            this.lbl_max.TabIndex = 6;
            this.lbl_max.Text = "stock_name";
            this.lbl_max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price / pcs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amount_txt
            // 
            this.amount_txt.BackColor = System.Drawing.Color.Transparent;
            this.amount_txt.BorderRadius = 10;
            this.amount_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount_txt.DefaultText = "";
            this.amount_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount_txt.Location = new System.Drawing.Point(51, 179);
            this.amount_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.PasswordChar = '\0';
            this.amount_txt.PlaceholderText = "E.g. 100";
            this.amount_txt.SelectedText = "";
            this.amount_txt.Size = new System.Drawing.Size(307, 48);
            this.amount_txt.TabIndex = 9;
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_txt_KeyPress);
            // 
            // price_txt
            // 
            this.price_txt.BackColor = System.Drawing.Color.Transparent;
            this.price_txt.BorderRadius = 10;
            this.price_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_txt.DefaultText = "";
            this.price_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Location = new System.Drawing.Point(51, 372);
            this.price_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price_txt.Name = "price_txt";
            this.price_txt.PasswordChar = '\0';
            this.price_txt.PlaceholderText = "E.g. 5000";
            this.price_txt.SelectedText = "";
            this.price_txt.Size = new System.Drawing.Size(307, 48);
            this.price_txt.TabIndex = 10;
            this.price_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Expired Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_exp
            // 
            this.date_exp.Checked = true;
            this.date_exp.FillColor = System.Drawing.Color.White;
            this.date_exp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_exp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_exp.Location = new System.Drawing.Point(51, 284);
            this.date_exp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_exp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_exp.Name = "date_exp";
            this.date_exp.Size = new System.Drawing.Size(307, 36);
            this.date_exp.TabIndex = 12;
            this.date_exp.Value = new System.DateTime(2023, 12, 4, 18, 19, 41, 64);
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_available.Location = new System.Drawing.Point(127, 100);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(131, 17);
            this.lbl_available.TabIndex = 13;
            this.lbl_available.Text = "(Available stock: 0)";
            this.lbl_available.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderRadius = 10;
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.Firebrick;
            this.btn_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(142, 438);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 46);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.close_btn.Location = new System.Drawing.Point(382, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.close_btn.Size = new System.Drawing.Size(36, 35);
            this.close_btn.TabIndex = 15;
            this.close_btn.Text = "close_btn";
            this.close_btn.UseTransparentBackground = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // New_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 509);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_available);
            this.Controls.Add(this.date_exp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_Batch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.New_Batch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox amount_txt;
        private Guna.UI2.WinForms.Guna2TextBox price_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_exp;
        private System.Windows.Forms.Label lbl_available;
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private Guna.UI2.WinForms.Guna2CircleButton close_btn;
    }
}