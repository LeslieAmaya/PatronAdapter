using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorElectrico
    {
        bool _moviendo, _conectado, _activo;
        public void Conectar()
        {
            if (_conectado)
            {
                Console.WriteLine("El motor ya está conectado");
            }
            else
            {
                Console.WriteLine("Motor conectado");
            }
        }
        public void Activar()
        {
            if (_conectado)
            {
                Console.WriteLine("Se tiene que conectar el motor");
            }
            else
            {
                _activo = true;
                Console.WriteLine("Activando");
            }
        }
        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor eléctrico");
            }
            else
            {
                Console.WriteLine("El motor tiene que estar conectado y activo");
            }
        }
        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor eléctrico");
            }
            else
            {
                Console.WriteLine("El motor no está en movimiento");
            }
        }
        public void Desconectar()
        {
            if (_conectado)
            {
                _conectado = false;
                Console.WriteLine("Motor se desconectó");
            }
            else
            {
                Console.WriteLine("El motor está desconectado");
            }
        }
        public void Desactivar ()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor desactivado");
            }
            else
            {
                Console.WriteLine("El motor ya está desactivado");
            }
        }
        public void Enchufar()
        {
            if(!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando");
            }
            else
            {
                Console.WriteLine("Ocupa desactivar el motor");
            }
        }
    }
}
