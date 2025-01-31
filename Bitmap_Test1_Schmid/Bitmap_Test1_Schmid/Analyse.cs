﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bitmap_Test1_Schmid
{
    public partial class Analyse : Form
    {
        public Analyse()
        {
            InitializeComponent();
        }
        int x = 0;
        int time = 0;
        int opacity = 0;
        public double schrittdurchschnitt = 0;
        public double kleinsterabstand = 500;
        public double größterabstand = 0;
        public double schritte = 0;
        public double länge = 300;



        Patientendatenbank patientendatenbank = new Patientendatenbank();

        private Form1 _form1_anal;
        public Form1 form1_anal
        {
            set { this._form1_anal = value; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
            if (time >= 30)
            {
                x += 15;
                if (x <= 250)
                {
                    Size = new Size(this.Size.Width, 136 + x);
                    this.CenterToScreen();
                }
                if (x > 300)
                {
                    if (opacity <= 190)
                    {
                        Color myColor = Color.FromArgb(40 + opacity, 50 + opacity, 60 + opacity);
                        lab_steps.ForeColor = myColor;
                        steps.ForeColor = myColor;
                    }
                    if (opacity >= 20 && opacity <= 210)
                    {
                        Color myColor = Color.FromArgb(20 + opacity, 30 + opacity, 40 + opacity);
                        lab_durchs.ForeColor = myColor;
                        durchs.ForeColor = myColor;
                    }
                    if (opacity >= 40 && opacity <= 230)
                    {
                        Color myColor = Color.FromArgb(opacity, 10 + opacity, 20 + opacity);
                        lab_klein.ForeColor = myColor;
                        klein.ForeColor = myColor;
                    }
                    if (opacity >= 60 && opacity <= 250)
                    {
                        Color myColor = Color.FromArgb(opacity - 20, opacity - 10, opacity);
                        lab_groß.ForeColor = myColor;
                        groß.ForeColor = myColor;
                    }

                    opacity += 10;
                    if (opacity >= 260)
                    {
                        timer.Stop(); return;
                    }
                }
            }
        }

        private void Analyse_Load(object sender, EventArgs e)
        {
            time = 0;
            opacity = 0;
            x = 0;

            hintergrund.Visible = false;
            Color myColor = Color.FromArgb(40, 50, 60);

            //das Chart weiß färben
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX2.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY2.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            //zuerst die form vergrößern um das chart zu zeigen
            //dann die werte aus der Patientendatenbank holen und im chart darstellen
            chart1.Titles["Title1"].Text =_form1_anal.Patientendatenbank.vorname + " " + _form1_anal.Patientendatenbank.nachname; //titel des diagramms setzen
            chart1.Series["Soll"].Points.Clear();//alle alten informationen löschen
            chart1.Series["Ist"].Points.Clear();

            int xcoord = 1;
            foreach (int element in _form1_anal.Patientendatenbank.sollMittelwerte) //die Durchschnittlichen Werte darstellen
            {
                
                chart1.Series["Soll"].Points.AddXY(xcoord, element);

                xcoord++;
            }

           
            for (int i = 0; i < _form1_anal.Patientendatenbank.istMaximalwerte.Length; i++)
            {
                if (i == 0)
                    xcoord = 1;

                
                chart1.Series["Ist"].Points.AddXY(xcoord, 0, _form1_anal.Patientendatenbank.istMinimalwerte[i], _form1_anal.Patientendatenbank.istMaximalwerte[i]);
                xcoord++;
            }



            lab_durchs.ForeColor = myColor;
            lab_klein.ForeColor = myColor;
            lab_groß.ForeColor = myColor;
            lab_steps.ForeColor = myColor;
            durchs.ForeColor = myColor;
            klein.ForeColor = myColor;
            groß.ForeColor = myColor;
            steps.ForeColor = myColor;

            länge = Properties.Settings.Default.länge;

            steps.Text = schritte.ToString() + " (" + Math.Round((_form1_anal.screen.Auflösung_Projektor_x / (schritte - 1)) / _form1_anal.screen.Auflösung_Projektor_x * länge).ToString() + " cm)";

            schrittdurchschnitt = Math.Round(((schrittdurchschnitt / _form1_anal.screen.Auflösung_Projektor_x) * länge));
            kleinsterabstand = Math.Round(((kleinsterabstand / _form1_anal.screen.Auflösung_Projektor_x) * länge));
            größterabstand = Math.Round(((größterabstand / _form1_anal.screen.Auflösung_Projektor_x) * länge));

            durchs.Text = schrittdurchschnitt + " cm";
            klein.Text = kleinsterabstand + " cm";
            groß.Text = größterabstand + " cm";

            Size = new Size(this.Size.Width, 136);
            this.CenterToScreen();
            timer.Start();
        }

        private void Analyse_HelpButtonClicked(object sender, CancelEventArgs e)
        {

            lab_durchs.Visible = false;
            lab_klein.Visible = false;
            lab_groß.Visible = false;
            lab_steps.Visible = false;
            durchs.Visible = false;
            klein.Visible = false;
            groß.Visible = false;
            steps.Visible = false;

            Size = new Size(470, this.Size.Height);
            hintergrund.Location = new Point(2, 2);
            label2.Location = new Point(33, 112);
            text_länge.Location = new Point(307, 112);
            button1.Location = new Point(150, 170);
            label2.Visible = true;
            button1.Visible = true;
            text_länge.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab_durchs.Visible = true;
            lab_klein.Visible = true;
            lab_groß.Visible = true;
            lab_steps.Visible = true;
            durchs.Visible = true;
            klein.Visible = true;
            groß.Visible = true;
            steps.Visible = true;

            label2.Visible = false;
            button1.Visible = false;
            text_länge.Visible = false;
            hintergrund.Visible = false;

            länge = Convert.ToDouble(text_länge.Text);
            Properties.Settings.Default.länge = länge;
            Properties.Settings.Default.Save();

            schrittdurchschnitt = Math.Round(((schrittdurchschnitt / _form1_anal.screen.Auflösung_Projektor_x) * länge));
            kleinsterabstand = Math.Round(((kleinsterabstand / _form1_anal.screen.Auflösung_Projektor_x) * länge));
            größterabstand = Math.Round(((größterabstand / _form1_anal.screen.Auflösung_Projektor_x) * länge));

            durchs.Text = schrittdurchschnitt + " cm";
            klein.Text = kleinsterabstand + " cm";
            groß.Text = größterabstand  + " cm";
            Size = new Size(892, this.Size.Height);
        }

        private void RB_sollwerte_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
