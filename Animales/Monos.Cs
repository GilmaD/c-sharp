using System;
namespace EjercicioAnimales
{
    class Monos:Mamifero
    {
        public bool Maulla { get; set; }
        public Monos(string nombre,string sexo,int edad,int patas,string reproduccion,string desplazamiento)
        {
            Nombre=nombre;
            Sexo=sexo;
            Edad=edad;
            Patas=patas;
            Reproduccion=reproduccion;
            Desplazamiento=desplazamiento; 
            
        }
        public Monos(string nombre,int patas, string reproduccion)
        {
            Nombre=nombre;
            Reproduccion=reproduccion;
            Patas=patas;
        }
        
         public void maulla()
        {
            Maulla=true;
        }

        
    }
}