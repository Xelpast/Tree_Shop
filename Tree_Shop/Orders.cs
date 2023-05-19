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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main2 f = new Main2();
            f.Show();
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            Connection.adap.SelectCommand = new MySqlCommand(
                "SELECT users.fio, topiariy.name, topiariy.city, topiariy.date " +
                "FROM (users, topiariy) " +
                "JOIN orders ON orders.login = users.login AND orders.id_topi = topiariy.id " +
                "WHERE orders.login = @login", Connection.connect);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@login", Connection.UserLogin);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            Connection.adap.Fill(table);
            Connection.connect.Close();
            dataGridView1.DataSource = table;
        }
    }
}
