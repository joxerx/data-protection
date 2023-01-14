using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remainder_theorem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void find1_Click(object sender, EventArgs e)
        {
            
            string[] tmp = standart_x.Text.Split(',');
            int[] m = new int[tmp.Length];
            int[] a = new int[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                    string[] tmp1 = tmp[i].Split(' ');
                    if (int.TryParse(tmp1[0], out int mt) && int.TryParse(tmp1[1], out int at))
                    {
                        m[i] = mt;
                        a[i] = at;
                    }
                    else {
                        MessageBox.Show("Попробуйте другой ввод!");
                        return;
                    }              
            }
            int M0 = m[0] * m[1] * m[2];
            int[] M = new int[3];
            for (int i = 0; i < 3; i++) M[i] = M0 / m[i];
            int[] y = new int[3];
            int x = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                int ya = 1;
                while (true)
                {
                    if ((M[i] * ya) % m[i] == a[i])
                    {
                        y[i] = ya;
                        break;
                    }
                    else ya++;
                }
                x += M[i] * y[i];
            }
            MessageBox.Show("Найденное число: " + x);
        }

        private void find2_Click(object sender, EventArgs e)
        {
            int[] m = new int[2];
            int[] a = new int[2];
            int[] b = new int[2];
            string[] tmp = multiplied_x.Text.Split(',');
            if (tmp.Length == 2) for (int i = 0; i < 2; i++)
                {
                    string[] tmp1 = tmp[i].Split(' ');
                    if (int.TryParse(tmp1[0], out int bt) && int.TryParse(tmp1[1], out int mt) && int.TryParse(tmp1[2], out int at))
                    {
                        b[i] = bt;
                        m[i] = mt;
                        a[i] = at;
                    }
                    else
                    {
                        MessageBox.Show("Попробуйте другой ввод!");
                        return;
                    }
                }
            int M0 = m[0] * m[1];
            int[] M = new int[2];
            for (int i = 0; i < 2; i++) M[i] = M0 / m[i];
            int[] y = new int[2];
            int x = 0;
            for (int i = 0; i < 2; i++)
            {
                int ya = 1;
                while (true)
                {
                    if ((M[i] * ya) % m[i] == a[i] / b[i]) 
                    {
                        y[i] = ya;
                        break;
                    }
                    else ya++;
                }
                x += M[i] * y[i];
            }
            MessageBox.Show("Найденное число: " + x);
        }
    }
}
