namespace Tree_Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(318, 64);
            label1.Name = "label1";
            label1.Size = new Size(246, 50);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(328, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(328, 193);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(328, 286);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 317);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 30, 30);
            button1.Location = new Point(390, 392);
            button1.Name = "button1";
            button1.Size = new Size(100, 37);
            button1.TabIndex = 5;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(302, 441);
            label4.Name = "label4";
            label4.Size = new Size(294, 19);
            label4.TabIndex = 6;
            label4.Text = "Нет связи с деревьями? Зарегистрироваться ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(334, 359);
            label5.Name = "label5";
            label5.Size = new Size(212, 20);
            label5.TabIndex = 7;
            label5.Text = "Неверный логин или пароль";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(882, 653);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label4;
        private Label label5;
    }
}