namespace Tree_Shop
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            value = new Label();
            Price = new Label();
            Date = new Label();
            City = new Label();
            Desc = new Label();
            Header = new Label();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            search = new Button();
            comboBox1 = new ComboBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1321, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 0;
            label1.Text = "Никнейм";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1393, 19);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(11, 19);
            button2.Name = "button2";
            button2.Size = new Size(213, 29);
            button2.TabIndex = 2;
            button2.Text = "Добавить новый топиарий";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(231, 19);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(138, 31);
            button3.TabIndex = 3;
            button3.Text = "Добавить город";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1000, 438);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(value);
            panel1.Controls.Add(Price);
            panel1.Controls.Add(Date);
            panel1.Controls.Add(City);
            panel1.Controls.Add(Desc);
            panel1.Controls.Add(Header);
            panel1.Location = new Point(1148, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 438);
            panel1.TabIndex = 5;
            // 
            // value
            // 
            value.AutoSize = true;
            value.Location = new Point(31, 310);
            value.Name = "value";
            value.Size = new Size(90, 20);
            value.TabIndex = 5;
            value.Text = "Количество";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(27, 394);
            Price.Name = "Price";
            Price.Size = new Size(94, 23);
            Price.TabIndex = 4;
            Price.Text = "Цена (руб)";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(31, 271);
            Date.MaximumSize = new Size(290, 0);
            Date.Name = "Date";
            Date.Size = new Size(172, 20);
            Date.TabIndex = 3;
            Date.Text = "Дата получения товара";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(31, 236);
            City.Name = "City";
            City.Size = new Size(51, 20);
            City.TabIndex = 2;
            City.Text = "Город";
            // 
            // Desc
            // 
            Desc.AutoSize = true;
            Desc.Location = new Point(27, 56);
            Desc.MaximumSize = new Size(290, 0);
            Desc.Name = "Desc";
            Desc.Size = new Size(131, 20);
            Desc.TabIndex = 1;
            Desc.Text = "Описание товара";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Header.Location = new Point(79, 21);
            Header.Name = "Header";
            Header.Size = new Size(180, 28);
            Header.TabIndex = 0;
            Header.Text = "Название товара";
            // 
            // button4
            // 
            button4.Location = new Point(1261, 545);
            button4.Name = "button4";
            button4.Size = new Size(136, 29);
            button4.TabIndex = 6;
            button4.Text = "Приобрести";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1149, 18);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 7;
            button5.Text = "Мои заказы";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(742, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 27);
            textBox1.TabIndex = 8;
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlLightLight;
            search.ForeColor = Color.Gray;
            search.Location = new Point(1084, 19);
            search.Name = "search";
            search.Size = new Size(37, 29);
            search.TabIndex = 9;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(528, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 10;
            // 
            // button6
            // 
            button6.Location = new Point(393, 21);
            button6.Name = "button6";
            button6.Size = new Size(109, 29);
            button6.TabIndex = 11;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1536, 649);
            Controls.Add(button6);
            Controls.Add(comboBox1);
            Controls.Add(search);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Topi Topi";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label value;
        private Label Price;
        private Label Date;
        private Label City;
        private Label Desc;
        private Label Header;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Button search;
        private ComboBox comboBox1;
        private Button button6;
    }
}