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
    public partial class Zalogowano : UserControl
    {
        public string zalogowany = " ";
        public bool stanLogowania = true;
        public Zalogowano()
        {
            InitializeComponent();
        }

        public void okreslLogin(string x)
        {
            this.zalogowany = x;
            LogState.Text = "Zalogowano jako : " + zalogowany;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stanLogowania = false;
            MessageBox.Show("Wylogowano ! Aby zalogować się ponownie kliknij w panelu po lewej stronie przycisk Zaloguj", "Wylogowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
