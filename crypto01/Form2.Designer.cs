namespace crypto01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generate_alphabet_B = new System.Windows.Forms.Button();
            this.cancel_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate_alphabet_B
            // 
            this.generate_alphabet_B.Location = new System.Drawing.Point(13, 13);
            this.generate_alphabet_B.Name = "generate_alphabet_B";
            this.generate_alphabet_B.Size = new System.Drawing.Size(173, 23);
            this.generate_alphabet_B.TabIndex = 0;
            this.generate_alphabet_B.Text = "generate new alphabet";
            this.generate_alphabet_B.UseVisualStyleBackColor = true;
            this.generate_alphabet_B.Click += new System.EventHandler(this.generate_alphabet_B_Click);
            // 
            // cancel_B
            // 
            this.cancel_B.Location = new System.Drawing.Point(192, 13);
            this.cancel_B.Name = "cancel_B";
            this.cancel_B.Size = new System.Drawing.Size(75, 23);
            this.cancel_B.TabIndex = 1;
            this.cancel_B.Text = "cancel";
            this.cancel_B.UseVisualStyleBackColor = true;
            this.cancel_B.Click += new System.EventHandler(this.cancel_B_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 48);
            this.Controls.Add(this.cancel_B);
            this.Controls.Add(this.generate_alphabet_B);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form2";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generate_alphabet_B;
        private System.Windows.Forms.Button cancel_B;
    }
}