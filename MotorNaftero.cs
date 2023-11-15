using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor naftero acelerando");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor naftero arrancando");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Motor naftero cargando combustible");
        }

        public override void Detener()
        {
            Console.WriteLine("Motor diesel deteniendo");
        }
    }
}
