using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sam_s_Burger
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Guna2Button btn_now;
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            popup_btn(btn_dashboard);

            panel_menu.Controls.Clear();

            Dashboard dashboard = new Dashboard();
            dashboard.TopLevel = false;
            dashboard.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            popup_btn(btn_orders);

            panel_menu.Controls.Clear();

            POS pos = new POS();
            pos.TopLevel = false;
            pos.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(pos);
            pos.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            popup_btn(btn_inventory);

            panel_menu.Controls.Clear();

            Inventory inv = new Inventory();
            inv.TopLevel = false;
            inv.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(inv);
            inv.Show();
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            popup_btn(btn_sales);

            panel_menu.Controls.Clear();

            Sales sales = new Sales();
            sales.TopLevel = false;
            sales.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(sales);
            sales.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btn_now = btn_orders;
            btn_now.Location = new Point(btn_now.Location.X + 10, btn_now.Location.Y);
            btn_now.FillColor = Color.LightGray;

            POS pos = new POS();
            pos.TopLevel = false;
            pos.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(pos);
            pos.Show();
        }
        private void popup_btn(Guna2Button button)
        {
            btn_now.FillColor = Color.White;
            btn_now.Location = new Point(btn_now.Location.X - 10, btn_now.Location.Y);
            btn_now = button;
            btn_now.Location = new Point(btn_now.Location.X + 10, btn_now.Location.Y);
            btn_now.FillColor = Color.LightGray;
        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
