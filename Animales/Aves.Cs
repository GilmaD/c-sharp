using System;
namespace EjercicioAnimales
{
    abstract class Aves:Animal
    {
        public string ColorPlumaje { get; set; }

        public bool Volar{ get; set; }

        public void volar()
        {
            Volar=true;
        }
    }
}
