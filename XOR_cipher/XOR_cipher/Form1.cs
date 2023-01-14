using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Win32;

namespace XOR_cipher
{
    public partial class Form1 : Form
    {
        int shiftRegister = 0;
        public Form1()
        {
            InitializeComponent();
            visualMode.SelectedIndex = 0;
            workMode.SelectedIndex = 0;
            LFSRmode.SelectedIndex = 0;
        }

        private void visualMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = inputBox.Text;
            string output = outputBox.Text;
            string key = keyBox.Text;

            if (visualMode.SelectedIndex == 0)
            {
                inputBox.Text = input;
                outputBox.Text = output;
                keyBox.Text = key;
            }
            else if (visualMode.SelectedIndex == 1) 
            {
                inputBox.Text = "";
                outputBox.Text = "";
                keyBox.Text = "";
                foreach (char c in input)
                    inputBox.Text += Convert.ToString(c, 2).PadLeft(8, '0') + "-";
                foreach (char c in key)
                    keyBox.Text += Convert.ToString(c, 2).PadLeft(8, '0') + "-";
                foreach (char c in output)
                    outputBox.Text += Convert.ToString(c, 2).PadLeft(8, '0') + "-";
            }
            else if (visualMode.SelectedIndex == 2)
            {
                inputBox.Text = BitConverter.ToString(Encoding.Default.GetBytes(input));
                outputBox.Text = BitConverter.ToString(Encoding.Default.GetBytes(output));
                keyBox.Text = BitConverter.ToString(Encoding.Default.GetBytes(key));
            }

        }

        private void workMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(workMode.SelectedIndex == 0)
            {
                LFSRmode.Enabled = false;
                startValue.Enabled = false;
            }
            else
            {
                LFSRmode.Enabled = true;
                startValue.Enabled = true;
            }
        }

        private void toCrypt_Click(object sender, EventArgs e)
        {
            string key = keyBox.Text;
            string input = inputBox.Text;
            if (workMode.SelectedIndex == 1 && int.TryParse(startValue.Text, out int register)) shiftRegister = register;
            if (key.Length == 0 || key.Length != input.Length ) 
            {

                Random rnd = new Random();
                byte[] keyBytes = new byte[input.Length];
                
                for (int i = 0; i < input.Length; i++)
                {
                    if (workMode.SelectedIndex == 0) keyBytes[i] = Convert.ToByte(rnd.Next(256));
                    else 
                    {                        
                        string binKey = "";
                        for (int j = 0; j < 8; j++) binKey += LFSR();
                        keyBytes[i] = Convert.ToByte(binKey, 2);
                    }
                }
                
                keyBox.Text = System.Text.Encoding.Default.GetString(keyBytes);
                StreamWriter sw = new StreamWriter("key.txt", false, Encoding.Default);
                sw.Write(keyBox.Text);
                sw.Close();
            }
            if (keyBox.Text.Length == inputBox.Text.Length)
            {
                StreamWriter swo = new StreamWriter("input.txt", false, Encoding.Default);
                swo.Write(input);
                swo.Close();
                byte[] inputText = Encoding.Default.GetBytes(inputBox.Text);
                byte[] keyText = Encoding.Default.GetBytes(keyBox.Text);
                byte[] outputText = new byte[inputText.Length];
                for (int i = 0; i < inputBox.Text.Length; i++) outputText[i] = Convert.ToByte(inputText[i] ^ keyText[i]);
                outputBox.Text = System.Text.Encoding.Default.GetString(outputText);
                StreamWriter sw = new StreamWriter("output.txt", false, Encoding.Default);
                sw.Write(outputBox.Text);
                sw.Close();
            }
        }
        int LFSR()
        {
            if (LFSRmode.SelectedIndex == 0) shiftRegister = ((((shiftRegister >> 5) ^ (shiftRegister >> 2) ^ shiftRegister) & 0x01) << 10) | (shiftRegister >> 1);
            else shiftRegister = ((((shiftRegister >> 2) ^ shiftRegister) & 0x01) << 10 | shiftRegister >> 1);
            return shiftRegister & 0x01;
        }
    }
}
