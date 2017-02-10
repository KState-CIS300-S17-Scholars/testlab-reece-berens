namespace Lab4
{
    partial class Form1
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
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxTextBoxInput = new System.Windows.Forms.TextBox();
            this.uxTextBoxPrimeList = new System.Windows.Forms.TextBox();
            this.uxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(45, 33);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(150, 18);
            this.uxLabel.TabIndex = 0;
            this.uxLabel.Text = "Enter Positive Bound:";
            // 
            // uxTextBoxInput
            // 
            this.uxTextBoxInput.Location = new System.Drawing.Point(241, 30);
            this.uxTextBoxInput.Name = "uxTextBoxInput";
            this.uxTextBoxInput.Size = new System.Drawing.Size(100, 24);
            this.uxTextBoxInput.TabIndex = 1;
            // 
            // uxTextBoxPrimeList
            // 
            this.uxTextBoxPrimeList.Location = new System.Drawing.Point(48, 143);
            this.uxTextBoxPrimeList.Multiline = true;
            this.uxTextBoxPrimeList.Name = "uxTextBoxPrimeList";
            this.uxTextBoxPrimeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxTextBoxPrimeList.Size = new System.Drawing.Size(293, 158);
            this.uxTextBoxPrimeList.TabIndex = 2;
            // 
            // uxButton
            // 
            this.uxButton.Location = new System.Drawing.Point(129, 78);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(114, 47);
            this.uxButton.TabIndex = 3;
            this.uxButton.Text = "Find Primes";
            this.uxButton.UseVisualStyleBackColor = true;
            this.uxButton.Click += new System.EventHandler(this.Button_FindPrimes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 313);
            this.Controls.Add(this.uxButton);
            this.Controls.Add(this.uxTextBoxPrimeList);
            this.Controls.Add(this.uxTextBoxInput);
            this.Controls.Add(this.uxLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.TextBox uxTextBoxInput;
        private System.Windows.Forms.TextBox uxTextBoxPrimeList;
        private System.Windows.Forms.Button uxButton;
    }
}

