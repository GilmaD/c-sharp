public class Vendedor: Persona
{
    

    public string CodigoVendedor { get; set; }

    public Vendedor(int codigo, string nombre,string codigoVendedor)//constructor
    {
        Codigo=codigo;
        Nombre=nombre;
        CodigoVendedor=codigoVendedor;
    }
    
    
}