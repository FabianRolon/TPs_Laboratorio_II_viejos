using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Changuito
    {
        List<Producto> productos;
        int espacioDisponible;
        public enum ETipo
        {
            Dulce,
            Leche,
            Snacks,
            Todos
        }

        #region "Constructores"
        private Changuito()
        {
            this.productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible)
            :this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="changuito">Elemento a exponer</param>
        /// <param name="tipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito changuito, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", changuito.productos.Count, changuito.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto productos in changuito.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if(productos.GetType() == typeof(Snacks))
                            sb.AppendLine(productos.Mostrar());
                        break;
                    case ETipo.Dulce:
                        if (productos.GetType() == typeof(Dulce))
                            sb.AppendLine(productos.Mostrar());
                        break;
                    case ETipo.Leche:
                        if (productos.GetType() == typeof(Leche))
                            sb.AppendLine(productos.Mostrar());
                        break;
                    default:
                        sb.AppendLine(productos.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se agregará el elemento</param>
        /// <param name="producto">Objeto a agregar</param>
        /// <returns>Devuelve el changuito ingresado con el producto agregado si pudo, sino lo devuelve como estaba</returns>
        public static Changuito operator +(Changuito changuito, Producto producto)
        {
            foreach (Producto productos in changuito.productos)
            {
                if (productos == producto)
                    return changuito;
            }
            if (changuito.productos.Count < changuito.espacioDisponible)
                changuito.productos.Add(producto);
            return changuito;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="changuito">Objeto donde se quitará el elemento</param>
        /// <param name="producto">Objeto a quitar</param>
        /// <returns>>Devuelve el changuito ingresado con el producto quitado si pudo, sino lo devuelve como estaba</returns>
        public static Changuito operator -(Changuito changuito, Producto producto)
        {
            foreach (Producto productos in changuito.productos)
            {
                if (productos == producto)
                {
                    changuito.productos.Remove(producto);
                    return changuito;
                }
            }

            return changuito;
        }
        #endregion
    }
}
