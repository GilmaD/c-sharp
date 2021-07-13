using System;


namespace _01_Inventario
{
    class Program
    {
    
    static void Main(string[] args)
        {

            string opcion="";
            Inventario inventario =new Inventario();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE INVENTARIO");//nombre del programa
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("1-> Productos");
                Console.WriteLine("2-> Ingreso de inventario");
                Console.WriteLine("3-> Salida de inventario");
                Console.WriteLine("4-> Producto en Mal Estado");
                Console.WriteLine("5-> Cambio de Producto en Mal Estado");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion=Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                    {   Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        inventario.listarProductos();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen ;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        inventario.ingresoInventario();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        Console.BackgroundColor = ConsoleColor.Red ;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        inventario.salidaInventario();
                        Console.ReadLine();
                        break;
                    }
                    case "4":
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        inventario.ProductoEnMalEstado();
                        Console.ReadLine();
                        break;
                    }
                    case "5":
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        inventario.CambiodeProductoEnMalEstado();
                        Console.ReadLine();
                        break;
                    }
                    
                    default:
                    break;
                }
                if (opcion=="0")
                {
                    break;
                }
                
            }
            
        }
    }
}