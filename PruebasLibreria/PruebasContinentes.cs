using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {

        [TestMethod]
        public void TestEuropa_Nombre()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = baseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = baseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count,0);
        }

        [TestMethod]
        public void TestEuropa_Espa�a()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = baseDatosGeografica.getContinente("Europa");
            Pais espa�a = europa.getPais("Espa�a");
            Assert.IsNotNull(espa�a);
        }

        [TestMethod]
        public void TestEuropa_NuevaZelanda()
        {

            BaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            Continente europa = baseDatosGeografica.getContinente("Europa");
            Pais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.IsNull(nuevaZelanda);
        }
    }
}
