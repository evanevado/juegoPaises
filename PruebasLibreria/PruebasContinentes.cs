using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            // a getPais le debe llamar ThrowsException para controlar lo que devuelve
            // thorwsexception espera una funci�n, no un pa�s que es lo que devuelve getPais
            // por eso ponermos ()=>
            // al m�todo throwsexception le pasamos por par�metro lo que tiene que hacer cuando se produzca la excepci�n.  Equivale a un try-catch
            //Action funcionALaQueTienesQueLlamar = recuperarNuevaZelanda;
            //Assert.ThrowsException<KeyNotFoundException>(
            //        funcionALaQueTienesQueLlamar  --> La pasamos como par�metro para que la lance el throwsException
            //    );
            Assert.ThrowsException<KeyNotFoundException>(
                   () => europa.getPais("Nueva Zelanda") //para ahorrarnos definir un nombre de funci�n.  Con () ya le decimos que es una funci�n
                   // y con => la definimos
               );

        }

        void recuperarNuevaZelanda()
        {
            throw new Exception("Nueva Zelanda no existe");
            
        }
    }
}
