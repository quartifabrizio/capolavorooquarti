using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace progetto
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            registra f2 = new registra();
            f2.Show();
            this.Hide();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        static string exepath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
        SqlConnection ConnServer = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={exepath}\CarRentalDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {      
            string query = "select count(*) from UserTable where UserName= '" + tb_LoginNome.Text + "' and UserPass= '" + tb_LoginPassword.Text + "'";
            ConnServer.Open();
            //SqlCommand comm = new SqlCommand(query, ConnServer);
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnServer);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                FormPrincMenucs mf = new FormPrincMenucs();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome utente o password errati");
            }
            ConnServer.Close();

        }


    }
}

