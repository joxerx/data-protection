namespace ElGamal_encryption
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
            this.inputQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputX = new System.Windows.Forms.TextBox();
            this.inputText = new System.Windows.Forms.TextBox();
            this.toCrypt = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputQ
            // 
            this.inputQ.Location = new System.Drawing.Point(72, 9);
            this.inputQ.Name = "inputQ";
            this.inputQ.Size = new System.Drawing.Size(100, 20);
            this.inputQ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите p";
            // 
            // inputP
            // 
            this.inputP.Location = new System.Drawing.Point(72, 35);
            this.inputP.Name = "inputP";
            this.inputP.Size = new System.Drawing.Size(100, 20);
            this.inputP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите x";
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(72, 61);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 20);
            this.inputX.TabIndex = 4;
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(179, 8);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(230, 73);
            this.inputText.TabIndex = 6;
            // 
            // toCrypt
            // 
            this.toCrypt.Location = new System.Drawing.Point(125, 87);
            this.toCrypt.Name = "toCrypt";
            this.toCrypt.Size = new System.Drawing.Size(106, 23);
            this.toCrypt.TabIndex = 7;
            this.toCrypt.Text = "Выполнить";
            this.toCrypt.UseVisualStyleBackColor = true;
            this.toCrypt.Click += new System.EventHandler(this.toCrypt_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 116);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(397, 73);
            this.outputBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 230);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.toCrypt);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputQ);
            this.Name = "Form1";
            this.Text = "Схема шифрования Эль-Гамаля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button toCrypt;
        private System.Windows.Forms.TextBox outputBox;
    }
}

