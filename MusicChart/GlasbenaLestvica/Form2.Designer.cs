namespace GlasbenaLestvica
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
            this.geslorTB = new System.Windows.Forms.TextBox();
            this.imerTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regiButton = new System.Windows.Forms.Button();
            this.nazajButton = new System.Windows.Forms.Button();
            this.potTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geslorTB
            // 
            this.geslorTB.Location = new System.Drawing.Point(12, 81);
            this.geslorTB.Name = "geslorTB";
            this.geslorTB.Size = new System.Drawing.Size(100, 20);
            this.geslorTB.TabIndex = 6;
            // 
            // imerTB
            // 
            this.imerTB.Location = new System.Drawing.Point(12, 25);
            this.imerTB.Name = "imerTB";
            this.imerTB.Size = new System.Drawing.Size(100, 20);
            this.imerTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Geslo";
            // 
            // regiButton
            // 
            this.regiButton.Location = new System.Drawing.Point(15, 121);
            this.regiButton.Name = "regiButton";
            this.regiButton.Size = new System.Drawing.Size(75, 23);
            this.regiButton.TabIndex = 8;
            this.regiButton.Text = "Registriraj";
            this.regiButton.UseVisualStyleBackColor = true;
            this.regiButton.Click += new System.EventHandler(this.regiButton_Click);
            // 
            // nazajButton
            // 
            this.nazajButton.Location = new System.Drawing.Point(124, 121);
            this.nazajButton.Name = "nazajButton";
            this.nazajButton.Size = new System.Drawing.Size(75, 23);
            this.nazajButton.TabIndex = 9;
            this.nazajButton.Text = "<--";
            this.nazajButton.UseVisualStyleBackColor = true;
            this.nazajButton.Click += new System.EventHandler(this.nazajButton_Click);
            // 
            // potTB
            // 
            this.potTB.Location = new System.Drawing.Point(126, 81);
            this.potTB.Name = "potTB";
            this.potTB.Size = new System.Drawing.Size(100, 20);
            this.potTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Potrditev";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 178);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.potTB);
            this.Controls.Add(this.nazajButton);
            this.Controls.Add(this.regiButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.geslorTB);
            this.Controls.Add(this.imerTB);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox geslorTB;
        private System.Windows.Forms.TextBox imerTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regiButton;
        private System.Windows.Forms.Button nazajButton;
        private System.Windows.Forms.TextBox potTB;
        private System.Windows.Forms.Label label3;
    }
}