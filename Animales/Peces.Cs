using System;
namespace EjercicioAnimales
{
    abstract class Peces:Animal
    {
        public int NumeroAletas { get; set; }

        public bool Nadar{ get; set; }

        public void nadar()
        {
            Nadar=true;
        }
    }

}
