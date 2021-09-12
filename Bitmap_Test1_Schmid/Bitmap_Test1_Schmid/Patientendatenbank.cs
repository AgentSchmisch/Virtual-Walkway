﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bitmap_Test1_Schmid
{
    public partial class Patientendatenbank : Form
    {
        /* TODO: erstellen der Tabellen nach Schema: Vorname_Nachname_Geburtsdatum(Format: DDMMYYYY)
        * TODO: überarbeiten aller SQL Queries um fehler auszuschließen die von vorherigen versionen übrig sind
        * TODO: tabellen überarbeiten um vor und nachname zu trennen
         */
        string connString_Christoph = @"";
        string pfadCHP = @"";

        string connString_SchmischLaptop = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Florian\source\repos\AgentSchmisch\Digitale-Koordinationsleiter\Bitmap_Test1_Schmid\Bitmap_Test1_Schmid\Database\Patienten.mdf;Integrated Security = True; Connect Timeout = 30";
        string pfadSchmischLaptop = @"C:\Users\Florian\source\repos\AgentSchmisch\Digitale-Koordinationsleiter\Bitmap_Test1_Schmid\Bitmap_Test1_Schmid\Database";
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Flori\source\repos\AgentSchmisch\Virtual-Walkway\\Bitmap_Test1_Schmid\\Bitmap_Test1_Schmid\\Database\\Patienten.mdf;Integrated Security=True;Connect Timeout=30";
        string pfadSchmisch = @"C:\Users\Flori\source\repos\AgentSchmisch\Digitale-Koordinationsleiter\Bitmap_Test1_Schmid\Bitmap_Test1_Schmid\Database";
        string query1;
        string query2;
        string query3;
        string record;
        string Patientenname;
        public string Nameaktuell;
        public string letzteBehandlung;
        public string letzteSchrittanzahl;
        public string BehandlungsnummerMax;
        //parameters for database connection
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable tbl;  //datatable for query results
        public Patientendatenbank() //constructuor
        {
            InitializeComponent();
            
        }

        private void conns()
        {
            if (Directory.Exists(pfadSchmisch))
            {
                conn = new SqlConnection(connString);
            }
            else if (Directory.Exists(pfadCHP))
            {
                conn = new SqlConnection(connString_Christoph);
            }
            else if (Directory.Exists(pfadSchmischLaptop))
            {
                conn = new SqlConnection(connString_SchmischLaptop);
            }
            else
            {
                MessageBox.Show("fehler");
            }
        }
        private void Patientendatenbank_Load(object sender, EventArgs e)
        {
            conns();
            try
            {
                conn.Open();
                labelHinweis.Text = "Verbindung zur Datenbank hergestellt";
            }
            catch
            {
                labelHinweis.Text = "Verbindung zur Datenbank fehlgeschlagen";
            }
            finally
            {
                conn.Close();
            }

        }

        private void sucheBtn_Click(object sender, EventArgs e)
        {
            query1 = "select Vorname, Nachname Postleitzahl, Ort, Geburtsdatum from Patientenliste where Vorname in ('" + TbName.Text + "') and Nachname in ('"+TbNachname.Text+"') order by Name asc ;";

            try
            {
                cmd = new SqlCommand(query1, conn);
                conn.Open();
                da = new SqlDataAdapter(cmd);
                tbl = new DataTable();
                da.Fill(tbl);
            }
            catch
            {
                labelHinweis.Text = "Abfrage fehlgeschlagen";
                return;
            }
            finally
            {

                conn.Close();
            }
            //fill listbox with all information
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                record = "";
                Nameaktuell = "";
                DataRow row = tbl.Rows[i];
                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    if (tbl.Columns[j].ColumnName == "Patientennummer")
                    {

                        record += row[j] + "\t";
                        
                        continue;
                    }
                }

                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    if (tbl.Columns[j].ColumnName == "Vorname")
                    {

                        record += row[j] + "\t";
                        Nameaktuell += row[j];
                        continue;
                    }
                }
                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    if (tbl.Columns[j].ColumnName == "Nachname")
                    {

                        record += row[j] + "\t";
                        Nameaktuell += row[j];
                        continue;
                    }
                }

                for (int k = 0; k < tbl.Columns.Count; k++)
                {
                    if (tbl.Columns[k].ColumnName == "Postleitzahl")
                    {
                        record += row[k] + "\t";
                        continue;
                    }
                }

                for (int l = 0; l < tbl.Columns.Count; l++)
                {
                    if (tbl.Columns[l].ColumnName == "Ort")
                    {
                        record += row[l] + "\t";
                        continue;
                    }
                }
                for (int m = 0; m < tbl.Columns.Count; m++)
                {
                    if (tbl.Columns[m].ColumnName == "Geburtsdatum")
                    {
                        record += row[m] + "\t";
                        continue;
                    }
                }
                //present the information in the listbox
                Patienten.Items.Add(record);

            }
        }

        private void button1_Click(object sender, EventArgs e) //auswahlBtn
        {
           

            Nameaktuell = Nameaktuell.Replace(" ", "_");
            labelHinweis.Text = Nameaktuell;

            query3 = "select Max(Behandlungsnummer) Vorname,Nachname, Behandlungsdatum, Schrittweite, Behandlungsnummer from " + Nameaktuell + "); ";
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                record = "";
                DataRow row = tbl.Rows[i];
                for (int j = 0; j < tbl.Columns.Count; j++)
                {
                    if (tbl.Columns[j].ColumnName == "Name")
                    {

                        Nameaktuell += row[j] + "\t";
                        continue;
                    }
                }

                for (int k = 0; k < tbl.Columns.Count; k++)
                {
                    if (tbl.Columns[k].ColumnName == "Behandlungsdatum")
                    {
                        letzteBehandlung += row[k] + "\t";
                        continue;
                    }
                }

                for (int l = 0; l < tbl.Columns.Count; l++)
                {
                    if (tbl.Columns[l].ColumnName == "Schrittweite")
                    {
                        letzteSchrittanzahl += row[l] + "\t";
                        continue;
                    }
                }
                for (int l = 0; l < tbl.Columns.Count; l++)
                {
                    if (tbl.Columns[l].ColumnName == "Behandlungsnummer")
                    {
                        BehandlungsnummerMax += row[l] + "\t";
                        continue;
                    }
                }

            }
        }
        #region clear the textbox if clicked, color the box black if text is entered
        private void TbName_Click(object sender, EventArgs e)
        {
            if (TbName.Text == "Vorname")
            {
                TbName.Text = "";
                TbName.ForeColor = Color.Black;
            }
        }
        private void TbAdresse_Click(object sender, EventArgs e)
        {
            if (TbAdresse.Text == "Adresse")
            {
                TbAdresse.Text = "";
                TbAdresse.ForeColor = Color.Black;
            }
        }
        private void TbGeburtsdatum_Click(object sender, EventArgs e)
        {
            if (TbGeburtsdatum.Text == "Geburtsdatum")
            {
                TbGeburtsdatum.Text = "";
                TbGeburtsdatum.ForeColor = Color.Black;
            }
        }
        private void TbOrt_Click(object sender, EventArgs e)
        {
            if (TbOrt.Text == "Ort")
            {
                TbOrt.Text = "";
                TbOrt.ForeColor = Color.Black;
            }
        }
        private void TbPLZ_Click(object sender, EventArgs e)
        {
            if (TbPLZ.Text == "PLZ")
            {
                TbPLZ.Text = "";
                TbPLZ.ForeColor = Color.Black;
            }
        }
        private void TbTelefonnummer_Click(object sender, EventArgs e)
        {
            if (TbTelefonnummer.Text == "Telefonnummer")
            {
                TbTelefonnummer.Text = "";
                TbTelefonnummer.ForeColor = Color.Black;
            }
        }
        private void TbNachname_Click(object sender, EventArgs e)
        {
            if (TbNachname.Text == "Nachname")
            {
                TbNachname.Text = "";
                TbNachname.ForeColor = Color.Black;
            }
        }

        private void TbName_Leave(object sender, EventArgs e)
        {
            if (TbName.Text == "")
            {
                TbName.ForeColor = Color.Gray;
                TbName.Text = "Vorname";
            }
        }
        private void TbNachname_Leave(object sender, EventArgs e)
        {
            if(TbNachname.Text=="")
            {
                TbName.ForeColor = Color.Gray;
                TbName.Text = "Vorname";
            }
        }
        private void TbAdresse_Leave(object sender, EventArgs e)
        {
            if (TbAdresse.Text == "")
            {
                TbAdresse.ForeColor = Color.Gray;
                TbAdresse.Text = "Adresse";
            }
        }
        private void TbTelefonnummer_Leave(object sender, EventArgs e)
        {
            if (TbTelefonnummer.Text == "")
            {
                TbTelefonnummer.ForeColor = Color.Gray;
                TbTelefonnummer.Text = "Telefonnummer";
            }
        }
        private void TbOrt_Leave(object sender, EventArgs e)
        {
            if (TbOrt.Text == "")
            {
                TbOrt.ForeColor = Color.Gray;
                TbOrt.Text = "Ort";
            }
        }
        private void TbGeburtsdatum_Leave(object sender, EventArgs e)
        {
            if (TbGeburtsdatum.Text == "")
            {
                TbGeburtsdatum.ForeColor = Color.Gray;
                TbGeburtsdatum.Text = "Geburtsdatum";
            }
        }
        private void TbPLZ_Leave(object sender, EventArgs e)
        {
            if (TbPLZ.Text == "")
            {
                TbPLZ.ForeColor = Color.Gray;
                TbPLZ.Text = "PLZ";
            }
        }
        #endregion
        public string wertuebergabe {
            set
            {
               int _BehandlungsnummerMax = Convert.ToInt32(BehandlungsnummerMax) + 1;
                Nameaktuell = Nameaktuell.Replace(" ", "_");
                query3 = "Insert Into " + Nameaktuell + "(Name,Behandlungsdatum,Schrittweite,Geburtsdatum,Behandlungsnummer) Values" + Nameaktuell + ","
                    + DateTime.Now.ToString("yyyy.mm.dd") + "," + value + "," +_BehandlungsnummerMax.ToString()+",";
                try
                {
                    cmd = new SqlCommand(query3, conn);
                    conn.Open();

                }
                catch
                {
                    labelHinweis.Text = "Abfrage fehlgeschlagen";
                    return;
                }
                finally
                {
                    conn.Close();
                }
            }
            //TODO: Werte für Name,Schrittweite und letzte Behandlung in die UI übergeben um sie dort anzeigen zu lassen

        }
       

        private void Patientendatenbank_FormClosing(object sender, FormClosingEventArgs e)
        {


            //BUG:      Fehler beim schließen und wiederöffnen der Form während form1 & projetktion geöffnet bleibt    


        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Patientenname = TbName.Text.ToString();
            Patientenname = Patientenname.Replace(' ', '_');
            //erstellen der Datenbank für den jeweiligen Patienten, Füllen der allgemeinen tablle mit Informationen für die Suche
            query2 = "create table " + Patientenname + " (Patientennummer nvarchar(10) not null primary key , Name nvarchar(50), Behandlungsdatum nvarchar(50),Schrittweite nvarchar(5));" +
                "Insert into Patientenliste(Name,Geburtsdatum,Adresse,Ort,Postleitzahl,Telefonnummer) values('" + Patientenname + "','" +
                TbGeburtsdatum.Text + "','" + TbAdresse.Text + "','" + TbOrt.Text + "','" + TbPLZ.Text + "','" + TbTelefonnummer.Text + "');";
            try
            {
                conn.Open();

                cmd = new SqlCommand(query2, conn);

                cmd.ExecuteNonQuery();
                labelHinweis.Text = "erfolgreich";

            }
            catch
            {
                MessageBox.Show("Fehler");
            }


            finally
            {
                //MessageBox.Show("Patient erfolgreich hinzugefügt", "Erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }


        }

        private void eintragungLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: löschen von angelegten Patienten
            //using (Form1 UI = new Form1())
            //{

            //    UI.Text = "TEST";
            //    UI.Labelsteps = "Text";

            //}
        }


    }
}
