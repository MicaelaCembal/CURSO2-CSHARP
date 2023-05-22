using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3= new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Roja";
            c3.Color = "Blanca";

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);*/

            /* listaCamionetas.Remove(c1);
             Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count());
             listaCamionetas[1].Color = "Negra";
             c3.Color = "Roja";            
             Console.WriteLine("El color de c2 es: " + listaCamionetas[1].Color);
             Console.WriteLine("El color de c3 es: " + c3.Color);*/

            /*foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }*/
                Auto a1 = new Auto();
            //ahora le agrego el motor
            a1.Motor = new Motor();

            

            Console.ReadKey(); 
        }
    }
}
