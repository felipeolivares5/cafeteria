using System;
using System.Collections.Generic;

class empleado
{
  public string nombre { get; set; }
  public string apellido { get; set; }
  
  public empleado(string nombre, string apellido)
  {
    this.nombre = nombre;
    this.apellido = apellido;
  }

  public static void menuempleados(List<empleado> empleados)
  { 
    listar(empleados);
    int opcionempleado = 0;
    do
    {
      Console.Clear();
      Console.WriteLine("Sección empleados");
      Console.WriteLine("Elija una opción de empleado:");
      Console.WriteLine("1 - Listar ");
      Console.WriteLine("2 - Ingresar ");
      Console.WriteLine("3 - editar");
      Console.WriteLine("4 - eliminar");
      Console.WriteLine("5 - Regresar");
      opcionempleado = int.Parse(Console.ReadLine());

      if (opcionempleado == 1)
      {
        Console.WriteLine("Sección listar empleado");
        mostrar(empleados);
        Console.ReadLine();
      }
      if (opcionempleado == 2)
      {
        Console.WriteLine("Sección ingresar nuevo empleado");
        guardar(empleados);
        Console.WriteLine("Los datos del empleado han sido guardados");
        Console.ReadLine();
      }
      if (opcionempleado == 3)
      {
        Console.WriteLine("Sección editar empleado");
        editar(empleados);
        Console.ReadLine();
      }
      if (opcionempleado == 4)
      {
        Console.WriteLine("Sección eliminar empleado");
        eliminar(empleados);
        Console.ReadLine();
      }
      if ((opcionempleado !=1) && (opcionempleado !=2) && (opcionempleado !=3) && (opcionempleado !=4) && (opcionempleado !=5))
      {
        Console.WriteLine(opcionempleado +" no es una opcion valida prueve con (1,2,3,4 o 5)");
        Console.ReadLine();
      }
  
    }while (opcionempleado !=5);
  }

  public static void guardar(List<empleado> empleados)
  {
    Console.WriteLine("Ingrese el nombre del empleado");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del empleado");
    string apellido = Console.ReadLine();
    empleado c1 = new empleado(nombre,apellido);
    empleados.Add(c1);
  }

  public static void mostrar(List<empleado> empleados)
  {
    foreach (var J in empleados)
    {
      Console.WriteLine("---------------------------------------------------------");
      Console.WriteLine("Nombre: "+ J.nombre);
      Console.WriteLine("Apellido: "+ J.apellido);
    }
  }

  public static void editar(List<empleado> empleados)
  {
    int a = 0;
    Console.WriteLine("ingrese el nombre del empleado que desea editar");
    string respuesta = Console.ReadLine();
    foreach (var j1 in empleados)
    {
      if (j1.nombre == respuesta)
      {
        a = 1;
        Console.WriteLine("¿Desea editar a " + j1.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          empleados.Remove(j1);

          Console.WriteLine("Ingrese el nuevo nombre del empleado");
          string nombre = Console.ReadLine();
          Console.WriteLine("Ingrese el nuevo apellido del empleado");
          string apellido = Console.ReadLine();
  
          empleado c2 = new empleado(nombre,apellido);
          empleados.Add(c2);

          Console.WriteLine("Los datos del empleado han sido editados");

          break;
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de empleado");
          break;
        }
      }
    }
  }

  public static void eliminar(List<empleado> empleados)
  {
    int b = 0;
    Console.WriteLine("ingrese el nombre del empleado que desea eliminar");
    string respuesta = Console.ReadLine();
    foreach (var e in empleados)
    {
      if (e.nombre == respuesta)
      {
        b = 1;
        Console.WriteLine("¿Desea eliminar a " + e.nombre +"?"); 
        string confirmar = Console.ReadLine();
        if (confirmar == "si")
        {
          empleados.Remove(e);
          Console.WriteLine("Los datos del empleado han sido eliminados");
          break; 
        }
        if (confirmar == "no")
        {
          Console.WriteLine("operacion cancelada volvera al menu de empleado");
          break;
        }
      } 
    }
    if (b == 0)
    {
     Console.WriteLine("Los datos del empleado no han sido eliminados porque no se ha encontrado el nombre: "+ respuesta);  
    }
  }

  public static void listar(List<empleado> empleados)
  {
    empleado p3 = new empleado("Mariana", "puebla");
    empleados.Add(p3);

    empleado p4 = new empleado("juan", "Fernandez");
    empleados.Add(p4);

    empleado p5 = new empleado("Rodrigo", "gonzales");
    empleados.Add(p5);
  }
}

