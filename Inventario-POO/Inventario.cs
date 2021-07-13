using System;
using System.Collections.Generic;

public class Inventario {

    public List<Producto> ListaProducto { get; set; }
    public Inventario()
    {
     ListaProducto = new List<Producto>();
     Producto a=new Producto ("001","Iphone X", 10 , 0);
     Producto b=new Producto ("002","Lapto DELL", 5 , 0);
     Producto c=new Producto ("003","Monitor samsung", 25 , 0);
     Producto d=new Producto ("004","Mause", 100 , 0);
     Producto e=new Producto ("005","Headset", 25 , 0);

     ListaProducto.Add(a);
     ListaProducto.Add(b);
     ListaProducto.Add(c);
     ListaProducto.Add(d);
     ListaProducto.Add(e);
    }
    
public void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Producto");
            Console.WriteLine("-------------------");
            Console.WriteLine("CODIGO | DESCRIPCION | EXISTENCIA |PRODUCTO DEFECTUOSO ");

     foreach (var producto in ListaProducto)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion +" | "+producto.Existencia.ToString() +" | "+ producto.ProductoDefectuoso.ToString());
        }
}
private void movimientoInventario(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
       foreach (var producto in ListaProducto)
       {
            if (producto.Codigo==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        producto.Existencia=producto.Existencia+cantidad;
                    }
                    else
                    {
                         producto.Existencia=producto.Existencia- cantidad;
                    }
                }
       }
}
       
private void movimientoAjuste(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        foreach (var producto in ListaProducto)
        {
            if (producto.Codigo==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        producto.ProductoDefectuoso=producto.ProductoDefectuoso+ cantidad;
                    }
                    else
                    {
                         producto.ProductoDefectuoso=producto.ProductoDefectuoso- cantidad;
                    }
                }
        }
}
        
public void ingresoInventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("PRODUCTO AGREGADO");
        movimientoInventario(codigo,Int32.Parse(cantidad),"+");
}   
public void salidaInventario(){//Resta  de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que saldra de inventario: ");
        cantidad=Console.ReadLine();
        movimientoInventario(codigo,Int32.Parse(cantidad),"-");
}
public void ProductoEnMalEstado(){// ajuste positivo Producto que se daña en la empresa o biene malo por defectos de fabrica
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto defectuoso: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("HAS AGREGADO PRODUCTOS DEFECTUOSOS A TU INVENTARIO : "+cantidad);
        movimientoAjuste(codigo,Int32.Parse(cantidad),"+");
}

public void CambiodeProductoEnMalEstado(){//Ajuste negativo
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de producto defectuoso para cambio");
        Console.WriteLine("**************************************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que se cambiara: ");
        cantidad=Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("HAS LOGRADO CAMBIAR PRODUCTOS DEFECTUOSOS");
        movimientoAjuste(codigo,Int32.Parse(cantidad),"-");
    }


}