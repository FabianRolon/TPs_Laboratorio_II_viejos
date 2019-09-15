using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        #region Validar y Operar
        /// <summary>
        /// Recibe un operador del tipo string y valida si es una operacion válida.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el operador si es valido, retorna el operador suma si no es valido</returns>
        private static string ValidarOperador(string operador)
        {
            switch (operador)
            {
                case "+":
                    return "+";
                case "-":
                    return "-";
                case "*":
                    return "*";
                case "/":
                    return "/";
                default:
                    return "+";
            }
        }
        /// <summary>
        /// Recibe dos objetos del tipo numero y un operador y realiza la operacion recibida entre los atributos de los mismos. 
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="NumeroDos"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion indicada, MinValue si no puede operar</returns>
        public static double Operar(Numero numeroUno, Numero NumeroDos, string operador)
        {
            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    return numeroUno + NumeroDos;
                case "-":
                    return numeroUno - NumeroDos;
                case "*":
                    return numeroUno * NumeroDos;
                case "/":
                    return numeroUno / NumeroDos;
                default:
                    return double.MinValue;
            }
        }
        #endregion
    }
}

