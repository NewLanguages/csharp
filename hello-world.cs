using System;

class World{
  void printWorld{
  Console.WriteLine("Hello World!");
}


/// <summary>
///   The main entry point for the application
/// </summary>
[STAThread]
public static void Main(string[] args)
{
  World w = new World();
  w.printWorld();
}
}
