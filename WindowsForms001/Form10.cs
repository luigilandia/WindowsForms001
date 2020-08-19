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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (
            SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "select * from factura";
                String sql2 = "select * from lineasfactura";
                SqlDataAdapter adaptador1 = new SqlDataAdapter(sql, conexion);
                adaptador1.Fill(dataSet11, "Factura");

                SqlDataAdapter adaptador2 = new SqlDataAdapter(sql2, conexion);
                adaptador2.Fill(dataSet11, "LineasFactura");

                dataSet11.Relations.Add("Relacion", dataSet11.Tables["Factura"].Columns["numero"],
                    dataSet11.Tables["LineasFactura"].Columns["factura_numero"]);

                dataGridView1.DataSource = dataSet11;
                dataGridView1.DataMember = "Factura";
                dataGridView2.DataSource = dataSet11;
                dataGridView2.DataMember = "LineasFactura";
            }
        }
    }
}
