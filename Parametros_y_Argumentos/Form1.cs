using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Los parametros son uno o varios elementos que necesita una funcion para realizar una tarea especifica,
 * dichos parametos pueden ser variables, constantes , Arrays, objetos , entre otros elementos que se utiliza la 
 funcion para su funcionamiento  */




namespace Parametros_y_Argumentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void CalcularSuma(int num1 , int num2)
        {
            int Resultado = num1 + num2;

            MessageBox.Show("El resultado es : " + Resultado);

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int numero1 = Convert.ToInt16(txtNumero1.Text);
            int numero2 = Convert.ToInt16(txtNumero2.Text);


            CalcularSuma(numero1, numero2);

        }
    }
}


