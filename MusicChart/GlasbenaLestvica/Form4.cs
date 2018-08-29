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
    public partial class Form4 : Form
    {
        private SQLiteConnection conn;
        public Form4()
        {
            InitializeComponent();
            conn = new SQLiteConnection("data source=bazagl.sqlite; version=3");
            this.ControlBox = false;
        }

        private void nazajButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (naslovTB.Text.Length == 0 || izvTB.Text.Length == 0 || alTB.Text.Length == 0 || tTB.Text.Length == 0)
            {
                MessageBox.Show("Izpolnite vsa polja!");
            }
            else
            {
                conn.Open();
                SQLiteCommand com = new SQLiteCommand(conn);
                com.CommandText = "INSERT INTO skladbe(naslov, izvajalec, album, trajanje, uporabnik_id) VALUES('" + naslovTB.Text + "','" + izvTB.Text + "','" + alTB.Text + "','" + tTB.Text + "', (SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "')) ";
                com.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }
    }
}
