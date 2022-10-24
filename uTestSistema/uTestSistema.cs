using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;
using System.Collections.Generic;

namespace uTestSistema
{
    [TestClass]
    public class uTestSistema
    {
        #region Atributos de prueba
        private clsSISTEMA testSistema;
        private clsALCANCIA testAlcancia;
        private List<clsMONEDA> testMonedas;
        private List<clsBILLETE> testBilletes;
        private clsMONEDA testMoneda;
        private clsBILLETE testBillte;
        #endregion
        #region Casos de prueba;
        #region CRUDS
        #region Registradores
        #region Alcancia
        [TestMethod]
        public void uTestRegistrarAlcanciaCaso1()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testAlcancia = new clsALCANCIA("Otra Alcancia",10,5, new List<int>(3) { 50,500,1000}, new List<int>(2) { 2000, 5000 });
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 }));
            Assert.AreNotEqual(null, testSistema.darAlcancia());
            Assert.AreEqual(0, testSistema.darAlcancia());
            #endregion
        }
        #endregion
        #endregion
        #endregion


        #endregion
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
