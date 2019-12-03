using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {
        String nombre { get; }
        List<IPais> paises { get; }
        IPais getPais(string nombrePais);


    }
}
