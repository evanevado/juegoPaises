using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosJugadores
    {
        List<IJugador> getJugadores { get; }

        IJugador nuevoJugador(string nombreJugador);
        IJugador getJugador(string nombreJugador);
        IJugador getOrCreateJugador(string nombreJugador);
       
    }
}
