using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sam_s_Burger
{
    public partial class New_Batch : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtStock;
        MySqlDataReader sqlDataReader;
        string connection;
        public static bool added;
        public New_Batch()
        {
            connection = "server=localhost;user=root;pwd=;database=db_SamsBurger";
            try
            {
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void amount_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void price_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(amount_txt.Text == "" || price_txt.Text == "")
            {
                MessageBox.Show("Enter all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date_exp.Value < DateTime.Now)
            {
                MessageBox.Show("Date must be older from now.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = $"insert into Stock (Nama_Stock, Jumlah_Stock, Harga_Beli, Expired_Date) values ('{Inventory.chosen_stock}', {Convert.ToInt32(amount_txt.Text)}, {Convert.ToInt32(price_txt.Text)}, '{date_exp.Value.ToString("yyyy-MM-dd")}')";
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
                added = true;
                this.Close();
            }
        }

        private void New_Batch_Load(object sender, EventArgs e)
        {
            added = false;
            lbl_max.Text = Inventory.chosen_stock;
            lbl_available.Text = "(Available stock: " + Inventory_2.stock_count.ToString() + ")";
        }
    }
}
