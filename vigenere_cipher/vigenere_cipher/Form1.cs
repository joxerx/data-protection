using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vigenere_cipher
{
    public partial class Form1 : Form
    {
        string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ,._-1234567890()=+";
        public Form1()
        {
            InitializeComponent();
            workMode.SelectedIndex = 0;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] originIds = new int[inputText.Text.Length];
            string input = inputText.Text.ToLower();
            for (int i = 0; i < input.Length; i++) for (int j = 0; j < alph.Length; j++) if (input[i] == alph[j]) originIds[i] = j;
            if (workMode.SelectedIndex == 0) 
            {
                int[] keyIds = new int[keyWord.Text.Length];
                string key = keyWord.Text.ToLower();
                for (int i = 0; i < keyWord.Text.Length; i++) for (int j = 0; j < alph.Length; j++) if (key[i] == alph[j]) keyIds[i] = j;
                int keyLength = keyWord.Text.Length;
                int keyRegister = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int newIndex = originIds[i] + keyIds[keyRegister];
                    if (newIndex >= alph.Length) newIndex -= alph.Length;
                    result += alph[newIndex];
                    keyRegister++;
                    if (keyRegister == keyLength) keyRegister = 0;
                }
                outputText.Text = result;
            }
            else
            {
                List<int> keyIds = keyWord.Text.Split(' ').Select(Int32.Parse).ToList();
                int keyLength = keyIds.Count;
                int keyRegister = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int newIndex = originIds[i] + keyIds[keyRegister];
                    if (newIndex >= alph.Length) newIndex -= alph.Length;
                    result += alph[newIndex];
                    keyRegister++;
                    if (keyRegister == keyLength) keyRegister = 0;
                }
                outputText.Text = result;
            }
            
        }

        private void swapper_Click(object sender, EventArgs e)
        {
            inputText.Text = outputText.Text;


            string result = "";
            int[] originIds = new int[inputText.Text.Length];
            string input = inputText.Text.ToLower();
            for (int i = 0; i < input.Length; i++) for (int j = 0; j < alph.Length; j++) if (input[i] == alph[j]) originIds[i] = j;
            if (workMode.SelectedIndex == 0)
            {
                int[] keyIds = new int[keyWord.Text.Length];
                string key = keyWord.Text.ToLower();
                for (int i = 0; i < keyWord.Text.Length; i++) for (int j = 0; j < alph.Length; j++) if (key[i] == alph[j]) keyIds[i] = j;
                int keyLength = keyWord.Text.Length;
                int keyRegister = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int newIndex = originIds[i] - keyIds[keyRegister];
                    if (newIndex < 0) newIndex += alph.Length;
                    result += alph[newIndex];
                    keyRegister++;
                    if (keyRegister == keyLength) keyRegister = 0;
                }
                outputText.Text = result;
            }
            else
            {
                List<int> keyIds = keyWord.Text.Split(' ').Select(Int32.Parse).ToList();
                int keyLength = keyIds.Count;
                int keyRegister = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    int newIndex = originIds[i] - keyIds[keyRegister];
                    if (newIndex < 0) newIndex += alph.Length;
                    result += alph[newIndex];
                    keyRegister++;
                    if (keyRegister == keyLength) keyRegister = 0;
                }
                outputText.Text = result;
            }
        }
    }
}
