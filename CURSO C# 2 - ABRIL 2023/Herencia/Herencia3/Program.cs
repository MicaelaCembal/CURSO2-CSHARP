using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
             a1.Nombre = "Pepe";
             Console.WriteLine(a1.ToString());

             Console.WriteLine(a1.Comunicarse());

             Gato g1 = new Gato();
             g1.Nombre = "Jorge";

             Perro p1 = new Perro();
             p1.Nombre = "Negri";

             List < Animal > animales = new List<Animal>();
             animales.Add(p1);
             animales.Add(new Pez());
             animales.Add(new Canario());
             animales.Add(g1);
             animales.Add(new Aguila());

             foreach (Animal item in animales)
             {
                 Console.WriteLine(item.Comunicarse());
             }
             Console.ReadKey();

             //POLIMORFISMO  ES CUANDO EJECUTE ESTO ULTIMO --> CARACTERISTICA DE LOS OBJETOS DE RESPONDER SEGUN SU CARACTERSITICA ANTE EL MISMO ESTIMULO, PERRO RESPONDE GUAUG Y GATO MIAU PORQUE YO DIGO ANIMAL COMUNICATE, SIEMPRE LLAMO AL ANIMAL 

             /*
             Console.WriteLine(g1.Comunicarse());

             Console.WriteLine(p1.Comunicarse());

             //guardo refernecia del gato en un animal porque el gato es un animal
             Animal a1 = g1;

             //para poder acceder a las carcterstostas del gato tengo que acceder a el porque animal no sabe las porpoediades de gato

             //transformo a1 en gato porque sino no sabe que lo es
             Gato g8 = (Gato)a1;
             g8.Nombre = "Blanquito";
             Console.WriteLine("Nombre gato: " + g8.Nombre);

             Console.WriteLine("Nombre gato: " + g1.Nombre);
             */


            //INTERFAZ

            List<Flyable> listaVoladores = new List<Flyable>();
             listaVoladores.Add(new Canario());
             listaVoladores.Add(new Aguila());
             
            // listaVoladores.Add(new Perro()); esto no puedo si yo no le agrego la interfaz de volar

            
        }
    }
}
