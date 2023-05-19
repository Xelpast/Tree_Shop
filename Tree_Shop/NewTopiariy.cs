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
    public partial class NewTopiariy : Form
    {
        public NewTopiariy()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTopiariy_Load(object sender, EventArgs e)
        {
            Connection.adap.SelectCommand = new MySqlCommand("SELECT names FROM city", Connection.connect);
            Connection.connect.Open();
            Connection.adap.SelectCommand.ExecuteNonQuery();
            DataTable city = new DataTable();
            Connection.adap.Fill(city);
            Connection.connect.Close();
            foreach (DataRow row in city.Rows)
            {
                comboBox1.Items.Add(row["names"].ToString());
            }
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO topiariy(name, description, city, date, price, value) VALUES(@name, @description, @city, @date, @price, @value)", Connection.connect);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@name", textBox1.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@description", textBox2.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@city", comboBox1.SelectedItem);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("dd-MM-yyyy"));
            Connection.adap.InsertCommand.Parameters.AddWithValue("@price", textBox3.Text);
            Connection.adap.InsertCommand.Parameters.AddWithValue("@value", textBox4.Text);
            Connection.connect.Open();
            Connection.adap.InsertCommand.ExecuteNonQuery();
            Connection.connect.Close();
        }
    }
}
