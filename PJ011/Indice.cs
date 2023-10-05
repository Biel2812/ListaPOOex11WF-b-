using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ011
{
    internal class Indice
    {
        //atributos
        private double peso;
        private double alt;
        private double ind;




        //metodos 
        public void setVpeso(double p)
        {
            peso = p;
        }

        public void setValtura(double p)
        {
            alt = p;
        }


        public double getVpeso()
        {
            return peso;
        }

        public double getValtura()
        {
            return alt;
        }

        public double getValores()
        {
            return ind;
        }


        public string calcularValores()


        {

            ind = (peso / (alt * alt));

            if (ind < 20)
                return "Abaixo do peso";

            else if (ind <= 20 || ind < 25)
               return "Peso ideal";

            else
                return "Acima do peso";


        }
    }
}

