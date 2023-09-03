using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {// declaramos variables
            double dato1, dato2, relsultado;

            //asiganamos volares a nuestra variables
            if( string.IsNullOrEmpty(txtDato1.Text)|| (string.IsNullOrEmpty(txtDato2.Text)))
            {
                MessageBox.Show("ingrese datos en los campos");
                return;
            }
            dato1 = Convert.ToDouble(txtDato1.Text);
            dato2 = Convert.ToDouble(txtDato2.Text);
        }
    }
}
