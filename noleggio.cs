using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace progetto
{
    public partial class noleggio : Form
    {
        public noleggio()
        {
            InitializeComponent();
        } // Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30
        static string exepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        SqlConnection ConnServer = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={exepath}\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void riempiCarCB()
        {
            ConnServer.Open();
            string query = "select AutoNumeReg from CarTable where AutoDispon='" + "SI" + "'";
            SqlCommand comm = new SqlCommand(query, ConnServer);
            SqlDataReader reader;
            reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AutoNumeReg", typeof(string));
            dt.Load(reader);
            N_RegNumCB.ValueMember = "AutoNumeReg";
            N_RegNumCB.DataSource = dt;
            ConnServer.Close();

        }

        private void riempiIdAcquiCB()
        {
            ConnServer.Open();
            string query = "select AcquId from AcquiTable";
            SqlCommand comm = new SqlCommand(query, ConnServer);
            SqlDataReader reader;
            reader = comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AcquId", typeof(int));
            dt.Load(reader);
            N_IdAcquiCB.ValueMember = "AcquId";
            N_IdAcquiCB.DataSource = dt;
            ConnServer.Close();

        }

        private void fetchNomeAcquirente()
        {
            ConnServer.Open();
            string query = "select * from AcquiTable where AcquId=" + N_IdAcquiCB.SelectedValue.ToString() + "";
            SqlCommand comm = new SqlCommand(query, ConnServer);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comm);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                N_NomeTb.Text = dr["AcquiNome"].ToString();
                CognTb.Text = dr["AcquiCogn"].ToString();
            }
            ConnServer.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void noleggio_Load(object sender, EventArgs e)
        {
            riempiCarCB();
            riempiIdAcquiCB();
            inserisci();
        }

        private void N_IdAcquiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void N_IdAcquiCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchNomeAcquirente();
        }

        private void btn_SalvaANole_Click(object sender, EventArgs e)
        {
            if (N_IdTb.Text == "" || TasseTb.Text == "" || N_NomeTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "INSERT INTO NoleTable VALUES (@NoleId, @CarReg, @NomeAcqui, @DataInizio, @DataFine, @TassaNole)";

                    SqlCommand comm = new SqlCommand(query, ConnServer);

                    // Aggiungi i parametri e assegna i valori
                    comm.Parameters.AddWithValue("@NoleId", N_IdTb.Text);
                    comm.Parameters.AddWithValue("@CarReg", N_RegNumCB.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@NomeAcqui", N_NomeTb.Text);
                    comm.Parameters.AddWithValue("@DataInizio", DataInDT.Value);
                    comm.Parameters.AddWithValue("@DataFine", DataFinDT.Value);
                    comm.Parameters.AddWithValue("@TassaNole", TasseTb.Text);

                    comm.ExecuteNonQuery();
                    MessageBox.Show("Auto noleggiata correttamente!");
                    ConnServer.Close();
                    cambiaDisponibilita();
                    inserisci();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void inserisci()
        {
            ConnServer.Open();
            string query = "select * from NoleTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvNole.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }

        private void cambiaDisponibilita()
        {
            ConnServer.Open();
            string query = "update CarTable set AutoDispon ='" + "NO" + "' where AutoNumeReg='" + N_RegNumCB.SelectedValue.ToString() + "';";
            SqlCommand comm = new SqlCommand(query, ConnServer);
            comm.ExecuteNonQuery();
            ConnServer.Close();
        }

        private void btn_IndietroNole_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincMenucs f = new FormPrincMenucs();
            f.Show();
        }

        private void btn_ModNole_Click(object sender, EventArgs e)
        {


            if (N_IdTb.Text == "" || TasseTb.Text == "" || N_NomeTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "UPDATE NoleTable VALUES (@NoleId, @CarReg, @NomeAcqui, @DataInizio, @DataFine, @TassaNole)";

                    SqlCommand comm = new SqlCommand(query, ConnServer);

                    // Aggiungi i parametri e assegna i valori
                    comm.Parameters.AddWithValue("@NoleId", N_IdTb.Text);
                    comm.Parameters.AddWithValue("@CarReg", N_RegNumCB.SelectedValue.ToString());
                    comm.Parameters.AddWithValue("@NomeAcqui", N_NomeTb.Text);
                    comm.Parameters.AddWithValue("@DataInizio", DataInDT.Value);
                    comm.Parameters.AddWithValue("@DataFine", DataFinDT.Value);
                    comm.Parameters.AddWithValue("@TassaNole", TasseTb.Text);

                    comm.ExecuteNonQuery();
                    MessageBox.Show("Prenotazione modificata correttamente!");
                    ConnServer.Close();
                    cambiaDisponibilita();
                    inserisci();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
            //string aquery = "update CarTable set AutoMarca='" + MarchioTb.Text + "', AutoModello='" + ModelloTb.Text + "' , AutoDispon='" + cb_DisponAuto.SelectedItem.ToString() + "', AutoPrezzo= '" + PrezzoTb.Text + "' where AutoNumeReg= '" + RegNumTb.Text + "';";                  
        }

        private void btn_CancNole_Click(object sender, EventArgs e)
        {
            if (N_IdTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "delete from NoleTable where NoleId='" + N_IdTb.Text + "';";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("DPrenotazione scelta eliminata");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvNole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNole.Rows[e.RowIndex];

                // Esempio: se hai tre colonne nella DataGridView e tre TextBox, puoi assegnare i valori alle TextBox come segue
                N_IdTb.Text = selectedRow.Cells[0].Value.ToString();
                N_RegNumCB.SelectedValue = selectedRow.Cells[1].Value.ToString();
                N_NomeTb.Text = selectedRow.Cells[2].Value.ToString();
                DataInDT.Text = selectedRow.Cells[3].Value.ToString();
                DataFinDT.Text = selectedRow.Cells[4].Value.ToString();
                TasseTb.Text = selectedRow.Cells[5].Value.ToString();
                CognTb.Text = "    ---";
            }
        }
    }
}

