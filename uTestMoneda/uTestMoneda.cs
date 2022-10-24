using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestMoneda
{
    [TestClass]
    public class uTestMoneda
    {
        #region Atributos de prueba
        private clsMONEDA testMoneda;
        #endregion
        #region Casos de prueba
        #region Accesores
        #region Propios
        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual("n.n", testMoneda.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarDenominacion()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(0, testMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestDarAño()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(0, testMoneda.darAño());
            #endregion
        }
        #endregion
        #region Asociativos
        [TestMethod]
        public void uTestDarAlcanciaCaso1()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(null, testMoneda.darAlcancia());
            #endregion
        }
        [TestMethod]
        public void uTestDarAlcanciaCaso2()
        {
            #region Configurar
            testMoneda = new clsMONEDA();
            testMoneda.Generar();
            #endregion
            #region Probar y comprobar

            Assert.AreNotEqual(null, testMoneda.darAlcancia());
            #endregion
        }
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerNombreValido()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(true, testMoneda.ponerNombre("COP"));
            Assert.AreEqual("COP", testMoneda.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestPonerNombreInvalido()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerNombre("FRE#$%&"));
            Assert.AreEqual("n.n", testMoneda.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestPonerNombreValidoMonedaEnAlcancia()
        {
            #region Configurar
            testMoneda = new clsMONEDA();
            testMoneda.Generar();
            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerNombre("COP"));
            Assert.AreEqual("n.n", testMoneda.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionValida()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(true, testMoneda.ponerDenominacion(100));
            Assert.AreEqual(100, testMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionInvalida()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerDenominacion(-2000));
            Assert.AreEqual(0, testMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionValidaMonedaEnAlcancia()
        {
            #region Configurar
            testMoneda = new clsMONEDA();
            testMoneda.Generar();
            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerDenominacion(500));
            Assert.AreEqual(0, testMoneda.darDenominacion());
            #endregion
        }
        [TestMethod]
        public void uTestPonerAñoValido()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(true, testMoneda.ponerAño(2021));
            Assert.AreEqual(2021, testMoneda.darAño());
            #endregion
        }
        [TestMethod]
        public void uTestPonerAñoInvalido()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerAño(-10000));
            Assert.AreEqual(0, testMoneda.darAño());
            #endregion
        }
        [TestMethod]
        public void uTestPonerAñoFuturo()
        {
            #region Configurar
            testMoneda = new clsMONEDA();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(false, testMoneda.ponerAño(2030));
            Assert.AreEqual(0, testMoneda.darAño());
            #endregion
        }
        #endregion
        #region Constructor Parametrizado
        [TestMethod]
        public void uTestConstructorParametrizado()
        {
            #region Configurar
            #endregion
            #region Probar y comprobar

            testMoneda = new clsMONEDA("COP", 1000, 2000);
            Assert.AreEqual("COP", testMoneda.darNombre());
            Assert.AreEqual(1000, testMoneda.darDenominacion());
            Assert.AreEqual(2000, testMoneda.darAño());
            #endregion
        }
        #endregion
        #endregion
    }
}
 