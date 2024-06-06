using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace progetto
{
    public partial class acquirente : Form
    {
        public acquirente()
        {
            InitializeComponent();
        }

        static string exepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        SqlConnection ConnServer = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={exepath}\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btn_SalvaAcqui_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NomeTb.Text == "" || CognTb.Text == "" || EmailTb.Text == "" || IndirizzoTb.Text == "" || TelefonoTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "insert into AcquiTable values('" + IdTb.Text + "','" + NomeTb.Text + "', '" + CognTb.Text + "','" + EmailTb.Text + "' , '" + IndirizzoTb.Text + "' , '" + TelefonoTb.Text + "')";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Acquirente aggiunto");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_IndietroAcqui_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincMenucs f = new FormPrincMenucs();
            f.Show();
        }

        private void acquirente_Load(object sender, EventArgs e)
        {
            inserisci();
        }

        private void inserisci()
        {
            ConnServer.Open();
            string query = "select * from AcquiTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvAcqui.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }

        private void btn_CancAcqui_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "delete from AcquiTable where AcquId='" + IdTb.Text + "';";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Acquirente eliminato");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_ModAcqui_Click(object sender, EventArgs e)
        {
            if (IdTb.Text == "" || NomeTb.Text == "" || CognTb.Text == "" || EmailTb.Text == "" || IndirizzoTb.Text == "" || TelefonoTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "update AcquiTable set AcquiNome='" + NomeTb.Text + "', AcquiCogn='" + CognTb.Text + "' , AcquiMail='" + EmailTb.Text + "', AcquIndirizzo='" + IndirizzoTb.Text + "', AcquiCell='" + TelefonoTb.Text + "' where AcquId='" + IdTb.Text + "';";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Dati dell'acquirente modificati");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvAcqui_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAcqui.Rows[e.RowIndex];

                // Esempio: se hai tre colonne nella DataGridView e tre TextBox, puoi assegnare i valori alle TextBox come segue
                IdTb.Text = selectedRow.Cells[0].Value.ToString();
                NomeTb.Text = selectedRow.Cells[1].Value.ToString();
                CognTb.Text = selectedRow.Cells[2].Value.ToString();
                EmailTb.Text = selectedRow.Cells[3].Value.ToString();
                IndirizzoTb.Text = selectedRow.Cells[4].Value.ToString();
                TelefonoTb.Text = selectedRow.Cells[5].Value.ToString();
            }
        }
    }
}
