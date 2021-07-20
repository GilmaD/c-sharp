using System;

namespace Ejercicio10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosPrueba datos=new DatosPrueba();
            string opcion="";
            while (true)
            {
            Console.Clear();
            Console.WriteLine("Sistemas de Ordenes");
            Console.WriteLine("===================");
            Console.WriteLine("");
            Console.WriteLine("1->Lista de Producto");
            Console.WriteLine("2->Crear Orden");
            Console.WriteLine("3->Lista de Clientes");
            Console.WriteLine("4->Lista de Vendedores");
            Console.WriteLine("5->Lista de Ordenes");
            Console.WriteLine("0->Salir");
            Console.WriteLine("Seleccione una opcion: ");
            opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1" :
                    Console.Clear();
                    datos.ListarProductos();
                    Console.ReadLine();
                    break;
                case "2" :
                    Console.Clear();
                    datos.crearOrdenes();
                    break;
                case "3" :
                    Console.Clear();
                    datos.ListarCliente();
                    break;
                case "4" :
                    Console.Clear();
                    datos.ListarVendedores();
                    break;
                case "5" :
                    Console.Clear();
                    datos.ListarOrdenes();
                    break;

                default:
                    break;
            }
            if(opcion=="0"){
                break;
            }
            }
        }
    }
}
