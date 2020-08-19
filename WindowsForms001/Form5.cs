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
    public partial class Form5 : Form
    {
        List<Persona> lista = new List<Persona>();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            IPersonaRepository repo = new PersonaRepositoryMemoria();
            IList<Persona> lista = repo.BuscarTodos();

            /*lista.Add(new Persona("Pedro", 20));
            lista.Add(new Persona("Juan", 30));*/
            comboBox1.DataSource = lista;
            comboBox1.ValueMember = "Edad";
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
