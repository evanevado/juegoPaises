using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Pregunta:IPregunta
    {
        internal Pregunta(IPartida partida, IPais pais)
        {
            this.Partida = partida;
            this.Pais = pais;
            this.IntentosRestantes = 3;
            this.respuestasPropuestas = new List<String>();
            this.acierto = false;
        }

        public IPartida Partida { get; }
        public IPais Pais { get; }     
        public bool acierto { get; private set; }
        public int IntentosRestantes { get; private set; }
        public List<String> respuestasPropuestas { get; }

        public bool proponerRespuesta(String capitalSugerida)
        {
            if (this.IntentosRestantes == 0) throw new Exception("Ruinaca... No te quedan intentos!");

            respuestasPropuestas.Add(capitalSugerida);
            this.IntentosRestantes--;
            this.acierto = (capitalSugerida == this.Pais.capital);
            return acierto;
        }




    }
}
