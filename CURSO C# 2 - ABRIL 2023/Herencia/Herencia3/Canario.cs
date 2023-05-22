using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Canario : AnimalDomestico, Flyable
    {
     
        public string volar()
        {
            return "Vuela como un canario"; 
        }
    }
}
