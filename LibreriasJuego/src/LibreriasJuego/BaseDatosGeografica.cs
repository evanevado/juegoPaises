using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface BaseDatosGeografica

    {
        Continente getContinente (string nombreContinente);
        Pais getPais(string nombrePais);
        List<Continente> Continentes  { get; }
    }
}
