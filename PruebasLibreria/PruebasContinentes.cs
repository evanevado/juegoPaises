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
        public void TestEuropa_España()
        {

            IBaseDatosGeografica baseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = baseDatosGeografica.getContinente("Europa");
            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
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
