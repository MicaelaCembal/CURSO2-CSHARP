using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //abstact no permotye crear insyancia, obliga a heredar para trabjar con sus herencias
    //sealed no permite heredar
    sealed class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Legajo { get; set; }
    }
}
