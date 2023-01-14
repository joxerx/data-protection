namespace caesar_cipher
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
            this.toCrypt = new System.Windows.Forms.GroupBox();
            this.mover = new System.Windows.Forms.TextBox();
            this.cipher = new System.Windows.Forms.Button();
            this.encrypted_text = new System.Windows.Forms.TextBox();
            this.origin_text = new System.Windows.Forms.TextBox();
            this.decryptor = new System.Windows.Forms.Button();
            this.resultAnlasyzis = new System.Windows.Forms.Label();
            this.toCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // toCrypt
            // 
            this.toCrypt.Controls.Add(this.resultAnlasyzis);
            this.toCrypt.Controls.Add(this.decryptor);
            this.toCrypt.Controls.Add(this.mover);
            this.toCrypt.Controls.Add(this.cipher);
            this.toCrypt.Controls.Add(this.encrypted_text);
            this.toCrypt.Controls.Add(this.origin_text);
            this.toCrypt.Location = new System.Drawing.Point(13, 13);
            this.toCrypt.Name = "toCrypt";
            this.toCrypt.Size = new System.Drawing.Size(567, 301);
            this.toCrypt.TabIndex = 0;
            this.toCrypt.TabStop = false;
            this.toCrypt.Text = "Шифрование";
            // 
            // mover
            // 
            this.mover.Location = new System.Drawing.Point(338, 147);
            this.mover.Name = "mover";
            this.mover.Size = new System.Drawing.Size(100, 20);
            this.mover.TabIndex = 3;
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(444, 144);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(117, 23);
            this.cipher.TabIndex = 2;
            this.cipher.Text = "Зашифровать";
            this.cipher.UseVisualStyleBackColor = true;
            this.cipher.Click += new System.EventHandler(this.cipher_Click);
            // 
            // encrypted_text
            // 
            this.encrypted_text.Location = new System.Drawing.Point(7, 173);
            this.encrypted_text.Multiline = true;
            this.encrypted_text.Name = "encrypted_text";
            this.encrypted_text.Size = new System.Drawing.Size(554, 118);
            this.encrypted_text.TabIndex = 1;
            // 
            // origin_text
            // 
            this.origin_text.Location = new System.Drawing.Point(7, 20);
            this.origin_text.Multiline = true;
            this.origin_text.Name = "origin_text";
            this.origin_text.Size = new System.Drawing.Size(554, 118);
            this.origin_text.TabIndex = 0;
            // 
            // decryptor
            // 
            this.decryptor.Location = new System.Drawing.Point(6, 147);
            this.decryptor.Name = "decryptor";
            this.decryptor.Size = new System.Drawing.Size(163, 23);
            this.decryptor.TabIndex = 4;
            this.decryptor.Text = "Вычислить смещение";
            this.decryptor.UseVisualStyleBackColor = true;
            this.decryptor.Click += new System.EventHandler(this.decryptor_Click);
            // 
            // resultAnlasyzis
            // 
            this.resultAnlasyzis.AutoSize = true;
            this.resultAnlasyzis.Location = new System.Drawing.Point(176, 154);
            this.resultAnlasyzis.Name = "resultAnlasyzis";
            this.resultAnlasyzis.Size = new System.Drawing.Size(0, 13);
            this.resultAnlasyzis.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 329);
            this.Controls.Add(this.toCrypt);
            this.Name = "Form1";
            this.Text = "Шифр Цезаря";
            this.toCrypt.ResumeLayout(false);
            this.toCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toCrypt;
        private System.Windows.Forms.TextBox mover;
        private System.Windows.Forms.Button cipher;
        private System.Windows.Forms.TextBox encrypted_text;
        private System.Windows.Forms.TextBox origin_text;
        private System.Windows.Forms.Button decryptor;
        private System.Windows.Forms.Label resultAnlasyzis;
    }
}

