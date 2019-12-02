using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Partida
    {
        Jugador Jugador { get; }
        List<Pregunta> historicoPreguntas { get; }      
        Continente Continente { get; }

        Pregunta nuevaPregunta();

    }
}
