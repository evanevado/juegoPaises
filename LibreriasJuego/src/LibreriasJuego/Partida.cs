using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    //clase que implementa la interfaz
    public class Partida:IPartida
    {
        static Random generadorNumerosAleatorios = new Random();
        // la partida la crea un jugador.. no me vale private porque sólo partida podría crear una nueva
        // no quiero public porque tampoco quiero que pueda crear todo el mundo
        // si no ponemos nada (equivale a friendly en java) podrían sólos los miembros del paquete... no podría ser utilizado desde pruebaLibreria
        // internal: sólo puede ser llamado desde ficheros que estén en la misma compilación (en la misma dll).  No existe en java
        // protected 
        // 
        internal Partida(IJugador jugador, IContinente continente) {
            this.Jugador = jugador;
            // podríamos poner también Jugador = jugador; porque el atributo se llama de forma distinta al parámetro pasado... no sería necesario el this
            this.Continente = continente;
            this.historicoPreguntas = new List<IPregunta>();


        }
        
        public IJugador Jugador { get; }
        public List<IPregunta> historicoPreguntas { get; }      
        public IContinente Continente { get; }

        public IPregunta nuevaPregunta() {
            int total = this.Continente.paises.Count;
            double numeroAleatorio = Partida.generadorNumerosAleatorios.NextDouble();
            int elElegido = (int)numeroAleatorio * total;

            IPais pais = this.Continente.paises[elElegido];

            IPregunta p = new Pregunta(this,pais);
            historicoPreguntas.Add(p);

            return p;
        }
            
    }
}
