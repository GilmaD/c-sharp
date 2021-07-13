public class Producto
{
    public string Codigo { get; set; }

    public string Descripcion { get; set; }

    public int Existencia { get; set; }

    public int ProductoDefectuoso { get; set; } //existencia de producto malo



    public Producto(string codigo, string descripcion, int existencia, int productoDefectuoso)
    {
        Codigo=codigo;
        Descripcion = descripcion;
        Existencia =existencia;
        ProductoDefectuoso = productoDefectuoso;
    }
}