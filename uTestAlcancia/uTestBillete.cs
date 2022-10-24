using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;

namespace uTestBillete
{
    [TestClass]
    public class uTestBillete
    {
        #region Atributos de prueba
        private clsBILLETE testBillete;
        #endregion
        #region Casos de prueba
        #region Accesores

        [TestMethod]
        public void uTestDarSerie()
        {
            #region Configurar
            testBillete = new clsBILLETE();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual("ninguna", testBillete.darSerie());
            #endregion
        }
        [TestMethod]
        public void uTestDarMes()
        {
            #region Configurar
            testBillete = new clsBILLETE();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(-1, testBillete.darMes());
            #endregion
        }

        [TestMethod]
        public void uTestDarDia()
        {
            #region Configurar
            testBillete = new clsBILLETE();

            #endregion
            #region Probar y comprobar

            Assert.AreEqual(-1, testBillete.darDia());
            #endregion
        }

        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerDiaValido()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testBillete.ponerDia(2));
            Assert.AreEqual(2, testBillete.darDia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDiaInvalido()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testBillete.ponerDia(32));
            Assert.AreEqual(-1, testBillete.darDia());
            #endregion
        }
        [TestMethod]
        public void uTestPonerMesValido()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testBillete.ponerMes(10));
            Assert.AreEqual(10, testBillete.darMes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerMesInvalido()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testBillete.ponerMes(15));
            Assert.AreEqual(-1, testBillete.darMes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerSerieValida()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testBillete.ponerSerie("ABC677"));
            Assert.AreEqual("ABC677", testBillete.darSerie());
            #endregion
        }
        [TestMethod]
        public void uTestPonerSerieInvalida()
        {
            #region Configurar
            testBillete = new clsBILLETE();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testBillete.ponerSerie("AB$#C&??2!!3"));
            Assert.AreEqual("ninguna", testBillete.darSerie());
            #endregion
        }
        #endregion
        #endregion
    }
}
