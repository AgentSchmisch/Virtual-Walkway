﻿namespace Bitmap_Test1_Schmid
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.steps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bestätigen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.längelabel = new System.Windows.Forms.Label();
            this.längebox = new System.Windows.Forms.TrackBar();
            this.fläche = new System.Windows.Forms.Button();
            this.reglertext = new System.Windows.Forms.Label();
            this.regler = new System.Windows.Forms.TrackBar();
            this.länge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kinectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSitzungBeenden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLezteTherapie = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.längebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // steps
            // 
            this.steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.steps.Location = new System.Drawing.Point(154, 120);
            this.steps.MaxLength = 2;
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(71, 38);
            this.steps.TabIndex = 1;
            this.steps.Text = "10";
            this.steps.TextChanged += new System.EventHandler(this.steps_TextChanged);
            this.steps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.steps_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schritte:";
            // 
            // bestätigen
            // 
            this.bestätigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bestätigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.bestätigen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bestätigen.Location = new System.Drawing.Point(51, 179);
            this.bestätigen.Name = "bestätigen";
            this.bestätigen.Size = new System.Drawing.Size(160, 56);
            this.bestätigen.TabIndex = 3;
            this.bestätigen.Text = "bestätigen";
            this.bestätigen.UseVisualStyleBackColor = true;
            this.bestätigen.Click += new System.EventHandler(this.bestätigen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(343, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Länge des Objektes:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // längelabel
            // 
            this.längelabel.Location = new System.Drawing.Point(26, 39);
            this.längelabel.Name = "längelabel";
            this.längelabel.Size = new System.Drawing.Size(100, 23);
            this.längelabel.TabIndex = 21;
            // 
            // längebox
            // 
            this.längebox.BackColor = System.Drawing.Color.DimGray;
            this.längebox.Enabled = false;
            this.längebox.LargeChange = 2;
            this.längebox.Location = new System.Drawing.Point(305, 190);
            this.längebox.Minimum = 1;
            this.längebox.Name = "längebox";
            this.längebox.Size = new System.Drawing.Size(273, 45);
            this.längebox.TabIndex = 18;
            this.längebox.Value = 1;
            this.längebox.ValueChanged += new System.EventHandler(this.längebox_ValueChanged);
            this.längebox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.längebox_KeyDown);
            // 
            // fläche
            // 
            this.fläche.BackColor = System.Drawing.Color.DimGray;
            this.fläche.Enabled = false;
            this.fläche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fläche.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fläche.ForeColor = System.Drawing.Color.White;
            this.fläche.Location = new System.Drawing.Point(365, 271);
            this.fläche.Name = "fläche";
            this.fläche.Size = new System.Drawing.Size(156, 70);
            this.fläche.TabIndex = 17;
            this.fläche.Text = "bestätigen";
            this.fläche.UseVisualStyleBackColor = false;
            this.fläche.Click += new System.EventHandler(this.fläche_Click);
            // 
            // reglertext
            // 
            this.reglertext.AutoSize = true;
            this.reglertext.BackColor = System.Drawing.Color.DimGray;
            this.reglertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reglertext.ForeColor = System.Drawing.Color.Gray;
            this.reglertext.Location = new System.Drawing.Point(427, 87);
            this.reglertext.Name = "reglertext";
            this.reglertext.Size = new System.Drawing.Size(24, 26);
            this.reglertext.TabIndex = 16;
            this.reglertext.Text = "0";
            // 
            // regler
            // 
            this.regler.BackColor = System.Drawing.Color.DimGray;
            this.regler.Enabled = false;
            this.regler.LargeChange = 2;
            this.regler.Location = new System.Drawing.Point(305, 39);
            this.regler.Name = "regler";
            this.regler.Size = new System.Drawing.Size(273, 45);
            this.regler.TabIndex = 15;
            this.regler.ValueChanged += new System.EventHandler(this.regler_ValueChanged);
            this.regler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.regler_KeyDown);
            // 
            // länge
            // 
            this.länge.AutoSize = true;
            this.länge.BackColor = System.Drawing.Color.DimGray;
            this.länge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.länge.ForeColor = System.Drawing.Color.Gray;
            this.länge.Location = new System.Drawing.Point(427, 228);
            this.länge.Name = "länge";
            this.länge.Size = new System.Drawing.Size(24, 26);
            this.länge.TabIndex = 22;
            this.länge.Text = "1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(584, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(584, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.kinectToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.patientToolStripMenuItem.Text = "Patient auswählen";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // kinectToolStripMenuItem
            // 
            this.kinectToolStripMenuItem.Name = "kinectToolStripMenuItem";
            this.kinectToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kinectToolStripMenuItem.Text = "Kinect";
            this.kinectToolStripMenuItem.Click += new System.EventHandler(this.kinectToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // BtnSitzungBeenden
            // 
            this.BtnSitzungBeenden.BackColor = System.Drawing.Color.DimGray;
            this.BtnSitzungBeenden.Enabled = false;
            this.BtnSitzungBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSitzungBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnSitzungBeenden.ForeColor = System.Drawing.Color.White;
            this.BtnSitzungBeenden.Location = new System.Drawing.Point(757, 271);
            this.BtnSitzungBeenden.Name = "BtnSitzungBeenden";
            this.BtnSitzungBeenden.Size = new System.Drawing.Size(233, 42);
            this.BtnSitzungBeenden.TabIndex = 28;
            this.BtnSitzungBeenden.Text = "Sitzung beenden";
            this.BtnSitzungBeenden.UseVisualStyleBackColor = false;
            this.BtnSitzungBeenden.Click += new System.EventHandler(this.BtnSitzungBeenden_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(659, 48);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(659, 127);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(180, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Schrittanzahl:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSteps.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSteps.Location = new System.Drawing.Point(875, 127);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSteps.Size = new System.Drawing.Size(44, 31);
            this.lblSteps.TabIndex = 32;
            this.lblSteps.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(659, 87);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(202, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "letzte Therapie:";
            // 
            // lblLezteTherapie
            // 
            this.lblLezteTherapie.AutoSize = true;
            this.lblLezteTherapie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLezteTherapie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLezteTherapie.Location = new System.Drawing.Point(875, 87);
            this.lblLezteTherapie.Name = "lblLezteTherapie";
            this.lblLezteTherapie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLezteTherapie.Size = new System.Drawing.Size(0, 31);
            this.lblLezteTherapie.TabIndex = 34;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(875, 48);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(221, 31);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Max Mustermann";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 370);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLezteTherapie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSitzungBeenden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.länge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.längelabel);
            this.Controls.Add(this.längebox);
            this.Controls.Add(this.fläche);
            this.Controls.Add(this.reglertext);
            this.Controls.Add(this.regler);
            this.Controls.Add(this.bestätigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitale Koordinationsleiter";
            ((System.ComponentModel.ISupportInitialize)(this.längebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bestätigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label längelabel;
        private System.Windows.Forms.Button fläche;
        public System.Windows.Forms.TrackBar längebox;
        public System.Windows.Forms.TextBox steps;
        public System.Windows.Forms.TrackBar regler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label reglertext;
        public System.Windows.Forms.Label länge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.Button BtnSitzungBeenden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLezteTherapie;
        public System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem kinectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

