using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Tester t1 = new Tester();
            Lider l = new Lider(); 
            Lider.algo();

            Console.WriteLine("hola"); 

            //console, program, lider, son clases

        }
    }
}
