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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void selectQuery()
        {
            label1.Text = Connection.NickUser;
            string query = "SELECT * FROM topiariy WHERE name LIKE '%" + textBox1.Text + "%\'";
            if (comboBox1.SelectedItem.ToString() != "Все")
            {
                query += (" AND city = '" + comboBox1.SelectedItem.ToString() + "'");
            }
            Connection.adap.SelectCommand = new MySqlCommand(query, Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable topi = new DataTable();
            Connection.adap.Fill(topi);
            Connection.connect.Close();
            dataGridView1.DataSource = topi;
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].HeaderText = "Название товара";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Город";
            dataGridView1.Columns[4].HeaderText = "Время заказа";
            dataGridView1.Columns[5].HeaderText = "Цена (руб)";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderText = "Количество товара";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if(Connection.admin == true) 
            {
                button2.Visible = true;
                button3.Visible = true;
                button6.Visible = true;
            }
            comboBox1.Items.Add("Все");
            Connection.adap.SelectCommand = new MySqlCommand("SELECT names FROM city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable table = new DataTable();
            Connection.adap.Fill(table);
            Connection.connect.Close();
            foreach (DataRow row in table.Rows)
            {
                comboBox1.Items.Add(row["names"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
            selectQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.UserLogin = " ";
            Connection.NickUser = " ";
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewCity f = new NewCity();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewTopiariy f = new NewTopiariy();
            f.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Header.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            Desc.Text = "Описание товара: " + dataGridView1.CurrentRow.Cells["description"].Value.ToString();
            City.Text = "Город: " + dataGridView1.CurrentRow.Cells["city"].Value.ToString();
            Date.Text = "Дата получения товара: " + dataGridView1.CurrentRow.Cells["date"].Value.ToString();
            Price.Text = "Цена: " + dataGridView1.CurrentRow.Cells["price"].Value.ToString() + "руб.";
            value.Text = "Количество: " + dataGridView1.CurrentRow.Cells["value"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //запрос на уменьшение количества товара
            Connection.adap.UpdateCommand = new MySqlCommand("UPDATE topiariy SET value = value-1 WHERE id = @id", Connection.connect);
            Connection.adap.UpdateCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.UpdateCommand.ExecuteNonQuery();
            Connection.connect.Close();

            //мои товары запрос
            Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO orders (login, id_topi) VALUES (@login, @id_topi)", Connection.connect);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@login", Connection.UserLogin);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@id_topi", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.InsertCommand.ExecuteNonQuery();
            Connection.connect.Close();

            selectQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            f.ShowDialog();
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            selectQuery();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Connection.adap.DeleteCommand = new MySqlCommand("DELETE FROM topiariy WHERE id = @id", Connection.connect);
            Connection.adap.DeleteCommand.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Connection.connect.Open();
            Connection.adap.DeleteCommand.ExecuteNonQuery();
            Connection.connect.Close();
            selectQuery();
        }
    }
}
