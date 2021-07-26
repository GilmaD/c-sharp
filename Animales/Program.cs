using System;

namespace EjercicioAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcion="";
            ListaAnimales a = new ListaAnimales();
            
            while (true)
            {
            Console.WriteLine("     ANIMALES");
            Console.WriteLine("     ********");
            Console.WriteLine("");
            Console.WriteLine("1->Perros");
            Console.WriteLine("2->Gatos");
            Console.WriteLine("3->Mono");
            Console.WriteLine("4->Aguila");
            Console.WriteLine("5->Loro");
            Console.WriteLine("6->Pez Globo");
            Console.WriteLine("0->Salir");
            Console.WriteLine("Seleccione una Opcion: ");
            opcion=Console.ReadLine();
            switch (opcion)
            {
                case "1":
                a.ListarPerros();
                break;
                case "2":
                a.ListarGatos();
                break;
                case "3":
                a.ListarMonos();
                break;
                case "4":
                a.ListarAguila();
                break;
                case "5":
                a.ListarLoro();
                break;
                case "6":
                a.ListarPezGlobo();
                break;

                default:
                break;
            }
            if (opcion =="0")
            {
               break; 
            }
            }
            
        }
    }
}
