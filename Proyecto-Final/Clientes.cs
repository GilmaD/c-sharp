using System;
using System.Collections.Generic;

public class Clientes
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    

    public Clientes(int codigo, string nombre, string telefono)
    {
        Codigo=codigo;
        Nombre= nombre;
        Telefono = telefono;
        
        
    }
}