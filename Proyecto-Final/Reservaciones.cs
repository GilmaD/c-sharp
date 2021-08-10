using System;
using System.Collections.Generic;

public class Reservaciones
{
    public int  Codigo { get; set; }

    public string NumeroReservacion{ get; set; }

    public DateTime  Fecha { get; set; }

    public Clientes Clientes { get; set; }

    public Hoteles Hoteles { get; set; }

    public Habitaciones_Disponibles Habitaciones_Disponibles { get; set; }

    public List<ReservacionesDetalle> ListaReservacionesDetalle { get; set; }

    public string Descripcion { get; set; }

    public double Descuento { get; set; }

    public double Total { get; set; }

    public double Precio { get; set; }

    public Reservaciones(int codigo,DateTime fecha, string numeroReservacion, Clientes clientes)
     

    {
        Codigo = codigo;
        NumeroReservacion = numeroReservacion;
        Fecha = fecha;
        Clientes = clientes;
        
      
      
      
        ListaReservacionesDetalle = new List<ReservacionesDetalle>();
  
        
        
    }
    
    public void agregarHoteles(Hoteles hoteles)
    {
        
        Descuento = 0.10;
        int nuevoCodigo = ListaReservacionesDetalle.Count+1;
       
        ReservacionesDetalle rD = new ReservacionesDetalle(nuevoCodigo);
        ListaReservacionesDetalle.Add(rD);
        Descuento+=0.10*hoteles.Precio;
        Total=hoteles.Precio-Descuento;
    } 
       
    

}