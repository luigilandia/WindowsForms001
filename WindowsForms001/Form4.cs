using System;
using System.Collections;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Insuficiente");
            comboBox1.Items.Add("Suficiente");
            comboBox1.Items.Add("Bien");
            comboBox1.Items.Add("Notable");
            comboBox1.Items.Add("Sobresaliente");

            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            comboBox2.Items.Add("5");

            listBox1.Items.Add("Rojo");
            listBox1.Items.Add("Verde");
            listBox1.Items.Add("Azul");
            listBox1.Items.Add("Amarillo");
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            ListBox list = sender as ListBox;
            if (sender is ComboBox)
            {
                MessageBox.Show(combo.SelectedItem.ToString());
            } /*if (sender is ListBox)
            {
                MessageBox.Show(list.SelectedItem.ToString());
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList lista = listBox1.SelectedItems;
            string total = "";
            foreach(string texto in lista)
            {
                total += texto + "\n";
            }
            MessageBox.Show(total);
        }
    }
}
