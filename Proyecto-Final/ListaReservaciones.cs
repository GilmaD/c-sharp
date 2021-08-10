using System;
using System.Collections.Generic;

public class ListaReservaciones 
{
    public  List<Hoteles> ListaHoteles { get; set; }
    public  List<Clientes> ListaClientes { get; set; }
    public  List<Habitaciones_Disponibles>  ListaHabitaciones_Disponibles { get; set; }    
    public  List<Reservaciones> OrdenReservaciones { get; set; }

    public ListaReservaciones()
    {
        ListaHoteles = new List<Hoteles>();
        cargarHoteles();
        ListaClientes = new List<Clientes>();
        cargarClientes();
        ListaHabitaciones_Disponibles = new List<Habitaciones_Disponibles>();
        cargarHabitaciones_Disponibles();
        OrdenReservaciones = new List<Reservaciones>();
        
        
    }
    private void cargarHoteles(){

        Hoteles h1=new Hoteles (1,"MH Boutique Hotel - 2", 1000);
        ListaHoteles.Add(h1);
        Hoteles h2=new Hoteles (2,"Hyatt Place - 3", 5000);
        ListaHoteles.Add(h2);
        Hoteles h3=new Hoteles (3,"Copantl Hotel & Convention Center - 4", 8000);
        ListaHoteles.Add(h3);
        Hoteles h4=new Hoteles (4,"Hilton Princess - 5", 10000);
        ListaHoteles.Add(h4);  
         
        
    }
    public void ListadeHoteles(){
        Console.Clear();
        Console.WriteLine("OPCIONES DE HOTELES");
        Console.WriteLine("°*°*°*°*°*°*°*°*°*°");
        Console.WriteLine("°*°*°*°*°*°*°*°*°*°");
        Console.WriteLine("CODIGO | NOMBRE-ESTRELLAS | PRECIO");
        foreach (var hoteles in ListaHoteles)
        {
            Console.WriteLine(hoteles.Codigo + " | "+hoteles.Nombre + " | "+hoteles.Precio);
        }
    }

    private void cargarClientes()
    {
        Clientes c1=new Clientes (001,"Cris","9893-0151");
        ListaClientes.Add(c1);
        Clientes  c2=new Clientes (002,"Matias","3284-6801");
        ListaClientes.Add(c2);
        Clientes  c3=new Clientes (003,"Clara","8537-1215");
        ListaClientes.Add(c3);
        
    }
    public void ListadeClientes()
    {
        
        Console.Clear();
        Console.WriteLine("LISTA DE CLIENTES");
        Console.WriteLine("°*°*°*°*°*°*°*°*°");
        Console.WriteLine("");
        Console.WriteLine("CODIGO | NOMBRE DEL CLIENTE | TELEFONO DEL CLIENTE");
        foreach (var clientes in ListaClientes)
        {
           Console.WriteLine(clientes.Codigo + " | "+clientes.Nombre+" | "+clientes.Telefono); 
        }
        Console.ReadLine();
    }

    private void cargarHabitaciones_Disponibles()
    {
        Habitaciones_Disponibles d1=new Habitaciones_Disponibles (5,"Individual","Vista al jardin");
        ListaHabitaciones_Disponibles.Add(d1);
        Habitaciones_Disponibles  d2=new Habitaciones_Disponibles (4,"Doble","Vista al mar");
        ListaHabitaciones_Disponibles.Add(d2);
        Habitaciones_Disponibles  d3=new Habitaciones_Disponibles (2,"Familiar","Vista a la ciudad");
        ListaHabitaciones_Disponibles.Add(d3);
        
    }
    public void ListadeHabitaciones_Disponibles()
    {
        Console.Clear();
        Console.WriteLine("HABITACIONES DISPONIBLES");
        Console.WriteLine("°*°*°*°*°*°*°*°*°*°*°*°*");
        Console.WriteLine("");
        Console.WriteLine("CANTIDAD DISPONIBLE | TIPO DE HABITACION | DESCRIPCION");
        foreach (var habitaciones_Disponibles in ListaHabitaciones_Disponibles)
        {
           Console.WriteLine(habitaciones_Disponibles.Cantidad_Disponible + " | "+habitaciones_Disponibles.Tipo_de_Habitacion+" | "+habitaciones_Disponibles.Descripcion); 
        }
        Console.ReadLine();
    }
    
    public void CrearReservaciones()
    {
        
        string codigoCliente = ""; 
        Console.WriteLine("CREANDO RESERVACIONES");
        Console.WriteLine("================");
        Console.WriteLine("Ingrese el codigo del Cliente");
        codigoCliente=Console.ReadLine();

        Clientes clientes = ListaClientes.Find(v=>v.Codigo.ToString()==codigoCliente);
        if (clientes==null)
        {
            Console.WriteLine("Cliente No encontrado");
            Console.ReadLine(); 
            return;
        }
        else
        {
            Console.WriteLine("Clientes: "+ clientes.Nombre);
        }
       
        Console.WriteLine("");

        int nuevoCodigo = OrdenReservaciones.Count + 1;
        
        Reservaciones ReservacionesNueva =new Reservaciones (nuevoCodigo, DateTime.Now ,""+nuevoCodigo, clientes);
        OrdenReservaciones.Add(ReservacionesNueva);

        while (true)
        {  Console.WriteLine("Ingrese el codigo del hotel: ");
           string codigoHoteles = Console.ReadLine();
           Hoteles hoteles = ListaHoteles.Find(p=>p.Codigo.ToString() == codigoHoteles);
            if (hoteles==null)
            {
            Console.WriteLine("Hotel No encontrado");
            Console.ReadLine();
            }else
            {
                ReservacionesNueva.agregarHoteles(hoteles);
                Console.WriteLine("Reservacion Agregado: "+ hoteles.Nombre + " con precio de: "+ hoteles.Precio);
            }

            string continuar = "";
            Console.WriteLine("Desea continuar (s/n): ");
            continuar=Console.ReadLine();
            if (continuar.ToLower()== "n")
            {
                break;
            }
            
        Console.WriteLine("");
        Console.WriteLine("Descuento total: "+ReservacionesNueva.Descuento);
        Console.WriteLine("El total de la reservacion es: "+ReservacionesNueva.Total);
        Console.WriteLine("");

        }
        
    }

    public void ListadeReservaciones()
    {
    Console.Clear();
    Console.WriteLine("                        LISTA DE RESERVACIONES");
    Console.WriteLine("                        °*°*°*°*°*°*°*°*°*°*°*");
    Console.WriteLine("               Numero de reservacion | Fecha de reservacion");
    Console.WriteLine("               °*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*");
  
    
    Console.WriteLine("");
    foreach (var reservaciones in OrdenReservaciones)
    {
        
        Console.WriteLine(reservaciones.NumeroReservacion+" | "+reservaciones.Fecha);
       
          Console.WriteLine("");
        
        Console.WriteLine("Descuento total de reservacion: "+reservaciones.Descuento);
        Console.WriteLine("El total de la reservacion es: "+reservaciones.Total);
        Console.WriteLine("");
    }
     Console.ReadLine();
    }  

}

 





        

    

                       

        