using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {

        
        [TestMethod]
        public void TestNuevaPregunta()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");
            int cuantasLlevaba = ivan.historicoPartidas.Count;

            
            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();

            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.Pais);

        }

        [TestMethod]
        public void TestRespuestaFallidas()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");
            int cuantasLlevaba = ivan.historicoPartidas.Count;


            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado =  pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);

        }
        [TestMethod]
        public void TestNuevaRespuestasFallidasMultiples()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");
            int cuantasLlevaba = ivan.historicoPartidas.Count;


            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            int intentos = pregunta.IntentosRestantes;
            Assert.AreEqual(intentos, 3);

            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            intentos = pregunta.IntentosRestantes;
            Assert.AreEqual(intentos, 0);

            //pregunta.proponerRespuesta("Ruina");

        }

        [TestMethod]
        public void TestRespuestaCorrecta()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador ivan = baseDatosJugadores.getOrCreateJugador("Ivan");

            IContinente europa = Juego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.Pais.capital);
            Assert.IsTrue(resultado);

        }

    }
}
