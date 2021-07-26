using System;
using System.Collections.Generic;  
namespace EjercicioAnimales
{   
    class ListaAnimales
    {
    //Mamiferos
    public List<Perro> ListaPerro { get; set; }
    public List<Gatos> ListaGatos { get; set; }
    public List<Monos> ListaMono { get; set; }
    //Aves
    public List<Aguila> ListaAguila { get; set; }
    public List<Loro> ListaLoro { get; set; }
    //peces
    public List<PezGlobo> ListaPez { get; set; }
    

    public ListaAnimales()
    {
        //Mamiferos
        ListaPerro =new List<Perro>();
        perros();
        ListaGatos = new List<Gatos>();
        Gato();
        ListaMono = new List<Monos>();
        Monos();
        //Aves
        ListaAguila = new List<Aguila>();
        aguila();
        ListaLoro = new List<Loro>();
        loro();
        //peces
        ListaPez = new List<PezGlobo>();
        pezGlobo();

    }
//PERROS
    private void perros()
    {
        Perro a = new Perro ("Cookie", "Macho" , 5, 4,"Viviparo","Digitígrados","Chihuahua");
        ListaPerro.Add(a);
        Perro b = new Perro ("Oso", "Macho" , 2, 4,"Viviparo","Digitígrados","Pastor Aleman");
        ListaPerro.Add(b);
        Perro c = new Perro ("Zafira", "Hembra" , 1, 4,"Viviparo","Digitígrados","Pitbull");
        ListaPerro.Add(c);
        Perro d = new Perro ("Tayson", "Macho" ,7, 4, "Viviparo","Digitígrados","Rottweiler");
        ListaPerro.Add(d);

    }

    public void ListarPerros()
    {
        Console.Clear();
 
        Console.WriteLine("                                    LISTA DE PERROS");
        Console.WriteLine("                                    ===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO | RAZA | COME | CAMINA | LADRA");
        
        foreach (var perros in ListaPerro)

        {
            perros.comer();
            perros.caminar();
            perros.ladrar();
            Console.WriteLine(perros.Nombre+" | "+perros.Sexo+" | "+perros.Edad+" | "+perros.Patas+" | "+perros.Reproduccion+" | "+perros.Desplazamiento+" | "+perros.Raza+" | "+perros.Comer+" | "+perros.Caminar+" | "+perros.Ladrar);
        }
        Console.ReadLine();
    }
//Gatos
   private void Gato()
    {
        Gatos a = new Gatos ("Theo", "Macho" , 1, 4,"Viviparo","Digitígrados");
        ListaGatos.Add(a);
        Gatos b = new Gatos ("Garfield", "Macho" , 3, 4,"Viviparo","Digitígrados");
        ListaGatos.Add(b);
        Gatos c = new Gatos ("Mimi", "Hembra" , 2, 4,"Viviparo","Digitígrados");
        ListaGatos.Add(c);
    }

    public void ListarGatos()
    {
        Console.Clear();
       Console.WriteLine("                                     LISTA DE GATOS");
        Console.WriteLine("                                     ==============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO |COMER | CAMINAR | MAULLAR");
        foreach (var gato in ListaGatos)
        {
            gato.comer();
            gato.caminar();
            gato.maullar();
            Console.WriteLine(gato.Nombre+" | "+gato.Sexo+" | "+gato.Edad+" | "+gato.Patas+" | "+gato.Reproduccion+" | "+gato.Desplazamiento+" | "+gato.Comer+" | "+gato.Caminar+" | "+gato.Maullar);
        }
        Console.ReadLine();
    }
    //Monos
   private void Monos()
    {
        Monos a = new Monos ("Jorge", "Macho" , 1, 2,"Viviparo","Plantígrados");
        ListaMono.Add(a);
        Monos b = new Monos ("Marcel", "Macho" , 5, 2,"Viviparo","Plantígrados");
        ListaMono.Add(b);
        Monos c = new Monos ("Abú", "Macho", 3, 2,"Viviparo", "Plantígrados");
        ListaMono.Add(c);
 
    }

