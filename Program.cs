using System;


Sistema sistema = new();
Vista _vista = new();
Controlador controlador = new(sistema, _vista);
controlador.Run();