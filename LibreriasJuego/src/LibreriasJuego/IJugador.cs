using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IJugador
    {
        string nombre { get; } //solo get porque no queremos poder cambiar el nombre
        List<IPartida> historicoPartidas { get; }
        IPartida nuevaPartida(IContinente continenteElegido);


    }

 
}
