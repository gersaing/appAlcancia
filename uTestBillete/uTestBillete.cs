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
        #endregion
        #endregion
    }
}
