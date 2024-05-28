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
    public partial class Inventory : Form
    {
        string connection, directory, search;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtInv, dtStock;
        List<string> itemid, name, exp, imagePaths;
        List<int> stock, hpp;
        Guna2ShadowPanel[] panels;
        Label[] itemname, stock_total, cogs, exp_date;
        public static string chosen_stock, poster;

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

                Inventory inv = new Inventory();
                inv.TopLevel = false;
                inv.Dock = DockStyle.Fill;
                this.Controls.Add(inv);
                inv.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Inventory_Filter.filtered == true)
            {
                this.panel_inv.Controls.Clear();

                int j = 0;
                int k = 0;
                x = 25;
                y = 30;
                search = search_txt.Text;

                string file = "inv.txt";
                string[] lines = File.ReadAllLines(file);
                imagePaths = new List<string>();
                foreach (string line in lines)
                {
                    imagePaths.AddRange(line.Split(','));
                }

                directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

                foreach (int stok in stock)
                {
                    if (stok < Inventory_Filter.max_stock)
                    {
                        panels[j] = new Guna2ShadowPanel();
                        panels[j].Size = new Size(310, 150);
                        panels[j].Location = new Point(x, y);
                        this.panel_inv.Controls.Add(panels[j]);

                        image[j] = new PictureBox();
                        image[j].Size = new Size(90, 130);
                        image[j].Location = new Point(10, 10);
                        string url = imagePaths[j];
                        string fullUrl = directory + url;
                        image[j].ImageLocation = fullUrl;
                        image[j].SizeMode = PictureBoxSizeMode.StretchImage;
                        panels[j].Controls.Add(image[j]);

                        itemname[j] = new Label();
                        itemname[j].Size = new Size(150, 24);
                        itemname[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                        itemname[j].Location = new Point(105, 20);
                        itemname[j].TextAlign = ContentAlignment.MiddleLeft;
                        itemname[j].BackColor = Color.White;
                        itemname[j].Text = name[j] + " (" + itemid[j].Substring(0, 3).ToUpper() + ")";
                        panels[j].Controls.Add(itemname[j]);

                        stock_total[j] = new Label();
                        stock_total[j].Size = new Size(150, 24);
                        stock_total[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                        stock_total[j].Location = new Point(105, 50);
                        stock_total[j].TextAlign = ContentAlignment.MiddleLeft;
                        stock_total[j].BackColor = Color.White;
                        stock_total[j].Text = "Available stock: " + stock[j].ToString();
                        panels[j].Controls.Add(stock_total[j]);

                        cogs[j] = new Label();
                        cogs[j].Size = new Size(150, 24);
                        cogs[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                        cogs[j].Location = new Point(105, 80);
                        cogs[j].TextAlign = ContentAlignment.MiddleLeft;
                        cogs[j].BackColor = Color.White;
                        cogs[j].Text = "Average COGS: Rp. " + hpp[j].ToString();
                        panels[j].Controls.Add(cogs[j]);

                        exp_date[j] = new Label();
                        exp_date[j].Size = new Size(190, 24);
                        exp_date[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                        exp_date[j].Location = new Point(105, 110);
                        exp_date[j].TextAlign = ContentAlignment.MiddleLeft;
                        exp_date[j].BackColor = Color.White;
                        exp_date[j].Text = "Fastest EXP date: " + exp[j];
                        panels[j].Controls.Add(exp_date[j]);

                        next_btn[j] = new Guna2CircleButton();
                        next_btn[j].Size = new Size(30, 30);
                        next_btn[j].Location = new Point(275, 60);
                        next_btn[j].FillColor = Color.Transparent;
                        next_btn[j].ForeColor = Color.Transparent;
                        next_btn[j].BackgroundImage = Image.FromFile(@"C:\Users\Angel Aprilia\Downloads\SAD\SAD\Sam's Burger\Elements\next icon.png");
                        next_btn[j].BackgroundImageLayout = ImageLayout.Stretch;
                        next_btn[j].Click += next_btn_Click;
                        panels[j].Controls.Add(next_btn[j]);
                        k++;
                        if (k % 2 == 1 || k == 0)
                        {
                            x += 320;
                        }
                        else
                        {
                            x = 25;
                            y += 160;
                        }
                    }
                    j++;
                }
                timer1.Stop();
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Inventory_Filter filter = new Inventory_Filter();
            filter.TopLevel = true;
            filter.Dock = DockStyle.Top;
            filter.Show();

            timer1.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Inventory_Filter.filtered = false;
            this.Controls.Clear();
            Inventory inventory = new Inventory();
            inventory.TopLevel = false;
            inventory.Dock = DockStyle.Fill;
            this.Controls.Add(inventory);
            inventory.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            this.panel_inv.Controls.Clear();

            int j = 0;
            int k = 0;
            x = 25;
            y = 30;
            search = search_txt.Text;

            string file = "inv.txt";
            string[] lines = File.ReadAllLines(file);
            imagePaths = new List<string>();
            foreach (string line in lines)
            {
                imagePaths.AddRange(line.Split(','));
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            foreach (string item in name)
            {
                if (item.ToLower().Contains(search.ToLower()))
                {
                    panels[j] = new Guna2ShadowPanel();
                    panels[j].Size = new Size(310, 150);
                    panels[j].Location = new Point(x, y);
                    this.panel_inv.Controls.Add(panels[j]);

                    image[j] = new PictureBox();
                    image[j].Size = new Size(90, 130);
                    image[j].Location = new Point(10, 10);
                    string url = imagePaths[j];
                    string fullUrl = directory + url;
                    image[j].ImageLocation = fullUrl;
                    image[j].SizeMode = PictureBoxSizeMode.StretchImage;
                    panels[j].Controls.Add(image[j]);

                    itemname[j] = new Label();
                    itemname[j].Size = new Size(150, 24);
                    itemname[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                    itemname[j].Location = new Point(105, 20);
                    itemname[j].TextAlign = ContentAlignment.MiddleLeft;
                    itemname[j].BackColor = Color.White;
                    itemname[j].Text = name[j] + " (" + itemid[j].Substring(0, 3).ToUpper() + ")";
                    panels[j].Controls.Add(itemname[j]);

                    stock_total[j] = new Label();
                    stock_total[j].Size = new Size(150, 24);
                    stock_total[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                    stock_total[j].Location = new Point(105, 50);
                    stock_total[j].TextAlign = ContentAlignment.MiddleLeft;
                    stock_total[j].BackColor = Color.White;
                    stock_total[j].Text = "Available stock: " + stock[j].ToString();
                    panels[j].Controls.Add(stock_total[j]);

                    cogs[j] = new Label();
                    cogs[j].Size = new Size(150, 24);
                    cogs[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                    cogs[j].Location = new Point(105, 80);
                    cogs[j].TextAlign = ContentAlignment.MiddleLeft;
                    cogs[j].BackColor = Color.White;
                    cogs[j].Text = "Average COGS: Rp. " + hpp[j].ToString();
                    panels[j].Controls.Add(cogs[j]);

                    exp_date[j] = new Label();
                    exp_date[j].Size = new Size(190, 24);
                    exp_date[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                    exp_date[j].Location = new Point(105, 110);
                    exp_date[j].TextAlign = ContentAlignment.MiddleLeft;
                    exp_date[j].BackColor = Color.White;
                    exp_date[j].Text = "Fastest EXP date: " + exp[j];
                    panels[j].Controls.Add(exp_date[j]);

                    next_btn[j] = new Guna2CircleButton();
                    next_btn[j].Size = new Size(30, 30);
                    next_btn[j].Location = new Point(275, 60);
                    next_btn[j].FillColor = Color.Transparent;
                    next_btn[j].ForeColor = Color.Transparent;
                    next_btn[j].BackgroundImage = Image.FromFile(@"C:\Users\Angel Aprilia\Downloads\SAD\SAD\Sam's Burger\Elements\next icon.png");
                    next_btn[j].BackgroundImageLayout = ImageLayout.Stretch;
                    next_btn[j].Click += next_btn_Click;
                    panels[j].Controls.Add(next_btn[j]);
                    k++;
                    if (k % 2 == 1 || k == 0)
                    {
                        x += 320;
                    }
                    else
                    {
                        x = 25;
                        y += 160;
                    }
                }
                j++;
            }

            if(k == 0)
            {
                MessageBox.Show("No items found.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Controls.Clear();

                Inventory inventory = new Inventory();
                inventory.TopLevel = false;
                inventory.Dock = DockStyle.Fill;
                this.Controls.Add(inventory);
                inventory.Show();
            }
        }

        PictureBox[] image;
        Guna2CircleButton[] next_btn;
        int x, y;
        public Inventory()
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            dtInv = new DataTable();
            string command = "select ID_Stock, Nama_Stock, Expired_Date from Stock where ID_Stock like '%001';";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtInv);

            dtStock = new DataTable();
            string command2 = "select sum(Jumlah_Stock), sum(Harga_Beli) / count(Nama_Stock) from Stock group by Nama_Stock;";
            sqlCommand = new MySqlCommand(command2, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtStock);

            itemid = new List<string>();
            name = new List<string>();
            exp = new List<string>();
            for(int i = 0; i < dtInv.Rows.Count; i++)
            {
                itemid.Add(dtInv.Rows[i][0].ToString());
                name.Add(dtInv.Rows[i][1].ToString());
                exp.Add(dtInv.Rows[i][2].ToString());
            }
            stock = new List<int>();
            hpp = new List<int>();
            for(int i = 0; i < dtStock.Rows.Count; i++)
            {
                stock.Add(Convert.ToInt32(dtStock.Rows[i][0]));
                hpp.Add(Convert.ToInt32(dtStock.Rows[i][1]));
            }


            panels = new Guna2ShadowPanel[itemid.Count];
            itemname = new Label[itemid.Count];
            stock_total = new Label[itemid.Count];
            cogs = new Label[itemid.Count];
            exp_date = new Label[itemid.Count];
            image = new PictureBox[itemid.Count];
            next_btn = new Guna2CircleButton[itemid.Count];
            int j = 0;
            x = 25;
            y = 30;

            string file = "inv.txt";
            string[] lines = File.ReadAllLines(file);
            imagePaths = new List<string>();
            foreach (string line in lines)
            {
                imagePaths.AddRange(line.Split(','));
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            foreach (string item in itemid)
            {
                panels[j] = new Guna2ShadowPanel();
                panels[j].Size = new Size(310, 150);
                panels[j].Location = new Point(x, y);
                this.panel_inv.Controls.Add(panels[j]);

                image[j] = new PictureBox();
                image[j].Size = new Size(85, 130);
                image[j].Location = new Point(10, 10);
                string url = imagePaths[j];
                string fullUrl = directory + url;
                image[j].ImageLocation = fullUrl;
                image[j].SizeMode = PictureBoxSizeMode.StretchImage;
                panels[j].Controls.Add(image[j]);

                itemname[j] = new Label();
                itemname[j].Size = new Size(150, 24);
                itemname[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                itemname[j].Location = new Point(100, 20);
                itemname[j].TextAlign = ContentAlignment.MiddleLeft;
                itemname[j].BackColor = Color.White;
                itemname[j].Text = name[j] + " (" + itemid[j].Substring(0, 3).ToUpper() + ")";
                panels[j].Controls.Add(itemname[j]);

                stock_total[j] = new Label();
                stock_total[j].Size = new Size(150, 24);
                stock_total[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                stock_total[j].Location = new Point(100, 50);
                stock_total[j].TextAlign = ContentAlignment.MiddleLeft;
                stock_total[j].BackColor = Color.White;
                stock_total[j].Text = "Available stock: " + stock[j].ToString();
                panels[j].Controls.Add(stock_total[j]);

                cogs[j] = new Label();
                cogs[j].Size = new Size(180, 24);
                cogs[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                cogs[j].Location = new Point(100, 80);
                cogs[j].TextAlign = ContentAlignment.MiddleLeft;
                cogs[j].BackColor = Color.White;
                cogs[j].Text = "Average COGS: Rp. " + hpp[j].ToString();
                panels[j].Controls.Add(cogs[j]);

                exp_date[j] = new Label();
                exp_date[j].Size = new Size(190, 24);
                exp_date[j].Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
                exp_date[j].Location = new Point(100, 115);
                exp_date[j].TextAlign = ContentAlignment.MiddleLeft;
                exp_date[j].BackColor = Color.White;
                exp_date[j].Text = "Fastest EXP date: " + exp[j];
                panels[j].Controls.Add(exp_date[j]);

                next_btn[j] = new Guna2CircleButton();
                next_btn[j].Size = new Size(30, 30);
                next_btn[j].Location = new Point(280, 60);
                next_btn[j].FillColor = Color.Transparent;
                next_btn[j].ForeColor = Color.Transparent;
                next_btn[j].Tag = j;
                next_btn[j].BackgroundImage = Image.FromFile(@"C:\Users\Angel Aprilia\Downloads\SAD\SAD\Sam's Burger\Elements\next icon.png");
                next_btn[j].BackgroundImageLayout = ImageLayout.Stretch;
                next_btn[j].Click += next_btn_Click;
                panels[j].Controls.Add(next_btn[j]);

                j++;

                if(j % 2 == 1)
                { 
                    x += 320;
                }
                else
                {
                    x = 25;
                    y += 160;
                }
            }
        }
        public void next_btn_Click(object sender, EventArgs e)
        {
            var send = sender as Guna2CircleButton;
            chosen_stock = name[Convert.ToInt32(send.Tag)];
            poster = imagePaths[Convert.ToInt32(send.Tag)];

            this.Controls.Clear();

            Inventory_2 inv = new Inventory_2();
            inv.TopLevel = false;
            inv.Dock = DockStyle.Fill;
            this.Controls.Add(inv);
            inv.Show();
        }
    }
}
