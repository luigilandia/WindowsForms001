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
        SqlDataAdapter adaptador1 = new SqlDataAdapter();

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
            midataset = new DataSet();

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;

            SqlConnection conexion = new SqlConnection(cadena);
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
                comandoInsertar.Parameters.Add("@Numero", SqlDbType.Int, 10, "Numero");
                comandoInsertar.Parameters.Add("@Concepto", SqlDbType.VarChar, 20, "Concepto");
                //ésta es la clave primaria de la tabla con la cual insertaremos nuevos elementos
                comandoInsertar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;

                String sqlActualizar = "Update Factura set Concepto=@Concepto where Numero=@Numero";
                SqlCommand comandoActualizar = conexion.CreateCommand();

                comandoActualizar.Parameters.Add("@Numero", SqlDbType.Int, 10);
                comandoActualizar.Parameters.Add("@Concepto", SqlDbType.VarChar, 20);
                comandoActualizar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;
                comandoActualizar.CommandType = CommandType.Text;
                comandoActualizar.CommandText = sqlActualizar;

                string sqlBorrar = "delete from Factura where Numero=@Numero";
                SqlCommand comandoBorrar = conexion.CreateCommand();
                comandoBorrar.CommandText = sqlBorrar;
                comandoBorrar.CommandType = CommandType.Text;
                comandoBorrar.Parameters.Add("@Numero", SqlDbType.Int, 10, "Numero");
                comandoBorrar.Parameters["@Numero"].SourceVersion = DataRowVersion.Original;
                

                adaptador1.SelectCommand = comando;
                adaptador1.InsertCommand = comandoInsertar;
                adaptador1.UpdateCommand = comandoActualizar;
                adaptador1.DeleteCommand = comandoBorrar;

                adaptador1.Fill(midataset, "Factura");

                /*dataGridView1.DataSource = midataset;
                dataGridView1.DataMember = "Factura";*/

                bindingSource1.DataSource = midataset.Tables["Factura"];
                dataGridView1.DataSource = bindingSource1;
                txtBoxNumero.DataBindings.Add("Text", bindingSource1, "Numero");
                txtBoxConcepto.DataBindings.Add("Text", bindingSource1, "Concepto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adaptador1.Update(midataset, "Factura");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            dataGridView1.Rows.Remove(fila);
            adaptador1.Update(midataset, "Factura");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();

        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bindingSource1.Sort = "Concepto";
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            label1.Text = bindingSource1.Position.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Concepto='" + filtrotxt.Text + "'";
            //bindingSource1.DataSource = midataset.Tables["Factura"];
            //bindingSource1.RemoveFilter();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
