using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotaciones_en_POO
{
    internal class Ventas
    {
        //Atributos

        private int numVenta;
        private double totalVenta;

        //Metodos contructores 

        public Ventas(int nv, double tv)
        {
            numVenta = nv;
            totalVenta = tv;

        }

        //Metodos setters 
        public void setNumVenta(int nv)
        {
            numVenta = nv;
        }

        public void setTotalVEnta (int tv)
        {
            totalVenta = tv;
        }

        //Metodos Getters

        public int getNumVenta()
        {
            return numVenta;
        }

        public double getTotalVenta()
        {
            return totalVenta;
        }

    }
}
