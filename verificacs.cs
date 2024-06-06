using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto
{
    public partial class verificacs : Form
    {
        public verificacs()
        {
            InitializeComponent();
        }
        static string exepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        SqlConnection ConnServer = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={exepath}\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void inserisci()
        {
            ConnServer.Open();
            string query = "select * from NoleTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvNoleVer.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }

        private void inserisciRitornate()
        {
            ConnServer.Open();
            string query = "select * from VerificaTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvVerRicons.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }

        private void verificacs_Load(object sender, EventArgs e)
        {
            inserisci();
            inserisciRitornate();
        }
        //private void riempiCarCB()
        //{
        //    ConnServer.Open();
        //    string query = "select AutoNumeReg from CarTable where AutoDispon='" + "SI" + "'";
        //    SqlCommand comm = new SqlCommand(query, ConnServer);
        //    SqlDataReader reader;
        //    reader = comm.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("AutoNumeReg", typeof(string));
        //    dt.Load(reader);
        //    RegNumCB.ValueMember = "AutoNumeReg";
        //    RegNumCB.DataSource = dt;
        //    ConnServer.Close();

        //}

        private void dgvNoleVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNoleVer.Rows[e.RowIndex];

                IdTb.Text = selectedRow.Cells[0].Value.ToString();
                regNum.Text = selectedRow.Cells[1].Value.ToString();
                NomeTb.Text = selectedRow.Cells[2].Value.ToString();
                DataFinDT.Text = selectedRow.Cells[4].Value.ToString();
                TimeSpan ritardo = DateTime.Now - DataFinDT.Value.Date;
                int giorniRit = Convert.ToInt32(ritardo.TotalDays);
                if(giorniRit <= 0)
                {
                    RitardoTb.Text = "Nessun ritardo";
                    MultaTb.Text = "Nessuna multa";
                }
                else
                {
                    RitardoTb.Text = giorniRit + "giorni";
                    MultaTb.Text = /*"Multa presente: " + */(giorniRit*210).ToString()/* +"$"*/;
                }  
            }
        }

        private void btn_Ricon_Click(object sender, EventArgs e)
        {
            //riempiCarCB();
            if (MultaTb.Text == "" || RitardoTb.Text == "" || DataFinDT.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "INSERT INTO VerificaTable VALUES (@VerId, @VerCarReg, @varNomeAcqui, @VarDataRit, @VarRitardo, @VarMulta)";

                    SqlCommand comm = new SqlCommand(query, ConnServer);

                    // Aggiungi i parametri e assegna i valori
                    comm.Parameters.AddWithValue("@VerId", IdTb.Text);
                    comm.Parameters.AddWithValue("@VerCarReg", regNum.Text);
                    comm.Parameters.AddWithValue("@varNomeAcqui", NomeTb.Text);
                    comm.Parameters.AddWithValue("@VarDataRit", DataFinDT.Value);
                    comm.Parameters.AddWithValue("@VarRitardo", RitardoTb.Text);
                    comm.Parameters.AddWithValue("@VarMulta", MultaTb.Text);

                    comm.ExecuteNonQuery();
                    MessageBox.Show("Auto riconsegnata correttamente!");
                    ConnServer.Close();
                    inserisciRitornate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_IndietroNole_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincMenucs f = new FormPrincMenucs();
            f.Show();
        }
    }
}
