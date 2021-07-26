namespace EjercicioAnimales
{
    abstract class Mamifero:Animal
    {
        public int Patas{ get; set; }
        public string Reproduccion { get; set; }
        public string Desplazamiento { get; set; }  

        public bool Caminar{ get; set; }
        
        public void caminar()
    {
        Caminar=true;
    }
    }
   

}