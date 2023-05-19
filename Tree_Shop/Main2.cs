using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tree_Shop
{
    public partial class Main2 : Form
    {
        public static int y = 100;
        public static DataTable table = new DataTable();
        public Main2()
        {
            InitializeComponent();
        }
        public void selectQuery()
        {
            y = 100;
            Controls.Clear();
            table.Clear();

            Button newTopiariy = new Button();
            newTopiariy.Location = new Point(12, 100);
            newTopiariy.Size = new Size(213, 29);
            newTopiariy.Text = "Добавить новый топиарий";
            newTopiariy.Click += newTopi_Click;
            this.Controls.Add(newTopiariy);

            Button newCity = new Button();
            newCity.Location = new Point(49, 147);
            newCity.Size = new Size(138, 31);
            newCity.Text = "Добавить город";
            newCity.Click += newCity_Click;
            this.Controls.Add(newCity);

            TextBox searchP = new TextBox();
            searchP.Location = new Point(479, 23);
            searchP.Size = new Size(336, 27);
            searchP.Name = "searchP";
            this.Controls.Add(searchP);

            ComboBox cityBox = new ComboBox();
            cityBox.Location = new Point(241, 22);
            cityBox.Size = new Size(177, 28);
            cityBox.Name = "cityBox";
            cityBox.Items.Add("Все");
            this.Controls.Add(cityBox);
            cityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Connection.adap.SelectCommand = new MySqlCommand("SELECT names FROM city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable city = new DataTable();
            Connection.adap.Fill(city);
            Connection.connect.Close();
            foreach (DataRow row in city.Rows)
            {
                (this.Controls["cityBox"] as ComboBox).Items.Add(row["names"].ToString());
            }

            Button searchButton = new Button();
            searchButton.Location = new Point(821, 23);
            searchButton.Size = new Size(37, 29);
            searchButton.ForeColor = Color.Gray;
            searchButton.Text = "🔍";
            this.Controls.Add(searchButton);

            Button MyOrders = new Button();
            MyOrders.Location = new Point(904, 23);
            MyOrders.Size = new Size(140, 29);
            MyOrders.Text = "Мои заказы";
            MyOrders.Click += myOrders_Click;
            this.Controls.Add(MyOrders);

            PictureBox TopiLogo = new PictureBox();
            TopiLogo.Location = new Point(28, 5);
            TopiLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TopiLogo.Size = new Size(164, 64);
            TopiLogo.Image = Properties.Resources.logot;
            this.Controls.Add(TopiLogo);

            Button DeleteTopi = new Button();
            DeleteTopi.Location = new Point(62, 195);
            DeleteTopi.Size = new Size(109, 29);
            DeleteTopi.Text = "Удалить";
            this.Controls.Add(DeleteTopi);

            Label Nickname = new Label();
            Nickname.Location = new Point(1080, 25);
            Nickname.Size = new Size(81, 23);
            Nickname.TextAlign = ContentAlignment.MiddleRight;
            Nickname.Text = Connection.NickUser;
            this.Controls.Add(Nickname);

            Button Exit = new Button();
            Exit.Location = new Point(1169, 23);
            Exit.Size = new Size(94, 29);
            Exit.Text = "Выйти";
            Exit.Click += Exit_Click;
            this.Controls.Add(Exit);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Connection.UserLogin = " ";
            Connection.NickUser = " ";
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        private void newTopi_Click(object sender, EventArgs e)
        {
            NewTopiariy f = new NewTopiariy();
            f.ShowDialog();
        }

        private void myOrders_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            f.ShowDialog();

        }

        private void newCity_Click(object sender, EventArgs e)
        {
            NewCity f = new NewCity();
            f.ShowDialog();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
