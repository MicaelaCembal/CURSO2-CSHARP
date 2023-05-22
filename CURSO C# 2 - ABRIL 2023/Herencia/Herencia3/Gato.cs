using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Gato : AnimalDomestico
    {
        public override string Comunicarse()
        {
            return "Gato: miau miau";
        }
    }
}
