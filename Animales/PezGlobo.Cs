using System;
namespace EjercicioAnimales
{
    class PezGlobo:Peces
    {
        public bool Inflarce{ get; set; }
        public PezGlobo(string nombre,string sexo,int edad,int numeroAletas)
        {
            Nombre=nombre;
            Sexo=sexo;
            Edad=edad;
            NumeroAletas=numeroAletas;
            
            
        }

        public PezGlobo()
        {
            
        }
        public void inflarce()
        {
            Inflarce=true;
        }
    }
}
