using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace PubgDataBase
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            // Configurar conexión al cargar el formulario
            ConfigurarConexion();
        }

        private void ConfigurarConexion()
        {
            string server = "localhost";
            string database = "pubg";
            string user = "root";
            string password = "Jtpffptj1.";
            string port = "3306";
            string sslM = "none";

            string connString = String.Format(
                "server={0};port={1};user id={2};password={3};database={4};SslMode={5}",
                server, port, user, password, database, sslM);

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error de conexión: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string query = txtConsulta.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Por favor, escribe una consulta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adapter.Fill(dt);

                // Mostrar los resultados en el DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}