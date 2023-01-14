using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesar_cipher
{
    public partial class Form1 : Form
    {
        string alph = "абвгдеёжзийклмнопрстуфхцчшщъьыэюя ";
        double[] probability = new double[] { 0.062, 0.014, 0.038, 0.013, 0.025, 0.072, 0.072, 
            0.007, 0.016, 0.062, 0.010, 0.028, 0.035, 0.026, 0.052, 0.090, 0.023, 0.040, 0.045,
            0.053, 0.021, 0.001, 0.009, 0.004, 0.012, 0.005, 0.003, 0.015, 0.017, 0.015, 0.002,
            0.006, 0.018, 0.175 };

        public Form1()
        {
            InitializeComponent();
        }

        private void cipher_Click(object sender, EventArgs e)
        {
            origin_text.Text = origin_text.Text.ToLower();
            string crypted = "";
            if (int.TryParse(mover.Text, out int move))
            {
                for (int i = 0; i < origin_text.Text.Length; i++)
                {
                    for (int j =0; j < alph.Length; j++)
                    {
                        if (origin_text.Text[i] == alph[j])
                        {
                            int index = j + move;
                            if (index < 0) index += alph.Length - 1;
                            else if (index >= alph.Length) index -= alph.Length - 1;
                            crypted += alph[index];
                            break;
                        }
                    }
                }
                encrypted_text.Text = crypted;
            }
        }
        int compare(double error, double[] sample, double[] analyzing)
        {
            for ( int i = 0; i < analyzing.Length; i++) 
            { 
                if (analyzing[i] <= sample[12] + error && analyzing[i] >= sample[12] - error && 
                    analyzing[i+1]  <= sample[13] + error && analyzing[i+1] >= sample[13] - error &&
                    analyzing[i+2] <= sample[14] + error && analyzing[i+2] >= sample[14] - error) return i - 2;
            }
            return -1;
        }
        double[] analyze(string text)
        {
            double[] result = new double[alph.Length];
            for(int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alph.Length; j++) if (alph[j] == text[i]) result[j]++;
            }
            for (int i = 0; i < result.Length; i++) result[i] /= text.Length;
            return result;
        }
        private void decryptor_Click(object sender, EventArgs e)
        {
            double[] analyzis = analyze(encrypted_text.Text);
            int found_off = compare(0.03, probability, analyzis);
            resultAnlasyzis.Text = Convert.ToString(found_off);
        }
    }
}
