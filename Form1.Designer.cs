
namespace Templates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRezID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazivPriredbe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGornjaGranica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonjaGranica = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNazivAero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtDatumPocetka = new System.Windows.Forms.TextBox();
            this.txtVrijemeOd = new System.Windows.Forms.TextBox();
            this.txtDatumZavrsetka = new System.Windows.Forms.TextBox();
            this.txtVrijemeDo = new System.Windows.Forms.TextBox();
            this.txtDatumZahtjeva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUasModel = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUasProizvodjac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(96, 82);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 23);
            this.txtIme.TabIndex = 1;
            this.txtIme.Text = "Mirko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(96, 128);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 23);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.Text = "Fodor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Template";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(96, 31);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.ReadOnly = true;
            this.txtTemplatePath.Size = new System.Drawing.Size(389, 23);
            this.txtTemplatePath.TabIndex = 5;
            this.txtTemplatePath.Text = "...";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(491, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(96, 616);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(389, 46);
            this.btnGenerate.TabIndex = 20;
            this.btnGenerate.Text = "Kreiraj dokument na osnovu templatea";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(96, 173);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 23);
            this.txtAdresa.TabIndex = 3;
            this.txtAdresa.Text = "Ulica 123";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(96, 217);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 23);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Text = "+385 (044) 861 118";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "mirko@email.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "RezID";
            // 
            // txtRezID
            // 
            this.txtRezID.Location = new System.Drawing.Point(385, 82);
            this.txtRezID.Name = "txtRezID";
            this.txtRezID.Size = new System.Drawing.Size(100, 23);
            this.txtRezID.TabIndex = 8;
            this.txtRezID.Text = "112233";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Naziv priredbe";
            // 
            // txtNazivPriredbe
            // 
            this.txtNazivPriredbe.Location = new System.Drawing.Point(385, 173);
            this.txtNazivPriredbe.Name = "txtNazivPriredbe";
            this.txtNazivPriredbe.Size = new System.Drawing.Size(100, 23);
            this.txtNazivPriredbe.TabIndex = 10;
            this.txtNazivPriredbe.Text = "Voloderske jeseni";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Gornja granica";
            // 
            // txtGornjaGranica
            // 
            this.txtGornjaGranica.Location = new System.Drawing.Point(385, 260);
            this.txtGornjaGranica.Name = "txtGornjaGranica";
            this.txtGornjaGranica.Size = new System.Drawing.Size(100, 23);
            this.txtGornjaGranica.TabIndex = 12;
            this.txtGornjaGranica.Text = "gore";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Donja granica";
            // 
            // txtDonjaGranica
            // 
            this.txtDonjaGranica.Location = new System.Drawing.Point(385, 300);
            this.txtDonjaGranica.Name = "txtDonjaGranica";
            this.txtDonjaGranica.Size = new System.Drawing.Size(100, 23);
            this.txtDonjaGranica.TabIndex = 13;
            this.txtDonjaGranica.Text = "dolje";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Naziv aero";
            // 
            // txtNazivAero
            // 
            this.txtNazivAero.Location = new System.Drawing.Point(385, 128);
            this.txtNazivAero.Name = "txtNazivAero";
            this.txtNazivAero.Size = new System.Drawing.Size(100, 23);
            this.txtNazivAero.TabIndex = 9;
            this.txtNazivAero.Text = "Letači";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(329, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lokacija";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(385, 217);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(100, 23);
            this.txtLokacija.TabIndex = 11;
            this.txtLokacija.Text = "Voloder";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Polumjer";
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(385, 341);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(100, 23);
            this.txtPolumjer.TabIndex = 14;
            this.txtPolumjer.Text = "500 m";
            // 
            // txtDatumPocetka
            // 
            this.txtDatumPocetka.Location = new System.Drawing.Point(385, 382);
            this.txtDatumPocetka.Name = "txtDatumPocetka";
            this.txtDatumPocetka.Size = new System.Drawing.Size(100, 23);
            this.txtDatumPocetka.TabIndex = 15;
            this.txtDatumPocetka.Text = "danas";
            // 
            // txtVrijemeOd
            // 
            this.txtVrijemeOd.Location = new System.Drawing.Point(385, 423);
            this.txtVrijemeOd.Name = "txtVrijemeOd";
            this.txtVrijemeOd.Size = new System.Drawing.Size(100, 23);
            this.txtVrijemeOd.TabIndex = 16;
            this.txtVrijemeOd.Text = "ujutro";
            // 
            // txtDatumZavrsetka
            // 
            this.txtDatumZavrsetka.Location = new System.Drawing.Point(385, 464);
            this.txtDatumZavrsetka.Name = "txtDatumZavrsetka";
            this.txtDatumZavrsetka.Size = new System.Drawing.Size(100, 23);
            this.txtDatumZavrsetka.TabIndex = 17;
            this.txtDatumZavrsetka.Text = "sutra";
            // 
            // txtVrijemeDo
            // 
            this.txtVrijemeDo.Location = new System.Drawing.Point(385, 507);
            this.txtVrijemeDo.Name = "txtVrijemeDo";
            this.txtVrijemeDo.Size = new System.Drawing.Size(100, 23);
            this.txtVrijemeDo.TabIndex = 18;
            this.txtVrijemeDo.Text = "navečer";
            // 
            // txtDatumZahtjeva
            // 
            this.txtDatumZahtjeva.Location = new System.Drawing.Point(385, 549);
            this.txtDatumZahtjeva.Name = "txtDatumZahtjeva";
            this.txtDatumZahtjeva.Size = new System.Drawing.Size(100, 23);
            this.txtDatumZahtjeva.TabIndex = 19;
            this.txtDatumZahtjeva.Text = "17.9.2021.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Datum početka";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Vrijeme od";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 467);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Datum završetka";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(315, 510);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 36;
            this.label17.Text = "Vrijeme do";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(290, 552);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 15);
            this.label18.TabIndex = 37;
            this.label18.Text = "Datum zahtjeva";
            // 
            // txtUasModel
            // 
            this.txtUasModel.Location = new System.Drawing.Point(141, 382);
            this.txtUasModel.Name = "txtUasModel";
            this.txtUasModel.Size = new System.Drawing.Size(100, 23);
            this.txtUasModel.TabIndex = 7;
            this.txtUasModel.Text = "Mavic Pro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 387);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "UAS model";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 344);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 15);
            this.label20.TabIndex = 39;
            this.label20.Text = "UAS proizvođač";
            // 
            // txtUasProizvodjac
            // 
            this.txtUasProizvodjac.Location = new System.Drawing.Point(141, 341);
            this.txtUasProizvodjac.Name = "txtUasProizvodjac";
            this.txtUasProizvodjac.Size = new System.Drawing.Size(100, 23);
            this.txtUasProizvodjac.TabIndex = 6;
            this.txtUasProizvodjac.Text = "DJY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 674);
            this.Controls.Add(this.txtUasModel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtUasProizvodjac);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDatumZahtjeva);
            this.Controls.Add(this.txtVrijemeDo);
            this.Controls.Add(this.txtDatumZavrsetka);
            this.Controls.Add(this.txtVrijemeOd);
            this.Controls.Add(this.txtDatumPocetka);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNazivAero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDonjaGranica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtGornjaGranica);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNazivPriredbe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRezID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Templates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRezID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazivPriredbe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGornjaGranica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonjaGranica;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNazivAero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtDatumPocetka;
        private System.Windows.Forms.TextBox txtVrijemeOd;
        private System.Windows.Forms.TextBox txtDatumZavrsetka;
        private System.Windows.Forms.TextBox txtVrijemeDo;
        private System.Windows.Forms.TextBox txtDatumZahtjeva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUasModel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtUasProizvodjac;
    }
}

