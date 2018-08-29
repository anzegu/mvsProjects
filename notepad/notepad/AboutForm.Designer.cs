namespace notepad
{
    partial class aboutForm
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
            this.aboutBox = new System.Windows.Forms.RichTextBox();
            this.aboutButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aboutBox
            // 
            this.aboutBox.BackColor = System.Drawing.SystemColors.Menu;
            this.aboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutBox.Font = new System.Drawing.Font("MicroSquare", 13.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBox.Location = new System.Drawing.Point(13, 13);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(257, 199);
            this.aboutBox.TabIndex = 0;
            this.aboutBox.Text = "Made by me\n©\n";
            // 
            // aboutButton1
            // 
            this.aboutButton1.Location = new System.Drawing.Point(104, 218);
            this.aboutButton1.Name = "aboutButton1";
            this.aboutButton1.Size = new System.Drawing.Size(75, 23);
            this.aboutButton1.TabIndex = 1;
            this.aboutButton1.Text = "Ok";
            this.aboutButton1.UseVisualStyleBackColor = true;
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 254);
            this.Controls.Add(this.aboutButton1);
            this.Controls.Add(this.aboutBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "aboutForm";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox aboutBox;
        private System.Windows.Forms.Button aboutButton1;
    }
}