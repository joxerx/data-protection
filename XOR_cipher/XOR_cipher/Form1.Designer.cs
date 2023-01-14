namespace XOR_cipher
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
            this.mainBox = new System.Windows.Forms.GroupBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.visualMode = new System.Windows.Forms.ComboBox();
            this.workMode = new System.Windows.Forms.ComboBox();
            this.LFSRmode = new System.Windows.Forms.ComboBox();
            this.startValue = new System.Windows.Forms.TextBox();
            this.toCrypt = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.mainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.keyBox);
            this.mainBox.Controls.Add(this.toCrypt);
            this.mainBox.Controls.Add(this.startValue);
            this.mainBox.Controls.Add(this.LFSRmode);
            this.mainBox.Controls.Add(this.workMode);
            this.mainBox.Controls.Add(this.visualMode);
            this.mainBox.Controls.Add(this.outputBox);
            this.mainBox.Controls.Add(this.inputBox);
            this.mainBox.Location = new System.Drawing.Point(12, 3);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(744, 425);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Шифрование и дешифровка";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(7, 20);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(731, 128);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(7, 264);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(731, 155);
            this.outputBox.TabIndex = 1;
            // 
            // visualMode
            // 
            this.visualMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Символьный вид",
            "Двоичный вид",
            "Шестнадцатиричный вид"});
            this.visualMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visualMode.FormattingEnabled = true;
            this.visualMode.Items.AddRange(new object[] {
            "Символьный вид",
            "Двоичный вид",
            "Шестнадцатиричный вид"});
            this.visualMode.Location = new System.Drawing.Point(7, 155);
            this.visualMode.Name = "visualMode";
            this.visualMode.Size = new System.Drawing.Size(151, 21);
            this.visualMode.TabIndex = 2;
            this.visualMode.SelectedIndexChanged += new System.EventHandler(this.visualMode_SelectedIndexChanged);
            // 
            // workMode
            // 
            this.workMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Символьный вид",
            "Двоичный вид",
            "Шестнадцатиричный вид"});
            this.workMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workMode.FormattingEnabled = true;
            this.workMode.Items.AddRange(new object[] {
            "Гаммирование",
            "Скремблер"});
            this.workMode.Location = new System.Drawing.Point(164, 154);
            this.workMode.Name = "workMode";
            this.workMode.Size = new System.Drawing.Size(151, 21);
            this.workMode.TabIndex = 3;
            this.workMode.SelectedIndexChanged += new System.EventHandler(this.workMode_SelectedIndexChanged);
            // 
            // LFSRmode
            // 
            this.LFSRmode.AutoCompleteCustomSource.AddRange(new string[] {
            "Символьный вид",
            "Двоичный вид",
            "Шестнадцатиричный вид"});
            this.LFSRmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LFSRmode.FormattingEnabled = true;
            this.LFSRmode.Items.AddRange(new object[] {
            "x^11 + x^5 + x^2 + 1",
            "x^11 + x^2 + 1"});
            this.LFSRmode.Location = new System.Drawing.Point(321, 154);
            this.LFSRmode.Name = "LFSRmode";
            this.LFSRmode.Size = new System.Drawing.Size(151, 21);
            this.LFSRmode.TabIndex = 4;
            // 
            // startValue
            // 
            this.startValue.Location = new System.Drawing.Point(479, 154);
            this.startValue.Name = "startValue";
            this.startValue.Size = new System.Drawing.Size(100, 20);
            this.startValue.TabIndex = 5;
            // 
            // toCrypt
            // 
            this.toCrypt.Location = new System.Drawing.Point(586, 154);
            this.toCrypt.Name = "toCrypt";
            this.toCrypt.Size = new System.Drawing.Size(152, 23);
            this.toCrypt.TabIndex = 6;
            this.toCrypt.Text = "Применить";
            this.toCrypt.UseVisualStyleBackColor = true;
            this.toCrypt.Click += new System.EventHandler(this.toCrypt_Click);
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(7, 183);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(731, 75);
            this.keyBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 448);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Гаммирование";
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.ComboBox visualMode;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.ComboBox LFSRmode;
        private System.Windows.Forms.ComboBox workMode;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button toCrypt;
        private System.Windows.Forms.TextBox startValue;
    }
}

