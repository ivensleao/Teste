using System;
using System.Collections.Generic;
using System.Linq;

namespace GFolha_Model.Utils
{
    public class Utils
    {   
        /// <summary>
        /// Função para checar se um objeto é nulo
        /// </summary>
        /// <param name="obj">Objeto genérico</param>
        /// <returns>true/false</returns>
        public static bool CheckNullObject(object obj)
        {
            return obj.Equals(null);
        }

        /// <summary>
        /// Função que converte uma string para data
        /// </summary>
        /// <param name="sDate">string data</param>
        /// <returns>DateTime()</returns>
        public static DateTime ConvertStringToDateTime(string sDate)
        {
            if (string.IsNullOrEmpty(sDate))
                return DateTime.Now;
            
            return Convert.ToDateTime(sDate);
        }
    }
}
