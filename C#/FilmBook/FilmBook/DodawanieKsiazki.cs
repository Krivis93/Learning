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
    public partial class DodawanieKsiazki : UserControl
    {
        Data_Manager dane = new Data_Manager();
        int charCount = 0; // zmienna przechowująca ilość znaków w textboxie opisu i recenzji ksiazki
        public DodawanieKsiazki()
        {
            InitializeComponent();
        }

        private void OpisKsiazki_TextChanged(object sender, EventArgs e)
        {
            charCount = OpisKsiazki.Text.Length; // pobiera ilość znaków
            ZnakiOpisK.Text = "Użyte znaki : " + charCount.ToString(); // wyprowadza ilość znaków do label'a po uprzedniej zmianie na string
        }

        private void RecenzjaKsiazki_TextCganged(object sender, EventArgs e)
        {
            charCount = RecenzjaKsiazki.Text.Length;
            ZnakiRecenzjaK.Text = "Użyte znaki : " + charCount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dane.DodajKsiazke(Tytul.Text,Rok.Text,OpisKsiazki.Text,RecenzjaKsiazki.Text);
            MessageBox.Show("Książka : '" + Tytul.Text + "' dodana", "Dodawanie Książki", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Tytul.Text = null;
            Rok.Text = null;
            OpisKsiazki.Text = null;
            RecenzjaKsiazki.Text = null;
        }
    }
}
