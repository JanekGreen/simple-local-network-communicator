namespace WindowsFormsApplication2
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
            this.label2 = new System.Windows.Forms.Label();
            this.tPort = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.tWiadomosc = new System.Windows.Forms.TextBox();
            this.bWyslij = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // tPort
            // 
            this.tPort.Location = new System.Drawing.Point(106, 25);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(53, 20);
            this.tPort.TabIndex = 3;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(227, 23);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tWiadomosc
            // 
            this.tWiadomosc.Location = new System.Drawing.Point(16, 290);
            this.tWiadomosc.Multiline = true;
            this.tWiadomosc.Name = "tWiadomosc";
            this.tWiadomosc.Size = new System.Drawing.Size(188, 41);
            this.tWiadomosc.TabIndex = 5;
            // 
            // bWyslij
            // 
            this.bWyslij.Location = new System.Drawing.Point(227, 290);
            this.bWyslij.Name = "bWyslij";
            this.bWyslij.Size = new System.Drawing.Size(75, 23);
            this.bWyslij.TabIndex = 6;
            this.bWyslij.Text = "Wyślij";
            this.bWyslij.UseVisualStyleBackColor = true;
            this.bWyslij.Click += new System.EventHandler(this.bWyslij_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(290, 209);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nick";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bWyslij);
            this.Controls.Add(this.tWiadomosc);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tPort);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Serwer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tWiadomosc;
        private System.Windows.Forms.Button bWyslij;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

