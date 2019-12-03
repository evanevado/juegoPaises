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

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = baseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = baseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count,0);
        }

        [TestMethod]
        public void TestEuropa_Espa�a()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = baseDatosGeografica.getContinente("Europa");
            IPais espa�a = europa.getPais("Espa�a");
            Assert.IsNotNull(espa�a);
        }

        [TestMethod]
        public void TestEuropa_NuevaZelanda()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = baseDatosGeografica.getContinente("Europa");
            IPais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.IsNull(nuevaZelanda);
        }
    }
}
