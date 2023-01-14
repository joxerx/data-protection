using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElGamal_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toCrypt_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            BigInteger y = -1;
            BigInteger a = -1;
            BigInteger b = -1;
            BigInteger decr = -1;
            int k = -1;
            int.TryParse(inputText.Text, out int M);

            if (int.TryParse(inputP.Text, out int p) && int.TryParse(inputQ.Text, out int q) && int.TryParse(inputX.Text, out int x)
                && q < p && x < p && isPrime(q) && isPrime(p)) 
            {
                y = BigInteger.Pow(q, x) % p;
                while (true) 
                {
                    int t = rnd.Next(0, p - 1);
                    if (GCD(t, p)) 
                    {
                        k = t;
                        break;
                    }
                }
                a = BigInteger.Pow(q, k) % p;
                b = (BigInteger.Pow(y, k) * M) % p;
                outputBox.Text = "Шифротекст: ";
                outputBox.Text += "(" + a + ", " + b+ ")";
                // Расшифруем
                int id_ans = 0;
                while (true)
                {
                    if (id_ans * BigInteger.Pow(a, x) % p == b) break;
                    id_ans++;
                }
                outputBox.Text += "\r\n Расшифрованный текст: " + id_ans;
                outputBox.Text += "\r\n Использован открытый ключ: " + y;
                outputBox.Text += "\r\n Использовано число k: " + k;

            }        
        }


        bool GCD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            if (a == 1) return true;
            else return false;
        }
        bool isPrime(int number)
        {
            if (number == 2) return true;
            for (int i = 2; i < (Math.Floor(Math.Sqrt(number)) + 2); i++) if (number % i == 0) return false;
            return true;
        }
    }
}
