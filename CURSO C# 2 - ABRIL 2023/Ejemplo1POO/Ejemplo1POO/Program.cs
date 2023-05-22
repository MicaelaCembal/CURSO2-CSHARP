using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un proyecto de consola .Net Framework.
Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
Agregale los siguientes atributos:
Modelo string.
Marca string.
NumeroTelefonico string.
CodigoOperador int (1, 2 o 3).
Agregale las propiedades correspondientes. Podés hacer el formato largo o el corto.
Modelo: solo lectura. Es decir, solo get.
Marca: solo lectura.
NumeroTelefonico: lectura y escritura.
CodigoOperador: lectura y escritura. Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
Agregar Constructor que reciba Modelo y Marca.
Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.*/
namespace Ejemplo1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("Modelo1", "Marca1");
            telefono1.NumeroTelefonico = "123456789";
            telefono1.CodigoOperador = 2;

            Console.WriteLine("Estado del Telefono 1:");
            Console.WriteLine("Modelo: " + telefono1.Modelo);
            Console.WriteLine("Marca: " + telefono1.Marca);
            Console.WriteLine("Número Telefónico: " + telefono1.NumeroTelefonico);
            Console.WriteLine("Código Operador: " + telefono1.CodigoOperador);
            Console.WriteLine(telefono1.Llamar());
            Console.WriteLine(telefono1.Llamar("Contacto1"));

            Console.WriteLine();

            Telefono telefono2 = new Telefono("Modelo2", "Marca2");
            telefono2.NumeroTelefonico = "987654321";
            telefono2.CodigoOperador = 4; // Se asignará un cero debido a la validación

            Console.WriteLine("Estado del Telefono 2:");
            Console.WriteLine("Modelo: " + telefono2.Modelo);
            Console.WriteLine("Marca: " + telefono2.Marca);
            Console.WriteLine("Número Telefónico: " + telefono2.NumeroTelefonico);
            Console.WriteLine("Código Operador: " + telefono2.CodigoOperador);
            Console.WriteLine(telefono2.Llamar());
            Console.WriteLine(telefono2.Llamar("Contacto2"));

            Console.ReadLine();
        }
    }
}
