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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.adap.SelectCommand = new MySqlCommand("SELECT * FROM users WHERE @login=login AND @password = password", Connection.connect);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@login", textBox1.Text);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@password", textBox2.Text);
            Connection.connect.Open();
            Connection.reader = Connection.adap.SelectCommand.ExecuteReader();
            if (Connection.reader.Read())
            {
                Connection.UserLogin = Connection.reader["login"].ToString();
                Connection.NickUser = Connection.reader["nickname"].ToString();
                Connection.admin = Convert.ToBoolean(Connection.reader["admin"]);
                Connection.connect.Close();
                Main2 f = new Main2();
                f.Show();
                this.Hide();
            }
            else
            {
                Connection.connect.Close();
                label5.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}