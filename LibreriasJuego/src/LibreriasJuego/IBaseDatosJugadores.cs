using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosJugadores
    {
        IList<IJugador> getJugadores { get; }

        IJugador nuevoJugador(string nombreJugador);
        IJugador getJugador(string nombreJugador);
        IJugador getOrCreateJugador(string nombreJugador);
       
    }
}
