using System;

namespace EjercicioAnimales
{
    class Perro:Mamifero
    {
        public string Raza{ get; set; }

        public bool Ladrar{ get; set; }
        
        public Perro(string nombre,int patas, string raza)
        {
            Nombre=nombre;
            Patas=patas;
            Raza=raza;
            
        }
        public Perro(string nombre,string sexo,int edad,int patas,string reproduccion,string desplazamiento,string raza)
        {
            Nombre=nombre;
            Sexo=sexo;
            Edad=edad;
            Patas=patas;
            Reproduccion=reproduccion;
            Desplazamiento=desplazamiento;
            Raza=raza;
            
        }
        public Perro()
        {
                
        }
        public void ladrar()
        {
            Ladrar=true;

        }

        
    }
}