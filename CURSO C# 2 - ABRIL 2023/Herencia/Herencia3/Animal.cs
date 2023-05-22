using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Animal
    {
        //es virtrual para que pueda sobrescribirse 
        public virtual string Comunicarse()
        {
            return "ruido..ruido";
        }
    }
}
