using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        Partida Partida { get; }
        Pais Pais { get; }     
        bool acierto { get; }
        int IntentosRestantes { get; }
        List<String> respuestasPropuestas { get; }

        bool proponerRespuesta(String capitalSugerida);



    }
}
