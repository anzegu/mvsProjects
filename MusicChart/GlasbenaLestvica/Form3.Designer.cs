namespace GlasbenaLestvica
{
    partial class Form3
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.izbrisButton = new System.Windows.Forms.Button();
            this.odjButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Naslov = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Izvajalec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trajanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.osButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.naslovToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvajalecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trajanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(79, 333);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(61, 23);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // izbrisButton
            // 
            this.izbrisButton.Enabled = false;
            this.izbrisButton.Location = new System.Drawing.Point(144, 333);
            this.izbrisButton.Name = "izbrisButton";
            this.izbrisButton.Size = new System.Drawing.Size(61, 23);
            this.izbrisButton.TabIndex = 2;
            this.izbrisButton.Text = "Izbris";
            this.izbrisButton.UseVisualStyleBackColor = true;
            this.izbrisButton.Click += new System.EventHandler(this.izbrisButton_Click);
            // 
            // odjButton
            // 
            this.odjButton.Location = new System.Drawing.Point(211, 333);
            this.odjButton.Name = "odjButton";
            this.odjButton.Size = new System.Drawing.Size(61, 23);
            this.odjButton.TabIndex = 3;
            this.odjButton.Text = "Odjava";
            this.odjButton.UseVisualStyleBackColor = true;
            this.odjButton.Click += new System.EventHandler(this.odjButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naslov,
            this.Izvajalec,
            this.Album,
            this.Trajanje});
            this.listView1.Location = new System.Drawing.Point(12, 28);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 299);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Naslov
            // 
            this.Naslov.Text = "Naslov";
            this.Naslov.Width = 117;
            // 
            // Izvajalec
            // 
            this.Izvajalec.Text = "Izvajalec";
            this.Izvajalec.Width = 103;
            // 
            // Album
            // 
            this.Album.Text = "Album";
            this.Album.Width = 95;
            // 
            // Trajanje
            // 
            this.Trajanje.Text = "Trajanje";
            // 
            // osButton
            // 
            this.osButton.Location = new System.Drawing.Point(12, 333);
            this.osButton.Name = "osButton";
            this.osButton.Size = new System.Drawing.Size(61, 23);
            this.osButton.TabIndex = 5;
            this.osButton.Text = "Osveži";
            this.osButton.UseVisualStyleBackColor = true;
            this.osButton.Click += new System.EventHandler(this.osButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naslovToolStripMenuItem1,
            this.izvajalecToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.trajanjeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Razvrsti";
            // 
            // naslovToolStripMenuItem1
            // 
            this.naslovToolStripMenuItem1.Name = "naslovToolStripMenuItem1";
            this.naslovToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.naslovToolStripMenuItem1.Text = "Naslov";
            this.naslovToolStripMenuItem1.Click += new System.EventHandler(this.naslovToolStripMenuItem1_Click);
            // 
            // izvajalecToolStripMenuItem
            // 
            this.izvajalecToolStripMenuItem.Name = "izvajalecToolStripMenuItem";
            this.izvajalecToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izvajalecToolStripMenuItem.Text = "Izvajalec";
            this.izvajalecToolStripMenuItem.Click += new System.EventHandler(this.izvajalecToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // trajanjeToolStripMenuItem
            // 
            this.trajanjeToolStripMenuItem.Name = "trajanjeToolStripMenuItem";
            this.trajanjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trajanjeToolStripMenuItem.Text = "Trajanje";
            this.trajanjeToolStripMenuItem.Click += new System.EventHandler(this.trajanjeToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 368);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.osButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.odjButton);
            this.Controls.Add(this.izbrisButton);
            this.Controls.Add(this.dodajButton);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Glasbena Lestvica";
            this.Shown += new System.EventHandler(this.Form3_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button izbrisButton;
        private System.Windows.Forms.Button odjButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Naslov;
        private System.Windows.Forms.ColumnHeader Izvajalec;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Trajanje;
        private System.Windows.Forms.Button osButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem naslovToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izvajalecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trajanjeToolStripMenuItem;
    }
}