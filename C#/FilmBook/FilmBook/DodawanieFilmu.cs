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
    public partial class DodawanieFilmu : UserControl
    {
        Data_Manager dane = new Data_Manager();
        int charCount = 0; // zmienna przechowująca ilość znaków w textboxie opisu i recenzji filmu
        public DodawanieFilmu()
        {
            InitializeComponent();
        }

        private void OpisFilm_TextChanged(object sender, EventArgs e)
        {
            charCount = OpisFilm.Text.Length; //pobiera ilość znaków
            ZnakiOpisF.Text = "Użyte znaki : " + charCount.ToString();// wyprowadza ilość znaków do label'a po uprzedniej zmianie na string
        }

        private void RecenzjaFilm_TextChanged(object sender, EventArgs e)
        {
            charCount = RecenzjaFilm.Text.Length;
            ZnakiRecenzjaF.Text = "Użyte znaki : " + charCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dane.DodajFilm(Tytul.Text, Rok.Text, OpisFilm.Text, RecenzjaFilm.Text);
            MessageBox.Show("Film : '" + Tytul.Text + "' dodany", "Dodawanie Książki", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tytul.Text = null;
            Rok.Text = null;
            OpisFilm.Text = null;
            RecenzjaFilm.Text = null;
        }
    }
}
