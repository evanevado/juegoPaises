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

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador juan = baseDatosJugadores.nuevoJugador("Juan");
            Assert.IsNotNull(juan);
        }
        //prueba recuperación

        [TestMethod]
        public void TestRecuperacionJugador()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador juan = baseDatosJugadores.getJugador("Juan");
            Assert.IsNotNull(juan);
        }

        [TestMethod]
        public void TestAltayRecuperacionJugador()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador juan = baseDatosJugadores.getOrCreateJugador("Juan");
            Assert.IsNotNull(juan);
        }

        //prueba nombre

        [TestMethod]
        public void TestNombreJugador()
        {

            IBaseDatosJugadores baseDatosJugadores = Juego.dameElJuego().baseDatosJugadores;
            IJugador juan = baseDatosJugadores.getOrCreateJugador("Juan");
            Assert.AreEqual(juan.nombre, "Juan");
        }



        
    }
}
