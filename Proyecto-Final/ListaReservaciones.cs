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

        Hoteles h1=new Hoteles (2,"MH Boutique Hotel",1000);
        ListaHoteles.Add(h1);
        Hoteles h2=new Hoteles (3,"Hyatt Place",5000);
        ListaHoteles.Add(h2);
        Hoteles h3=new Hoteles (4,"Copantl Hotel & Convention Center",8000);
        ListaHoteles.Add(h3);
        Hoteles h4=new Hoteles (5,"Hilton Princess ",10000);
        ListaHoteles.Add(h4);  
         
        
    }
    public void ListadeHoteles(){
        Console.Clear();
        Console.WriteLine("OPCIONES DE HOTELES");
        Console.WriteLine("°*°*°*°*°*°*°*°*°*°");
        Console.WriteLine("°*°*°*°*°*°*°*°*°*°");
        Console.WriteLine("ESTRELLAS | NOMBRE | PRECIO");
        foreach (var hoteles in ListaHoteles)
        {
            Console.WriteLine (hoteles.Estrellas +" | "+hoteles.Nombre +"  | " +hoteles.Precio);
        }
    }

    private void cargarClientes()
    {
        Clientes c1=new Clientes (001,"Aspen","9893-0151",0);
        ListaClientes.Add(c1);
        Clientes  c2=new Clientes (002,"Lucas","3284-6801",0);
        ListaClientes.Add(c2);
        Clientes  c3=new Clientes (003,"Jack","8537-1215",0);
        ListaClientes.Add(c3);
        
    }
    public void ListadeClientes()
    {
        
        Console.Clear();
        Console.WriteLine("LISTA DE CLIENTES");
        Console.WriteLine("°*°*°*°*°*°*°*°*°");
        Console.WriteLine("");
        Console.WriteLine("CODIGO | NOMBRE DEL CLIENTE | TELEFONO DEL CLIENTE | SALDO DEL CLIENTE");
        foreach (var clientes in ListaClientes)
        {
           Console.WriteLine(clientes.Codigo + " | "+clientes.Nombre+" | "+clientes.Telefono+" | "+clientes.Saldo); 
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

        int NumeroReservacion = OrdenReservaciones.Count + 1;
        
        Reservaciones ReservacionesNueva =new Reservaciones (NumeroReservacion, DateTime.Now ,"SPS"+NumeroReservacion,clientes);
        OrdenReservaciones.Add(ReservacionesNueva);

        while (true)
        {  Console.WriteLine("Ingrese el nombre del hotel: ");
           string nombreHoteles = Console.ReadLine();
           Hoteles hoteles = ListaHoteles.Find(p=>p.Nombre.ToString() == nombreHoteles);
            if (hoteles==null)
            {
            Console.WriteLine("Hotel No encontrado");
            Console.ReadLine();
            }else
            {
                ReservacionesNueva.agregarHoteles(hoteles);
                Console.WriteLine("Reservacion Agregado: "+ hoteles.Nombre + " con precio de: "+ hoteles.Precio);
            }
            

        }
        
    }

    public void ListadeReservaciones()
    {
    Console.Clear();
    Console.WriteLine("             LISTA DE RESERVACIONES");
    Console.WriteLine("             °*°*°*°*°*°*°*°*°*°*°*");
    Console.WriteLine("Numero de reservacion | Fecha | Precio de la reservacion");
    Console.WriteLine("°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°*°");
    Console.WriteLine("             Cliente|Hotel");
    Console.WriteLine("             °*°*°*°*°*°*°");
    Console.WriteLine("");
    foreach (var reservaciones in OrdenReservaciones){
        
        Console.WriteLine(reservaciones.NumeroReservacion+" | "+reservaciones.Fecha+" | "+reservaciones.Precio );
        Console.WriteLine(reservaciones.Clientes.Nombre+" | "+reservaciones.Hoteles.Nombre);

    }

    foreach (var detalle in reservaciones.ListaReservacionesDetalle)
            {
                Console.WriteLine("     "+detalle.Hoteles.Descripcion+" |"+detalle.Precio);
                
            }
        Console.WriteLine("");
        
        Console.WriteLine("Descuento total: "+reservaciones.Descuento);
        Console.WriteLine("El total de la reservacion es: "+reservaciones.Total);
        Console.WriteLine("");
        }
       

}

 





        

    

                       

        