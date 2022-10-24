using System;
using System.Linq;
namespace appAlcancia.Dominio
{
    public class clsMONEDA :IComparable
    {
        #region Atributos
        #region Propios
        protected string atrNombre = "n.n";
        protected int atrDenominacion  ;
        protected int atrAño  ;
        #endregion
        #region Asociativos
        protected clsALCANCIA atrAlcancia;
        #endregion
        #endregion
        #region Metodos
         #region Constructores
        public clsMONEDA() { }
        /// <summary>
        /// Crea una nueva instancia de moneda con nombre, denominacion y año de emisión
        /// </summary>
        /// <param name="prmNombre">Nombre de la moneda según el pais. Ej: Peso, Dolar</param>
        /// <param name="prmDenominacion">Valor monetario. Ejm: 100 pesos</param>
        /// <param name="prmAño">Año de emisión de la moneda</param>
        public clsMONEDA(string prmNombre, int prmDenominacion, int prmAño)
        {   
            atrNombre = prmNombre;
            atrDenominacion = prmDenominacion;
            atrAño = prmAño;
        }
        public void Generar()
        {
            atrAlcancia = new clsALCANCIA();
        }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve el nombre de la moneda segun el pais Ej: Peso , Dolar
        /// </summary>
        /// <returns>Cadena de texto</returns>
        public string darNombre()
        {
            return atrNombre;
        }
        /// <summary>
        /// Devuelve el valor monetario de la moneda.
        /// </summary>
        /// <returns>Entero</returns>
        public int darDenominacion()
        {
            return atrDenominacion;
        }
        /// <summary>
        /// Devuelve el año de emisión de la moneda.
        /// </summary>
        /// <returns>Entero</returns>
        public int darAño()
        {
            return atrAño;
        }
        public clsALCANCIA darAlcancia()
        {
            return atrAlcancia;
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modofica el nombre asignado a la moneda Ej: Cambia el nombre de Dolar a Peso
        /// </summary>
        /// <param name="prmValor">Nuevo nombre que tomara la moneda</param>
        /// <returns>True si la moneda esta fuera de la Alcancia y el cambio fue posoble. False de lo contrario</returns>
        public bool ponerNombre(string prmValor)
        {   
            if(atrAlcancia == null)
            {
                var withoutSpecial = new string(prmValor.Where(c => Char.IsLetterOrDigit(c)
                                           || Char.IsWhiteSpace(c)).ToArray());
                if (prmValor == withoutSpecial)
                {
                    atrNombre = prmValor;
                    return true;
                }
            }
           
            return false;
        }
        /// <summary>
        /// Modofica el valor monetario asignado a la moneda Ej: Cambia de 10 a 100
        /// </summary>
        /// <param name="prmValor">Nueva denominacion que tomara la moneda</param>
        /// <returns>True si la moneda esta afuera de la Alcancia y el cambio fue posoble. False de lo contrario</returns>
        public bool ponerDenominacion(int prmValor)
        {
            if (atrAlcancia == null)
            {
                if (prmValor > 0)
                {
                    atrDenominacion = prmValor;
                    return true;
                }
                return false;
            }
            return false;
        }
        /// <summary>
        /// Modifica el año de emisión asignado a la moneda Ej: cambia de 1999 a 2001
        /// </summary>
        /// <param name="prmValor">Nuevo año de emisión de la moneda</param>
        /// <returns>True si el nuevo año no está en el futuro y el cambio fue posible. False de lo contrario</returns>
        public bool ponerAño(int prmValor)
        {
            if (atrAlcancia == null)
            {
                //ToDo: Averiguar rango real
                if (prmValor <= DateTime.Now.Year && prmValor > -8000)
                {
                    atrAño = prmValor;
                    return true;
                }
                return false;
            }
            return false;
        }
        /// <summary>
        /// Actualizamos el atributo alcancia ya sea una referencia a alcancia o null si la moneda ya no está en la alcancia
        /// </summary>
        /// <param name="objetoAlcancia">Referencia de la alcancia</param>
        /// <returns>True si puede realizar el cambio. False de lo contrario</returns>
        public bool ponerAlcancia(clsALCANCIA objetoAlcancia)
        {
            if (atrAlcancia == null)
            {
                this.atrAlcancia = objetoAlcancia;
                return true;
            }else if( atrAlcancia == objetoAlcancia)
            {
                this.atrAlcancia = null;
                return true;
            }
            return false;
        }
        #region Consultores
        public int CompareTo(object prmObjeto)
        {
            try
            {   
                clsMONEDA varObjeto = (clsMONEDA)Convert.ChangeType(prmObjeto, typeof(clsMONEDA));
                if (this.atrNombre == varObjeto.atrNombre && this.atrDenominacion == varObjeto.atrDenominacion && this.atrAño == varObjeto.atrAño)
                    return 0;
                if (this.atrDenominacion > varObjeto.atrDenominacion)
                    return 1;
                return -1;
            }
            catch
            {
                return 99;
            }
        }
        #endregion
        #endregion
        #endregion
     
    }
}
