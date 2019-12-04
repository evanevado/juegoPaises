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
            // a getPais le debe llamar ThrowsException para controlar lo que devuelve
            // thorwsexception espera una función, no un país que es lo que devuelve getPais
            // por eso ponermos ()=>
            // al método throwsexception le pasamos por parámetro lo que tiene que hacer cuando se produzca la excepción.  Equivale a un try-catch
            //Action funcionALaQueTienesQueLlamar = recuperarNuevaZelanda;
            //Assert.ThrowsException<KeyNotFoundException>(
            //        funcionALaQueTienesQueLlamar  --> La pasamos como parámetro para que la lance el throwsException
            //    );
            Assert.ThrowsException<KeyNotFoundException>(
                   () => europa.getPais("Nueva Zelanda") //para ahorrarnos definir un nombre de función.  Con () ya le decimos que es una función
                   // y con => la definimos
               );

        }

        void recuperarNuevaZelanda()
        {
            throw new Exception("Nueva Zelanda no existe");
            
        }
    }
}
