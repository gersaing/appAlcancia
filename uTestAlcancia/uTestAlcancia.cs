using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using appAlcancia.Dominio;
using System.Collections.Generic;

namespace uTestAlcancia
{
    [TestClass]
    public class uTestAlcancia
    {
        #region Atributos de prueba
        private clsALCANCIA testAlcancia;
        private List<clsMONEDA> testMonedas;
        private List<clsBILLETE> testBilletes;
        private List<int> testDenominacionesMonedas;
        private List<int> testSaldoPorDenominacionMonedas;
        private List<int> testConteoPorDenominacionMonedas;
        private List<int> testDenominacionesBilletes;
        private List<int> testSaldoPorDenominacionBilletes;
        private List<int> testConteoPorDenominacionBilletes;
        private clsMONEDA testMoneda;
        private clsBILLETE testBillete;

        #endregion
        #region Casos de prueba
        #region Accesores 
        #region Propios

        [TestMethod]
        public void uTestDarNombre()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual("Mi Alcancia", testAlcancia.darNombre());
            #endregion
        }
        [TestMethod]
        public void uTestDarCapacidadMonedas()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(22, testAlcancia.darCapacidadMonedas());
            #endregion
        }

        [TestMethod]
        public void uTestDarCapacidadBilletes()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(11, testAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDarDenominacionesMonedas()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDarDenominacionesBilletes()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            #endregion
        }
        #endregion
        #region Derivables
        [TestMethod]
        public void uTestDarSaldoPorDenominacionMonedas()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionMonedas()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoPorDenominacionBilletes()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDarConteoPorDenominacionBilletes()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestDarSaldoTotal()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        #region Asociativos
        public void uTestDarMonedas()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            testMonedas = new List<clsMONEDA>();
            testMonedas.Add(new clsMONEDA("COP", 100, 2011));
            testMonedas.Add(new clsMONEDA("COP", 100, 1999));
            testMonedas.Add(new clsMONEDA("COP", 100, 2010));
            testMonedas.Add(new clsMONEDA("COP", 100, 2000));
            testMonedas.Add(new clsMONEDA("COP", 100, 2009));
            testMonedas.Add(new clsMONEDA("COP", 100, 2010));
            testMonedas.Add(new clsMONEDA("COP", 100, 1999));
            testMonedas.Add(new clsMONEDA("COP", 100, 2010));
            testMonedas.Add(new clsMONEDA("COP", 100, 2000));
            testMonedas.Add(new clsMONEDA("COP", 100, 2009));
            testMonedas.Add(new clsMONEDA("COP", 100, 2010));

            testMonedas.Add(new clsMONEDA("COP", 200, 2010));
            testMonedas.Add(new clsMONEDA("COP", 200, 2011));
            testMonedas.Add(new clsMONEDA("COP", 200, 2010));

            testMonedas.Add(new clsMONEDA("COP", 500, 2010));
            testMonedas.Add(new clsMONEDA("COP", 500, 2011));
            testMonedas.Add(new clsMONEDA("COP", 500, 2010));
            testMonedas.Add(new clsMONEDA("COP", 500, 2010));
            testMonedas.Add(new clsMONEDA("COP", 500, 2011));
            testMonedas.Add(new clsMONEDA("COP", 500, 2010));
            #endregion
            #region Probar y comprobar
            for (int varIterador = 0; varIterador < 20; varIterador++)
            {
                Assert.AreEqual(0, testAlcancia.darMonedas()[varIterador].CompareTo(testMonedas[varIterador]));
            }
            #endregion
        }
        [TestMethod]
        public void uTestDarBilletes()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testBilletes = new List<clsBILLETE>();
            testBilletes.Add(new clsBILLETE("ABC123", "COP", 1000, 2010, 11, 4));
            testBilletes.Add(new clsBILLETE("ABC456", "COP", 1000, 2011, 8, 17));
            testBilletes.Add(new clsBILLETE("ABC789", "COP", 1000, 2009, 12, 27));

            testBilletes.Add(new clsBILLETE("DEF789", "COP", 2000, 2009, 12, 27));
            testBilletes.Add(new clsBILLETE("GHI789", "COP", 2000, 2009, 12, 27));
            testBilletes.Add(new clsBILLETE("NMO789", "COP", 2000, 2009, 12, 27));
            testBilletes.Add(new clsBILLETE("PQR789", "COP", 2000, 2011, 12, 27));
            testBilletes.Add(new clsBILLETE("XYZ789", "COP", 2000, 2019, 12, 27));

            testBilletes.Add(new clsBILLETE("AAX123", "COP", 5000, 2019, 11, 30));
            #endregion
            #region Probar y comprobar
            for (int varIterador = 0; varIterador < 9; varIterador++)
            {
                Assert.AreEqual(0, testAlcancia.darBilletes()[varIterador].CompareTo(testBilletes[varIterador]));
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region Mutadores
        [TestMethod]
        public void uTestPonerNombreCaso1()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ponerNombre("Otra Alcancia"));
            Assert.AreEqual("Otra Alcancia", testAlcancia.darNombre());
            #endregion
        }

        [TestMethod]
        public void uTestPonerNombreCaso2()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ponerNombre("Al#ca%nc#&ia"));
            Assert.AreEqual("Mi Alcancia", testAlcancia.darNombre());
            #endregion
        }


        [TestMethod]
        public void uTestPonerCapacidadMonedasCaso1()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ponerCapacidadMonedas(1000));
            Assert.AreEqual(1000, testAlcancia.darCapacidadMonedas());
            #endregion
        }

        [TestMethod]
        public void uTestPonerCapacidadMonedasCaso2()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ponerCapacidadMonedas(5));
            Assert.AreEqual(22, testAlcancia.darCapacidadMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadBilletesCaso1()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ponerCapacidadBilletes(1000));
            Assert.AreEqual(1000, testAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerCapacidadBilletesCaso2()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ponerCapacidadBilletes(3));
            Assert.AreEqual(11, testAlcancia.darCapacidadBilletes());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionesMonedasCaso1()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testDenominacionesMonedas = new List<int> { 50, 100, 200, 500, 1000 };
            testSaldoPorDenominacionMonedas = new List<int> {0, 1100,600,3000,0 };
            testConteoPorDenominacionMonedas = new List<int> {0,11,3,6,0};
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ponerDenominacionesMonedas(testDenominacionesMonedas));
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoPorDenominacionMonedas, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(testConteoPorDenominacionMonedas, testAlcancia.darConteoPorDenominacionMonedas());
            #endregion
        }

        [TestMethod]
        public void uTestPonerDenominacionesMonedasCaso2()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testDenominacionesMonedas = new List<int> { 100, 200, 500};
            testSaldoPorDenominacionMonedas = new List<int> { 1100, 600, 3000 };
            testConteoPorDenominacionMonedas = new List<int> { 11, 3, 6,  };
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ponerDenominacionesMonedas(new List<int> { 50 , 200, 500}));
            CollectionAssert.AreEqual(testDenominacionesMonedas, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(testSaldoPorDenominacionMonedas, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(testConteoPorDenominacionMonedas, testAlcancia.darConteoPorDenominacionMonedas());
            #endregion
        }
        [TestMethod]
        public void uTestPonerDenominacionesBilletesCaso1()
        {  
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testDenominacionesBilletes = new List<int> { 1000, 2000, 5000, 10000 };
            testSaldoPorDenominacionBilletes = new List<int> { 3000, 10000, 5000 ,0};
            testConteoPorDenominacionBilletes = new List<int> { 3, 5, 1,0 };
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ponerDenominacionesBilletes(testDenominacionesBilletes));
            CollectionAssert.AreEqual(testDenominacionesBilletes, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(testSaldoPorDenominacionBilletes, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(testConteoPorDenominacionBilletes, testAlcancia.darConteoPorDenominacionBilletes());
            #endregion
        }

        [TestMethod]
        public void uTestPonerDenominacionesBilletesCaso2()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testDenominacionesBilletes = new List<int> { 1000, 2000, 5000};
            testSaldoPorDenominacionBilletes = new List<int> { 3000, 10000, 5000 };
            testConteoPorDenominacionBilletes = new List<int> { 3, 5, 1 };
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ponerDenominacionesBilletes(new List<int> { 1000, 2000, 50000 }));
            CollectionAssert.AreEqual(testDenominacionesBilletes, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(testSaldoPorDenominacionBilletes, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(testConteoPorDenominacionBilletes, testAlcancia.darConteoPorDenominacionBilletes());
            #endregion
        }
        #endregion
        #region Constructor
        [TestMethod]
        public void uTestConstructor()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA("Otra Alcancia", 50, 20, new List<int>() { 10, 20 }, new List<int> { 100, 200 });
            #endregion
            #region Probar y comprobar
            Assert.AreEqual("Otra Alcancia", testAlcancia.darNombre());
            Assert.AreEqual(50, testAlcancia.darCapacidadMonedas());
            Assert.AreEqual(20, testAlcancia.darCapacidadBilletes());
            CollectionAssert.AreEqual(new List<int>() { 10, 20 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int>() { 100, 200 }, testAlcancia.darDenominacionesBilletes());
            #endregion
        }
        #endregion
        #region Transacciones
        #region Ingreso de Monedas

        [TestMethod]
        public void uTestIngresoMonedaConDenominacionNoAceptada()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ingresar(new clsMONEDA("COP", 1000, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        public void uTestIngresoMonedaConDenominacionAceptada()
        {
            #region Configurar
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion

            #region Probar y Comprobar
            Assert.AreEqual(true, testAlcancia.ingresar(new clsMONEDA("COP", 200, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 800, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 4, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4900, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22900, testAlcancia.darSaldoTotal());


            #endregion
        }
        [TestMethod]
        public void uTestIngresoMonedaConCapacidadAgotada()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testAlcancia.ponerCapacidadMonedas(20);
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ingresar(new clsMONEDA("COP", 500, 2010)));
            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }

        #endregion
        #region Ingreso de Billetes
        [TestMethod]
        public void uTestIngresoBilleteConDenominacionAceptada()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.ingresar(new clsBILLETE("ABC124", "COP", 1000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 4000,10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 4, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(19000, testAlcancia.darSaldoTotalBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            Assert.AreEqual(23700, testAlcancia.darSaldoTotal());

            #endregion
        }

        [TestMethod]
        public void uTestIngresoBilleteConDenominacionNoAceptada()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();

            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ingresar(new clsBILLETE("ABC124", "COP", 20000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        public void uTestIngresoBilleteConCapacidadAgotada()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testAlcancia.ponerCapacidadBilletes(9);
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.ingresar(new clsBILLETE("ABC124", "COP", 2000, 2010, 12, 27)));
            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }

        #endregion
        #region Retirar Moneda
        [TestMethod]
        public void uTestRetirarMonedaExistente()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testMoneda = null;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.retirar(200, ref testMoneda));
            Assert.AreNotEqual(null, testMoneda);
            Assert.AreEqual(null, testMoneda.darAlcancia());
            Assert.AreEqual(200, testMoneda.darDenominacion());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 400, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 2, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4500, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22500, testAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        public void uTestRetirarMonedaNOExistente()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testMoneda = null;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.retirar(1000, ref testMoneda));
            Assert.AreEqual(null, testMoneda);

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }
        #endregion
        #region Retirar Billete
        [TestMethod]
        public void uTestRetirarBilleteExistente()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testBillete = null;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(true, testAlcancia.retirar(2000, ref testBillete));
            Assert.AreNotEqual(null, testBillete);
            Assert.AreEqual(null, testBillete.darAlcancia());
            Assert.AreEqual(2000, testBillete.darDenominacion());

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 8000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 4, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(16000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(20700, testAlcancia.darSaldoTotal());
            #endregion
        }
        [TestMethod]
        public void uTestRetirarBilleteNOExistente()
        {
            #region Configurar 
            testAlcancia = new clsALCANCIA();
            testAlcancia.Generar();
            testBillete = null;
            #endregion
            #region Probar y comprobar
            Assert.AreEqual(false, testAlcancia.retirar(10000, ref testBillete));
            Assert.AreEqual(null, testBillete);

            CollectionAssert.AreEqual(new List<int> { 100, 200, 500 }, testAlcancia.darDenominacionesMonedas());
            CollectionAssert.AreEqual(new List<int> { 1100, 600, 3000 }, testAlcancia.darSaldoPorDenominacionMonedas());
            CollectionAssert.AreEqual(new List<int> { 11, 3, 6 }, testAlcancia.darConteoPorDenominacionMonedas());
            Assert.AreEqual(4700, testAlcancia.darSaldoTotalMonedas());

            CollectionAssert.AreEqual(new List<int> { 1000, 2000, 5000 }, testAlcancia.darDenominacionesBilletes());
            CollectionAssert.AreEqual(new List<int> { 3000, 10000, 5000 }, testAlcancia.darSaldoPorDenominacionBilletes());
            CollectionAssert.AreEqual(new List<int> { 3, 5, 1 }, testAlcancia.darConteoPorDenominacionBilletes());
            Assert.AreEqual(18000, testAlcancia.darSaldoTotalBilletes());

            Assert.AreEqual(22700, testAlcancia.darSaldoTotal());
            #endregion
        }
        #endregion
        #endregion
        #endregion

    }


}
