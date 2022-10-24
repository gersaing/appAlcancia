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
        private clsBILLETE testBillete;
        #endregion
        #region Casos de prueba;
        #region CRUDS
        #region Registradores
        #region Alcancia
        [TestMethod]
        public void uTestRegistrarConAlcanciaInexistente()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testAlcancia = new clsALCANCIA("Otra Alcancia",10,5, new List<int>(3) { 50,500,1000}, new List<int>(2) { 2000, 5000 });
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 }));
            Assert.AreNotEqual(null, testSistema.darAlcancia());
            Assert.AreEqual(0, testSistema.darAlcancia().CompareTo(testAlcancia));
            #endregion
        }

        [TestMethod]
        public void uTestRegistrarConAlcanciaExistenteVacia()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarAlcanciaSinDinero();
            testAlcancia = new clsALCANCIA("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 });
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 }));
            Assert.AreNotEqual(null, testSistema.darAlcancia());
            Assert.AreEqual(0, testSistema.darAlcancia().CompareTo(testAlcancia));
            #endregion
        }
        [TestMethod]
        public void uTestRegistrarConAlcanciaExistenteConDinero()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarAlcanciaSinDinero();
            testAlcancia = new clsALCANCIA("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 });
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testSistema.registrar("Otra Alcancia", 10, 5, new List<int>(3) { 50, 500, 1000 }, new List<int>(2) { 2000, 5000 }));
            Assert.AreNotEqual(null, testSistema.darAlcancia());
            Assert.AreNotEqual(0, testSistema.darAlcancia().CompareTo(testAlcancia));
            #endregion
        }
        #endregion
        #region Moneda
        [TestMethod]
        public void uTestRegistrarMonedaPrimeraOcurrencia()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarDinero();
            testMoneda = new clsMONEDA("COP", 500, 1995);
            int varConteoMonedas = testSistema.darMonedas().Count;
            int varConteoOcurrencias = 0;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("COP", 500, 1995));
            Assert.AreEqual(varConteoMonedas + 1, testSistema.darMonedas().Count);
            foreach (clsMONEDA varItem in testSistema.darMonedas())
                if (varItem.CompareTo(testMoneda) == 0) varConteoOcurrencias++;
            Assert.AreEqual(1, varConteoOcurrencias);
            #endregion
        }
        [TestMethod]
        public void uTestRegistrarMonedaSegundaOcurrencia()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarDinero();
            testMoneda = new clsMONEDA("COP", 200, 1990);
            int varConteoMonedas = testSistema.darMonedas().Count;
            int varConteoOcurrencias = 0;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("COP", 200, 1990));
            Assert.AreEqual(varConteoMonedas + 1, testSistema.darMonedas().Count);
            foreach (clsMONEDA varItem in testSistema.darMonedas())
                if (varItem.CompareTo(testMoneda) == 0) varConteoOcurrencias++;
            Assert.AreEqual(2, varConteoOcurrencias);
            #endregion
        }
        #endregion
        #region Billete
        public void uTestRegistrarBilletePrimeraOcurrencia()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarDinero();
            testBillete = new clsBILLETE("ABC789","COP", 1000,2010,11, 4);
            int varConteoBilletes = testSistema.darBilletes().Count;
            int varConteoOcurrencias = 0;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testSistema.registrar("ABC789", "COP", 1000, 2010, 11, 4));
            Assert.AreEqual(varConteoBilletes + 1, testSistema.darBilletes().Count);
            foreach (clsMONEDA varItem in testSistema.darBilletes())
                if (varItem.CompareTo(testBillete) == 0) varConteoOcurrencias++;
            Assert.AreEqual(1, varConteoOcurrencias);
            #endregion
        }
        public void uTestRegistrarBilleteSegundaOcurrencia()
        {
            #region Configurar
            testSistema = clsSISTEMA.darInstacia();
            testSistema.GenerarDinero();
            testBillete = new clsBILLETE("ABC123", "COP", 1000, 2010, 11, 4);
            int varConteoBilletes = testSistema.darBilletes().Count;
            int varConteoOcurrencias = 0;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testSistema.registrar("ABC123", "COP", 1000, 2010, 11, 4));
            Assert.AreEqual(varConteoBilletes + 1, testSistema.darBilletes().Count);
            foreach (clsMONEDA varItem in testSistema.darBilletes())
                if (varItem.CompareTo(testBillete) == 0) varConteoOcurrencias++;
            Assert.AreEqual(1, varConteoOcurrencias);
            #endregion
        }
        #endregion
        #endregion
        #endregion


        #endregion

    }
}
