using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* En ocasiones, queremos que nuestros programas modulares permitan retornar algun valor o dato especifico,
 * con el que se permitira realizar otras tareas o procedimientos en la solucion del problema,
 en las funciones de retorno las cuales permiten ejecutar una serie e intrucciones retornando un dato relacionado con algun tipo de dato en particular
(int, double,char, bol )  

 CARACTERISTICA DE LAS FUNCIONES DE RETORNO 

-DEBE RETORNAR UN DATO

-COMIENZAN CON EL TIPO DE DATO QUE VA A DEVOLVER LA FUNCION

-PUEDEN TENER O NO ARGUMENTOS 

--------------------------------------------------------------------------------------------------------------------- 
 
 */



namespace Funciones_de_Retorno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double calcularDescuento(double totalCompra )
        {
            double descuento = 0;

            if (totalCompra > 100 && totalCompra >= 200)
            {
                descuento = totalCompra * 0.05;
            }
            else if(totalCompra > 200 && totalCompra >= 300)
            {
                descuento = totalCompra * 0.10;
            }
            else if (totalCompra > 300 )
            {
                descuento = totalCompra * 0.20;
            }

            return descuento;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double descuentoCompra = calcularDescuento(double.Parse(txtTotalCompra.Text));

           double TotalNeto =  int.Parse(txtTotalNeto.Text) - descuentoCompra ;

            txtTotalNeto.Text = TotalNeto.ToString();

        }
    }
}
