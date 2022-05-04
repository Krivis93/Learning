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
    public partial class Starcik : UserControl
    {
        private SQL_Helper dane = new SQL_Helper();
        public Starcik()
        {
            InitializeComponent();

        }

        private void Starcik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dane.start_bazy(), "Łączenie z bazą danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
