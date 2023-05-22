using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //Redefino metodo to string para que me muestre el nombre y no que yo tenga que crear un metodo que lo haga

        public override string ToString()
        {
            return "Animal Domestico: " + Nombre;
        }
    }
}
