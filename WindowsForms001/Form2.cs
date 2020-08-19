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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            EtiqRadios.Text = radio.Text;
        }

        private void GroupboxColores_Enter(object sender, EventArgs e)
        {

        }

        /*private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EtiqRadios.Text = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            EtiqRadios.Text = radioButton3.Text;
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Seleccionado_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(radioButton1.Text);
                
            } else if (radioButton2.Checked)
            {
                MessageBox.Show(radioButton2.Text);

            }
            else
            {
                MessageBox.Show(radioButton3.Text);
            }
        }

        private void EtiqAprob_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radio2 = sender as RadioButton;
            EtiqAprob.Text = radio2.Text;
            //EtiqRadios.Text = radio.Text; EtiqAprob.Text = radioButton4.Text;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAprobado_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                MessageBox.Show(radioButton4.Text);

            }
            else
            {
                MessageBox.Show(radioButton5.Text);

            }
        }

        private void BotonInfo_Click(object sender, EventArgs e)
        {
            if (EsInformatico.Checked)
            {
                MessageBox.Show("La caja está chequeada");
            }
            else
            {
                MessageBox.Show("La caja no está chequeada");
            }
        }
    }
}
