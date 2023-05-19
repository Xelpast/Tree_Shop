﻿using System;
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
    public partial class NewCity : Form
    {
        public NewCity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.adap.SelectCommand = new MySqlCommand("SELECT * FROM city WHERE names = @names", Connection.connect);
            Connection.adap.SelectCommand.Parameters.AddWithValue("@names", textBox1.Text);
            Connection.connect.Open();
            Connection.reader = Connection.adap.SelectCommand.ExecuteReader();
            if (!Connection.reader.Read())
            {
                Connection.connect.Close();
                Connection.adap.InsertCommand = new MySqlCommand("INSERT INTO city(names) VALUES(@names)", Connection.connect);
                Connection.adap.InsertCommand.Parameters.AddWithValue("@names", textBox1.Text);
                Connection.connect.Open();
                Connection.adap.InsertCommand.ExecuteNonQuery();
                Connection.connect.Close();
                label2.Visible = false;
            }
            else
            {
                Connection.connect.Close();
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
