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
            
            
            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = baseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = baseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }
        [TestMethod]
        public void TestEspa�a_Continente()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = baseDatosGeografica.getPais("Espa�a");
            Continente europa = baseDatosGeografica.getContinente("Europa"); ;
            Assert.AreEqual(espa�a.continente, europa);
        }

    }
}
