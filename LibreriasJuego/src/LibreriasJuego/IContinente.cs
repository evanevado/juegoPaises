using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {
        String nombre { get; }
        IList<IPais> paises { get; }
        IPais getPais(string nombrePais);


    }
}
