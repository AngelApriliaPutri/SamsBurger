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
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Sam_s_Burger
{
    public partial class Sales : Form
    {
        string connection, directory, search;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtSales, dtSales2, dtSales3;
        Guna2ShadowPanel[] panels;
        Label[] title, total, totalcust;

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to log out?", "Log out?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                this.Controls.Clear();

                Sales s = new Sales();
                s.TopLevel = false;
                s.Dock = DockStyle.Fill;
                this.Controls.Add(s);
                s.Show();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            panel_sales.Controls.Clear();
            dtSales2 = new DataTable();
            string command2 = $"select * from Penjualan_harian where Tanggal_Penjualan like '%{date_time.Value.ToString("yyyy-MM-dd")}%'";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSales2);

            for (int j = 0; j < dtSales2.Rows.Count; j++)
            {
                dtSales = new DataTable();
                string command = $"select * from Pesanan where ID_Penjualan = '{dtSales2.Rows[j][0].ToString()}' order by 2 desc";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSales);

                panels[j] = new Guna2ShadowPanel();
                panels[j].Size = new Size(600, 150);
                panels[j].Location = new Point(30, 20);
                this.panel_sales.Controls.Add(panels[j]);

                title[j] = new Label();
                title[j].Size = new Size(220, 24);
                title[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                title[j].Location = new Point(30, 30);
                title[j].TextAlign = ContentAlignment.MiddleLeft;
                title[j].BackColor = Color.White;
                title[j].Text = dtSales2.Rows[j][1].ToString() + " - " + dtSales2.Rows[j][0].ToString();
                panels[j].Controls.Add(title[j]);

                total[j] = new Label();
                total[j].Size = new Size(200, 24);
                total[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                total[j].Location = new Point(30, 70);
                total[j].TextAlign = ContentAlignment.MiddleLeft;
                total[j].BackColor = Color.White;
                total[j].Text = "Total pendapatan: Rp. " + dtSales2.Rows[j][2].ToString();
                panels[j].Controls.Add(total[j]);

                dgv_sales[j] = new Guna2DataGridView();
                dgv_sales[j].Size = new Size(300, 120);
                dgv_sales[j].Location = new Point(260, 10);
                dgv_sales[j].DataSource = dtSales;
                panels[j].Controls.Add(dgv_sales[j]);

            }
        }

        Guna2DataGridView[] dgv_sales;
        public Sales()
        {
            connection = "server=localhost;user=root;pwd=r123;database=db_SamsBurger";
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Sales sales = new Sales();
            sales.TopLevel = false;
            sales.Dock = DockStyle.Fill;
            this.Controls.Add(sales);
            sales.Show();
        }

        private void Sales_Load(object sender, EventArgs e)
        {

            dtSales2 = new DataTable();
            string command2 = "select * from Penjualan_harian";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSales2);

            int x = 30;
            int y = 20;
            panels = new Guna2ShadowPanel[dtSales2.Rows.Count];
            title = new Label[dtSales2.Rows.Count];
            total = new Label[dtSales2.Rows.Count];
            totalcust = new Label[dtSales2.Rows.Count];
            dgv_sales = new Guna2DataGridView[dtSales2.Rows.Count];

            for (int j = 0; j < dtSales2.Rows.Count; j++)
            {
                dtSales = new DataTable();
                string command = $"select * from Pesanan where ID_Penjualan = '{dtSales2.Rows[j][0].ToString()}' order by 2 desc";
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSales);

                dtSales3 = new DataTable();
                string command3 = $"select count(ID_Pesanan) from Pesanan where ID_Penjualan = '{dtSales2.Rows[j][0].ToString()}' group by ID_Penjualan";
                sqlCommand = new MySqlCommand(command3, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtSales3);

                panels[j] = new Guna2ShadowPanel();
                panels[j].Size = new Size(600, 150); 
                panels[j].Location = new Point(x, y);
                this.panel_sales.Controls.Add(panels[j]);

                title[j] = new Label();
                title[j].Size = new Size(220, 24);
                title[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                title[j].Location = new Point(30, 20);
                title[j].TextAlign = ContentAlignment.MiddleLeft;
                title[j].BackColor = Color.White;
                title[j].Text = dtSales2.Rows[j][1].ToString() + " - " + dtSales2.Rows[j][0].ToString();
                panels[j].Controls.Add(title[j]);

                total[j] = new Label();
                total[j].Size = new Size(200, 24);
                total[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                total[j].Location = new Point(30, 60);
                total[j].TextAlign = ContentAlignment.MiddleLeft;
                total[j].BackColor = Color.White;
                total[j].Text = "Total pendapatan: Rp. " + dtSales2.Rows[j][2].ToString();
                panels[j].Controls.Add(total[j]);

                totalcust[j] = new Label();
                totalcust[j].Size = new Size(200, 24);
                totalcust[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                totalcust[j].Location = new Point(30, 100);
                totalcust[j].TextAlign = ContentAlignment.MiddleLeft;
                totalcust[j].BackColor = Color.White;
                totalcust[j].Text = "Total customer: " + dtSales3.Rows[0][0].ToString();
                panels[j].Controls.Add(totalcust[j]);

                dgv_sales[j] = new Guna2DataGridView();
                dgv_sales[j].Size = new Size(300, 120);
                dgv_sales[j].Location = new Point(260, 10);
                dgv_sales[j].DataSource = dtSales;
                panels[j].Controls.Add(dgv_sales[j]);

                y += 160;

            }

        }

    }

}
