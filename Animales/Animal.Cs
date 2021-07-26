namespace EjercicioAnimales
{
    abstract class Animal
    {
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int  Edad{ get; set; }

        public bool Comer { get; set; }

        public void comer()
        {
            Comer=true;
        }


    }

}