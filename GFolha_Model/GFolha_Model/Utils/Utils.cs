using System;
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
            return Regex.IsMatch(email,
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);
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

        /// <summary>
        /// Função que verifica se a formatação de um CNPJ é válida.
        /// Considerando a formatação '00.000.000/0000-00"
        /// </summary>
        /// <param name="cnpj">CNPJ</param>
        /// <returns>true/false</returns>
        public static bool ValidaFormatacaoCnpj(string cnpj)
        {
            return Regex.IsMatch(cnpj, @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Função que valida se o conteúdo do CPF é válido.
        /// </summary>
        /// <param name="cpf">CPF</param>
        /// <returns>true/false</returns>
        public static bool ChecaSeCpfValido(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return false;

            return !ValidaFormatacaoCpf(cpf) && ValidaCpf(cpf);
        }

        #region Funções privadas
        private static bool ValidaCpf(string cpf)
        {
            int dv1;
            int dv2;

            if (string.IsNullOrEmpty(cpf))
            {
                return true;
            }
            if (long.Parse(cpf) == 0)
            {
                return false;
            }
            if (cpf.Length != 11)
            {
                cpf = string.Format("{0: D11}", long.Parse(cpf));
            }

            var calcArr = new int[11];
            for (int x = 0; x < calcArr.Length; x++)
            {
                calcArr[x] = int.Parse(cpf[x].ToString());
            }

            var sum = 0;
            for (int x = 1; x <= 9; x++)
            {
                sum += calcArr[x - 1]*(11 - x);
            }

            Math.DivRem(sum, 11, out dv1);
            dv1 = 11 - dv1;
            dv1 = dv1 > 9 ? 0 : dv1;
            if (dv1 != calcArr[9])
            {
                return false;
            }
            sum = 0;
            for (var x = 1; x <= 10; x++)
            {
                sum += calcArr[x - 1]*(12 -x);
            }
            Math.DivRem(sum, 11, out dv2);
            dv2 = 11-dv2;
            dv2 = dv2 > 9 ? 0 : dv2;

            return dv2 == calcArr[10];
        }
        #endregion
    }
}
