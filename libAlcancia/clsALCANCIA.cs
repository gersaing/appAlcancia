using Servicios.Colecciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace appAlcancia.Dominio
{
    public class clsALCANCIA :IComparable
    {
        #region ATRIBUTOS
        #region Propios
        private string atrNombre = "ninguno";
        private int atrCapacidadMonedas ;
        private List<int> atrDenominacionesAceptadasMonedas ;
        private int atrCapacidadBilletes ;
        private List<int> atrDenominacionesAceptadasBilletes ;
        #endregion
        #region Derivables
        private List<int> atrSaldoPorDenominacionMonedas ;
        private List<int> atrConteoPorDenominacionMonedas ;
        private int atrSaldoTotalMonedas ;
        private List<int> atrSaldoPorDenominacionBilletes ;
        private List<int> atrConteoPorDenominacionBilletes ;
        private int atrSaldoTotalBilletes ;
        private int atrSaldoTotal ;
        #endregion
        #region Asociativos
        private List<clsMONEDA> atrMonedas = null;
        private List<clsBILLETE> atrBilletes = null;
        #endregion
        #endregion
        #region Métodos
        #region Constructores
        public clsALCANCIA(){} 
        /// <summary>
        /// El proposito de este método consiste en crear una nueva instancia de Alcancia
        /// </summary>
        /// <param name="prmNombre">El nombre que el usuario quiere asignar a su nueva Alcancia</param>
        /// <param name="prmCapacidadMonedas">Indica cuantas monedas admite la alcancia para todas las denominaciones. No puede ser negativa</param>
        /// <param name="prmCapacidadBilletes">Indica cuantos billetes admite la alcancia para todas las denominaciones. No puede ser negativa</param>
        /// <param name="prmDenMonedas">Especifica las denominaciones (de moneda) aceptadas por la alcancia</param>
        /// <param name="prmDenBilletes">Especifica las denominaciones (de billete) aceptadas por la alcancia</param>
        public clsALCANCIA(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int>prmDenMonedas, List<int> prmDenBilletes)
        {   
            this.atrNombre = prmNombre;
            this.atrCapacidadMonedas = prmCapacidadMonedas;
            this.atrCapacidadBilletes = prmCapacidadBilletes;
            this.atrDenominacionesAceptadasMonedas = prmDenMonedas;
            this.atrDenominacionesAceptadasBilletes = prmDenBilletes;
            
            
        }
        public void Generar()
        {
            atrNombre = "Mi Alcancia";
            atrCapacidadMonedas = 22;
            atrCapacidadBilletes = 11;

            #region Universo Monedas
            atrDenominacionesAceptadasMonedas = new List<int> { 100, 200, 500 };
            atrSaldoPorDenominacionMonedas = new List<int> { 1100, 600, 3000 };
            atrConteoPorDenominacionMonedas = new List<int> { 11, 3, 6 };
            atrSaldoTotalMonedas = 4700;
            atrMonedas = new List<clsMONEDA>();
            atrMonedas.Add(new clsMONEDA("COP", 100, 2011));
            atrMonedas.Add(new clsMONEDA("COP", 100, 1999));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2000));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2009));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 100, 1999));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2000));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2009));
            atrMonedas.Add(new clsMONEDA("COP", 100, 2010));

            atrMonedas.Add(new clsMONEDA("COP", 200, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 200, 2011));
            atrMonedas.Add(new clsMONEDA("COP", 200, 2010));

            atrMonedas.Add(new clsMONEDA("COP", 500, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 500, 2011));
            atrMonedas.Add(new clsMONEDA("COP", 500, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 500, 2010));
            atrMonedas.Add(new clsMONEDA("COP", 500, 2011));
            atrMonedas.Add(new clsMONEDA("COP", 500, 2010));
            #endregion
            #region Universo Billetes
            atrDenominacionesAceptadasBilletes = new List<int> { 1000, 2000, 5000 };
            atrSaldoPorDenominacionBilletes = new List<int> { 3000, 10000, 5000 };
            atrConteoPorDenominacionBilletes = new List<int> { 3, 5, 1 };
            atrSaldoTotalBilletes = 18000;

            atrBilletes = new List<clsBILLETE>();
            atrBilletes.Add(new clsBILLETE("ABC123", "COP", 1000, 2010, 11, 4));
            atrBilletes.Add(new clsBILLETE("ABC456", "COP", 1000, 2011, 8, 17));
            atrBilletes.Add(new clsBILLETE("ABC789", "COP", 1000, 2009, 12, 27));

            atrBilletes.Add(new clsBILLETE("DEF789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBILLETE("GHI789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBILLETE("NMO789", "COP", 2000, 2009, 12, 27));
            atrBilletes.Add(new clsBILLETE("PQR789", "COP", 2000, 2011, 12, 27));
            atrBilletes.Add(new clsBILLETE("XYZ789", "COP", 2000, 2019, 12, 27));

            atrBilletes.Add(new clsBILLETE("AAX123", "COP", 5000, 2019, 11, 30));
            #endregion

            atrSaldoTotal = 22700;
        }
        #endregion
        #region Accesores
        #region Propios
        /// <summary>
        /// Retorna el nombre dado a la alcancia dado en el momento de su creacion
        /// </summary>
        /// <returns>Cadena de texto</returns>
        public string darNombre()
        {
            return atrNombre;
        }
          
        /// <summary>
        /// Retorna la capacidad (en monedas) que tiene la alcancia en el momento de su creacion
        /// </summary>
        /// <returns>Entero</returns>
        public int darCapacidadMonedas()
        {
        return atrCapacidadMonedas;
        }
        /// <summary>
        /// Retorna la capacidad (en billetes) que tiene la alcancia en el momento de su creacion
        /// </summary>
        /// <returns>Entero</returns>
        public int darCapacidadBilletes()
        {
        return atrCapacidadBilletes;
        }
        /// <summary>
        /// Retorna una lista que contiene las denominaciones (en monedas) que son aceptadas por la alcancia en el momento de su creacion
        /// </summary>
        /// <returns>Lista de enteros</returns>
        public List<int> darDenominacionesMonedas()
        {
        return atrDenominacionesAceptadasMonedas;
        }
        /// <summary>
        /// Retorna una lista que contiene las denominaciones (en billetes) que son aceptadas por la alcancia en el momento de su creacion
        /// </summary>
        /// <returns>Una Lista de enteros</returns>
        public List<int> darDenominacionesBilletes()
        {
        return atrDenominacionesAceptadasBilletes;
        }
        #endregion
        #region Derivables
        /// <summary>
        /// Retorna el saldo de monedas por cada denominacion aceptada por la Alcancia
        /// </summary>
        /// <returns>Lista de enteros</returns>
        public List<int> darSaldoPorDenominacionMonedas()
        {
            darConteoPorDenominacionMonedas();
            atrSaldoPorDenominacionMonedas.Clear();
            for(int i = 0; i < atrDenominacionesAceptadasMonedas.Count; i++)
            {
                atrSaldoPorDenominacionMonedas.Add(atrConteoPorDenominacionMonedas[i] * atrDenominacionesAceptadasMonedas[i]);
            }

        return atrSaldoPorDenominacionMonedas;
        }
        /// <summary>
        /// Retorna el conteo de monedas por cada denominacion aceptada por la alcancia
        /// </summary>
        /// <returns>Lista de enteros</returns>
        public List<int> darConteoPorDenominacionMonedas()
        {
            atrConteoPorDenominacionMonedas.Clear();
            for(int i = 0; i < atrDenominacionesAceptadasMonedas.Count; i++)
            {
                atrConteoPorDenominacionMonedas.Add(contarMonedasPorDenominacion(atrDenominacionesAceptadasMonedas[i]));
            }
        return atrConteoPorDenominacionMonedas;
        }
        /// <summary>
        /// Retorna el saldo de billetes por cada denominacion aceptada por la Alcancia
        /// </summary>
        /// <returns>Lista de enteros</returns>
        public List<int> darSaldoPorDenominacionBilletes()
        {
            darConteoPorDenominacionBilletes();
            atrSaldoPorDenominacionBilletes.Clear();
            for (int i = 0; i < atrDenominacionesAceptadasBilletes.Count; i++)
            {
                atrSaldoPorDenominacionBilletes.Add(atrConteoPorDenominacionBilletes[i] * atrDenominacionesAceptadasBilletes[i]);
            }

            return atrSaldoPorDenominacionBilletes;
        }
        /// <summary>
        /// Retorna el conteo de billetes por cada denominacion aceptada por la alcancia
        /// </summary>
        /// <returns>Lista de enteros</returns>
        public List<int> darConteoPorDenominacionBilletes()
        {
            atrConteoPorDenominacionBilletes.Clear();
            for (int i = 0; i < atrDenominacionesAceptadasBilletes.Count; i++)
            {
                atrConteoPorDenominacionBilletes.Add(contarBilletesPorDenominacion(atrDenominacionesAceptadasBilletes[i]));
            }
            return atrConteoPorDenominacionBilletes;
        }
        /// <summary>
        /// Retorna el saldo total de monedas que tiene la alcancia para todas las denominacones
        /// </summary>
        /// <returns>Entero</returns>
        public int darSaldoTotalMonedas()
        {
            atrSaldoTotalMonedas = 0;
            for(int i = 0; i < atrSaldoPorDenominacionMonedas.Count; i++)
            {
                atrSaldoTotalMonedas = atrSaldoTotalMonedas + atrSaldoPorDenominacionMonedas[i];
            }
            return atrSaldoTotalMonedas;
        }
        /// <summary>
        /// Retorna el saldo total de billetes que tiene la alcancia para todas las denominacones
        /// </summary>
        /// <returns>Entero</returns>
        public int darSaldoTotalBilletes()
        {
            atrSaldoTotalBilletes = 0;
            for(int i = 0; i < atrSaldoPorDenominacionBilletes.Count; i++)
            {
                atrSaldoTotalBilletes = atrSaldoTotalBilletes + atrSaldoPorDenominacionBilletes[i];
            }
            return atrSaldoTotalBilletes;
        }
        /// <summary>
        /// Retorna el saldo total de monedas y billetes que tiene almacenada la alcancia para todas las denominaciones
        /// </summary>
        /// <returns>Entero</returns>
        public int darSaldoTotal()
        {
            darSaldoPorDenominacionMonedas();
            darSaldoPorDenominacionBilletes();
            atrSaldoTotal = atrSaldoTotalMonedas + atrSaldoTotalBilletes;

            return atrSaldoTotal;
        }
        #endregion
        #region Asociativos
        /// <summary>
        /// Retorna la coleccion (en modo lectura) de monedas almacenadas en la alcancia
        /// </summary>
        /// <returns>Lista de Monedas</returns>
        public List<clsMONEDA> darMonedas()
        {
        return atrMonedas;
        }
        /// <summary>
        /// Retorna la coleccion (en modo lectura) de billetes almacenadas en la alcancia
        /// </summary>
        /// <returns>Lista de billetes</returns>
        public List<clsBILLETE> darBilletes()
        {
        return atrBilletes;
        }
        #endregion
        #region Consultores
        
        public int CompareTo(Object prmObjeto)
        {   
            try
            {
                clsALCANCIA varObjeto = (clsALCANCIA)Convert.ChangeType(prmObjeto, typeof(clsALCANCIA));
                if (this.atrNombre == varObjeto.atrNombre &&
                    this.atrCapacidadMonedas == varObjeto.atrCapacidadMonedas &&
                    this.atrCapacidadBilletes == varObjeto.atrCapacidadBilletes &&
                    clsBrokerLista.sonListasIguales(this.atrDenominacionesAceptadasMonedas, varObjeto.atrDenominacionesAceptadasMonedas) &&
                    clsBrokerLista.sonListasIguales(this.atrConteoPorDenominacionMonedas, varObjeto.atrConteoPorDenominacionMonedas)&&
                    clsBrokerLista.sonListasIguales(this.atrSaldoPorDenominacionMonedas, varObjeto.atrSaldoPorDenominacionMonedas)&&
                    clsBrokerLista.sonListasIguales(this.atrDenominacionesAceptadasBilletes, varObjeto.atrDenominacionesAceptadasBilletes) &&
                    clsBrokerLista.sonListasIguales(this.atrConteoPorDenominacionBilletes, varObjeto.atrConteoPorDenominacionBilletes)&&
                    clsBrokerLista.sonListasIguales(this.atrSaldoPorDenominacionBilletes, varObjeto.atrSaldoPorDenominacionBilletes)&&
                    clsBrokerLista.sonListasIguales(this.atrMonedas, varObjeto.atrMonedas) &&
                    clsBrokerLista.sonListasIguales(this.atrBilletes, varObjeto.atrBilletes)
                    )
                    return 0;
                if (this.atrCapacidadMonedas + this.atrCapacidadBilletes > varObjeto.atrCapacidadMonedas + varObjeto.atrCapacidadBilletes)
                    return 1;
                return -1;
            }
            catch { return 99; }
            
        }
        
        #endregion
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica el nombe asignado a la Alcancia en el momento de su creacion o posterior
        /// </summary>
        /// <param name="prmValor">Nuevo nombre para la alcancia</param>
        /// <returns>True si el nombre para la Alcancia cumple con las reglas. False de lo contrario</returns>
        public bool ponerNombre(string prmValor)
        {
            var withoutSpecial = new string(prmValor.Where(c => Char.IsLetterOrDigit(c)
                                            || Char.IsWhiteSpace(c)).ToArray());
            if (prmValor == withoutSpecial)
            {
                atrNombre = prmValor;
                return true;
            }
            return false;          
        
        }
        /// <summary>
        /// Ajusta la capacidad de monedas establecida para la Alcancia por una capacidad mayor
        /// </summary>
        /// <param name="prmValor">Capacidad. Debe ser mayor que la capacidad anterior</param>
        /// <returns>True si tuvo exito. Falso de lo contrario</returns>
        public bool ponerCapacidadMonedas(int prmValor)
        {
             
            if(atrMonedas.Count <= prmValor)
            {
            atrCapacidadMonedas = prmValor;
            return true;
            }else
            {
            return false;
            }
        }
        /// <summary>
        /// Ajusta la capacidad de billetes establecida para la Alcancia por una capacidad mayor
        /// </summary>
        /// <param name="prmValor">Capacidad. Debe ser mayor que la capacidad anterior</param>
        /// <returns>True si tuvo exito. Falso de lo contrario</returns>
        public bool ponerCapacidadBilletes(int prmValor)
        {
            if (atrBilletes.Count <= prmValor)
            {
                atrCapacidadBilletes = prmValor;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Establece una nueva coleccion de donominaciones aceptadas para Monedas
        /// </summary>
        /// <param name="prmColeccion">Nueva colleccion de monedas la cual no debe presentar conflictos con la coleccion actual</param>
        /// <returns>True si se puede realizar el cambio. False de lo contrario</returns>
        public bool ponerDenominacionesMonedas(List<int>prmColeccion)
        {
               
            List<int> monedasConSaldo = denMonedasConSaldo(atrMonedas);

            if (monedasConSaldo.Count > 0)
            {
                for(int i = 0; i < monedasConSaldo.Count; i++)
                {  
                    if (buscarDenMonedas(monedasConSaldo[i], prmColeccion)==false)
                    {
                        return false;
                    } 
                }
                atrDenominacionesAceptadasMonedas = prmColeccion;
                return true;
            }
            else
            {
                atrDenominacionesAceptadasMonedas = prmColeccion;
                return true;
            }
        }
        /// <summary>
        /// Establece una nueva coleccion de donominaciones aceptadas para Billetes
        /// </summary>
        /// <param name="prmColeccion">Nueva colleccion de billetes la cual no debe presentar conflictos con la coleccion actual</param>
        /// <returns>True si se puede realizar el cambio. False de lo contrario</returns>
        public bool ponerDenominacionesBilletes(List<int> prmColeccion)
        {
            List<int> denominaciones = denBilletesConSaldo(atrBilletes);

            if (denominaciones.Count > 0)
            {
                for (int i = 0; i < denominaciones.Count; i++)
                {
                    if (buscarDenBilletes(denominaciones[i], prmColeccion) == false)
                    {
                        return false;
                    }
                }
                atrDenominacionesAceptadasBilletes = prmColeccion;
                return true;
            }
            else
            {
                atrDenominacionesAceptadasBilletes = prmColeccion;
                return true;
            }
        }
        #endregion
        #region Transacciones
        /// <summary>
        /// Metodo que nos premite engresar monedas a nuestra Alcancia
        /// </summary>
        /// <param name="prmMoneda">Moneda a ingresas</param>
        /// <returns>True si la denominacion de la moned es valida y se puede realizar el ingreso. False de lo contrario</returns>
        public bool ingresar(clsMONEDA prmMoneda)
        {
            for(int i = 0; i < atrDenominacionesAceptadasMonedas.Count; i++)
            {
                if(prmMoneda.darDenominacion() == atrDenominacionesAceptadasMonedas[i] && atrMonedas.Count < atrCapacidadMonedas)
                {   
                    atrMonedas.Add(prmMoneda);
                    prmMoneda.ponerAlcancia(this);
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        ///  Metodo que nos premite engresar billetes a nuestra Alcancia
        /// </summary>
        /// <param name="prmBillete"></param>
        /// <returns>True si la denominacion del billete es valida y se puede realizar el ingreso. False de lo contrario</returns>
        public bool ingresar(clsBILLETE prmBillete)
        {
            for (int i = 0; i < atrDenominacionesAceptadasBilletes.Count; i++)
            {
                if (prmBillete.darDenominacion() == atrDenominacionesAceptadasBilletes[i] && atrBilletes.Count < atrCapacidadBilletes)
                {
                    atrBilletes.Add(prmBillete);
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Metodo que nos sirve para realizar el retiro de una denominacion(moneda) de la alcancia.
        /// </summary>
        /// <param name="prmDenominacion">denominacion a retirar</param>
        /// <param name="prmObjeto">referencia a la alcancia </param>
        /// <returns>True si se puede realizar el retiro.False de lo contrario</returns>
        public bool retirar(int prmDenominacion,ref clsMONEDA prmObjeto)
        {
            if (!atrDenominacionesAceptadasMonedas.Contains(prmDenominacion))
            {
                return false;
            }
            for (int moneda = 0; moneda < atrMonedas.Count; moneda++)
            {
                if (atrMonedas[moneda].darDenominacion() == prmDenominacion)
                {
                    atrMonedas[moneda].ponerAlcancia(null);
                    prmObjeto = atrMonedas[moneda];
                    atrMonedas.RemoveAt(moneda);
                    actualizarRetiroConteoSaldoDenominacionesMonedas(prmDenominacion);
                    
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo que nos sirve para realizar el retiro de una denominacion(Billete) de la alcancia.
        /// </summary>
        /// <param name="prmDenominacion">denominacion a retirar</param>
        /// <param name="prmObjeto">referencia a la alcancia </param>
        /// <returns>True si se puede realizar el retiro.False de lo contrario</returns>
        public bool retirar(int prmDenominacion, ref clsBILLETE prmObjeto)
        {
            if (!atrDenominacionesAceptadasBilletes.Contains(prmDenominacion))
            {
                return false;
            }
            for (int billete = 0; billete < atrBilletes.Count; billete++)
            {
                if (atrBilletes[billete].darDenominacion() == prmDenominacion)
                {
                    prmObjeto = atrBilletes[billete];
                    atrBilletes.RemoveAt(billete);
                    actualizarRetiroConteoSaldoDenominacionesBilletes(prmDenominacion);
                    return true;
                }
            }
            return false;
        }
        #endregion
        #region Metodos privados
        /// <summary>
        /// Busca determinar si una denominacion(de moneda) se encuentra en una colleccion 
        /// </summary>
        /// <param name="prmValor">La denominacion que se va a buscar en una colleccion</param>
        /// <param name="prmColeccion">Coleccion de monedas o billetes</param>
        /// <returns>True si la denominacion se encuentra. False de lo contrario</returns>
        private bool buscarDenMonedas(int prmValor, List<int> prmColeccion)
        {
            for (int i = 0; i < prmColeccion.Count; i++)
            {
                if (prmValor == prmColeccion[i])
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Busca determinar si una denominacion(debillete) se encuentra en una colleccion 
        /// </summary>
        /// <param name="prmValor">La denominacion que se va a buscar en una colleccion</param>
        /// <param name="prmColeccion">Coleccion de monedas o billetes</param>
        /// <returns>True si la denominacion se encuentra. False de lo contrario</returns>
        private bool buscarDenBilletes(int prmValor, List<int> prmColeccion)
        {
            for (int i = 0; i < prmColeccion.Count; i++)
            {
                if (prmValor == prmColeccion[i])
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna una lista con las denominaciones de moneda que tienen saldo en la alcancia
        /// </summary>
        /// <param name="prmColeccionDenominaciones"></param>
        /// <returns>Lista de denominaciones q tienen saldo</returns>
        private List<int> denMonedasConSaldo(List<clsMONEDA> prmColeccionDenominaciones)
        {
            List<int> denominaciones = new List<int>();
            for (int i = 0; i < prmColeccionDenominaciones.Count; i++)
            {
                denominaciones.Add(prmColeccionDenominaciones[i].darDenominacion());
            }
            denominaciones = denominaciones.Distinct().ToList();

            return denominaciones;

        }
        /// <summary>
        /// Cuenta el numero de monedas de una denominacion en especifico
        /// </summary>
        /// <param name="prmDenominacion">Denominacion a contar</param>
        /// <returns>Entero</returns>
        private int contarMonedasPorDenominacion(int prmDenominacion)
        {
            int contador = 0;
            for (int i = 0; i < atrMonedas.Count; i++)
            {
                if (atrMonedas[i].darDenominacion() == prmDenominacion)
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Cuenta el numero de billetes de una denominacion en especifico
        /// </summary>
        /// <param name="prmDenominacion">Denominacion a contar</param>
        /// <returns>Entero</returns>
        private int contarBilletesPorDenominacion(int prmDenominacion)
        {
            int contador = 0;
            for (int i = 0; i < atrBilletes.Count; i++)
            {
                if (atrBilletes[i].darDenominacion() == prmDenominacion)
                {
                    contador++;
                }
            }
            return contador;
        }
        /// <summary>
        /// Retorna una lista con las denominaciones de billete que tienen saldo en la alcancia
        /// </summary>
        /// <param name="prmColeccionDenominaciones"></param>
        /// <returns>Lista de denominaciones q tienen saldo</returns>
        private List<int> denBilletesConSaldo(List<clsBILLETE> prmColeccionDenominaciones)
        {
            List<int> denominaciones = new List<int>();
            for (int i = 0; i < prmColeccionDenominaciones.Count; i++)
            {
                denominaciones.Add(prmColeccionDenominaciones[i].darDenominacion());
            }

            denominaciones = denominaciones.Distinct().ToList();

            return denominaciones;

        }
        /// <summary>
        /// Actualiza El conteo, saldo por denominaciones y saldo, el saldo total de billetes en la alcancia, y el saldo total despues de un cambio
        /// </summary>
        /// <param name="prmDenominacion">Denominacion que se removio</param>
        private void actualizarRetiroConteoSaldoDenominacionesMonedas(int prmDenominacion)
        {
            for (int varIterador = 0; varIterador < atrDenominacionesAceptadasMonedas.Count; varIterador++)
            {
                if (atrDenominacionesAceptadasMonedas[varIterador] == prmDenominacion)
                {
                    atrConteoPorDenominacionMonedas[varIterador] = atrConteoPorDenominacionMonedas[varIterador] - 1;
                    atrSaldoPorDenominacionMonedas[varIterador] = atrSaldoPorDenominacionMonedas[varIterador] - prmDenominacion;
                    atrSaldoTotalMonedas = atrSaldoTotalMonedas - prmDenominacion;
                    atrSaldoTotal = atrSaldoTotal - prmDenominacion;
                }
            }
        }
        /// <summary>
        /// Actualiza El conteo, saldo por denominaciones y saldo, el saldo total de billetes en la alcancia, y el saldo total despues de un cambio
        /// </summary>
        /// <param name="prmDenominacion">Denominacion que se removio</param>
        private void actualizarRetiroConteoSaldoDenominacionesBilletes(int prmDenominacion)
        {
            for (int varIterador = 0; varIterador < atrDenominacionesAceptadasBilletes.Count; varIterador++)
            {
                if (atrDenominacionesAceptadasBilletes[varIterador] == prmDenominacion)
                {
                    atrConteoPorDenominacionBilletes[varIterador] = atrConteoPorDenominacionBilletes[varIterador] - 1;
                    atrSaldoPorDenominacionBilletes[varIterador] = atrSaldoPorDenominacionBilletes[varIterador] - prmDenominacion;
                    atrSaldoTotalBilletes = atrSaldoTotalBilletes - prmDenominacion;
                    atrSaldoTotal = atrSaldoTotal - prmDenominacion;
                }
            }
        }
        #endregion
        #endregion
    }
}
