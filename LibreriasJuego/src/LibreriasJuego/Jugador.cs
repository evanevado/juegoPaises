using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Jugador
    {
        String nombre { get; } //solo get porque no queremos poder cambiar el nombre
        List<Partida> historicoPartidas { get; }
        Partida nuevaPartida(Continente continenteElegido);


    }

 
}
