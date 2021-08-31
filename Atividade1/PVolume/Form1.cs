using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        Double raio;
        Double altura;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Text = "";
            txtAltura.Text = "";
            txtVolume.Text = "";
            txtRaio.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double volume;
            if(Double.TryParse(txtRaio.Text, out raio) &&
                Double.TryParse(txtAltura.Text, out altura))
            {
                volume = Math.PI * Math.Pow(raio, 2) * altura;
                txtVolume.Text = volume.ToString("N2");
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
                txtRaio.Focus();
            }
        }

        private void txtRaio_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
