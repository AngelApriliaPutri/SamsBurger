using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sam_s_Burger
{
    public partial class Inventory_Filter : Form
    {
        public Inventory_Filter()
        {
            InitializeComponent();
        }
        public static int max_stock;
        public static bool filtered;
        private void btn_filter_Click(object sender, EventArgs e)
        {
            max_stock = Convert.ToInt32(stock_txt.Text);
            filtered = true;
            this.Close();
        }

        private void stock_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Inventory_Filter_Load(object sender, EventArgs e)
        {
            filtered = false;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
