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
using System.Data.SqlClient;

namespace GlasbenaLestvica
{
    public partial class Form3 : Form
    {
        private SQLiteConnection conn;

        public Form3()
        {
            InitializeComponent();
            conn = new SQLiteConnection("data source=bazagl.sqlite; version=3");
        }

        void Osvezi()
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "');", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            try
            {                         
                Osvezi();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Form4 dodajOkno = new Form4();
            dodajOkno.Show();
        }

        private void izbrisButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ali ste prepričani?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                SQLiteCommand com = new SQLiteCommand("DELETE FROM skladbe WHERE naslov=@naslov;", conn);
                com.Parameters.AddWithValue("@naslov", listView1.SelectedItems[0].Text);

                try
                {
                    com.ExecuteNonQuery();
                    conn.Close();
                    Osvezi();
                    izbrisButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) izbrisButton.Enabled = true;
            else izbrisButton.Enabled = false;
        }

        private void osButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "');", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void odjButton_Click(object sender, EventArgs e)
        {
            Form1 priOkno = new Form1();
            priOkno.Show();
            this.Close();
        }

        private void naslovToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "') ORDER BY naslov;", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void izvajalecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "') ORDER BY izvajalec;", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "') ORDER BY album;", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trajanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM skladbe WHERE uporabnik_id=(SELECT id FROM uporabniki WHERE ime='" + Form1.trenutnoIme + "') ORDER BY trajanje;", conn);
            try
            {
                SQLiteDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["Naslov"].ToString());
                    item.SubItems.Add(dr["Izvajalec"].ToString());
                    item.SubItems.Add(dr["Album"].ToString());
                    item.SubItems.Add(dr["Trajanje"].ToString());

                    listView1.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
