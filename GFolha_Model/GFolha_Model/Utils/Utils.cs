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

        public static bool CheckEmptyList(IList<object> list)
        {
            return list.Any();
        }
    }
}
