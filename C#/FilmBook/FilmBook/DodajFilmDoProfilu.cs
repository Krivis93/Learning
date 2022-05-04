using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FilmBook
{
    public partial class DodajFilmDoProfilu : UserControl
    {
        private Data_Manager dane = new Data_Manager();
        private ArrayList filmy = new ArrayList();
        public string uzytkownik = "nic";
        public DodajFilmDoProfilu()
        {
            InitializeComponent();
            this.pokazFilmy();
        }

        private void pokazFilmy()
        {
            dane.TytulyFilmow(ref filmy);
            Lista.Items.Clear(); // czyszczenie comboboxa aby uniknąć dodawania tytułów które już się tam znalazły
            for (int i = 0; i < filmy.Count; i++)
            {
                Lista.Items.Add(filmy[i]);
            }
            filmy.Clear(); // czyszczenie arraylisty aby uniknąć powtarzania tych samych tytułow
        }

        private void Odswiez_Click(object sender, EventArgs e)
        {
            dane.TytulyFilmow(ref filmy);
            Lista.Items.Clear(); // czyszczenie comboboxa aby uniknąć dodawania tytułów które już się tam znalazły
            for (int i = 0; i < filmy.Count; i++)
            {
                Lista.Items.Add(filmy[i]);
            }
            filmy.Clear(); // czyszczenie arraylisty aby uniknąć powtarzania tych samych tytułow
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.uzytkownik == "nic") { MessageBox.Show("Nie jesteś Zalogowany !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (Lista.SelectedItem == null) { MessageBox.Show("Nie Wybrano tytułu !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (Ocena == null) { MessageBox.Show("Nie oceniono filmu !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                dane.PrzypiszFilm(Lista.SelectedItem.ToString(), this.uzytkownik, Int16.Parse(Ocena.Text.ToString()));
                MessageBox.Show("Dodano Film : " + Lista.SelectedItem, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Lista.SelectedItem = null;
            Ocena.Text = null;
        }
    }
}
