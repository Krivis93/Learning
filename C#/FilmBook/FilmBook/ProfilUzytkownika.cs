using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmBook
{
    public partial class ProfilUzytkownika : UserControl
    {
        Data_Manager dane = new Data_Manager();
        public string uzytkownik;
        public ProfilUzytkownika()
        {
            InitializeComponent();
        }

        private void Ksiazki_Click(object sender, EventArgs e)
        {
            if (this.uzytkownik == null) { MessageBox.Show("Nie jesteś zalogowany !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                WidokTabeli.DataSource = null;
                DataTable pokaz = new DataTable();
                dane.WyswietlProfilUzytkownikaKsiazka(uzytkownik, ref pokaz);
                WidokTabeli.DataSource = pokaz;
            }
        }

        private void Filmy_Click(object sender, EventArgs e)
        {
            if (this.uzytkownik == null) { MessageBox.Show("Nie jesteś zalogowany !", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                WidokTabeli.DataSource = null;
                DataTable pokaz = new DataTable();
                dane.WyswietlProfilUzytkownikaFilm(uzytkownik, ref pokaz);
                WidokTabeli.DataSource = pokaz;
            }
        }
    }
}
