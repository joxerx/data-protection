namespace vigenere_cipher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.swapper = new System.Windows.Forms.Button();
            this.keyWord = new System.Windows.Forms.TextBox();
            this.workMode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workMode);
            this.groupBox1.Controls.Add(this.keyWord);
            this.groupBox1.Controls.Add(this.swapper);
            this.groupBox1.Controls.Add(this.convert);
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Controls.Add(this.inputText);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифрование и дешифрование";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(7, 20);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(634, 137);
            this.inputText.TabIndex = 0;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(7, 195);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(634, 137);
            this.outputText.TabIndex = 1;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(547, 163);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(94, 26);
            this.convert.TabIndex = 2;
            this.convert.Text = "Шифровать";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // swapper
            // 
            this.swapper.Location = new System.Drawing.Point(375, 162);
            this.swapper.Name = "swapper";
            this.swapper.Size = new System.Drawing.Size(166, 26);
            this.swapper.TabIndex = 3;
            this.swapper.Text = "Поменять и дешифровать";
            this.swapper.UseVisualStyleBackColor = true;
            this.swapper.Click += new System.EventHandler(this.swapper_Click);
            // 
            // keyWord
            // 
            this.keyWord.Location = new System.Drawing.Point(6, 167);
            this.keyWord.Name = "keyWord";
            this.keyWord.Size = new System.Drawing.Size(298, 20);
            this.keyWord.TabIndex = 4;
            // 
            // workMode
            // 
            this.workMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workMode.FormattingEnabled = true;
            this.workMode.Items.AddRange(new object[] {
            "Слово",
            "Числа"});
            this.workMode.Location = new System.Drawing.Point(310, 167);
            this.workMode.Name = "workMode";
            this.workMode.Size = new System.Drawing.Size(59, 21);
            this.workMode.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 365);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Шифр Виженера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox workMode;
        private System.Windows.Forms.TextBox keyWord;
        private System.Windows.Forms.Button swapper;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox inputText;
    }
}

