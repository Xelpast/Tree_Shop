namespace Tree_Shop
{
    partial class NewTopiariy
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Название Топиарий";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 96);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 2;
            label2.Text = "Описание Топиарий";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 126);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 204);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 16);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Города";
            label3.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(470, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 15);
            label4.Name = "label4";
            label4.Size = new Size(200, 20);
            label4.TabIndex = 7;
            label4.Text = "Дата приобритения товара";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 103);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 9;
            label5.Text = "Цена топиарии";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 103);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 10;
            label6.Text = "(руб)";
            label6.Click += label6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(470, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(506, 103);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 12;
            label7.Text = "Количество товара";
            // 
            // button1
            // 
            button1.Location = new Point(492, 282);
            button1.Name = "button1";
            button1.Size = new Size(195, 48);
            button1.TabIndex = 13;
            button1.Text = "Добавить топиарий";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NewTopiariy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 371);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewTopiariy";
            Text = "Создание товара(топиарии)";
            Load += NewTopiariy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
    }
}