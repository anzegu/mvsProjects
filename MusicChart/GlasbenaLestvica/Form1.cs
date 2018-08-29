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
    public partial class Form1 : Form
    {
        private SQLiteConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SQLiteConnection("data source=bazagl.sqlite; version=3");
        }
        public static string trenutnoIme = "";
        private void priButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            SQLiteCommand com = new SQLiteCommand(conn);
            com.CommandText = "SELECT count(*) FROM uporabniki WHERE ime='" + imeTB.Text + "' AND geslo='" + gesloTB.Text + "';";
                int Veljavnost = Convert.ToInt32(com.ExecuteScalar());
                conn.Close();
                if (Veljavnost == 1)
                {
                    Form3 GlOkno = new Form3();
                    GlOkno.Show();
                    trenutnoIme = imeTB.Text;
                    this.Hide();                    
                }
                else
                {
                    MessageBox.Show("Napačno uporabniško ime ali geslo!");
                }
         }
        

        private void regButton_Click(object sender, EventArgs e)
        {
            Form2 RegOkno = new Form2(this);
            RegOkno.Show();
            this.Hide();
            
        }
    }
}
