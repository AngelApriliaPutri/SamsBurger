using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Sam_s_Burger
{
    public partial class POS_2 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtMenu;
        string connection, id;
        bool success;
        public POS_2()
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
        List<string> orders;
        List<int> jumlah;
        Label[] menuLabel, jumlahLabel, hargapcs, total, line;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            POS pos = new POS();
            pos.TopLevel = false;
            pos.Dock = DockStyle.Fill;
            this.Controls.Add(pos);
            pos.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            
            if(name_txt.Text == "")
            {
                MessageBox.Show("Insert order name.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                string command = $"insert into Pesanan (Tanggal_Pesanan, Total_Harga, Nama_Cust) values ('{DateTime.Now.ToString("yyyy-MM-dd")}', {Convert.ToInt32(lbl_total.Text)}, '{name_txt.Text}')";
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
                string command2;
                int k = 0;
                foreach (string item in orders)
                {
                    for(int i = 0; i < dtMenu.Rows.Count; i++)
                    {
                        if (dtMenu.Rows[i][1].ToString() == item)
                        {
                            id = dtMenu.Rows[i][0].ToString();
                            break;
                        }
                    }
                    int jumlah_barang = jumlah[k];
                    success = true;
                    for(int j = 0; j < jumlah_barang; j++)
                    {
                        command2 = $"insert into Menu_Pesanan (ID_Menu) values ('{id}')";
                        try
                        {
                            sqlConnection.Open();
                            sqlCommand = new MySqlCommand(command2, sqlConnection);
                            sqlDataReader = sqlCommand.ExecuteReader();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            success = false;
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                    k++;
                }
                if (success)
                {
                    MessageBox.Show("Payment accepted, printing invoice.", "Thank you for the order.", MessageBoxButtons.OK);
                    this.Controls.Clear();

                    POS pos = new POS();
                    pos.TopLevel = false;
                    pos.Dock = DockStyle.Fill;
                    this.Controls.Add(pos);
                    pos.Show();
                }
            }
            
        }

        private void POS_2_Load(object sender, EventArgs e)
        {
            orders = POS.cart;
            jumlah = POS.cartCount;
            menuLabel = new Label[orders.Count];
            jumlahLabel = new Label[jumlah.Count];
            hargapcs = new Label[jumlah.Count]; 
            total = new Label[jumlah.Count];
            line = new Label[jumlah.Count];
            int i = 0;
            int x = 50;
            int y = 200;
            lbl_total.Size = new Size(70, 30);
            lbl_rp.Size = new Size(30, 30);
            lbl_price.Size = new Size(60, 30);
            int harga_total = 0;
            int harga_item = 0;

            dtMenu = new DataTable();
            string command = "select * from Menu";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMenu);

            foreach (string pesanan in orders)
            {
                for (int j = 0; j < dtMenu.Rows.Count; j++)
                {
                    if (dtMenu.Rows[j][1].ToString() == pesanan)
                    {
                        harga_item = Convert.ToInt32(dtMenu.Rows[j][2]);
                        harga_total += harga_item * jumlah[i];
                    }
                }

                menuLabel[i] = new Label();
                menuLabel[i].Size = new Size(150, 24);
                menuLabel[i].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                menuLabel[i].Location = new Point(x, y);
                menuLabel[i].TextAlign = ContentAlignment.MiddleLeft;
                menuLabel[i].BackColor = Color.Transparent;
                menuLabel[i].Text = orders[i];
                this.Controls.Add(menuLabel[i]);

                jumlahLabel[i] = new Label();
                jumlahLabel[i].Size = new Size(50, 24);
                jumlahLabel[i].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                jumlahLabel[i].Location = new Point(x + 235, y);
                jumlahLabel[i].TextAlign = ContentAlignment.MiddleLeft;
                jumlahLabel[i].BackColor = Color.Transparent;
                jumlahLabel[i].Text = Convert.ToString(jumlah[i]);
                this.Controls.Add(jumlahLabel[i]);

                hargapcs[i] = new Label();
                hargapcs[i].Size = new Size(100, 24);
                hargapcs[i].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                hargapcs[i].Location = new Point(x + 340, y);
                hargapcs[i].TextAlign = ContentAlignment.MiddleLeft;
                hargapcs[i].BackColor = Color.Transparent;
                hargapcs[i].Text = "Rp. " + harga_item.ToString();
                this.Controls.Add(hargapcs[i]);

                total[i] = new Label();
                total[i].Size = new Size(100, 24);
                total[i].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                total[i].Location = new Point(x + 470, y);
                total[i].TextAlign = ContentAlignment.MiddleLeft;
                total[i].BackColor = Color.Transparent;
                total[i].Text = "Rp. " + (harga_item * jumlah[i]).ToString();
                this.Controls.Add(total[i]);

                line[i] = new Label();
                line[i].Size = new Size(800, 24);
                line[i].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                line[i].Location = new Point(x, y + 25);
                line[i].TextAlign = ContentAlignment.MiddleLeft;
                line[i].BackColor = Color.Transparent;
                line[i].Text = "-------------------------------------------------------------------------------------------------------";
                this.Controls.Add(line[i]);

                i++;
                y += 50;
                harga_item = 0;
            }
            lbl_total.Text = harga_total.ToString();
            lbl_pemesan.Size = new Size(70, 25);
        }
    }
}
