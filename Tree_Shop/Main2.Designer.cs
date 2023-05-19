namespace Tree_Shop
{
    partial class Main2
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
            button6 = new Button();
            comboBox1 = new ComboBox();
            search = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Location = new Point(62, 195);
            button6.Name = "button6";
            button6.Size = new Size(109, 29);
            button6.TabIndex = 21;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 28);
            comboBox1.TabIndex = 20;
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlLightLight;
            search.ForeColor = Color.Gray;
            search.Location = new Point(821, 22);
            search.Name = "search";
            search.Size = new Size(37, 29);
            search.TabIndex = 19;
            search.Text = "🔍";
            search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(479, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 27);
            textBox1.TabIndex = 18;
            // 
            // button5
            // 
            button5.Location = new Point(880, 22);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 17;
            button5.Text = "Мои заказы";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(728, 332);
            button4.Name = "button4";
            button4.Size = new Size(136, 29);
            button4.TabIndex = 16;
            button4.Text = "Приобрести";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(49, 147);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(138, 31);
            button3.TabIndex = 15;
            button3.Text = "Добавить город";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(1169, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1082, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 12;
            label1.Text = "Никнейм";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(241, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(890, 383);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logot;
            pictureBox1.Location = new Point(28, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Main2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1292, 590);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(comboBox1);
            Controls.Add(search);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main2";
            Text = "Main2";
            Load += Main2_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private ComboBox comboBox1;
        private Button search;
        private TextBox textBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}