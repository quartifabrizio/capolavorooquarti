using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto
{
    public partial class FormPrincMenucs : Form
    {
        public FormPrincMenucs()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PrincAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            automobili f = new automobili();
            f.Show();
        }

        private void btn_PrincUtente_Click(object sender, EventArgs e)
        {
            this.Hide();
            utente f = new utente();
            f.Show();
        }

        private void btn_PrincAcqui_Click(object sender, EventArgs e)
        {
            this.Hide();
            acquirente f = new acquirente();
            f.Show();
        }

        private void btn_PrincNoleggio_Click(object sender, EventArgs e)
        {
            this.Hide();
            noleggio f = new noleggio();
            f.Show();
        }

        private void btn_PrincRest_Click(object sender, EventArgs e)
        {
            this.Hide();
            verificacs f = new verificacs();
            f.Show();
        }

        private void FormPrincMenucs_Load(object sender, EventArgs e)
        {

        }
    }
}
