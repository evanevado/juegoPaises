using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface BaseDatosJugadores
    {
        List<Jugador> getJugadores { get; }

        Jugador nuevoJugador(string nombreJugador);
        Jugador getJugador(string nombreJugador);
        Jugador getOrCreateJugador(string nombreJugador);
       
    }
}
