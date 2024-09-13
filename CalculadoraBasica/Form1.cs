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
            double dato1, dato2, resultado;

            //asiganamos volares a nuestra variables  ...
            if( string.IsNullOrEmpty(txtDato1.Text)|| (string.IsNullOrEmpty(txtDato2.Text)))
            {
                MessageBox.Show("ingrese datos en los campos");
                return;
            }
            dato1 = Convert.ToDouble(txtDato1.Text);
            dato2 = Convert.ToDouble(txtDato2.Text);

            int indice = lstOperacion.SelectedIndex;
            if (indice == 0)
            {
                resultado = dato1 + dato2;
                lblResultado.Text = (Convert.ToString("el Resultado es :" + resultado));
            }

            else if (indice == 1)
            {
                resultado = dato1 - dato2;
                lblResultado.Text = (Convert.ToString("el Resultado es :" + resultado));
            }
            else if (indice == 2)
            {
                resultado = dato1 * dato2;
                lblResultado.Text = (Convert.ToString("el Resultado es :" + resultado));
            }
            else if (indice == 3)
            {
                resultado = dato1 / dato2;
                lblResultado.Text = (Convert.ToString("el Resultado es :" + resultado));
            }
            else
            {
                MessageBox.Show("erro de seleccion de datos");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = " En espera del resultado";
            lblOperacion.Text = " Elija una de las siguientes operaciones";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDato1.Clear();
            txtDato2.Clear();
            lblResultado.Text = " En espera del resultado"; 
        }
    }
}
