using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Jugador:IJugador
    {
        internal Jugador(String nombre)
        {
            this.nombre = nombre;
            this.historicoPartidas = new List<IPartida>();
        }
        public String nombre { get; } //solo get porque no queremos poder cambiar el nombre.  Sólo desde el constructor
        public List<IPartida> historicoPartidas { get; }
        public IPartida nuevaPartida(IContinente continenteElegido)
        {
            Partida p = new Partida(this, continenteElegido);
            this.historicoPartidas.Add(p);
            return p;
        }


    }

 
}
