using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace FilmBook
{
    class SQL_Helper
    {
        //private static string con = "Data Source=DESKTOP-\\SQLEXPRESS;Initial Catalog=Entertainment;Integrated Security=True"; // adres serwera SQL wraz z danymi do połączenia
        private static string con = "Data Source=DESKTOP-\\SQLEXPRESS;Initial Catalog=Entertainment;Persist Security Info=True;User ID=User;Password=Password";
        SqlConnection polacz = new SqlConnection(con);
        public string connection_message;
        public SQL_Helper()
        {
            polacz.Open();
        }
        

        public string start_bazy()
        {
            
            if (polacz.State == System.Data.ConnectionState.Open)
            {
                connection_message = "Połączenie z bazą danych Udane.";

            }
            else
            {
                connection_message = "Wystąpił błąd przy połączeniu z bazą danych. Skontaktuj się z administratorem.";
            }
            return connection_message;

        }

        private void Zaloguj_prawda(ref bool x)
        {
            x = true;
        }
        private void Zaloguj_falsz(ref bool x)
        {
            x = false;
        }
        public string Logowanie(string login, string haslo, ref bool stan)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            string komunikat;
            bool a = false;
            bool b = false;
            string komenda = "SELECT username FROM uzytkownik"/*WHERE username = '"+login+"'"*/;
            SqlCommand loguj = new SqlCommand(komenda, polacz);
            SqlDataReader read = loguj.ExecuteReader();
            dt.Load(read);
            for (int i = 0; i < dt.Rows.Count;i++)
            {
                DataRow y = dt.Rows[i];
                if (y[0].ToString() == login) { this.Zaloguj_prawda(ref a); break; }
                else { this.Zaloguj_falsz(ref a); }
            }
            /*DataRow l1 = dt.Rows[0];
            DataRow l2 = dt.Rows[1];
            DataRow l3 = dt.Rows[2];
            DataRow l4 = dt.Rows[3];
            //if (l1[0].ToString() == login || l2[0].ToString() == login || l3[0].ToString() == login || l4[0].ToString() == login) a = true;// testuje czy poprawny login
            //else a = false;*/
            

            read.Close();

            string komenda2 = "SELECT passwordd FROM uzytkownik"/* WHERE passwordd = '" + haslo + "'"*/;
            SqlCommand loguj2 = new SqlCommand(komenda2, polacz);
            SqlDataReader read2 = loguj2.ExecuteReader();
            dt2.Load(read2);
            for (int i = 0; i<dt2.Rows.Count;i++) 
            {
                DataRow x = dt2.Rows[i];
                if (x[0].ToString() == haslo) { this.Zaloguj_prawda(ref b); break; }
                else { this.Zaloguj_falsz(ref b); }
            }
            /*DataRow h1 = dt2.Rows[0];
            DataRow h2 = dt2.Rows[1];
            DataRow h3 = dt2.Rows[2];
            DataRow h4 = dt2.Rows[3];
            if (h1[0].ToString() == haslo || h2[0].ToString() == haslo || h3[0].ToString() == haslo || h4[0].ToString() == haslo) b = true; // testuje czy poprawne haslo
            else b = false;*/

            read2.Close();
            if (!a)
            {
                komunikat = "Błędny Login"; // komunikat w przypadku blednego loginu
                stan = false;
                return komunikat;
            }
            else if (!b)
            {
                komunikat = "Błędne Hasło"; // komunikat w przypadku blednego hasla
                stan = false;
                return komunikat;
            }
            else
            {
                komunikat = "Logowanie Udane ! Witaj " + login +" !"; // komunikat w przypadku użycia poprawnych danych logowania
                stan = true;
                return komunikat;
            }
            
        }

        public void DodajKsiazke(ArrayList x)
        {
            string pobierzid = "SELECT MAX(book_id) FROM book";
            SqlCommand pobierz = new SqlCommand(pobierzid, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable numer = new DataTable();
            numer.Load(czytaj);
            DataRow id1 = numer.Rows[0];
            int id = Int16.Parse(id1[0].ToString()) + 1; // Wczytuje ID z bazy danych  z tabeli book i nadaje kolejne wolne

            string rok = x[1].ToString(); // Zmiana ze zmiennej typu ArrayList na string aby konwertować do inta w komendzie

            string komenda = "INSERT INTO book(book_id,title,year,review, description) VALUES(" + id + ",'"+ x[0] +"'," + Int16.Parse(rok) + ",'" + x[2] + "','" + x[3] + "');";
            SqlCommand dodaj = new SqlCommand(komenda,polacz);
            dodaj.ExecuteNonQuery();

        }

        public void DodajFilm(ArrayList x)
        {
            string pobierzid = "SELECT MAX(movie_id) FROM movies";
            SqlCommand pobierz = new SqlCommand(pobierzid, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable numer = new DataTable();
            numer.Load(czytaj);
            DataRow id1 = numer.Rows[0];

            int id = Int16.Parse(id1[0].ToString()) + 1; // Wczytuje ID z bazy danych  z tabeli movies i nadaje kolejne wolne

            string rok = x[1].ToString(); // Zmiana ze zmiennej typu ArrayList na string aby konwertować do inta w komendzie

            string komenda = "INSERT INTO movies(movie_id,title,year,review, description) VALUES(" + id + ",'" + x[0] + "'," + Int16.Parse(rok) + ",'" + x[2] + "','" + x[3] + "');";
            SqlCommand dodaj = new SqlCommand(komenda, polacz);
            dodaj.ExecuteNonQuery();

        }

        public void WyswietlKasiazke(ref DataTable tabela)
        {
            string comand = "SELECT title FROM book";
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            tabela = tytuly;
        }

        public void WyswietlFilm(ref DataTable tabela)
        {
            string comand = "SELECT title FROM movies";
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            tabela = tytuly;
        }

        public void PrzypiszKsiazke(string t, string user, int score)
        {
            string upmid = "SELECT MAX(user_profile_books_id) FROM user_profile_books";// wczytanie id ostatniego dodanego rekordu
            SqlCommand pobierzupmid = new SqlCommand(upmid, polacz);
            SqlDataReader czytajupmid = pobierzupmid.ExecuteReader();
            DataTable numerupmid = new DataTable();
            numerupmid.Load(czytajupmid);
            DataRow upmid1 = numerupmid.Rows[0];

            string comand = "SELECT book_id FROM book WHERE title =  '" + t + "'"; // pobranie id książki
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            DataRow id = tytuly.Rows[0];

            /*string pobierzid = "SELECT user_id FROM uzytkownik WHERE username = '" + user + "';"; // pobranie id uzytkownika
            SqlCommand getid = new SqlCommand(pobierzid, polacz);
            SqlDataReader read = pobierz.ExecuteReader();
            DataTable numer = new DataTable();
            numer.Load(read);
            DataRow id1 = numer.Rows[0];*/

            int uzytkownik = 0;
            if (user == "User1") { uzytkownik = 1; }
            else if (user == "User2") { uzytkownik = 2; }
            else if (user == "User3") { uzytkownik = 3; }
            else if (user == "User4") { uzytkownik = 4; }

            string comand2 = "INSERT INTO user_profile_books(user_profile_books_id,user_id,book_id,book_score) VALUES(" + (Int16.Parse(upmid1[0].ToString())+ 1) + "," + /*Int16.Parse(id1[0].ToString())*/ uzytkownik +"," +Int16.Parse(id[0].ToString()) + ", " + score + ")";
            SqlCommand pobierz2 = new SqlCommand(comand2, polacz);
            pobierz2.ExecuteNonQuery();
        }

        public void PrzypiszFilm(string t, string user, int score)
        {
            string upmid = "SELECT MAX(user_profile_movies_id) FROM user_profile_movies";// wczytanie id ostatniego dodanego rekordu
            SqlCommand pobierzupmid = new SqlCommand(upmid, polacz);
            SqlDataReader czytajupmid = pobierzupmid.ExecuteReader();
            DataTable numerupmid = new DataTable();
            numerupmid.Load(czytajupmid);
            DataRow upmid1 = numerupmid.Rows[0];

            string comand = "SELECT movie_id FROM movies WHERE title =  '" + t + "'"; // pobranie id książki
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            DataRow id = tytuly.Rows[0];

            /*string pobierzid = "SELECT user_id FROM uzytkownik WHERE username = '" + user + "';"; // pobranie id uzytkownika
            SqlCommand getid = new SqlCommand(pobierzid, polacz);
            SqlDataReader read = pobierz.ExecuteReader();
            DataTable numer = new DataTable();
            numer.Load(read);
            DataRow id1 = numer.Rows[0];*/

            int uzytkownik = 0;
            if (user == "User1") { uzytkownik = 1; }
            else if (user == "User2") { uzytkownik = 2; }
            else if (user == "User3") { uzytkownik = 3; }
            else if (user == "User4") { uzytkownik = 4; }

            string comand2 = "INSERT INTO user_profile_movies(user_profile_movies_id,user_id,movie_id,movie_score) VALUES(" + (Int16.Parse(upmid1[0].ToString()) + 1) + "," + /*Int16.Parse(id1[0].ToString())*/ uzytkownik + "," + Int16.Parse(id[0].ToString()) + ", " + score + ")";
            SqlCommand pobierz2 = new SqlCommand(comand2, polacz);
            pobierz2.ExecuteNonQuery();
        }

        public void WyswietlProfilKsiazka(string uzytkownik,ref DataTable tabela)
        {
            string komenda = "SELECT user_id FROM uzytkownik WHERE username = '" + uzytkownik + "';";
            SqlCommand getid = new SqlCommand(komenda, polacz);
            SqlDataReader readid = getid.ExecuteReader();
            DataTable idd = new DataTable();
            idd.Load(readid);
            DataRow iid = idd.Rows[0];

            string comand = "SELECT B.title AS Tytuł,P.book_score AS Ocena,B.year AS Rok FROM[Entertainment].[dbo].[user_profile_books] P JOIN[Entertainment].[dbo].[uzytkownik] U ON P.user_id = U.user_id JOIN[Entertainment].[dbo].[book] B ON P.book_id = B.book_id WHERE U.user_id = " + Int16.Parse(iid[0].ToString()) + "; ";
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            tabela = tytuly;
        }

        public void WyswietlProfilFilm(string uzytkownik, ref DataTable tabela)
        {
            string komenda = "SELECT user_id FROM [Entertainment].[dbo].[uzytkownik] WHERE username = '" + uzytkownik + "';";
            SqlCommand getid = new SqlCommand(komenda, polacz);
            SqlDataReader readid = getid.ExecuteReader();
            DataTable idd = new DataTable();
            idd.Load(readid);
            DataRow iid = idd.Rows[0];

            string comand = "SELECT B.title AS Tytuł,P.movie_score AS Ocena,B.year AS Rok FROM[Entertainment].[dbo].[user_profile_movies] P JOIN[Entertainment].[dbo].[uzytkownik] U ON P.user_id = U.user_id JOIN[Entertainment].[dbo].[movies] B ON P.movie_id = B.movie_id WHERE U.user_id = " + Int16.Parse(iid[0].ToString()) + "; ";
            SqlCommand pobierz = new SqlCommand(comand, polacz);
            SqlDataReader czytaj = pobierz.ExecuteReader();
            DataTable tytuly = new DataTable();
            tytuly.Load(czytaj);
            tabela = tytuly;
        }

    }
}
