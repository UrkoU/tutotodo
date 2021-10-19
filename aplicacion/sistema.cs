using System;
using System.Collections.Generic;
class Sistema
{
    // Datos
    List<int> data = new();
    // Métodos de lenguaje empresarial

    public int SumaDataOno(DataModel data)
    {
        if (data.a > 7)
            return -3;

        return data.a + data.b;
    }
}