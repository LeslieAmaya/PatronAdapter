using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Motor diesel acelerando");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Motor diesel arrancando");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Motor diesel cargando combustible");
        }

        public override void Detener()
        {
            Console.WriteLine("Motor diesel deteniendo");
        }
    }
}
