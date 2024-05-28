using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Sam_s_Burger
{
    public partial class Stock_Opname : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtStock;
        string connection;
        public static bool opnamed;
        public Stock_Opname()
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string command = $"update Stock set Jumlah_Stock = Jumlah_Stock + {Convert.ToInt32(stock_txt.Text)} where ID_Stock = '{Inventory_2.chosenBatch}'";
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
            opnamed = true;
            this.Close();
        }

        private void Stock_Opname_Load(object sender, EventArgs e)
        {
            dtStock = new DataTable();
            string command2 = $"select * from Stock where ID_Stock = '{Inventory_2.chosenBatch}'";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStock);
            lbl_itemid.Text = Inventory_2.chosenBatch;
            lbl_remaining.Text = "Remaining: " + dtStock.Rows[0][2].ToString();
            opnamed = false;
        }

        private void stock_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(stock_txt.Text) > Convert.ToInt32(dtStock.Rows[0][2]))
            {
                MessageBox.Show("Insufficient remaining stock.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string command = $"update Stock set Jumlah_Stock = Jumlah_Stock - {Convert.ToInt32(stock_txt.Text)} where ID_Stock = '{Inventory_2.chosenBatch}'";
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
                opnamed = true;
                this.Close();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
