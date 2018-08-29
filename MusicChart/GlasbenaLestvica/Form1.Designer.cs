namespace GlasbenaLestvica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.gesloTB = new System.Windows.Forms.TextBox();
            this.priButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geslo";
            // 
            // imeTB
            // 
            this.imeTB.Location = new System.Drawing.Point(12, 25);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(100, 20);
            this.imeTB.TabIndex = 2;
            // 
            // gesloTB
            // 
            this.gesloTB.Location = new System.Drawing.Point(12, 81);
            this.gesloTB.Name = "gesloTB";
            this.gesloTB.Size = new System.Drawing.Size(100, 20);
            this.gesloTB.TabIndex = 3;
            // 
            // priButton
            // 
            this.priButton.Location = new System.Drawing.Point(15, 120);
            this.priButton.Name = "priButton";
            this.priButton.Size = new System.Drawing.Size(75, 23);
            this.priButton.TabIndex = 4;
            this.priButton.Text = "Prijava";
            this.priButton.UseVisualStyleBackColor = true;
            this.priButton.Click += new System.EventHandler(this.priButton_Click);
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(135, 120);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Registracija";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 178);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.priButton);
            this.Controls.Add(this.gesloTB);
            this.Controls.Add(this.imeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.TextBox gesloTB;
        private System.Windows.Forms.Button priButton;
        private System.Windows.Forms.Button regButton;
    }
}

