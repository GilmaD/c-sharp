
public class Hoteles
{
    public int Codigo { get; set; }
    public int Estrellas { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Hoteles(int codigo, string nombre, double precio )
    {
        Codigo=codigo;
        Nombre=nombre;
        Precio=precio;
    }
}