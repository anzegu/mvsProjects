namespace GlasbenaLestvica
{
    partial class Form4
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
            this.naslovTB = new System.Windows.Forms.TextBox();
            this.izvTB = new System.Windows.Forms.TextBox();
            this.tTB = new System.Windows.Forms.TextBox();
            this.alTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.nazajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslovTB
            // 
            this.naslovTB.Location = new System.Drawing.Point(12, 36);
            this.naslovTB.Name = "naslovTB";
            this.naslovTB.Size = new System.Drawing.Size(170, 20);
            this.naslovTB.TabIndex = 0;
            // 
            // izvTB
            // 
            this.izvTB.Location = new System.Drawing.Point(12, 86);
            this.izvTB.Name = "izvTB";
            this.izvTB.Size = new System.Drawing.Size(170, 20);
            this.izvTB.TabIndex = 1;
            // 
            // tTB
            // 
            this.tTB.Location = new System.Drawing.Point(12, 187);
            this.tTB.Name = "tTB";
            this.tTB.Size = new System.Drawing.Size(170, 20);
            this.tTB.TabIndex = 2;
            // 
            // alTB
            // 
            this.alTB.Location = new System.Drawing.Point(12, 136);
            this.alTB.Name = "alTB";
            this.alTB.Size = new System.Drawing.Size(170, 20);
            this.alTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izvajalec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trajanje";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(48, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(134, 226);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(48, 23);
            this.nazajButton.TabIndex = 9;
            this.nazajButton.Text = "<--";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 261);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alTB);
            this.Controls.Add(this.tTB);
            this.Controls.Add(this.izvTB);
            this.Controls.Add(this.naslovTB);
            this.Name = "Form4";
            this.Text = "Dodajanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naslovTB;
        private System.Windows.Forms.TextBox izvTB;
        private System.Windows.Forms.TextBox tTB;
        private System.Windows.Forms.TextBox alTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button nazajButton;
    }
}