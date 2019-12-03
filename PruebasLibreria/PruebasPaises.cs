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
            
            
            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = baseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = baseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.nombre, "España");
        }
        [TestMethod]
        public void TestEspaña_Continente()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = baseDatosGeografica.getPais("España");
            IContinente europa = baseDatosGeografica.getContinente("Europa"); ;
            Assert.AreEqual(españa.continente, europa);
        }

    }
}
