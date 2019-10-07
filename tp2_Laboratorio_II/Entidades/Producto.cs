using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        EMarca marca;
        string codigoDeBarras;
        ConsoleColor colorPrimarioEmpaque;
        public Producto(EMarca marca, string codigo, ConsoleColor color)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.colorPrimarioEmpaque = color;
        }

        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }
       

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias del producto
        /// </summary>
        protected abstract short CantidadCalorias
        {
            get;
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>Devuelve un string con los datos del Producto</returns>
        public virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("CODIGO DE BARRAS: {0}\r\n", codigoDeBarras);
            str.AppendFormat("MARCA          : {0}\r\n", marca.ToString());
            str.AppendFormat("COLOR EMPAQUE  : {0}\r\n", colorPrimarioEmpaque.ToString());
            str.AppendLine("---------------------");
            return str.ToString();
        }
        /// <summary>
        /// Sobrecarga el operador string para que devuelva los datos del producto.
        /// </summary>
        /// <param name="producto"></param>
        public static explicit operator string(Producto producto)
        {
            return producto.Mostrar();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="productoUno"></param>
        /// <param name="productoDos"></param>
        /// <returns>True si son iguales, false caso contrario</returns>
        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return (productoUno.codigoDeBarras == productoDos.codigoDeBarras);
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="productoUno"></param>
        /// <param name="productoDos"></param>
        /// <returns>True si no son iguales, false caso contrario</returns>
        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }
    }
}
