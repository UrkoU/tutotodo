using System;


Sistema sistema = new();
Vista vista = new();
Controlador controlador = new(sistema, vista);
controlador.Run();

Console.WriteLine("Agur World!");