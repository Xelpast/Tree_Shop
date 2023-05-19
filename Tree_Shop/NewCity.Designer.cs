namespace Tree_Shop
{
    partial class NewCity
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
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 59);
            label1.Name = "label1";
            label1.Size = new Size(233, 25);
            label1.TabIndex = 0;
            label1.Text = "Введите название города";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(120, 146);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(97, 127);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 3;
            label2.Text = "Город уже есть в списке";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // NewCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 216);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "NewCity";
            Text = "Добавление города";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
    }
}