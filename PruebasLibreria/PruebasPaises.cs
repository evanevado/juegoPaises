using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_Capital()
        {
            
            
            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = baseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = baseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }
        [TestMethod]
        public void TestEspa�a_Continente()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais espa�a = baseDatosGeografica.getPais("Espa�a");
            IContinente europa = baseDatosGeografica.getContinente("Europa"); ;
            Assert.AreEqual(espa�a.continente, europa);
        }

    }
}
