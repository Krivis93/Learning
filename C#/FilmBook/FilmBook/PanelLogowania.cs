using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace FilmBook
{

    public partial class PanelLogowania : UserControl
    {
        public string uzytkownik;
        public bool Stan;

       // private int counter = 1;


        private Data_Manager dane = new Data_Manager();
        public void UstawLogowaniePuste()
        {
            Login.Text = "";
            Haslo.Text = "";
        }
        public PanelLogowania()
        {
            InitializeComponent();
            Haslo.PasswordChar = '#';
        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (counter < 2)
            //{
                this.uzytkownik = Login.Text;
                MessageBox.Show(dane.Logowanie(Login.Text, Haslo.Text, ref Stan), "Logowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // }
           // else { MessageBox.Show("Uwaga z powodu błędu aby zalogować się ponownie zrestartuj aplikację", "Logowanie", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //counter++;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.google.com");
        }

    }
}
