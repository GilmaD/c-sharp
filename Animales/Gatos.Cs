using System;
namespace EjercicioAnimales
{
    class Gatos: Mamifero
    {
        public bool Maullar { get; set; }
        public Gatos(string nombre,string sexo,int edad,int patas,string reproduccion,string desplazamiento)
        {
            Nombre=nombre;
            Sexo=sexo;
            Edad=edad;
            Patas=patas;
            Reproduccion=reproduccion;
            Desplazamiento=desplazamiento;
        }

        public Gatos()
        {
            
        }
        public void maullar()
        {
            Maullar=true;
            
        }

    }

}