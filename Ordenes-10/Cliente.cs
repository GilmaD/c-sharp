using System;


public class Cliente:Persona
{
    public double Saldo { get; set; }

    public Cliente(int codigo, string nombre, string telefono, double saldo)
    {
        Codigo=codigo;
        Nombre= nombre;
        Telefono = telefono;
        Saldo =saldo;
        
    }
}