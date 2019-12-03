using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspaña_Capital()
        {
            
            
            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = baseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = baseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.nombre, "España");
        }
        [TestMethod]
        public void TestEspaña_Continente()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais españa = baseDatosGeografica.getPais("España");
            Continente europa = baseDatosGeografica.getContinente("Europa"); ;
            Assert.AreEqual(españa.continente, europa);
        }

    }
}
