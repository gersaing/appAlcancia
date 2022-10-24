using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appAlcancia.Dominio
{
    public class clsBILLETE:clsMONEDA
    {
        #region Atributos
        #region Propios
        private string atrSerie = "ninguna";
        private int atrMes = -1;
        private int atrDia = -1;
        #endregion
        #endregion
        #region Metodos
        #region Constructores
        public clsBILLETE() { }
        public clsBILLETE(string prmSerie,string prmNombre,int prmDenominacion, int prmAño, int prmMes, int prmDia)
            :base(prmNombre,prmDenominacion,prmAño)
            {
            atrSerie = prmSerie;
            atrMes = prmMes;
            atrDia = prmDia;
              
            }
        #endregion
        #region Accesores
        /// <summary>
        /// Devuelve la serie asignada al billete
        /// </summary>
        /// <returns>Cadena de texto</returns>
        public string darSerie()
        {
            return atrSerie;
        }
        /// <summary>
        /// Devuelve el mes de emisión del billete
        /// </summary>
        /// <returns>Entero</returns>
        public int darMes()
        {
            return atrMes;
        }
        /// <summary>
        /// Devuelve el dia de emisión del billete
        /// </summary>
        /// <returns>Entero</returns>
        public int darDia()
        {
            /*  //TODO
              throw new NotImplementedException();*/
            return atrDia;
        }
        #endregion
        #region Mutadores
        /// <summary>
        /// Modifica la serie asignada al billete. Ej: cambia de "45FGT3" a "734GHE".
        /// </summary>
        /// <param name="prmValor">Nueva serie para el billete</param>
        /// <returns>True si la serie cumple con los estandares y el cambio fue posible. False de lo contrario</returns>
        public bool ponerSerie(string prmValor)
        {
            if (atrAlcancia == null)
            {
                var withoutSpecial = new string(prmValor.Where(c => Char.IsLetterOrDigit(c)
                                           || Char.IsWhiteSpace(c)).ToArray());
                if (prmValor == withoutSpecial)
                {
                    atrSerie = prmValor;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Modifica el mes de emision asignado al billete. Ej: cambia de "12" a "7".
        /// </summary>
        /// <param name="prmValor">Mes del billete</param>
        /// <returns>True si el mes se encuentra en el rango de (1 a 12) y el cambio fue posible. False de lo contrario</returns>
        public bool ponerMes(int prmValor)
        {
            if(prmValor == 1 || prmValor == 3 || prmValor == 5 || prmValor == 7 || prmValor == 8 || prmValor == 10 || prmValor == 12)
            {
                this.atrMes = prmValor;
                return true;
            }else if (prmValor == 4 || prmValor == 6 || prmValor == 9 || prmValor == 11 )
            {
                if(atrDia < 31)
                {
                    this.atrMes = prmValor;
                    return true;
                }
                return false;
            }else if( prmValor == 2)
            {
                if (DateTime.IsLeapYear(atrAño))
                {
                    if (atrDia < 30)
                    {
                        this.atrMes = prmValor;
                        return true;
                    }
                    return false;
                }else
                {
                    if (atrDia < 29)
                    {
                        this.atrMes = prmValor;
                        return true;
                    }
                    return false;
                }
            }

            return false;
        }
        /// <summary>
        /// Modifica el dia de emisión asignado al billete. Ej: cambia de "30" a "4"
        /// </summary>
        /// <param name="prmValor">Nuevo dia de emision del billete</param>
        /// <returns>True si el dia en relacion al mes de emisión es un dia valido y el cambio fue posible. False de lo contrario</returns>
        public bool ponerDia(int prmValor)
        {
            if(prmValor> 0 && prmValor < 32)
            {   
                if(atrMes == -1)
                {
                    if (prmValor > 0 && prmValor < 32)
                    {
                        this.atrDia = prmValor;
                        return true;
                    }
                }
                if (atrMes == 2)
                {
                    if (DateTime.IsLeapYear(atrAño))
                    {
                        if (prmValor < 30)
                        {
                            this.atrDia = prmValor;
                            return true;
                        }
                    }
                } else if (atrMes == 1 || atrMes == 3 || atrMes == 5 || atrMes == 7 || atrMes == 8 || atrMes == 10 || atrMes == 12)
                {
                    if (prmValor < 32)
                    {
                        this.atrDia = prmValor;
                        return true;
                    }
                } else if (atrMes == 4 || atrMes == 6 || atrMes == 9 || atrMes == 11)
                {
                    if (prmValor < 31)
                    {
                        this.atrDia = prmValor;
                        return true;
                    }
                }
            }
            return false;
            
        }
        #endregion
        #region Consultores
        public new int CompareTo(object prmObjeto)
        {
            try
            {
                clsBILLETE varObjeto = (clsBILLETE)Convert.ChangeType(prmObjeto, typeof(clsBILLETE));
                if (this.atrNombre == varObjeto.atrNombre && 
                    this.atrDenominacion == varObjeto.atrDenominacion && 
                    this.atrAño == varObjeto.atrAño &&
                    this.atrMes == varObjeto.atrMes &&
                    this.atrDia == varObjeto.atrDia &&
                    this.atrSerie == varObjeto.atrSerie)
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
    }
}
