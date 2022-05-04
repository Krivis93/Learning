using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace FilmBook
{
    class Data_Manager
    {
        private ArrayList lista;
        private SQL_Helper baza = new SQL_Helper();
        public string Logowanie(string login, string haslo, ref bool stanLogowania)
        {

            return baza.Logowanie(login, haslo, ref stanLogowania);
        }

        public void WyswietlProfilUzytkownikaKsiazka(string uzytkownik,ref DataTable tab)
        {
            baza.WyswietlProfilKsiazka(uzytkownik,ref tab);
        }

        public void WyswietlProfilUzytkownikaFilm(string uzytkownik, ref DataTable tab)
        {
            baza.WyswietlProfilFilm(uzytkownik, ref tab);
        }

        public void DodajKsiazke(string tytul, string rok, string opis, string recenzja)
        {
            lista = new ArrayList(); // kolecja która zbiera dane o nowym tytule
            lista.Add(tytul);
            lista.Add(rok);
            lista.Add(opis);
            lista.Add(recenzja);
            baza.DodajKsiazke(lista); // wywolanie funkcji z klasy SQL_Helper która dodaje tytul do bazy danych

        }

        public void DodajFilm(string tytul, string rok, string opis, string recenzja)
        {
            lista = new ArrayList();// kolecja która zbiera dane o nowym tytule
            lista.Add(tytul);
            lista.Add(rok);
            lista.Add(opis);
            lista.Add(recenzja);
            baza.DodajFilm(lista);// wywolanie funkcji z klasy SQL_Helper która dodaje tytul do bazy danych
        }

        public void TytulyKsiazek(ref ArrayList z)
        {
            DataTable ksiazki = new DataTable();
            baza.WyswietlKasiazke(ref ksiazki);
            for (int i = 0;i < ksiazki.Rows.Count;i++)
            {
                DataRow book = ksiazki.Rows[i];
                z.Add(book[0].ToString());
            }
        }

        public void TytulyFilmow(ref ArrayList x)
        {
            DataTable filmy = new DataTable();
            baza.WyswietlFilm(ref filmy);
            for (int i = 0; i < filmy.Rows.Count; i++)
            {
                DataRow book = filmy.Rows[i];
                x.Add(book[0].ToString());
            }
        }

        public void PrzypiszKsiazke(string tytul,string uzytkownik, int score)
        {
            baza.PrzypiszKsiazke(tytul,uzytkownik,score);
        }

        public void PrzypiszFilm(string tytul, string uzytkownik,int score)
        {
            baza.PrzypiszFilm(tytul, uzytkownik, score);
        }
    }
}
