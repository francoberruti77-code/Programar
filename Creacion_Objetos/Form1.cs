using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace Creacion_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AireAcondicionado aire1 = new AireAcondicionado(); // <-- crear una variable aire1 de tipo AireAcondicionado

            AireAcondicionado aire2 = new AireAcondicionado();

            /*  Ahora le colocamos los valores */

            aire1.marca = "Sony";
            aire1.modelo= " 2023AC ";
            aire1.color = "Azul ";
            aire1.btu = 12000;
            aire1.voltaje = 110;
            aire1.temperatura = 16;


            aire2.marca = "philco";
            aire2.modelo = " 2024AC ";
            aire2.color = " Negro ";
            aire2.btu = 18000;
            aire2.voltaje = 220;
            aire2.temperatura = 20;


            MessageBox.Show("La marca del aire 1 es :  " + aire1.marca);

        }
    }
}
