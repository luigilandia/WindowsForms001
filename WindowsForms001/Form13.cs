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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            List<string> textos = new List<string>();
            textos.Add("hola");
            textos.Add("que tal");
            bindingSource1.DataSource = textos;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
