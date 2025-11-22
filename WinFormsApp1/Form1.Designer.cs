namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            textBox6 = new TextBox();
            label4 = new Label();
            button3 = new Button();
            textBox7 = new TextBox();
            label5 = new Label();
            button4 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(22, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(22, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(22, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 27);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(28, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(143, 27);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(26, 23);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Bремя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "Разница";
            // 
            // button1
            // 
            button1.Location = new Point(173, 187);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 7;
            button1.Text = "Начинать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(82, 92);
            label3.Name = "label3";
            label3.Size = new Size(0, 45);
            label3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(256, 187);
            button2.Name = "button2";
            button2.Size = new Size(93, 28);
            button2.TabIndex = 9;
            button2.Text = "Oстановить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(195, 27);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(39, 23);
            textBox6.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 9);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Число";
            // 
            // button3
            // 
            button3.Location = new Point(90, 187);
            button3.Name = "button3";
            button3.Size = new Size(77, 28);
            button3.TabIndex = 12;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(278, 27);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(39, 23);
            textBox7.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 9);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 13;
            label5.Text = "Разница Таймера";
            // 
            // button4
            // 
            button4.Location = new Point(7, 187);
            button4.Name = "button4";
            button4.Size = new Size(80, 28);
            button4.TabIndex = 15;
            button4.Text = "Start";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(134, 166);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 227);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BINGO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private TextBox textBox6;
        private Label label4;
        private Button button3;
        private TextBox textBox7;
        private Label label5;
        private Button button4;
        private Label label6;
    }
}
