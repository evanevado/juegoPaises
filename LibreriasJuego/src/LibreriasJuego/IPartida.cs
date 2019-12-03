using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPartida
    {
        IJugador Jugador { get; }
        List<IPregunta> historicoPreguntas { get; }      
        IContinente Continente { get; }

        IPregunta nuevaPregunta();
    }
}
