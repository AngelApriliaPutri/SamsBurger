using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sam_s_Burger
{
    public partial class POS : Form
    {
        string connection, directory;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dtMenu;
        public static string[] menu;
        PictureBox[] menuPics;
        Label[] menuLabel, order_count;
        Button[] plus_btn, minus_btn;
        public static List<string> imagePaths;
        public static List<string> cart;
        public static List<int> cartCount;
        int x, y, i;

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            dtMenu = new DataTable();
            string command = "select * from Menu";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMenu);

            cart = new List<string>();
            cartCount = new List<int>();
            int counter = 0;

            if (Convert.ToInt32(lbl_orders.Text) == 0)
            {
                MessageBox.Show("No items selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Label label in order_count)
                {
                    if (Convert.ToInt32(label.Text) > 0)
                    {
                        cart.Add(menuLabel[counter].Text);
                        cartCount.Add(Convert.ToInt32(order_count[counter].Text));
                    }
                    counter++;
                }
                this.Controls.Clear();
                POS_2 pos2 = new POS_2();
                pos2.TopLevel = false;
                pos2.Dock = DockStyle.Fill;
                this.Controls.Add(pos2);
                pos2.Show();
            }
        }

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

                POS pos = new POS();
                pos.TopLevel = false;
                pos.Dock = DockStyle.Fill;
                this.Controls.Add(pos);
                pos.Show();
            }
                
        }

        public POS()
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

        private void POS_Load(object sender, EventArgs e)
        {
            lbl_total.Size = new Size(135, 25);
            lbl_orders.Size = new Size(30, 25);
            dtMenu = new DataTable();
            string command = "select * from Menu";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMenu);

            menu = new string[8] {"OG Chicken Burger", "BBQ Chicken Burger", "OG Beef Burger", "BBQ Beef Burger", "French Fries", "Teh Botol", "Aqua", "Coca-cola"};
            menuPics = new PictureBox[8];
            menuLabel = new Label[8];
            plus_btn = new Button[8];
            minus_btn = new Button[8];
            order_count = new Label[8];

            string file = "menu.txt";
            string[] lines = File.ReadAllLines(file);
            imagePaths = new List<string>();
            foreach (string line in lines)
            {
                imagePaths.AddRange(line.Split(','));
            }

            directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;


            x = 40;
            y = 90;
            i = 0;
            int j = 0;
            foreach (string name in menu)
            {
                menuPics[i] = new PictureBox();
                menuPics[i].Size = new Size(130, 130);
                menuPics[i].Location = new Point(x, y);
                menuPics[i].SizeMode = PictureBoxSizeMode.Zoom;
                menuPics[i].BackColor = Color.LightSalmon;
                string url = imagePaths[i];
                string fullUrl = directory + url;
                menuPics[i].ImageLocation = fullUrl;
                this.Controls.Add(menuPics[i]);

                menuLabel[i] = new Label();
                menuLabel[i].Size = new Size(130, 24);
                menuLabel[i].Font = new Font("Century Gothic", 8F, FontStyle.Bold);
                menuLabel[i].Location = new Point(x, y + 135);
                menuLabel[i].TextAlign = ContentAlignment.MiddleCenter;
                menuLabel[i].BackColor = Color.White;                
                menuLabel[i].Text = name;
                this.Controls.Add(menuLabel[i]);

                minus_btn[i] = new Button();
                minus_btn[i].Size = new Size(30, 30);
                minus_btn[i].Location = new Point(x, y + 160);
                minus_btn[i].BackgroundImage = Image.FromFile(@"C:\Users\Angel Aprilia\Downloads\SAD\SAD\Sam's Burger\Elements\symbol -.png");
                minus_btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                minus_btn[i].Tag = i;
                minus_btn[i].ForeColor = Color.Black;
                minus_btn[i].BackColor = Color.White;
                minus_btn[i].Click += minus_btn_Click;
                this.Controls.Add((minus_btn[i]));

                order_count[i] = new Label();
                order_count[i].Size = new Size(30, 24);
                order_count[i].Location = new Point(x + 50, y + 163);
                order_count[i].Text = "0";
                order_count[i].Tag = i;
                order_count[i].Font = new Font("Century Gothic", 8F, FontStyle.Bold);
                order_count[i].TextAlign = ContentAlignment.MiddleCenter;
                order_count[i].BackColor = Color.White; 
                this.Controls.Add((order_count[i]));

                plus_btn[i] = new Button();
                plus_btn[i].Size = new Size(30, 30);
                plus_btn[i].Location = new Point(x + 100, y + 160);
                plus_btn[i].BackgroundImage = Image.FromFile(@"C:\Users\Angel Aprilia\Downloads\SAD\SAD\Sam's Burger\Elements\symbol +.png");
                plus_btn[i].BackgroundImageLayout = ImageLayout.Stretch;
                plus_btn[i].Tag = i;
                plus_btn[i].ForeColor = Color.Black;
                plus_btn[i].BackColor = Color.White;
                plus_btn[i].Click += plus_btn_Click;
                this.Controls.Add((plus_btn[i]));

                if ((j + 1) % 4 == 0)
                    {
                        x = 40;
                        y += 200;
                    }
                    else
                    {
                        x += 165;
                    }
                    j++;
                
                i++;
            }
            i = 0;
        }
        private void minus_btn_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            int i = Convert.ToInt32(send.Tag);
            int countnow = Convert.ToInt32(order_count[i].Text);
            if(countnow == 0)
            {
                MessageBox.Show("Value can not be less than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                order_count[i].Text = Convert.ToString(countnow - 1);
                int total = Convert.ToInt32(lbl_orders.Text) - 1;
                lbl_orders.Text = Convert.ToString(total);
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            var send = sender as Button;
            int i = Convert.ToInt32(send.Tag);
            int countnow = Convert.ToInt32(order_count[i].Text);
            order_count[i].Text = Convert.ToString(countnow + 1);

            int total = Convert.ToInt32(lbl_orders.Text) + 1;
            lbl_orders.Text = Convert.ToString(total);
        }
    }
}