namespace WindowsFormsApplication3
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bWyslij = new System.Windows.Forms.Button();
            this.tWiadomosc = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.tPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nick";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 208);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // bWyslij
            // 
            this.bWyslij.Location = new System.Drawing.Point(226, 285);
            this.bWyslij.Name = "bWyslij";
            this.bWyslij.Size = new System.Drawing.Size(75, 23);
            this.bWyslij.TabIndex = 14;
            this.bWyslij.Text = "Wyślij";
            this.bWyslij.UseVisualStyleBackColor = true;
            this.bWyslij.Click += new System.EventHandler(this.bWyslij_Click);
            // 
            // tWiadomosc
            // 
            this.tWiadomosc.Location = new System.Drawing.Point(16, 285);
            this.tWiadomosc.Multiline = true;
            this.tWiadomosc.Name = "tWiadomosc";
            this.tWiadomosc.Size = new System.Drawing.Size(188, 41);
            this.tWiadomosc.TabIndex = 13;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(274, 18);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 12;
            this.bStart.Text = "Polacz";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // tPort
            // 
            this.tPort.Location = new System.Drawing.Point(215, 20);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(53, 20);
            this.tPort.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adres:";
            // 
            // tAdres
            // 
            this.tAdres.Location = new System.Drawing.Point(109, 20);
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(100, 20);
            this.tAdres.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 335);
            this.Controls.Add(this.tAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bWyslij);
            this.Controls.Add(this.tWiadomosc);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tPort);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bWyslij;
        private System.Windows.Forms.TextBox tWiadomosc;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tAdres;
    }
}

