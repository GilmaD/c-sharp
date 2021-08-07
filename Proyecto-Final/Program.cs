using System;


namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ListaReservaciones a = new ListaReservaciones();
            string opcion="";

            while (true)
            {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("°*°*°*°*°*°*°*°*°*°*°*°*°*°");
            Console.WriteLine("     MENU PRINCIPAL");
            Console.WriteLine("°*°*°*°*°*°*°*°*°*°*°*°*°*°");
            Console.WriteLine("");
            Console.WriteLine("+ 1 ->Lista de Hoteles");
            Console.WriteLine("+ 2 ->Crear Reservacion");
            Console.WriteLine("+ 4 ->Registro de Clientes");
            Console.WriteLine("+ 3 ->Lista de Habitaciones Disponibles");
            Console.WriteLine("+ 5 ->Registro de Reservaciones");
            Console.WriteLine("+ 0-> Salir");
            Console.WriteLine("Seleccione una opcion: ");
            opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1":

                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    a.ListadeHoteles();
                    Console.ReadLine();
                    break;
                }   

                case "2":

                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    a.CrearReservaciones();
                    break;
                }

                case "3":

                {

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    a.ListadeClientes();
                    break;
                }

                case "4":

                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    a.ListadeHabitaciones_Disponibles();
                    break;
                }

                case "5":

                {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Gray;
                a.ListadeReservaciones();
                break;
                
                }
                
                default:
                break;
            }
            if(opcion=="0")
            {
                break;
            }

            }
            
        }
    }
}