namespace Sam_s_Burger
{
    partial class Inventory_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_2));
            this.stock_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.stock_data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_opname = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_total = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_chosen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_stock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_details = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.search_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.search_txt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stock_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_data)).BeginInit();
            this.SuspendLayout();
            // 
            // stock_pic
            // 
            this.stock_pic.ImageRotate = 0F;
            this.stock_pic.Location = new System.Drawing.Point(65, 190);
            this.stock_pic.Name = "stock_pic";
            this.stock_pic.Size = new System.Drawing.Size(246, 365);
            this.stock_pic.TabIndex = 2;
            this.stock_pic.TabStop = false;
            // 
            // stock_data
            // 
            this.stock_data.AllowUserToAddRows = false;
            this.stock_data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.stock_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stock_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.stock_data.ColumnHeadersHeight = 4;
            this.stock_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_data.DefaultCellStyle = dataGridViewCellStyle3;
            this.stock_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.stock_data.Location = new System.Drawing.Point(344, 233);
            this.stock_data.Name = "stock_data";
            this.stock_data.ReadOnly = true;
            this.stock_data.RowHeadersVisible = false;
            this.stock_data.RowHeadersWidth = 51;
            this.stock_data.RowTemplate.Height = 24;
            this.stock_data.Size = new System.Drawing.Size(526, 243);
            this.stock_data.TabIndex = 3;
            this.stock_data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.stock_data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.stock_data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.stock_data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.stock_data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.stock_data.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.stock_data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.stock_data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.stock_data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.stock_data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.stock_data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.stock_data.ThemeStyle.HeaderStyle.Height = 4;
            this.stock_data.ThemeStyle.ReadOnly = true;
            this.stock_data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.stock_data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.stock_data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.stock_data.ThemeStyle.RowsStyle.Height = 24;
            this.stock_data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.stock_data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.stock_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stock_data_CellContentClick);
            // 
            // btn_opname
            // 
            this.btn_opname.BackColor = System.Drawing.Color.Transparent;
            this.btn_opname.BorderRadius = 10;
            this.btn_opname.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_opname.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_opname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_opname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_opname.FillColor = System.Drawing.Color.Firebrick;
            this.btn_opname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_opname.ForeColor = System.Drawing.Color.White;
            this.btn_opname.Location = new System.Drawing.Point(366, 516);
            this.btn_opname.Name = "btn_opname";
            this.btn_opname.Size = new System.Drawing.Size(181, 39);
            this.btn_opname.TabIndex = 4;
            this.btn_opname.Text = "Stock Opname";
            this.btn_opname.Click += new System.EventHandler(this.btn_opname_Click);
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
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(658, 516);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 39);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add Batch";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(366, 489);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(123, 21);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Chosen batch:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(658, 489);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(53, 21);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Stock:";
            // 
            // lbl_chosen
            // 
            this.lbl_chosen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chosen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chosen.Location = new System.Drawing.Point(505, 489);
            this.lbl_chosen.Name = "lbl_chosen";
            this.lbl_chosen.Size = new System.Drawing.Size(10, 21);
            this.lbl_chosen.TabIndex = 8;
            this.lbl_chosen.Text = "-";
            this.lbl_chosen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_stock
            // 
            this.lbl_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stock.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(731, 489);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(10, 21);
            this.lbl_stock.TabIndex = 9;
            this.lbl_stock.Text = "-";
            this.lbl_stock.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_details
            // 
            this.lbl_details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_details.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_details.Location = new System.Drawing.Point(344, 190);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(52, 20);
            this.lbl_details.TabIndex = 10;
            this.lbl_details.Text = "Details";
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
            this.search_btn.Location = new System.Drawing.Point(395, 116);
            this.search_btn.Name = "search_btn";
            this.search_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.search_btn.Size = new System.Drawing.Size(40, 35);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "guna2CircleButton1";
            this.search_btn.UseTransparentBackground = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btn_back.Location = new System.Drawing.Point(816, 46);
            this.btn_back.Name = "btn_back";
            this.btn_back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_back.Size = new System.Drawing.Size(54, 51);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "Logout";
            this.btn_back.UseTransparentBackground = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(456, 114);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(142, 39);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Reset";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.Color.Transparent;
            this.search_txt.BorderRadius = 10;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultText = "";
            this.search_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_txt.Location = new System.Drawing.Point(65, 109);
            this.search_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_txt.Name = "search_txt";
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderText = "Search ID (e.g. TOM001)";
            this.search_txt.SelectedText = "";
            this.search_txt.Size = new System.Drawing.Size(318, 48);
            this.search_txt.TabIndex = 1;
            // 
            // Inventory_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 609);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_chosen);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_opname);
            this.Controls.Add(this.stock_data);
            this.Controls.Add(this.stock_pic);
            this.Controls.Add(this.search_txt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox stock_pic;
        private Guna.UI2.WinForms.Guna2DataGridView stock_data;
        private Guna.UI2.WinForms.Guna2Button btn_opname;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_total;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_chosen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_stock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_details;
        private Guna.UI2.WinForms.Guna2CircleButton search_btn;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_back;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox search_txt;
    }
}