namespace transposition_cipher
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
            this.toCrypt = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.ComboBox();
            this.maskBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.cols_order = new System.Windows.Forms.TextBox();
            this.lines_order = new System.Windows.Forms.TextBox();
            this.cols_label = new System.Windows.Forms.Label();
            this.lines_label = new System.Windows.Forms.Label();
            this.cols = new System.Windows.Forms.TextBox();
            this.lines = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.mainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.toCrypt);
            this.mainBox.Controls.Add(this.mode);
            this.mainBox.Controls.Add(this.maskBox);
            this.mainBox.Controls.Add(this.instructionsLabel);
            this.mainBox.Controls.Add(this.cols_order);
            this.mainBox.Controls.Add(this.lines_order);
            this.mainBox.Controls.Add(this.cols_label);
            this.mainBox.Controls.Add(this.lines_label);
            this.mainBox.Controls.Add(this.cols);
            this.mainBox.Controls.Add(this.lines);
            this.mainBox.Controls.Add(this.label1);
            this.mainBox.Controls.Add(this.label);
            this.mainBox.Controls.Add(this.outputText);
            this.mainBox.Controls.Add(this.inputText);
            this.mainBox.Location = new System.Drawing.Point(13, 13);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(581, 392);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Шифрование";
            // 
            // toCrypt
            // 
            this.toCrypt.Location = new System.Drawing.Point(300, 230);
            this.toCrypt.Name = "toCrypt";
            this.toCrypt.Size = new System.Drawing.Size(273, 23);
            this.toCrypt.TabIndex = 13;
            this.toCrypt.Text = "Зашифровать";
            this.toCrypt.UseVisualStyleBackColor = true;
            this.toCrypt.Click += new System.EventHandler(this.toCrypt_Click);
            // 
            // mode
            // 
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Табличная маршрутная перестановка",
            "Вертикальная перестановка",
            "Поворотная решётка",
            "Двойная перестановка Кардано"});
            this.mode.Location = new System.Drawing.Point(10, 229);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(283, 21);
            this.mode.TabIndex = 12;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // maskBox
            // 
            this.maskBox.Location = new System.Drawing.Point(270, 203);
            this.maskBox.Name = "maskBox";
            this.maskBox.Size = new System.Drawing.Size(303, 20);
            this.maskBox.TabIndex = 11;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(7, 206);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(257, 13);
            this.instructionsLabel.TabIndex = 10;
            this.instructionsLabel.Text = "Пары Строка Столбец \"прорезей\" через запятую";
            // 
            // cols_order
            // 
            this.cols_order.Location = new System.Drawing.Point(295, 177);
            this.cols_order.Name = "cols_order";
            this.cols_order.Size = new System.Drawing.Size(278, 20);
            this.cols_order.TabIndex = 9;
            // 
            // lines_order
            // 
            this.lines_order.Location = new System.Drawing.Point(295, 151);
            this.lines_order.Name = "lines_order";
            this.lines_order.Size = new System.Drawing.Size(278, 20);
            this.lines_order.TabIndex = 8;
            // 
            // cols_label
            // 
            this.cols_label.AutoSize = true;
            this.cols_label.Location = new System.Drawing.Point(188, 180);
            this.cols_label.Name = "cols_label";
            this.cols_label.Size = new System.Drawing.Size(101, 13);
            this.cols_label.TabIndex = 7;
            this.cols_label.Text = "Порядок столбцов";
            // 
            // lines_label
            // 
            this.lines_label.AutoSize = true;
            this.lines_label.Location = new System.Drawing.Point(188, 154);
            this.lines_label.Name = "lines_label";
            this.lines_label.Size = new System.Drawing.Size(83, 13);
            this.lines_label.TabIndex = 6;
            this.lines_label.Text = "Порядок строк";
            // 
            // cols
            // 
            this.cols.Location = new System.Drawing.Point(129, 177);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(53, 20);
            this.cols.TabIndex = 5;
            // 
            // lines
            // 
            this.lines.Location = new System.Drawing.Point(129, 151);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(53, 20);
            this.lines.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество столбцов";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 154);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Количество строк";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(6, 259);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(567, 126);
            this.outputText.TabIndex = 1;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(6, 19);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(567, 126);
            this.inputText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 413);
            this.Controls.Add(this.mainBox);
            this.Name = "Form1";
            this.Text = "Шифры перестановки";
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.TextBox maskBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox cols_order;
        private System.Windows.Forms.TextBox lines_order;
        private System.Windows.Forms.Label cols_label;
        private System.Windows.Forms.Label lines_label;
        private System.Windows.Forms.TextBox cols;
        private System.Windows.Forms.TextBox lines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button toCrypt;
    }
}

