using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms001
{
    public partial class Form7 : Form
    {
        DataSet midataset;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            midataset = new DataSet();
            DataTable tabla = new DataTable("Tabla1");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellidos");
            DataRow fila = tabla.NewRow();
            fila["Nombre"] = "Pedro";
            fila["Apellidos"] = "Álvarez";
            tabla.Rows.Add(fila);
            
            midataset.Tables.Add(tabla);
            dataGridView1.DataSource = midataset;
            dataGridView1.DataMember = "Tabla1";

            DataTable tabla2 = new DataTable("Tabla2");
            tabla2.Columns.Add("Numero");
            tabla2.Columns.Add("Concepto");
            DataRow fila2 = tabla.NewRow();
            fila2["Nombre"] = "3";
            fila2["Apellidos"] = "Ordenador";
            tabla2.Rows.Add(fila2);

            midataset.Tables.Add(tabla2);
            dataGridView1.DataSource = midataset;
            dataGridView1.DataMember = "Tabla2";
        }
    }
}
