using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAherencia
{
    internal class Gato: Mamifero
    {
        private int nBigotes { get; set; }

        public Gato(string n, double p, int b) : base(n, p)
        {
            this.nBigotes = b;
        }

        //Metodos 
        public string mostrarGato()
        {
            string dato;
            dato = "el nombre del gato es: " + getNombre() + Environment.NewLine;
            dato += "el peso es: " + peso + "kilogramos" + Environment.NewLine;
            dato += "el numero de bigotes es: " + nBigotes + Environment.NewLine;
            return dato;
        }
    }
}
