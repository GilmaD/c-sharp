public class ReservacionesDetalle
{
    public int NumeroReservacion { get; set; }

    public int Estrellas { get; set; }

    public double Precio { get; set; }

    public Hoteles Hoteles { get; set; }

    public ReservacionesDetalle(int numeroReservacion, int estrellas, Hoteles hoteles)
    {
        NumeroReservacion= numeroReservacion;
        Estrellas=estrellas;
        Hoteles=hoteles;
        Precio=hoteles.Precio;
        
        
    }

}
