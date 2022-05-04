namespace FilmBook
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ZnajdzFilm = new System.Windows.Forms.Button();
            this.ZnajdzKsiazke = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.DodajFilm = new System.Windows.Forms.Button();
            this.DodajKsiazke = new System.Windows.Forms.Button();
            this.ProfilUzytkownika = new System.Windows.Forms.Button();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.dodajKsiazkeDoProfilu1 = new FilmBook.DodajKsiazkeDoProfilu();
            this.zalogowano1 = new FilmBook.Zalogowano();
            this.dodawanieFilmu1 = new FilmBook.DodawanieFilmu();
            this.dodawanieKsiazki1 = new FilmBook.DodawanieKsiazki();
            this.panelLogowania2 = new FilmBook.PanelLogowania();
            this.panelLogowania1 = new FilmBook.PanelLogowania();
            this.starcik1 = new FilmBook.Starcik();
            this.dodajFilmDoProfilu1 = new FilmBook.DodajFilmDoProfilu();
            this.profilUzytkownika1 = new FilmBook.ProfilUzytkownika();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ZnajdzFilm);
            this.panel1.Controls.Add(this.ZnajdzKsiazke);
            this.panel1.Controls.Add(this.Wyjscie);
            this.panel1.Controls.Add(this.DodajFilm);
            this.panel1.Controls.Add(this.DodajKsiazke);
            this.panel1.Controls.Add(this.ProfilUzytkownika);
            this.panel1.Controls.Add(this.Zaloguj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // ZnajdzFilm
            // 
            this.ZnajdzFilm.Location = new System.Drawing.Point(57, 350);
            this.ZnajdzFilm.Name = "ZnajdzFilm";
            this.ZnajdzFilm.Size = new System.Drawing.Size(100, 40);
            this.ZnajdzFilm.TabIndex = 6;
            this.ZnajdzFilm.Text = "Znajdź Film";
            this.ZnajdzFilm.UseVisualStyleBackColor = true;
            this.ZnajdzFilm.Click += new System.EventHandler(this.ZnajdzFilm_Click);
            // 
            // ZnajdzKsiazke
            // 
            this.ZnajdzKsiazke.Location = new System.Drawing.Point(57, 207);
            this.ZnajdzKsiazke.Name = "ZnajdzKsiazke";
            this.ZnajdzKsiazke.Size = new System.Drawing.Size(100, 40);
            this.ZnajdzKsiazke.TabIndex = 5;
            this.ZnajdzKsiazke.Text = "Znajdź Książkę";
            this.ZnajdzKsiazke.UseVisualStyleBackColor = true;
            this.ZnajdzKsiazke.Click += new System.EventHandler(this.ZnajdzKsiazke_Click);
            // 
            // Wyjscie
            // 
            this.Wyjscie.Location = new System.Drawing.Point(57, 500);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(100, 40);
            this.Wyjscie.TabIndex = 4;
            this.Wyjscie.Text = "Wyjście";
            this.Wyjscie.UseVisualStyleBackColor = true;
            this.Wyjscie.Click += new System.EventHandler(this.button5_Click);
            // 
            // DodajFilm
            // 
            this.DodajFilm.Location = new System.Drawing.Point(57, 431);
            this.DodajFilm.Name = "DodajFilm";
            this.DodajFilm.Size = new System.Drawing.Size(100, 40);
            this.DodajFilm.TabIndex = 3;
            this.DodajFilm.Text = "Dodaj Film";
            this.DodajFilm.UseVisualStyleBackColor = true;
            this.DodajFilm.Click += new System.EventHandler(this.button4_Click);
            // 
            // DodajKsiazke
            // 
            this.DodajKsiazke.Location = new System.Drawing.Point(57, 277);
            this.DodajKsiazke.Name = "DodajKsiazke";
            this.DodajKsiazke.Size = new System.Drawing.Size(100, 40);
            this.DodajKsiazke.TabIndex = 2;
            this.DodajKsiazke.Text = "Dodaj Książkę";
            this.DodajKsiazke.UseVisualStyleBackColor = true;
            this.DodajKsiazke.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProfilUzytkownika
            // 
            this.ProfilUzytkownika.Location = new System.Drawing.Point(57, 124);
            this.ProfilUzytkownika.Name = "ProfilUzytkownika";
            this.ProfilUzytkownika.Size = new System.Drawing.Size(100, 40);
            this.ProfilUzytkownika.TabIndex = 1;
            this.ProfilUzytkownika.Text = "Profil Użytkownika";
            this.ProfilUzytkownika.UseVisualStyleBackColor = true;
            this.ProfilUzytkownika.Click += new System.EventHandler(this.button2_Click);
            // 
            // Zaloguj
            // 
            this.Zaloguj.Location = new System.Drawing.Point(57, 40);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(100, 40);
            this.Zaloguj.TabIndex = 0;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajKsiazkeDoProfilu1
            // 
            this.dodajKsiazkeDoProfilu1.Location = new System.Drawing.Point(279, 40);
            this.dodajKsiazkeDoProfilu1.Name = "dodajKsiazkeDoProfilu1";
            this.dodajKsiazkeDoProfilu1.Size = new System.Drawing.Size(600, 500);
            this.dodajKsiazkeDoProfilu1.TabIndex = 7;
            // 
            // zalogowano1
            // 
            this.zalogowano1.Location = new System.Drawing.Point(293, 40);
            this.zalogowano1.Name = "zalogowano1";
            this.zalogowano1.Size = new System.Drawing.Size(600, 500);
            this.zalogowano1.TabIndex = 6;
            // 
            // dodawanieFilmu1
            // 
            this.dodawanieFilmu1.Location = new System.Drawing.Point(293, 40);
            this.dodawanieFilmu1.Name = "dodawanieFilmu1";
            this.dodawanieFilmu1.Size = new System.Drawing.Size(600, 500);
            this.dodawanieFilmu1.TabIndex = 5;
            // 
            // dodawanieKsiazki1
            // 
            this.dodawanieKsiazki1.Location = new System.Drawing.Point(293, 40);
            this.dodawanieKsiazki1.Name = "dodawanieKsiazki1";
            this.dodawanieKsiazki1.Size = new System.Drawing.Size(600, 500);
            this.dodawanieKsiazki1.TabIndex = 4;
            // 
            // panelLogowania2
            // 
            this.panelLogowania2.Location = new System.Drawing.Point(941, 413);
            this.panelLogowania2.Name = "panelLogowania2";
            this.panelLogowania2.Size = new System.Drawing.Size(24, 18);
            this.panelLogowania2.TabIndex = 3;
            // 
            // panelLogowania1
            // 
            this.panelLogowania1.Location = new System.Drawing.Point(293, 40);
            this.panelLogowania1.Name = "panelLogowania1";
            this.panelLogowania1.Size = new System.Drawing.Size(600, 500);
            this.panelLogowania1.TabIndex = 2;
            // 
            // starcik1
            // 
            this.starcik1.Location = new System.Drawing.Point(293, 40);
            this.starcik1.Name = "starcik1";
            this.starcik1.Size = new System.Drawing.Size(600, 500);
            this.starcik1.TabIndex = 1;
            // 
            // dodajFilmDoProfilu1
            // 
            this.dodajFilmDoProfilu1.Location = new System.Drawing.Point(293, 40);
            this.dodajFilmDoProfilu1.Name = "dodajFilmDoProfilu1";
            this.dodajFilmDoProfilu1.Size = new System.Drawing.Size(600, 500);
            this.dodajFilmDoProfilu1.TabIndex = 8;
            // 
            // profilUzytkownika1
            // 
            this.profilUzytkownika1.Location = new System.Drawing.Point(293, 40);
            this.profilUzytkownika1.Name = "profilUzytkownika1";
            this.profilUzytkownika1.Size = new System.Drawing.Size(600, 500);
            this.profilUzytkownika1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 600);
            this.Controls.Add(this.profilUzytkownika1);
            this.Controls.Add(this.dodajFilmDoProfilu1);
            this.Controls.Add(this.dodajKsiazkeDoProfilu1);
            this.Controls.Add(this.zalogowano1);
            this.Controls.Add(this.dodawanieFilmu1);
            this.Controls.Add(this.dodawanieKsiazki1);
            this.Controls.Add(this.panelLogowania2);
            this.Controls.Add(this.panelLogowania1);
            this.Controls.Add(this.starcik1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Aplikacja FilmBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Wyjscie;
        private System.Windows.Forms.Button DodajFilm;
        private System.Windows.Forms.Button DodajKsiazke;
        private System.Windows.Forms.Button ProfilUzytkownika;
        private System.Windows.Forms.Button Zaloguj;
        private Starcik starcik1;
        private PanelLogowania panelLogowania1;
        private PanelLogowania panelLogowania2;
        private DodawanieKsiazki dodawanieKsiazki1;
        private System.Windows.Forms.Button ZnajdzFilm;
        private System.Windows.Forms.Button ZnajdzKsiazke;
        private DodawanieFilmu dodawanieFilmu1;
        private Zalogowano zalogowano1;
        private DodajKsiazkeDoProfilu dodajKsiazkeDoProfilu1;
        private DodajFilmDoProfilu dodajFilmDoProfilu1;
        private ProfilUzytkownika profilUzytkownika1;
    }
}

