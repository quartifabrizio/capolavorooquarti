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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace progetto
{
    public partial class utente : Form
    {
        public utente()
        {
            InitializeComponent();
        }
        SqlConnection ConnServer = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "delete from UserTable where UserId=" + UserId.Text + ";";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Utente eliminato");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void utente_Load(object sender, EventArgs e)
        {
            inserisci();
        }
        private void inserisci()
        {
            ConnServer.Open();
            string query = "select * from UserTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvUtente.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }
        private void btn_SalvaUtente_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || UserName.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "insert into UserTable values(" + UserId.Text + ",'" + UserName.Text + "', '" + UserPass.Text + "')";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Utente aggiunto");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvUtente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvUtente.Rows[e.RowIndex];

                // Esempio: se hai tre colonne nella DataGridView e tre TextBox, puoi assegnare i valori alle TextBox come segue
                UserId.Text = selectedRow.Cells[0].Value.ToString(); 
                UserName.Text = selectedRow.Cells[1].Value.ToString(); 
                UserPass.Text = selectedRow.Cells[2].Value.ToString(); 
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModUtente_Click(object sender, EventArgs e)
        {
            if (UserId.Text == "" || UserName.Text == "" || UserPass.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "update UserTable set UserName= '" + UserName.Text + "', UserPass= '" + UserPass.Text + "'where UserId=" + UserPass.Text + ";";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Utente modificato");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_IndietroUtente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincMenucs f = new FormPrincMenucs();
            f.Show();
        }
    }
}
