namespace Lab2_Ex2
{
    partial class RandomKeyNumeric
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
            btnGenerate = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(271, 108);
            btnGenerate.Margin = new Padding(3, 2, 3, 2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(109, 36);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(466, 34);
            btnEncrypt.Margin = new Padding(3, 2, 3, 2);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(144, 49);
            btnEncrypt.TabIndex = 1;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(466, 98);
            btnDecrypt.Margin = new Padding(3, 2, 3, 2);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(144, 46);
            btnDecrypt.TabIndex = 2;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 36);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 3;
            label1.Text = "p";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 36);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "q";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 76);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 82);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "e";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 116);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 7;
            label5.Text = "d";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 223);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 8;
            label6.Text = "Plaintext";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 315);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 9;
            label7.Text = "Ciphertext";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(271, 74);
            richTextBox4.Margin = new Padding(3, 2, 3, 2);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(110, 24);
            richTextBox4.TabIndex = 13;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(127, 113);
            richTextBox5.Margin = new Padding(3, 2, 3, 2);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(110, 22);
            richTextBox5.TabIndex = 14;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(136, 181);
            richTextBox6.Margin = new Padding(3, 2, 3, 2);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(650, 91);
            richTextBox6.TabIndex = 15;
            richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(136, 278);
            richTextBox7.Margin = new Padding(3, 2, 3, 2);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(650, 91);
            richTextBox7.TabIndex = 16;
            richTextBox7.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(127, 34);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(110, 24);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(271, 34);
            richTextBox2.Margin = new Padding(3, 2, 3, 2);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(110, 23);
            richTextBox2.TabIndex = 18;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(127, 74);
            richTextBox3.Margin = new Padding(3, 2, 3, 2);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(110, 24);
            richTextBox3.TabIndex = 19;
            richTextBox3.Text = "";
            // 
            // RandomKeyNumeric
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 371);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox7);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnGenerate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RandomKeyNumeric";
            Text = "RandomKeyNumeric";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
    }
}