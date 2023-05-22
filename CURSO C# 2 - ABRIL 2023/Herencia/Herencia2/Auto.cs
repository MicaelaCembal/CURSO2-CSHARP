using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    class Auto : Vehiculo
    { 
         public Auto()
            {
            Chasis  = new Chasis(); 
            }
    

        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }



        //se defiine a traves de saber si el auto puede nacer con o sin el motor. si puede hacerlo sin, es agregacion. si es obligatorio de su nacimento, composicion
       
        //Composicion
        //el auto no puede nacer sin chasis, no se lo puedo setear desde el exterior
        public Chasis Chasis { get; }

        //Agregación
        //puedo construir un auto y desoues agregarle el motor asi que es agregacion, lo agrego en pogram

        public Motor Motor { get; set; }
    }
}
