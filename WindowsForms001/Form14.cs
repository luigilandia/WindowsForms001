
using ADO.NET.Persistencia;
using Persistencia.Semicrol.Cursos.Persistencia;
using Semicrol.Cursos.Dominio;
using Semicrol.Cursos.Servicios;
using Servicios.Semicrol.Cursos.Servicios;
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
    public partial class Form14 : Form

        //Hacer lo mismo que en el caso anterior pero con IservicioFacturas
    {
        DataSet midataset;
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            SqlConnection conexion = new SqlConnection(cadena);
            {
                List<Factura> lista = new List<Factura>();

                conexion.Open();
                String sql = "select * from factura";
                SqlCommand comando = new SqlCommand(sql, conexion);

                SqlDataReader lector = comando.ExecuteReader();

                bindingSource1.DataSource = lista;
                dataGridView1.DataSource = bindingSource1;

                midataset = new DataSet();
            }
            
        }
    }
}
