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
    public partial class DodajKsiazkeDoProfilu : UserControl
    {
        private Data_Manager dane = new Data_Manager();
        ArrayList ksiazki = new ArrayList();
        public string uzytkownik = "nic";

        public DodajKsiazkeDoProfilu()
        {
            InitializeComponent();
            this.pokazTytuly();
        }

        public void pokazTytuly()
        {
            dane.TytulyKsiazek(ref ksiazki);
            lista.Items.Clear(); // czyszczenie comboboxa aby uniknąć dodawania tytułów które już się tam znalazły
            for (int i = 0; i < ksiazki.Count; i++)
            {
                lista.Items.Add(ksiazki[i]);
            }
            ksiazki.Clear(); // czyszczenie arraylisty aby uniknąć powtarzania tych samych tytułow
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.uzytkownik == "nic") { MessageBox.Show("Nie jesteś Zalogowany !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (lista.SelectedItem == null) { MessageBox.Show("Nie wybrano tytułu !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (Ocena == null) { MessageBox.Show("Nie oceniono ksiazki !", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            else { dane.PrzypiszKsiazke(lista.SelectedItem.ToString(), this.uzytkownik, Int16.Parse(Ocena.Text.ToString()));
                MessageBox.Show("Dodano Książkę : " + lista.SelectedItem, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lista.SelectedItem = null;
            Ocena.Text = null;

        }

        private void Odswiez_Click(object sender, EventArgs e)
        {
            
            dane.TytulyKsiazek(ref ksiazki);
            lista.Items.Clear(); // czyszczenie comboboxa 
            for (int i = 0;i < ksiazki.Count;i++)
            {
                lista.Items.Add(ksiazki[i]);
            }
            ksiazki.Clear(); // czyszczenie arraylisty
        }
    }
}
