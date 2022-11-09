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

namespace atletikaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT NemzetId, Nemzet, Versenyszam, Nem, NemzetKod, VersenyzoNev, Eredmeny, Csucs, Helyezes FROM `nemzetek` JOIN `versenyekszamok` on NemzetId = versenyekszamok.NemzetKod;";
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (!dr.IsDBNull(7))
                    {
                        vb Vb = new vb(dr.GetString("Versenyszam"), dr.GetString("Nem"), dr.GetInt32("NemzetKod"), dr.GetString("VersenyzoNev"), dr.GetString("Eredmeny"), dr.GetString("Csucs"), dr.GetInt32("Helyezes"), dr.GetInt32("NemzetId"), dr.GetString("Nemzet"));
                        listBox1.Items.Add(dr.GetString("VersenyzoNev"));
                    }
                }
            }
        } }
}
