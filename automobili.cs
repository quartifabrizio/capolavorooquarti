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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace progetto
{
    public partial class automobili : Form
    {
        public automobili()
        {
            InitializeComponent();
        }
        SqlConnection ConnServer = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void btn_SalvaAuto_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || MarchioTb.Text == "" || ModelloTb.Text == "" || PrezzoTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "insert into CarTable values('" + RegNumTb.Text + "','" + MarchioTb.Text + "', '" + ModelloTb.Text + "','" + cb_DisponAuto.SelectedItem.ToString() +"' , '" + PrezzoTb.Text + "')";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Auto aggiunta");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void automobili_Load(object sender, EventArgs e)
        {
            inserisci();
        }

        private void inserisci()
        {
            ConnServer.Open();
            string query = "select * from CarTable";

            SqlDataAdapter datadapt = new SqlDataAdapter(query, ConnServer);
            SqlCommandBuilder builder = new SqlCommandBuilder(datadapt);
            var dataset = new DataSet();
            datadapt.Fill(dataset);
            dgvAuto.DataSource = dataset.Tables[0];
            ConnServer.Close();
        }

        private void btn_CancAuto_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "delete from CarTable where AutoNumeReg='" + RegNumTb.Text + "';";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Dati dell'auto scelta eliminati");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void dgvAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvAuto.Rows[e.RowIndex];

                // Esempio: se hai tre colonne nella DataGridView e tre TextBox, puoi assegnare i valori alle TextBox come segue
                RegNumTb.Text = selectedRow.Cells[0].Value.ToString();
                MarchioTb.Text = selectedRow.Cells[1].Value.ToString();
                ModelloTb.Text = selectedRow.Cells[2].Value.ToString();
                cb_DisponAuto.SelectedItem = selectedRow.Cells[3].Value.ToString();
                PrezzoTb.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btn_ModAuto_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || MarchioTb.Text == "" || ModelloTb.Text == "" || PrezzoTb.Text == "")
            {
                MessageBox.Show("Informazioni mancanti, si prega di inserirle");
            }
            else
            {
                try
                {
                    ConnServer.Open();
                    string query = "update CarTable set AutoMarca='" + MarchioTb.Text + "', AutoModello='" + ModelloTb.Text + "' , AutoDispon='" + cb_DisponAuto.SelectedItem.ToString() + "', AutoPrezzo= '" + PrezzoTb.Text + "' where AutoNumeReg= '" + RegNumTb.Text + "';";

                    SqlCommand comm = new SqlCommand(query, ConnServer);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Dati dell'auto scelta modificati");
                    ConnServer.Close();
                    inserisci();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btn_IndietroAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincMenucs f = new FormPrincMenucs();
            f.Show();
        }
    }
}
