﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Ex2
{
    public partial class EnterKeyString : Form
    {
        public EnterKeyString()
        {
            InitializeComponent();
        }

        private bool IsPrime(long n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0) return false;
            for (long i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private long GCD(long a, long b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }

        private long Mod(long a, long b, long c)
        {
            long x = 1, y = a;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    x = (x * y) % c;
                }
                y = (y * y) % c;
                b /= 2;
            }
            return (long)(x % c);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            richTextBox5.Clear();

            long p = long.Parse(richTextBox1.Text);
            long q = long.Parse(richTextBox2.Text);
            long publicKey = long.Parse(richTextBox4.Text);

            if (!IsPrime(p) || !IsPrime(q) || !IsPrime(publicKey))
            {
                MessageBox.Show("p, q, and e is must a prime.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long n = p * q;
            long phi = (p - 1) * (q - 1);

            long privateKey = 2;
            while (true)
            {
                if ((privateKey * publicKey - 1) % phi == 0)
                {
                    break;
                }
                privateKey++;
            }
            // Hiển thị giá trị trong RichTextBoxes
            richTextBox3.AppendText(n + Environment.NewLine);
            richTextBox5.AppendText(privateKey + Environment.NewLine);
        }

        private List<long> EncryptString(string plaintext, long publicKey, long n)
        {
            List<long> cipherText = new List<long>();

            foreach (char c in plaintext)
            {
                long charValue = (long)c;
                long cipherChar = Mod(charValue, publicKey, n);
                cipherText.Add(cipherChar);
            }

            return cipherText;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            richTextBox7.Clear();

            string plaintext = richTextBox6.Text; // Lấy chuỗi văn bản từ richTextBox6
            long publicKey = long.Parse(richTextBox4.Text.Trim());
            long n = long.Parse(richTextBox3.Text.Trim());

            List<long> cipherText = EncryptString(plaintext, publicKey, n);

            foreach (long encryptedChar in cipherText)
            {
                richTextBox7.AppendText(encryptedChar + " ");
            }
            richTextBox7.AppendText(Environment.NewLine);
        }
        private string DecryptString(string cipherText, long privateKey, long n)
        {
            StringBuilder plainText = new StringBuilder();

            string[] cipherChars = cipherText.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            foreach (string cipherChar in cipherChars)
            {
                long cipherValue = Convert.ToInt64(cipherChar);
                long plainValue = Mod(cipherValue, privateKey, n);
                char plainChar = (char)plainValue;
                plainText.Append(plainChar);
            }

            return plainText.ToString();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            richTextBox6.Clear();

            string cipherText = richTextBox7.Text;
            long privateKey = long.Parse(richTextBox5.Text.Trim());
            long n = long.Parse(richTextBox3.Text.Trim());

            string plainText = DecryptString(cipherText, privateKey, n);

            richTextBox6.AppendText(plainText + Environment.NewLine);
        }
    }
}
