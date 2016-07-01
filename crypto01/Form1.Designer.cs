namespace crypto01
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypt_B = new System.Windows.Forms.Button();
            this.decrypt_B = new System.Windows.Forms.Button();
            this.more_options = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 18);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 11);
            this.label1.TabIndex = 2;
            this.label1.Text = "введите данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 11);
            this.label2.TabIndex = 3;
            this.label2.Text = "результат";
            // 
            // encrypt_B
            // 
            this.encrypt_B.Location = new System.Drawing.Point(122, 60);
            this.encrypt_B.Name = "encrypt_B";
            this.encrypt_B.Size = new System.Drawing.Size(75, 23);
            this.encrypt_B.TabIndex = 4;
            this.encrypt_B.Text = "encrypt";
            this.encrypt_B.UseVisualStyleBackColor = true;
            this.encrypt_B.Click += new System.EventHandler(this.encrypt_B_Click);
            // 
            // decrypt_B
            // 
            this.decrypt_B.Location = new System.Drawing.Point(203, 60);
            this.decrypt_B.Name = "decrypt_B";
            this.decrypt_B.Size = new System.Drawing.Size(75, 23);
            this.decrypt_B.TabIndex = 5;
            this.decrypt_B.Text = "decrypt";
            this.decrypt_B.UseVisualStyleBackColor = true;
            this.decrypt_B.Click += new System.EventHandler(this.decrypt_B_Click);
            // 
            // more_options
            // 
            this.more_options.Location = new System.Drawing.Point(297, 60);
            this.more_options.Name = "more_options";
            this.more_options.Size = new System.Drawing.Size(75, 23);
            this.more_options.TabIndex = 6;
            this.more_options.Text = "more...";
            this.more_options.UseVisualStyleBackColor = true;
            this.more_options.Click += new System.EventHandler(this.more_options_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 11);
            this.label3.TabIndex = 7;
            this.label3.Text = "alph:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 11);
            this.label4.TabIndex = 8;
            this.label4.Text = "0 1 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.more_options);
            this.Controls.Add(this.decrypt_B);
            this.Controls.Add(this.encrypt_B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Substitution cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button encrypt_B;
        private System.Windows.Forms.Button decrypt_B;
        private System.Windows.Forms.Button more_options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