    public void ListarMonos()
    {
        Console.Clear();
        Console.WriteLine("                             LISTA DE MONOS");
        Console.WriteLine("                            ===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | PATAS | REPRODUCCION | DESPLAZAMIENTO | COMER | CAMINA | MAULLA");
        
        foreach (var mono in ListaMono)
        {
            mono.comer();
            mono.caminar();
            mono.maulla();
            Console.WriteLine(mono.Nombre+" | "+mono.Sexo+" | "+mono.Edad+" | "+mono.Patas+" | "+mono.Reproduccion+" | "+mono.Desplazamiento+" | "+mono.Comer+" | "+mono.Caminar+" | "+mono.Maulla);
        }
        Console.ReadLine();
    }  
//Aves
    //Aguila
    private void aguila()
    {
        Aguila a = new Aguila("Águila real", "Macho" , 5,"Blanca");
        ListaAguila.Add(a);
        Aguila b = new Aguila ("Águila imperial ibérica", "Macho" , 2,"Negro");
        ListaAguila.Add(b);
        Aguila c = new Aguila("Águila harpía", "Hembra" , 1,"Cafe");
        ListaAguila.Add(c);
        Aguila d = new Aguila("Águila calva", "Hembra", 3, "Café");
        ListaAguila.Add(d);
    }
    public void ListarAguila()
    {
        Console.Clear();
        Console.WriteLine("                        LISTA DE AGUILAS");
        Console.WriteLine("                        ==============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | COLOR PLUMAJE | COMER | VOLAR| VUELA ALTO");
        
        foreach (var aguilas in ListaAguila)
        {
            aguilas.comer();
            aguilas.volarAlto();
            aguilas.volar();
            Console.WriteLine(aguilas.Nombre+" | "+aguilas.Sexo+" | "+aguilas.Edad+" | "+aguilas.ColorPlumaje+" | "+aguilas.Comer+" | "+aguilas.Volar+" | "+aguilas.VolarAlto);
        }
        Console.ReadLine();
    }  
     private void loro()
    {
        Loro a = new Loro("Lolo", "Macho" , 3,"Verde");
        ListaLoro.Add(a);
        Loro b = new Loro ("Pancha", "Hembra",4,"Verde");
        ListaLoro.Add(b);
        Loro c = new Loro("Perla", "Hembra" , 1,"Azul");
        ListaLoro.Add(c);
    }
    public void ListarLoro()
    {
        Console.Clear();
        Console.WriteLine("                     LISTA DE LOROS");
        Console.WriteLine("                     ===============");
        Console.WriteLine("NOMBRE | SEXO | EDAD | COLOR PLUMAJE | COMER | VOLAR| HABLAR");
        
        foreach (var loros in ListaLoro)
        {
            loros.comer();
            loros.hablar();
            loros.volar();
            Console.WriteLine(loros.Nombre+" | "+loros.Sexo+" | "+loros.Edad+" | "+loros.ColorPlumaje+" | "+loros.Comer+" | "+loros.Volar+" | "+loros.Hablar);
        }
        Console.ReadLine();
    }  


    private void pezGlobo()
    {
        PezGlobo a = new PezGlobo("Flounder", "Macho" , 3, 2);
        ListaPez.Add(a);
        PezGlobo b = new PezGlobo ("Globo", "Macho" , 2, 2);
        ListaPez.Add(b);
        PezGlobo c = new PezGlobo("Marlín", "Hembra" , 1, 2);
        ListaPez.Add(c);
    }
    public void ListarPezGlobo()
    {
        Console.Clear();
        Console.WriteLine("                     LISTA DE PEZ GLOBO");
        Console.WriteLine("                     ==================");
        Console.WriteLine("NOMBRE | SEXO | EDAD | N° ALETAS| COMER | NADAR| INFLARCE");
        
        foreach (var peces in ListaPez)
        {
            peces.comer();
            peces.nadar();
            peces.inflarce();
            Console.WriteLine(peces.Nombre+" | "+peces.Sexo+" | "+peces.Edad+" | "+peces.NumeroAletas+" | "+peces.Comer+" | "+peces.Nadar+" | "+peces.Inflarce);
        }
        Console.ReadLine();
    }  

    



















    }
}