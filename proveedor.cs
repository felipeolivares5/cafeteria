using System;
using System.Collections.Generic;

class proveedor
{
  public string nombre { get; set; }
  public string apellido { get; set; }
  
  public proveedor(string nombre, string apellido)
  {
    this.nombre = nombre;
    this.apellido = apellido;
  }

  public static void menuproveedores(List<proveedor> proveedores)
  { 
    listar(proveedores);
    int opcionproveedor = 0;
    do
    {
      Console.Clear();
      Console.WriteLine("Sección proveedores");
      Console.WriteLine("Elija una opción de proveedores:");
      Console.WriteLine("1 - Listar ");
      Console.WriteLine("2 - Ingresar ");
      Console.WriteLine("3 - editar");
      Console.WriteLine("4 - eliminar");
      Console.WriteLine("5 - Regresar");
      opcionproveedor = int.Parse(Console.ReadLine());

      if (opcionproveedor == 1)
      {
        Console.WriteLine("Sección listar proveedor");
        mostrar(proveedores);
        Console.ReadLine();
      }
      if (opcionproveedor == 2)
      {
        Console.WriteLine("Sección ingresar nuevo proveedor");
        guardar(proveedores);
        Console.WriteLine("Los datos del proveedor han sido guardados");
        Console.ReadLine();
      }
      if (opcionproveedor == 3)
      {
        Console.WriteLine("Sección editar proveedor");
        editar(proveedores);
        Console.ReadLine();
      }
      if (opcionproveedor == 4)
      {
        Console.WriteLine("Sección eliminar proveedor");
        eliminar(proveedores);
        Console.ReadLine();
      }
      if ((opcionproveedor !=1) && (opcionproveedor !=2) && (opcionproveedor !=3) && (opcionproveedor !=4) && (opcionproveedor !=5))
      {
        Console.WriteLine(opcionproveedor +" no es una opcion valida prueve con (1,2,3,4 o 5)");
        Console.ReadLine();
      }
  
    }while (opcionproveedor !=5);
  }

  public static void guardar(List<proveedor> proveedores)
  {
    Console.WriteLine("Ingrese el nombre del proveedor");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del proveedor");
    string apellido = Console.ReadLine();
    proveedor c1 = new proveedor(nombre,apellido);
    proveedores.Add(c1);
  }

  public static void mostrar(List<proveedor> proveedores)
  {
    foreach (var J in proveedores)
    {
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine("Nombre: "+ J.nombre);
      Console.WriteLine("Apellido: "+ J.apellido);
    }
  }

  public static void editar(List<proveedor> proveedores)
  {
    int a = 0;
    Console.WriteLine("ingrese el nombre del proveedor que desea editar");
    string respuesta = Console.ReadLine();
    foreach (var j1 in proveedores)
    {
      if (j1.nombre == respuesta)
      {
        a = 1;
        Console.WriteLine("¿Desea editar a " + j1.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          proveedores.Remove(j1);

          Console.WriteLine("Ingrese el nuevo nombre del proveedor");
          string nombre = Console.ReadLine();
          Console.WriteLine("Ingrese el nuevo apellido del proveedor");
          string apellido = Console.ReadLine();
  
          proveedor c2 = new proveedor(nombre,apellido);
          proveedores.Add(c2);

          Console.WriteLine("Los datos del proveedor han sido editados");

          break;
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de proveedor");
          break;
        }
      }
    }
  }

  public static void eliminar(List<proveedor> proveedores)
  {
    int b = 0;
    Console.WriteLine("ingrese el nombre del proveedor que desea eliminar");
    string respuesta = Console.ReadLine();
    foreach (var e in proveedores)
    {
      if (e.nombre == respuesta)
      {
        b = 1;
        Console.WriteLine("¿Desea eliminar a " + e.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          proveedores.Remove(e);
          Console.WriteLine("Los datos del proveedor han sido eliminados");
          break; 
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de proveedor");
          break;
        }
      } 
    }
    if (b == 0)
    {
     Console.WriteLine("Los datos del proveedor no han sido eliminados porque no se ha encontrado el nombre: "+ respuesta);  
    }
  }

  public static void listar(List<proveedor> proveedores)
  {
    proveedor p3 = new proveedor("Mariana", "puebla");
    proveedores.Add(p3);

    proveedor p4 = new proveedor("juan", "Fernandez");
    proveedores.Add(p4);

    proveedor p5 = new proveedor("Rodrigo", "gonzales");
    proveedores.Add(p5);
  }
}

