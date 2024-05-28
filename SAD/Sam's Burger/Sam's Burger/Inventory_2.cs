using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sam_s_Burger
{
    public partial class Inventory_2 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtStock;
        string connection;
        public static string chosenBatch;
        public static int stock_count;
        public Inventory_2()
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

        private void Inventory_2_Load(object sender, EventArgs e)
        {
            lbl_total.Size = new Size(150, 21);
            guna2HtmlLabel1.Size = new Size(75, 21);
            string directory = directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string url = Inventory.poster;
            string fullUrl = directory + url;
            stock_pic.ImageLocation = fullUrl;
            stock_pic.SizeMode = PictureBoxSizeMode.StretchImage;

            dtStock = new DataTable();
            string command2 = $"select * from Stock where Nama_Stock = '{Inventory.chosen_stock}'";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStock);

            stock_data.DataSource = dtStock;

            stock_count = 0;
            int cogs = 0;

            for(int i = 0; i < dtStock.Rows.Count; i++)
            {
                stock_count += Convert.ToInt32(dtStock.Rows[i][2]);
                cogs += Convert.ToInt32(dtStock.Rows[i][3]);
            }
            cogs = cogs / dtStock.Rows.Count;

            lbl_details.Size = new Size(250, 25);
            lbl_details.Text = dtStock.Rows[0][1].ToString() + "(" + dtStock.Rows[0][0].ToString().Substring(0,3) + ") | Available stock: " + stock_count + " | Average COGS: Rp. " + cogs;
        }

        private void stock_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = stock_data.CurrentCell.RowIndex;
            lbl_chosen.Text = stock_data.CurrentRow.Cells["ID_Stock"].Value.ToString();
        }

        private void btn_opname_Click(object sender, EventArgs e)
        {
            if(lbl_chosen.Text == "-")
            {
                MessageBox.Show("Select a batch", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chosenBatch = lbl_chosen.Text;
                Stock_Opname opname = new Stock_Opname();
                opname.TopLevel = true;
                opname.Dock = DockStyle.Top;
                opname.Show();
                timer1.Start();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            New_Batch newbatch = new New_Batch();
            newbatch.TopLevel = true;
            newbatch.Dock = DockStyle.Top;
            newbatch.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Stock_Opname.opnamed == true || New_Batch.added == true)
            {
                dtStock = new DataTable();
                string command2 = $"select * from Stock where Nama_Stock = '{Inventory.chosen_stock}'";
                sqlCommand = new MySqlCommand(command2, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtStock);

                stock_data.DataSource = dtStock;

                int stock_count = 0;
                int cogs = 0;

                for (int i = 0; i < dtStock.Rows.Count; i++)
                {
                    stock_count += Convert.ToInt32(dtStock.Rows[i][2]);
                    cogs += Convert.ToInt32(dtStock.Rows[i][3]);
                }
                cogs = cogs / dtStock.Rows.Count;

                lbl_details.Size = new Size(250, 25);
                lbl_details.Text = dtStock.Rows[0][1].ToString() + "(" + dtStock.Rows[0][0].ToString().Substring(0, 3) + ") | Available stock: " + stock_count + " | Average COGS: Rp. " + cogs;
                timer1.Stop();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Inventory inv = new Inventory();
            inv.TopLevel = false;
            inv.Dock = DockStyle.Fill;
            this.Controls.Add(inv);
            inv.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if(search_txt.Text == "")
            {
                MessageBox.Show("Enter the search bar", "", MessageBoxButtons.OK);
            }
            else
            {
                dtStock = new DataTable();
                string command2 = $"select * from Stock where ID_Stock like '%{search_txt.Text}%' and Nama_Stock = '{Inventory.chosen_stock}'";
                sqlCommand = new MySqlCommand(command2, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtStock);
                stock_data.DataSource = dtStock;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            Inventory_2 inv = new Inventory_2();
            inv.TopLevel = false;
            inv.Dock = DockStyle.Fill;
            this.Controls.Add(inv);
            inv.Show();
        }
    }
}
