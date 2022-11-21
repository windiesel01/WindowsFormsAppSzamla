using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppSzamla
{
    public partial class Form_Szamlak : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form_Szamlak()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";

            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }

            szamlak_lista_update();
        }

        private void szamlak_lista_update()
        {
            listBox_Szamlak.Items.Clear();
            cmd.CommandText = "SELECT `id`,`tulajdonosNeve`,`egyenleg`,`nyitasdatum` FROM `szamlak` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    szamlak uj = new szamlak(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetDecimal("egyenleg"), dr.GetMySqlDateTime("nyitasdatum"));
                    listBox_Szamlak.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adja meg a tulajdonos nevét!");
                textBox_nev.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_egyenleg.Text))
            {
                MessageBox.Show("Adjon meg egyenleget!");
                textBox_egyenleg.Focus();
                return;
            }

            cmd.CommandText = "INSERT INTO `szamlak`(`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (NULL,@tulajdnonosNeve,@egyenleg,@nyitasdatum)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulajdnonosNeve", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egyenleg", Convert.ToDecimal(textBox_egyenleg.Text));
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker_datum.Value);
            conn.Open();

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzitve!");
                    textBox_nev.Text = "";
                    textBox_egyenleg.Text = "";
                    dateTimePicker_datum.Value = dateTimePicker_datum.MinDate;
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzités!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            conn.Close();
            szamlak_lista_update();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (listBox_Szamlak.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve számla!");
                return;
            }

            cmd.CommandText = "UPDATE `szamlak` SET `tulajdonosNeve`= @tulajdonosNeve,`egyenleg`= @egyenleg,`nyitasdatum`= @nyitasdatum WHERE id = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox_id.Text));
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egyenleg", Convert.ToDecimal(textBox_egyenleg.Text));
            cmd.Parameters.AddWithValue("@nyitasdatum", dateTimePicker_datum.Value);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módositás sikeres!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_egyenleg.Text = "";
                dateTimePicker_datum.Value = dateTimePicker_datum.Value;
                szamlak_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok módositása sikertelen;");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_Szamlak.SelectedIndex < 0)
            {
                return;
            }

            cmd.CommandText = "DELETE FROM `szamlak` WHERE id = @id;";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                textBox_egyenleg.Text = "";
                dateTimePicker_datum.Value = dateTimePicker_datum.Value;
                szamlak_lista_update();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }

        private void listBox_Szamlak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Szamlak.SelectedIndex < 0)
            {
                return;
            }

            szamlak kivalasztott_szamla = (szamlak)listBox_Szamlak.SelectedItem;
            textBox_id.Text = kivalasztott_szamla.Id.ToString();
            textBox_nev.Text = kivalasztott_szamla.TulajNev.ToString();
            textBox_egyenleg.Text = kivalasztott_szamla.Egyenleg.ToString();
            dateTimePicker_datum.Value = kivalasztott_szamla.Datum.GetDateTime();
        }

        
    }
}
