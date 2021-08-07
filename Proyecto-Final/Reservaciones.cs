using System;
using System.Collections.Generic;

public class Reservaciones
{
    public int NumeroReservacion{ get; set; }

    public DateTime  Fecha { get; set; }

    public Clientes Clientes { get; set; }

    public Hoteles Hoteles { get; set; }

    public List<ReservacionesDetalle> ListaReservacionesDetalle { get; set; }

    public string Descripcion { get; set; }

    public double Descuento { get; set; }

     public double Total { get; set; }

    public double Precio { get; set; }

    public Reservaciones(int numeroReservacion, DateTime fecha, Clientes clientes, Hoteles hoteles, string descripcion, double precio)

    {
        NumeroReservacion = numeroReservacion;
        Fecha = fecha;
        Clientes = clientes;
        Hoteles = hoteles;
        Descripcion = descripcion; 
        Precio = precio;
        ListaReservacionesDetalle = new List<ReservacionesDetalle>();
  
        
        
    }
    
    public void agregarHoteles(Hoteles hoteles)
    {
        
        Descuento = 0.10;
        int NumeroReservacion = ListaReservacionesDetalle.Count+1;
        ReservacionesDetalle rD = new ReservacionesDetalle(NumeroReservacion,1,hoteles);
        ListaReservacionesDetalle.Add(rD);
        Descuento+=0.10*hoteles.Precio;
        Total=Descuento-hoteles.Precio;
    } 
       
    

}