using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Continente
    {
        String nombre { get; }
        List<Pais> getPaises();
        Pais getPais(string nombrePais);


    }
}
