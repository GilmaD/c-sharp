using System;
using System.Collections.Generic;

public class Clientes
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public double Saldo { get; set; }

    public Clientes(int codigo, string nombre, string telefono, double saldo)
    {
        Codigo=codigo;
        Nombre= nombre;
        Telefono = telefono;
        Saldo =saldo;
        
    }
}