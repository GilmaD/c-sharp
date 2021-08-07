
public class Habitaciones_Disponibles
{
    
    public int Cantidad_Disponible { get; set; }

    public string Tipo_de_Habitacion { get; set; }

    public string Descripcion { get; set; }

    public Habitaciones_Disponibles(int cantidad_Disponible, string tipo_de_Habitacion,  string descripcion)
    {
        Cantidad_Disponible=cantidad_Disponible;
        Tipo_de_Habitacion=tipo_de_Habitacion;
        Descripcion=descripcion;
        
        
    }
}
