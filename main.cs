using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  {
    var empleados = new List<empleado>();
    var proveedores = new List<proveedor>(); 
    var clientes = new List<cliente>();
    
    

    int error = 0;
    string opcion = "0";

    Console.Clear();
    Console.WriteLine("__________________________________________");
    Console.WriteLine("|    /☕ /      ___________         /☕ /  |");
    Console.WriteLine("|   /☕ /      |           |       /☕ /   |");
    Console.WriteLine("|  /☕ /       | CAFETERIA |      /☕ /    |");
    Console.WriteLine("| /☕ /        |___________|     /☕ /     |");
    Console.WriteLine("|/☕ /__________________________/☕ /______|");
    Console.WriteLine("   Precione enter para acceder al menu    ");
    Console.ReadLine();
    do
    {
      Console.Clear();
      Console.WriteLine("MENÚ DE CAFETERIA");
      Console.WriteLine("Elija una opción:");
      Console.WriteLine("1 - Empleados");
      Console.WriteLine("2 - Proveedores");
      Console.WriteLine("3 - clientes");
      Console.WriteLine("4 - Salir");
      opcion = Console.ReadLine();
      if (opcion == "1")
      {
        Console.WriteLine("Sección Empleados");
        empleado.menuempleados(empleados);
      }
      if (opcion == "2")
      {
        Console.WriteLine("Sección Proveedores");
        proveedor.menuproveedores(proveedores);
      }
      if (opcion == "3")
      {
        Console.WriteLine("Sección Clientes");
        cliente.menuclientes(clientes);
      }
      if ((opcion !="1") && (opcion !="2") && (opcion !="3") && (opcion !="4"))
      {
        error ++;
        Console.Write("OPCION NO VALIDA");
        for(int f = 1; f<=error; f++)
        {
          Console.Write("!");
        }
        Console.WriteLine("");
        if (error == 4)
        {
          Console.WriteLine("OPCION NO VALIDA");
        }
        if (error > 4)
        {
          Console.WriteLine("OPCION NO VALIDA");
        }
        Console.ReadLine();
      }
    } 
    while (opcion != "4");

  }
}
