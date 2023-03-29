namespace DamianGrembocki_Zadanie1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(261, 30);
            label1.TabIndex = 0;
            label1.Text = "Plik źródłowy\r\n(tu umieść tekst do szyfrowania/deszytfrowania)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 25);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Wynik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 475);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 2;
            label3.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(465, 475);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 3;
            label4.Text = "?";
            // 
            // button1
            // 
            button1.Location = new Point(24, 433);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Wczytaj plik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(15, 35);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 5;
            button2.Text = "Szyfruj =>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(465, 433);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Zapisz do pliku";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 101);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 7;
            button4.Text = "Rozszyfruj =>";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 362);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(465, 47);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 362);
            textBox2.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Location = new Point(316, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 143);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Algorytm 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(316, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(126, 143);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Algorytm 2";
            // 
            // button6
            // 
            button6.Location = new Point(15, 94);
            button6.Name = "button6";
            button6.Size = new Size(105, 23);
            button6.TabIndex = 1;
            button6.Text = "Rozszyfruj =>";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(15, 40);
            button5.Name = "button5";
            button5.Size = new Size(105, 23);
            button5.TabIndex = 0;
            button5.Text = "Szyfruj =>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 539);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button6;
        private Button button5;
    }
}