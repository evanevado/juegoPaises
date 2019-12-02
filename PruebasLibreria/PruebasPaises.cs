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
            Juego.dameElJuego();
            
            BaseDatosGeografica baseDatosGeografica = null;
            Pais espa�a = baseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            Pais espa�a = null;
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }
        [TestMethod]
        public void TestEspa�a_Continente()
        {
            Pais espa�a = null;
            Continente europa = null;
            Assert.AreEqual(espa�a.continente, europa);
        }
    }
}
