using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace transposition_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mode.SelectedIndex = 0;

        }

        private void toCrypt_Click(object sender, EventArgs e)
        {
            string result = "";
            if (mode.SelectedIndex == 0)
            {
                if (int.TryParse(lines.Text, out int line) && int.TryParse(cols.Text, out int col) && col > 0 && line > 0 && inputText.Text.Length > 0)
                {
                    string input = inputText.Text;
                    char[,] charTable = getChartable(input, line, col);
                    for (int i = 0; i < col; i++) for (int j = 0; j < line; j++) result += charTable[j, i];
                    outputText.Text = result;
                }
            }
            else if (mode.SelectedIndex == 1)
            {
                if (int.TryParse(lines.Text, out int line) && int.TryParse(cols.Text, out int col) && col > 0 && line > 0 && inputText.Text.Length > 0)
                {
                    int[] order = Array.ConvertAll(cols_order.Text.Split(' '), int.Parse);
                    string input = inputText.Text;
                    char[,] charTable = getChartable(input, line, col);
                    char[,] transformedTable = new char[line, col];

                    for (int i = 0; i < line; i++) for (int j = 0; j < col; j++) transformedTable[i, order[j] - 1] = charTable[i, j];
                    for (int i = 0; i < col; i++) for (int j = 0; j < line; j++) result += transformedTable[j, i];
                    outputText.Text = result;
                }
            }
            else if (mode.SelectedIndex == 2)
            {
                if (int.TryParse(lines.Text, out int line) && int.TryParse(cols.Text, out int col) && col > 0 && line > 0 && inputText.Text.Length > 0)
                {
                    string input = inputText.Text;
                    char[,] resMatrix = new char[line, col];

                    // Строковые пары прорезей
                    string[] maskPairs = maskBox.Text.Split(',');
                    // Индексы прорезей
                    int[,] maskIds = new int[maskPairs.Length, 2];
   
                    for (int i = 0; i < maskPairs.Length; i++)
                    {
                        maskIds[i, 0] = Convert.ToInt32(maskPairs[i].Split(' ')[0]);
                        maskIds[i, 1] = Convert.ToInt32(maskPairs[i].Split(' ')[1]);
                    }
                    int curr_sym = 0;
                    for (int j = 0; j < maskPairs.Length; j++, curr_sym++) resMatrix[maskIds[j, 0], maskIds[j, 1]] = input[curr_sym];

                    for (int i = 0; i < 3; i++)
                    {
                        maskIds = moveMask(maskIds, i, line, col);
                        for (int j = 0; j < maskPairs.Length; j++, curr_sym++)
                        {
                            if (curr_sym >= input.Length) break;
                            resMatrix[maskIds[j, 0], maskIds[j, 1]] = input[curr_sym];
                        }
                    }
                    for (int i = 0; i < line; i++) for (int j = 0; j < col; j++) result += resMatrix[i, j];
                    outputText.Text = result;
                }
            }
            else if (mode.SelectedIndex == 3)
            {
                if (int.TryParse(lines.Text, out int line) && int.TryParse(cols.Text, out int col) && col > 0 && line > 0 && inputText.Text.Length > 0)
                {
                    string input = inputText.Text;
                    int[] col_order = Array.ConvertAll(cols_order.Text.Split(' '), int.Parse);
                    int[] line_order = Array.ConvertAll(lines_order.Text.Split(' '), int.Parse);


                    char[,] charTable = getChartable(input, line, col);
                    char[,] tempTable = new char[line, col];
                    char[,] transformedTable = new char[line, col];
                    

                    for (int i = 0; i < line; i++) for (int j = 0; j < col; j++) tempTable[i, col_order[j] - 1] = charTable[i, j];
                    for (int i = 0; i < line; i++) for (int j = 0; j < col; j++) transformedTable[line_order[i] - 1, j] = tempTable[i, j];
                    for (int i = 0; i < col; i++) for (int j = 0; j < line; j++) result += transformedTable[j, i];
                    outputText.Text = result;
                }
            }
        }
        char[,] getChartable(string text, int lines, int columns)
        {
            char[,] matrix = new char[lines, columns];
            int wordCount = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (wordCount == text.Length) break;
                    matrix[i, j] = text[wordCount];
                    wordCount++;
                }
            }
            return matrix;
        }
        int[,] moveMask(int[,] curMask, int interation, int lines, int columns)
        {
            int[,] newMask = new int[curMask.Length / 2, 2];
            if (interation == 0 || interation == 2)
            {
                for (int i = 0; i < newMask.Length / 2; i++)
                {
                    newMask[i, 0] = curMask[i, 0];
                    newMask[i, 1] = columns - 1 - curMask[i, 1];
                }
            }
            else
            {
                for (int i = 0, z = newMask.Length / 2 - 1; i < newMask.Length / 2; i++, z--) 
                {
                    newMask[z, 0] = lines - 1 - curMask[i, 0];
                    newMask[z, 1] = curMask[i, 1];    
                }
            }
            return newMask;
        }
        private void mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode.SelectedIndex == 0) 
            {
                lines_order.Enabled = false;
                cols_order.Enabled = false;
                lines_label.Enabled = false;
                cols_label.Enabled = false;
                instructionsLabel.Enabled = false;
                maskBox.Enabled = false;
            }
            else if(mode.SelectedIndex == 1)
            {
                lines_order.Enabled = false;
                cols_order.Enabled = true;
                lines_label.Enabled = false;
                cols_label.Enabled = true;
                instructionsLabel.Enabled = false;
                maskBox.Enabled = false;
            }
            else if(mode.SelectedIndex == 2)
            {
                lines_order.Enabled = false;
                cols_order.Enabled = false;
                lines_label.Enabled = false;
                cols_label.Enabled = false;
                instructionsLabel.Enabled = true;
                maskBox.Enabled = true;
            }
            else if(mode.SelectedIndex == 3)
            {
                lines_order.Enabled = true;
                cols_order.Enabled = true;
                lines_label.Enabled = true;
                cols_label.Enabled = true;
                instructionsLabel.Enabled = false;
                maskBox.Enabled = false;
            }
        }
    }
}
