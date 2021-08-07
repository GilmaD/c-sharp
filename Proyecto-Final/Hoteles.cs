
public class Hoteles
{
    public int Estrellas { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Hoteles(int estrellas, string nombre, double precio )
    {
        Estrellas=estrellas;
        Nombre=nombre;
        Precio=precio;
    }
}