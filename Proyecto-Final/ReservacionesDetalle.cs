public class ReservacionesDetalle
{
    public int NumeroReservacion { get; set; }

    public double Precio { get; set; }

    public Hoteles Hoteles { get; set; }

    public ReservacionesDetalle(int numeroReservacion)
    {
        NumeroReservacion= numeroReservacion;
       
        
        Precio=Precio;
        
        
    }

}
