using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double basee = double.Parse(txtBase.Text);
            double alturaa = double.Parse(txtAltura.Text);

            double resultado = basee * alturaa / 2;

            txtResultado.Text = resultado.ToString();
        }
    }
}
