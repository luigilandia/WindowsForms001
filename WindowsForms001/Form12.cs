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
    public partial class Form12 : Form
    {
        DataSet midataset;
        SqlDataAdapter adaptador1 = new SqlDataAdapter();

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            midataset = new DataSet();

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;

            SqlConnection conexion = new SqlConnection(cadena);
            {
                conexion.Open();
                String sql = "select * from Personas";
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;

                SqlCommand comandoInsertar = conexion.CreateCommand();
                comandoInsertar.CommandType = CommandType.Text;
                //consulta parametrizada
                String sqlInsertar = "Insert into Personas (DNI, Nombre, Apellidos) values (" +
                    "@DNI, @Nombre, @Apellidos)";
                comandoInsertar.CommandText = sqlInsertar;
                comandoInsertar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");
                comandoInsertar.Parameters.Add("@Nombre", SqlDbType.VarChar, 20, "Nombre");
                comandoInsertar.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50, "Apellidos");
                //ésta es la clave primaria de la tabla con la cual insertaremos nuevos elementos
                comandoInsertar.Parameters["@DNI"].SourceVersion = DataRowVersion.Original;

                String sqlActualizar = "Update Personas set Nombre=@Nombre where DNI=@DNI";
                SqlCommand comandoActualizar = conexion.CreateCommand();

                comandoActualizar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");
                comandoActualizar.Parameters.Add("@Nombre", SqlDbType.VarChar, 20, "Nombre");
                comandoActualizar.Parameters.Add("@Apellidos", SqlDbType.VarChar, 50, "Apellidos");
                comandoActualizar.Parameters["@DNI"].SourceVersion = DataRowVersion.Original;
                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = sqlActualizar;

                string sqlBorrar = "delete from Personas where DNI=@DNI";
                SqlCommand comandoBorrar = conexion.CreateCommand();
                comandoBorrar.CommandText = sqlBorrar;
                comandoBorrar.CommandType = CommandType.Text;
                comandoBorrar.Parameters.Add("@DNI", SqlDbType.VarChar, 10, "DNI");
                comandoBorrar.Parameters["@DNI"].SourceVersion = DataRowVersion.Original;

                adaptador1.SelectCommand = comando;
                adaptador1.InsertCommand = comandoInsertar;
                adaptador1.UpdateCommand = comandoActualizar;
                adaptador1.DeleteCommand = comandoBorrar;

                adaptador1.Fill(midataset, "Personas");


                dataGridView1.DataSource = midataset;
                dataGridView1.DataMember = "Personas";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador1.Update(midataset, "Personas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(fila);
            adaptador1.Update(midataset, "Personas");
        }
    }
}
