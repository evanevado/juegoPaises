using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Continente
    {
        String nombre { get; }
        List<Pais> paises { get; }
        Pais getPais(string nombrePais);


    }
}
