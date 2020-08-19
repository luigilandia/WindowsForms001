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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola desde Windows Form");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonPersona_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CajaNombre.Text + "," + CajaApellidos.Text);
        }

        private void BotonNotas_Click(object sender, EventArgs e)
        {
            int nota1 = Convert.ToInt32(CajaNota1.Text);
            int nota2 = Convert.ToInt32(CajaNota2.Text);
            int nota3 = Convert.ToInt32(CajaNota3.Text);
            int suma = nota1 + nota2 + nota3;
            //MessageBox.Show("Suma: "+suma);
            MessageBox.Show("Suma: "+suma);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Formulario cargado");
        }
    }
}
