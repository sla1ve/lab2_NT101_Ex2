using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Ex2
{
    public partial class RandomKeyString : Form
    {
        public RandomKeyString()
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

        private void RandomKeyString_Load(object sender, EventArgs e)
        {

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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();

            Random random = new Random();
            long p, q;

            do
            {
                p = 1000 + random.Next(9000);
            } while (!IsPrime(p));

            do
            {
                q = 1000 + random.Next(9000);
            } while (!IsPrime(q));

            long n = p * q;
            long phi = (p - 1) * (q - 1);

            long publicKey = 0;
            for (long i = 2; i < phi; i++)
            {
                if (GCD(i, phi) == 1)
                {
                    publicKey = i;
                    break;
                }
            }

            long privateKey = 2;
            while (true)
            {
                if ((privateKey * publicKey - 1) % phi == 0)
                {
                    break;
                }
                privateKey++;
            }

            richTextBox1.AppendText(p + Environment.NewLine);
            richTextBox2.AppendText(q + Environment.NewLine);
            richTextBox3.AppendText(n + Environment.NewLine);
            richTextBox4.AppendText(publicKey + Environment.NewLine);
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

        private string DecryptString(string cipherText, long privateKey, long n)
        {
            StringBuilder plainText = new StringBuilder();

            string[] cipherChars = cipherText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string cipherChar in cipherChars)
            {
                long cipherValue = long.Parse(cipherChar);
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
