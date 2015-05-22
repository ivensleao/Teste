using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Função que verifica se um e-mail é válido
        /// </summary>
        /// <param name="email">E-mail</param>
        /// <returns>true/false</returns>
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Função que verifica se a formatação de um CPF é válida.
        /// Considerando a formatação '000.000.000-00'
        /// </summary>
        /// <param name="cpf">CPF</param>
        /// <returns>true/false</returns>
        public static bool ValidaFormatacaoCpf(string cpf)
        {
            return Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$", RegexOptions.IgnoreCase);
        }
    }
}
