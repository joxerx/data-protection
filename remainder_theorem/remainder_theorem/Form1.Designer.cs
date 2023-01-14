namespace remainder_theorem
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
            this.default_task = new System.Windows.Forms.GroupBox();
            this.instruction1 = new System.Windows.Forms.Label();
            this.standart_x = new System.Windows.Forms.TextBox();
            this.find1 = new System.Windows.Forms.Button();
            this.multiplied_task = new System.Windows.Forms.GroupBox();
            this.find2 = new System.Windows.Forms.Button();
            this.multiplied_x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.default_task.SuspendLayout();
            this.multiplied_task.SuspendLayout();
            this.SuspendLayout();
            // 
            // default_task
            // 
            this.default_task.Controls.Add(this.find1);
            this.default_task.Controls.Add(this.standart_x);
            this.default_task.Controls.Add(this.instruction1);
            this.default_task.Location = new System.Drawing.Point(14, 14);
            this.default_task.Name = "default_task";
            this.default_task.Size = new System.Drawing.Size(345, 108);
            this.default_task.TabIndex = 0;
            this.default_task.TabStop = false;
            this.default_task.Text = "Стандартное представление";
            // 
            // instruction1
            // 
            this.instruction1.AutoSize = true;
            this.instruction1.Location = new System.Drawing.Point(6, 16);
            this.instruction1.Name = "instruction1";
            this.instruction1.Size = new System.Drawing.Size(289, 26);
            this.instruction1.TabIndex = 0;
            this.instruction1.Text = "Ввод в следующем формате: \r\nмодуль1 остаток1,модуль2 остаток2,модуль3 остаток3\r\n";
            // 
            // standart_x
            // 
            this.standart_x.Location = new System.Drawing.Point(7, 46);
            this.standart_x.Name = "standart_x";
            this.standart_x.Size = new System.Drawing.Size(326, 20);
            this.standart_x.TabIndex = 1;
            // 
            // find1
            // 
            this.find1.Location = new System.Drawing.Point(6, 72);
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(75, 23);
            this.find1.TabIndex = 2;
            this.find1.Text = "Найти";
            this.find1.UseVisualStyleBackColor = true;
            this.find1.Click += new System.EventHandler(this.find1_Click);
            // 
            // multiplied_task
            // 
            this.multiplied_task.Controls.Add(this.find2);
            this.multiplied_task.Controls.Add(this.multiplied_x);
            this.multiplied_task.Controls.Add(this.label1);
            this.multiplied_task.Location = new System.Drawing.Point(12, 128);
            this.multiplied_task.Name = "multiplied_task";
            this.multiplied_task.Size = new System.Drawing.Size(347, 108);
            this.multiplied_task.TabIndex = 3;
            this.multiplied_task.TabStop = false;
            this.multiplied_task.Text = "Представление с множителями";
            // 
            // find2
            // 
            this.find2.Location = new System.Drawing.Point(6, 72);
            this.find2.Name = "find2";
            this.find2.Size = new System.Drawing.Size(75, 23);
            this.find2.TabIndex = 2;
            this.find2.Text = "Найти";
            this.find2.UseVisualStyleBackColor = true;
            this.find2.Click += new System.EventHandler(this.find2_Click);
            // 
            // multiplied_x
            // 
            this.multiplied_x.Location = new System.Drawing.Point(7, 46);
            this.multiplied_x.Name = "multiplied_x";
            this.multiplied_x.Size = new System.Drawing.Size(328, 20);
            this.multiplied_x.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод в следующем формате: \r\nмножитель1 модуль1 остаток1,множитель 2 модуль2 остат" +
    "ок2\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 264);
            this.Controls.Add(this.multiplied_task);
            this.Controls.Add(this.default_task);
            this.Name = "Form1";
            this.Text = "Китайская теорема об остатках";
            this.default_task.ResumeLayout(false);
            this.default_task.PerformLayout();
            this.multiplied_task.ResumeLayout(false);
            this.multiplied_task.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox default_task;
        private System.Windows.Forms.Button find1;
        private System.Windows.Forms.TextBox standart_x;
        private System.Windows.Forms.Label instruction1;
        private System.Windows.Forms.GroupBox multiplied_task;
        private System.Windows.Forms.Button find2;
        private System.Windows.Forms.TextBox multiplied_x;
        private System.Windows.Forms.Label label1;
    }
}

