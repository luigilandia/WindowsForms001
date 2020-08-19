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
    public partial class Form8 : Form
    {
        DataSet midataset;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            midataset = new DataSet();

            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["miconexion"];
            String cadena = settings.ConnectionString;
            using (
            SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                String sql = "select * from factura";
                String sql2 = "select * from lineasfactura";
                SqlDataAdapter adaptador1 = new SqlDataAdapter(sql, conexion);
                adaptador1.Fill(midataset, "Factura");
                
                SqlDataAdapter adaptador2=new SqlDataAdapter(sql2, conexion);
                adaptador2.Fill(midataset, "LineasFactura");

                midataset.Relations.Add("Relacion", midataset.Tables["Factura"].Columns["numero"], 
                    midataset.Tables["LineasFactura"].Columns["factura_numero"]);

                dataGridView1.DataSource = midataset;
                dataGridView1.DataMember = "Factura";
                dataGridView2.DataSource = midataset;
                dataGridView2.DataMember = "LineasFactura";
            }
        }
    }
}
