using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsSISTEMA
    {
        #region Atributos
        private clsALCANCIA atrAlcancia;
        private List<clsMONEDA> atrMonedas;
        private List<clsBILLETE> atrBilletes;
        #endregion

        #region Patrón Singleton
        private static clsSISTEMA atrInstancia;
        public static clsSISTEMA darInstacia()
        {
            if(atrInstancia == null)
            {
                atrInstancia = new clsSISTEMA();
               
            }
            return atrInstancia; 
        }
        #endregion
        #region Metodos
        #region Generadores
        public void GenerarAlcanciaSinDinero()
        {
            atrAlcancia = new clsALCANCIA();
        }
        public void GenerarAlcanciaConDinero()
        {
            atrAlcancia = new clsALCANCIA();
            atrAlcancia.Generar();
        }
        public void GenerarDinero()
        {
            atrAlcancia = new clsALCANCIA();
            atrAlcancia.Generar();

            atrMonedas = new List<clsMONEDA>();
            atrMonedas.Add(new clsMONEDA("", 200, 1990));
            atrMonedas.Add(new clsMONEDA("", 100, 1993));
            atrMonedas.Add(new clsMONEDA("", 1000, 2003));

            atrBilletes = new List<clsBILLETE>();
            atrBilletes.Add(new clsBILLETE("ABC123", "COP", 1000, 2010, 11, 4));
        }
        #endregion
        #region Accesores
        public clsALCANCIA darAlcancia()
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        public List<clsMONEDA> darMonedas()
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        public List<clsMONEDA> darBilletes()
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        #endregion
        #region CRUDS
        #region Registradores
        public bool registrar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
            {
                //TODO implementar
                throw new NotImplementedException();
            }

            public bool registrar(string prmNombre, int prmDenominacion, int prmAño)
            {
                //TO DO implementar
                throw new NotImplementedException();
            }

            public bool registrar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
            {
                //TO DO implementar
                throw new NotImplementedException();
            }
        #endregion
        #region Actualizadores
        public bool actualizar(string prmNombre, int prmCapacidadMonedas, int prmCapacidadBilletes, List<int> prmDenMonedas, List<int> prmDenBilletes)
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        public bool actualizar(string prmNombre, int prmDenominacion, int prmAño)
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        public bool actualizar(string prmSerie, string prmNombre, int prmDenominacion, int prmAño, int prmMes, int prmDia)
        {
            //TODO implementar
            throw new NotImplementedException();
        }
        #endregion
        #endregion

        #endregion
    }
}
