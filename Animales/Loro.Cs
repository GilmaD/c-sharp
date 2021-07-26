using System;
namespace EjercicioAnimales
{
    class Loro:Aves
    {

        public bool Hablar{ get; set; }
    public Loro(string nombre,string sexo,int edad,string colorPlumaje)
    {
      Nombre=nombre;
      Sexo=sexo;
      Edad=edad;
      ColorPlumaje=colorPlumaje;  
      
    }
    public Loro()
    {
      
    }
    public void hablar()
    {
        Hablar=true;
    }



    }
    
}