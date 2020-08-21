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
    public partial class Form11 : Form
    {
        DataSet midataset;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            midataset = new DataSet();

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (
            SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "select * from factura";
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                SqlCommand comandoInsertar = conexion.CreateCommand();
                comandoInsertar.CommandType = CommandType.Text;
                //consulta parametrizada
                String sqlInsertar = "Insert into Factura (Numero, Concepto) values (" +
                    "@Numero, @Concepto)";
                comandoInsertar.CommandText = sqlInsertar;
                comandoInsertar.Parameters.Add("@Numero", SqlDbType.Int, 10);
                comandoInsertar.Parameters.Add("@Concepto", SqlDbType.VarChar, 20);
                //ésta es la clave primaria de la tabla con la cual insertaremos nuevos elementos
                comandoInsertar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;

                String sqlActualizar = "Update Factura set Concepto=@Concepto where @Numero=Numero";
                SqlCommand comandoActualizar = conexion.CreateCommand();

                comandoActualizar.Parameters.Add("@Numero", SqlDbType.Int, 10);
                comandoActualizar.Parameters.Add("@Concepto", SqlDbType.VarChar, 20);
                comandoActualizar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;
                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = sqlActualizar;

                SqlDataAdapter adaptador1 = new SqlDataAdapter();
                adaptador1.SelectCommand = comando;
                adaptador1.InsertCommand = comandoInsertar;
                adaptador1.UpdateCommand = comandoActualizar;

                adaptador1.Fill(midataset, "Factura");

                dataGridView1.DataSource = midataset;
                dataGridView1.DataMember = "Factura";

            }
        }
    }
}
