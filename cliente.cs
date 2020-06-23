using System;
using System.Collections.Generic;

class cliente
{
  public string nombre { get; set; }
  public string apellido { get; set; }
  
  public cliente(string nombre, string apellido)
  {
    this.nombre = nombre;
    this.apellido = apellido;
  }

  public static void menuclientes(List<cliente> clientes)
  { 
    listar(clientes);
    int opcioncliente = 0;
    do
    {
      Console.Clear();
      Console.WriteLine("Sección clientes");
      Console.WriteLine("Elija una opción de cliente:");
      Console.WriteLine("1 - Listar ");
      Console.WriteLine("2 - Ingresar ");
      Console.WriteLine("3 - editar");
      Console.WriteLine("4 - eliminar");
      Console.WriteLine("5 - Regresar");
      opcioncliente = int.Parse(Console.ReadLine());

      if (opcioncliente == 1)
      {
        Console.WriteLine("Sección listar cliente");
        mostrar(clientes);
        Console.ReadLine();
      }
      if (opcioncliente == 2)
      {
        Console.WriteLine("Sección ingresar nuevo cliente");
        guardar(clientes);
        Console.WriteLine("Los datos del cliente han sido guardados");
        Console.ReadLine();
      }
      if (opcioncliente == 3)
      {
        Console.WriteLine("Sección editar cliente");
        editar(clientes);
        Console.ReadLine();
      }
      if (opcioncliente == 4)
      {
        Console.WriteLine("Sección eliminar cliente");
        eliminar(clientes);
        Console.ReadLine();
      }
      if ((opcioncliente !=1) && (opcioncliente !=2) && (opcioncliente !=3) && (opcioncliente !=4) && (opcioncliente !=5))
      {
        Console.WriteLine(opcioncliente +" no es una opcion valida prueve con (1,2,3,4 o 5)");
        Console.ReadLine();
      }
  
    }while (opcioncliente !=5);
  }

  public static void guardar(List<cliente> clientes)
  {
    Console.WriteLine("Ingrese el nombre del cliente");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del cliente");
    string apellido = Console.ReadLine();
    cliente c1 = new cliente(nombre,apellido);
    clientes.Add(c1);
  }

  public static void mostrar(List<cliente> clientes)
  {
    foreach (var J in clientes)
    {
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine("Nombre: "+ J.nombre);
      Console.WriteLine("Apellido: "+ J.apellido);
    }
  }

  public static void editar(List<cliente> clientes)
  {
    int a = 0;
    Console.WriteLine("ingrese el nombre del cliente que desea editar");
    string respuesta = Console.ReadLine();
    foreach (var j1 in clientes)
    {
      if (j1.nombre == respuesta)
      {
        a = 1;
        Console.WriteLine("¿Desea editar a " + j1.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          clientes.Remove(j1);

          Console.WriteLine("Ingrese el nuevo nombre del cliente");
          string nombre = Console.ReadLine();
          Console.WriteLine("Ingrese el nuevo apellido del cliente");
          string apellido = Console.ReadLine();
  
          cliente c2 = new cliente(nombre,apellido);
          clientes.Add(c2);

          Console.WriteLine("Los datos del cliente han sido editados");

          break;
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de cliente");
          break;
        }
      }
    }
  }

  public static void eliminar(List<cliente> clientes)
  {
    int b = 0;
    Console.WriteLine("ingrese el nombre del cliente que desea eliminar");
    string respuesta = Console.ReadLine();
    foreach (var e in clientes)
    {
      if (e.nombre == respuesta)
      {
        b = 1;
        Console.WriteLine("¿Desea eliminar a " + e.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          clientes.Remove(e);
          Console.WriteLine("Los datos del cliente han sido eliminados");
          break; 
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de cliente");
          break;
        }
      } 
    }
    if (b == 0)
    {
     Console.WriteLine("Los datos del cliente no han sido eliminados porque no se ha encontrado el nombre: "+ respuesta);  
    }
  }

  public static void listar(List<cliente> clientes)
  {
    cliente p3 = new cliente("Pedro", "Rodriguez");
    clientes.Add(p3);

    cliente p4 = new cliente("Laura", "Moreno");
    clientes.Add(p4);

    cliente p5 = new cliente("Pablo", "Funez");
    clientes.Add(p5);
  }
}
