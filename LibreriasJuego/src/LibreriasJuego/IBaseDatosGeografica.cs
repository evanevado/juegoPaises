using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica

    {
        IContinente getContinente (string nombreContinente);
        IPais getPais(string nombrePais);
        List<IContinente> Continentes  { get; }
    }
}
