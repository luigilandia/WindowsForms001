using Semicrol.Cursos.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            /*IPersonaRepository repo = new PersonaRepositoryMemoria();
            dataGridView1.DataSource = repo.BuscarTodos();*/
            CargarTabla();


        }

        private void CargarTabla()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (
            SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "select * from factura";
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataReader lector = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(lector);
                dataGridView1.DataSource = table;

            }

        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (
            SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "insert into factura (Numero, Concepto) values " +
                    "(@Numero, @Concepto)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@Numero", textBoxNumero.Text);
                comando.Parameters.AddWithValue("@Concepto", textBoxConcepto.Text);
                comando.ExecuteNonQuery();

            }
        }
    }
}
