using System;
using System.Collections.Generic;
using System.Text;


namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {

        IPais getPais(string nombrePais);

        IContinente getContinente(string nombreContinente);

        IList<IContinente> getContinentes();

    }
}