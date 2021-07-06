using System;

namespace inventario
{
    class Program
    {


    static string [,] productos = new string [5,4]
        {
            {"001","Iphone X","10","0"},
            {"002","Lapto DELL","5","0"},
            {"003","Monitor samsung","25","0"},
            {"004","Mause","100","0"},
            {"005","Headset","25","0"},
        
        } ;
    static void listarProductos(){
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Producto");
            Console.WriteLine("*******************");
            Console.WriteLine("Codigo | Descripcion  | Existencia | Producto Defectuoso");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine (productos [i, 0] + " |" + productos [i, 1] + " |"+productos[i, 2] + " | "+productos[i, 3]);
            }
        }
    static void movimientoInventario(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        for (int i = 0; i < 5; i++)
            {
                if (productos [i, 0]==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        productos[i, 2]=(Int32.Parse(productos[i, 2])+ cantidad).ToString();
                    }
                    else
                    {
                         productos[i, 2]=(Int32.Parse(productos[i, 2])- cantidad).ToString();
                    }
                    
                    
                }
                
            }
            
        }
    
    static void movimientoAjuste(string codigo, int cantidad, string tipo_movimiento){//Conversion de texto a enteros
        for (int i = 0; i < 5; i++)
            {
                if (productos [i, 0]==codigo)
                {
                    if (tipo_movimiento == "+")
                    {
                        productos[i, 3]=(Int32.Parse(productos[i, 3])+ cantidad).ToString();
                    }
                    else
                    {
                         productos[i, 3]=(Int32.Parse(productos[i, 3])- cantidad).ToString();
                    }
                    
                    
                }
                
            }
            
        }

    static void ingresoInventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        movimientoInventario(codigo,Int32.Parse(cantidad),"+");
}   
     static void salidaInventario(){//suma de inventarios
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto: ");
        cantidad=Console.ReadLine();
        movimientoInventario(codigo,Int32.Parse(cantidad),"-");
}
     static void ProductoEnMalEstado(){// Ajuste Positivo de Inventario
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Ingreso de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto en mal estado: ");
        cantidad=Console.ReadLine();
        movimientoAjuste(codigo,Int32.Parse(cantidad),"+");
}

    static void CambiodeProductoEnMalEstado(){//Ajuste Negativo de Inventario
        string codigo = "";
        string cantidad= "";
        Console.WriteLine("");
        Console.WriteLine("Salida de producto en mal estado para cambio");
        Console.WriteLine("**************************************");
        Console.WriteLine("Ingrese el codigo del producto: ");
        codigo=Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad del producto que se cambiara: ");
        cantidad=Console.ReadLine();
        movimientoAjuste(codigo,Int32.Parse(cantidad),"-");
    }
    static void Main(string[] args)
        {
            string opcion="";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema De Inventario");
                Console.WriteLine("**********************");
                Console.WriteLine("");
                Console.WriteLine("1-> Productos");
                Console.WriteLine("2-> Ingreso de inventario");
                Console.WriteLine("3-> Salida de inventario");
                Console.WriteLine("4-> Producto en Mal Estado");
                Console.WriteLine("5-> Cambio de Producto en Mal Estado");
                Console.WriteLine("0-> Salir");
                Console.WriteLine("Seleccione una opcion: ");
                opcion=Console.ReadLine(); 

                switch (opcion)
                {
                    case "1":
                    {
                        Console.Clear();
                        listarProductos();
                        Console.ReadLine();
                        break;
                    }
                    case "2":
                    {
                        Console.Clear();
                        ingresoInventario();
                        Console.ReadLine();
                        break;
                    }
                    case "3":
                    {
                        Console.Clear();
                        salidaInventario();
                        break;
                    }
                    case "4":
                    {
                        Console.Clear();
                        ProductoEnMalEstado();
                        break;
                    }
                    case "5":
                    {
                        Console.Clear();
                        CambiodeProductoEnMalEstado();
                        break;
                    }
                    
                    default:
                    break;
                }
                if (opcion=="0")
                {
                    break;
                }
                
            }
            
        }
    }
}