using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace progetto
{
    public partial class registra : Form
    {
        public registra()
        {
            InitializeComponent();
        }

        private void registra_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 100;
            int max = 200;
            int randomNumber = random.Next(min, max + 1);
            tbid.Text = randomNumber.ToString();
        }

        static string exepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        SqlConnection ConnServer = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={exepath}\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_LoginNome.Text == "" || tb_LoginPassword.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            if (tb_ConfermaPass.Text != tb_LoginPassword.Text)
            {
                MessageBox.Show("Le password inserite non corrispondono");
            }

            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "insert into UserTable values(" + tbid.Text + ",'" + tb_LoginNome.Text + "', '" + tb_LoginPassword.Text + "')";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Utente aggiunto");
                    ConnServer.Close();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
