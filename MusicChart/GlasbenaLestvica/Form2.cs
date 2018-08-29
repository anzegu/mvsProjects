using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GlasbenaLestvica
{
    public partial class Form2 : Form
    {
        Form1 priOkno;
        private SQLiteConnection conn;        
        public Form2(Form1 priOkn)
        {
            InitializeComponent();
            conn = new SQLiteConnection("data source=bazagl.sqlite; version=3");
            this.ControlBox = false;
            priOkno = priOkn;
        }

        private void regiButton_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SQLiteCommand com = new SQLiteCommand(conn);
            com.CommandText = "SELECT count(*) FROM uporabniki WHERE ime='" + imerTB.Text + "';";
            int Veljavnost = Convert.ToInt32(com.ExecuteScalar());
            bool Ujemanje = false;
            if (geslorTB.Text == potTB.Text) Ujemanje = true;
            if (Veljavnost == 1) MessageBox.Show("Uporabnik že obstaja!");
            else if (geslorTB.Text.Length < 5) MessageBox.Show("Geslo mora biti vsaj 5 znakov");
            else if (!Ujemanje) MessageBox.Show("Gesli se ne ujemata!");
            else if (imerTB.Text.Length == 0) MessageBox.Show("Niste vnesli imena!");
            else
            {
                com.CommandText = "INSERT INTO uporabniki(ime, geslo) VALUES('" + imerTB.Text + "','" + geslorTB.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Uspešno ste registrirani!");

            }
            conn.Close();
        }

        private void nazajButton_Click(object sender, EventArgs e)
        {
            priOkno.Show();
            this.Close();
        }
    }
}
