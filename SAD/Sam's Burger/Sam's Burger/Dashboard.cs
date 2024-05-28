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
    public partial class Dashboard : Form
    {
        string connection, MOTW, MOTW2, MOTW3;
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        DataTable dt1Week, dtReport, dtExp;

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

                Dashboard d = new Dashboard();
                d.TopLevel = false;
                d.Dock = DockStyle.Fill;
                this.Controls.Add(d);
                d.Show();
            }
        }

        List<string> posters;
        Panel[] panel_Exp;
        public Dashboard()
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_MOTW.Size = new Size(550, 70);
            dt1Week = new DataTable();
            string command = "select Nama_Menu, count(Jumlah) from vPenjualanMenuHarian where Tanggal >= CURRENT_DATE - INTERVAL 7 DAY group by 1";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt1Week);

            String[] menu = new string[8] { "OG Chicken Burger", "BBQ Chicken Burger", "OG Beef Burger", "BBQ Beef Burger", "French Fries", "Teh Botol", "Aqua", "Coca-cola" };

            int most_order = 0;
            for(int i = 0; i < dt1Week.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt1Week.Rows[i][1]) > most_order)
                {
                    
                    most_order = Convert.ToInt32(dt1Week.Rows[i][1]);
                    MOTW = dt1Week.Rows[i][0].ToString();
                }
            }
            int most_order_2 = 0;
            for (int i = 0; i < dt1Week.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt1Week.Rows[i][1]) > most_order_2 && Convert.ToInt32(dt1Week.Rows[i][1]) <= most_order && dt1Week.Rows[i][0].ToString() != MOTW)
                {
                    most_order_2 = Convert.ToInt32(dt1Week.Rows[i][1]);
                    MOTW2 = dt1Week.Rows[i][0].ToString();
                }
            }
            int most_order_3 = 0;
            for (int i = 0; i < dt1Week.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt1Week.Rows[i][1]) > most_order_3 && Convert.ToInt32(dt1Week.Rows[i][1]) <= most_order && dt1Week.Rows[i][0].ToString() != MOTW && dt1Week.Rows[i][0].ToString() != MOTW2)
                {
                    most_order_3 = Convert.ToInt32(dt1Week.Rows[i][1]);
                    MOTW3 = dt1Week.Rows[i][0].ToString();
                }
            }
            posters = POS.imagePaths;
            string directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            int j = 0;
            foreach(string food in menu)
            {
                if(food == MOTW)
                {
                    pic_motw.ImageLocation = directory + posters[j];
                    pic_motw.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (food == MOTW2)
                {
                    pic_motw2.ImageLocation = directory + posters[j];
                    pic_motw2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (food == MOTW3)
                {
                    pic_motw3.ImageLocation = directory + posters[j];
                    pic_motw3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                j++;
            }
            dtReport = new DataTable();
            command = "select * from vPenjualanMenuHarian order by 4 desc;";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtReport);

            dgv_report.DataSource = dtReport;

            dtExp = new DataTable();
            command = "select * from Stock where Expired_Date <= CURRENT_DATE + INTERVAL 7 DAY;";
            sqlCommand = new MySqlCommand(command, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtExp);

            panel_Exp = new Panel[dtExp.Rows.Count];
            for(int h = 0; h < dtExp.Rows.Count; h++)
            {
                panel_Exp[h] = new Panel();
                panel_Exp[h].Size = new Size(215, 70);
                panel_Exp[h].BackColor = Color.LightGray;
                panel_notif.Controls.Add(panel_Exp[h]);

                Label label = new Label();
                label.Text = dtExp.Rows[h][0].ToString() + " is expiring at " + dtExp.Rows[h][4].ToString();
                label.Location = new Point(5, 5);
                label.Size = new Size(150, 40);
                label.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
                panel_Exp[h].Controls.Add(label);

                Button button = new Button();
                button.Tag = h.ToString();
                button.Text = "Clear";
                button.Size = new Size(50, 27);
                button.Location = new Point(90, 42);
                button.Click += button_Click;
                button.BringToFront();
                panel_Exp[h].Controls.Add(button);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            int i = 0;
            var send = sender as Button;
            panel_Exp[Convert.ToInt32(send.Tag)].Controls.Clear();
            panel_Exp[Convert.ToInt32(send.Tag)].BackColor = Color.Transparent;
            panel_Exp[Convert.ToInt32(send.Tag)] = null;

            foreach(Panel panel in panel_Exp)
            {
                if(panel != null && Convert.ToInt32(send.Tag) < i)
                {
                    panel.Location = new Point(panel.Location.X, panel.Location.Y - 70);
                }
            }
        }
    }
}
