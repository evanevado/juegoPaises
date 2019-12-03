using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugador
    {
        //prueba alta

        [TestMethod]
        public void TestAltaJugador()
        {

            BaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador juan = baseDatosJugadores.nuevoJugador("Juan");
            Assert.IsNotNull(juan);
        }
        //prueba recuperación

        [TestMethod]
        public void TestRecuperacionJugador()
        {

            BaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador juan = baseDatosJugadores.getJugador("Juan");
            Assert.IsNotNull(juan);
        }

        [TestMethod]
        public void TestAltayRecuperacionJugador()
        {

            BaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador juan = baseDatosJugadores.getOrCreateJugador("Juan");
            Assert.IsNotNull(juan);
        }

        //prueba nombre

        [TestMethod]
        public void TestNombreJugador()
        {

            BaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            Jugador juan = baseDatosJugadores.getOrCreateJugador("Juan");
            Assert.AreEqual(juan.nombre, "Juan");
        }



        
    }
}
