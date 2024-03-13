using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAherencia
{
    internal class Vaca : Mamifero
    {
        private double LtsLeche { get; set; }
       
        //constructor
        public Vaca(string n, double p, double L) : base(n, p)
        {
            this.LtsLeche = L;
        }

        //metodo
        public double CantComida()
        {
            double K;
            K = peso / LtsLeche;
            return K;
        }

        public string mostrarVaca()
        {
            string dato;
            dato = "el nombre de la vaca es: " + getNombre() + Environment.NewLine;
            dato += "el peso es: " + peso + "kilogramos" + Environment.NewLine;
            dato += "la cantidad de leche es: " + LtsLeche + Environment.NewLine;
            dato += "la cantidad de comida es: " + CantComida() + Environment.NewLine;
            return dato;
        }
    }
}

