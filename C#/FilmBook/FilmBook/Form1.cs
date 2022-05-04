using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmBook
{
    public partial class Form1 : Form
    {
        private bool StanLogowania; // zmienna określająca stan logowania true - zalogowano, false - nie zalogowano
        // do zrobienia : logowanie stan uzytkownika
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            starcik1.Show(); // polozenie 293 ; 40 
            panelLogowania1.Hide();
            profilUzytkownika1.Hide();
            dodawanieKsiazki1.Hide();
            dodawanieFilmu1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();
            zalogowano1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            starcik1.Hide();
            profilUzytkownika1.Hide();
            dodawanieKsiazki1.Hide();
            dodawanieFilmu1.Hide();
            zalogowano1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();// funkcja Hide() ukrywa dany user control w momencie przycisnięcia przycisku
            panelLogowania1.Show();// funkcja Show() pokazuje dany usercontrol w momencie przyciśnięcia przycisku
            panelLogowania1.UstawLogowaniePuste();
            if (!zalogowano1.stanLogowania) { this.StanLogowania = zalogowano1.stanLogowania; }
            else { this.StanLogowania = panelLogowania1.Stan; }

            zalogowano1.zalogowany = panelLogowania1.uzytkownik;
            dodajKsiazkeDoProfilu1.uzytkownik = panelLogowania1.uzytkownik;
            dodajFilmDoProfilu1.uzytkownik = panelLogowania1.uzytkownik;
            profilUzytkownika1.uzytkownik = panelLogowania1.uzytkownik;

            if (this.StanLogowania) {panelLogowania1.Hide(); zalogowano1.okreslLogin(panelLogowania1.uzytkownik); zalogowano1.Show(); } // Jeżeli zalogowano pokaż usercontrol zalogowano
            else {zalogowano1.Hide(); panelLogowania1.Show(); } // Jeżeli nie zalogowano pokaż usercontrol panelLogowania


            //Zaloguj

        }

        private void button2_Click(object sender, EventArgs e)            //Profil Użytkownika
        {
            starcik1.Hide();
            dodawanieKsiazki1.Hide();
            dodawanieFilmu1.Hide();
            panelLogowania1.Hide();
            zalogowano1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();
            profilUzytkownika1.Show();



        }

        private void button3_Click(object sender, EventArgs e)            //Dodaj Książke
        {
            starcik1.Hide();
            profilUzytkownika1.Hide();
            dodawanieFilmu1.Hide();
            panelLogowania1.Hide();
            zalogowano1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();
            dodawanieKsiazki1.Show();



        }

        private void button4_Click(object sender, EventArgs e)            //Dodaj Film
        {
            starcik1.Hide();
            dodawanieKsiazki1.Hide();
            profilUzytkownika1.Hide();
            panelLogowania1.Hide();
            zalogowano1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();
            dodawanieFilmu1.Show();



        }

        private void button5_Click(object sender, EventArgs e)            //Wyjście
        {

            Application.Exit();
        }

        private void ZnajdzKsiazke_Click(object sender, EventArgs e)            //Znajdź Książkę
        {
            starcik1.Hide();
            dodawanieKsiazki1.Hide();
            profilUzytkownika1.Hide();
            panelLogowania1.Hide();
            zalogowano1.Hide();
            dodawanieFilmu1.Hide();
            dodajFilmDoProfilu1.Hide();
            dodajKsiazkeDoProfilu1.Show();


        }

        private void ZnajdzFilm_Click(object sender, EventArgs e)            //Znajdź Film
        {
            starcik1.Hide();
            dodawanieKsiazki1.Hide();
            profilUzytkownika1.Hide();
            panelLogowania1.Hide();
            zalogowano1.Hide();
            dodawanieFilmu1.Hide();
            dodajKsiazkeDoProfilu1.Hide();
            dodajFilmDoProfilu1.Show();



        }
    }
}
