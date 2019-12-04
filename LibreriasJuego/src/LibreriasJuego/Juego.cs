using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego
    {
        private Juego() {
            // va a ser en el único sitio donde tenemos que modificar la conexión a base de datos
            baseDatosJugadores = new BaseDatosJugadoresRAM();
            baseDatosGeografica = new BaseDatosGeografica();
        }

        private static Juego elJuego;

        public static Juego dameElJuego()
        {
            if (elJuego == null)
            {
                elJuego = new Juego();  // crea un nuevo juego sólo la primera vez.  El resto devuelve el juego que ya tenemos creado
            }
            return elJuego;
            
            
        }

        public IBaseDatosJugadores baseDatosJugadores { get; }
        public IBaseDatosGeografica baseDatosGeografica { get; }
    }
    

}
