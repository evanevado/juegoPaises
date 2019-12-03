using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPartidas
    {

        [TestMethod]
        public void TestRecuperarListaPartidas()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");            
            Assert.IsNotNull(ivan.historicoPartidas);
        }

        [TestMethod]
        public void TestNuevaPartida1()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida= ivan.nuevaPartida(europa);
            Assert.IsNotNull(partida);
        }

        [TestMethod]
        public void TestNuevaPartida2()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");
            int cuantasLlevaba = ivan.historicoPartidas.Count;

            
            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            int cuantasLleva = ivan.historicoPartidas.Count;

            Assert.AreEqual(cuantasLlevaba+1, cuantasLleva);
            Assert.AreEqual(ivan.historicoPartidas[ivan.historicoPartidas.Count - 1], partida);

        }

    }
}
