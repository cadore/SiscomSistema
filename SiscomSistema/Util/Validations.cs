using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SiscomSistema.Util
{
    public static class Validations
    {
        public static bool validCPF(string CPF)
        {

            int[] Multiplier = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] MultiplierII = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digit;

            int _Sum;
            int _Rest;

            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");

            if ((CPF.Length != 11) || (CPF == "00000000000") || (CPF == "11111111111") ||
                (CPF == "22222222222") || (CPF == "33333333333") || (CPF == "44444444444") || (CPF == "55555555555") ||
                (CPF == "66666666666") || (CPF == "77777777777") || (CPF == "88888888888") || (CPF == "99999999999"))
            {
                return false;
            }
            TempCPF = CPF.Substring(0, 9);

            _Sum = 0;

            for (int i = 0; i < 9; i++)
            {
                _Sum += int.Parse(TempCPF[i].ToString()) * (Multiplier[i]);
            }
            _Rest = _Sum % 11;

            if (_Rest < 2)
            {
                _Rest = 0;
            }
            else
            {
                _Rest = 11 - _Rest;
            }

            Digit = _Rest.ToString();
            TempCPF = TempCPF + Digit;
            int _SumII = 0;

            for (int i = 0; i < 10; i++)
            {
                _SumII += int.Parse(TempCPF[i].ToString()) * MultiplierII[i];
            }

            _Rest = _SumII % 11;

            if (_Rest < 2)
            {
                _Rest = 0;
            }
            else
            {
                _Rest = 11 - _Rest;
            }

            Digit = Digit + _Rest.ToString();
            return CPF.EndsWith(Digit);
        }

        public static bool validCNPJ(string CNPJ)
        {
            CNPJ = CNPJ.Trim();
            CNPJ = CNPJ.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            CNPJ = CNPJ.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            CNPJ = CNPJ.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            CNPJ = CNPJ.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            CNPJ = CNPJ.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            CNPJ = CNPJ.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            CNPJ = CNPJ.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            switch (CNPJ)
            {       //00000000000000
                case "11111111111111":
                    return false;
                case "00000000000000":
                    return false;
                case "22222222222222":
                    return false;
                case "33333333333333":
                    return false;
                case "44444444444444":
                    return false;
                case "55555555555555":
                    return false;
                case "66666666666666":
                    return false;
                case "77777777777777":
                    return false;
                case "88888888888888":
                    return false;
                case "99999999999999":
                    return false;
            }
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            int resto;
            string digito;
            string tempCnpj;
            CNPJ = CNPJ.Trim();
            CNPJ = CNPJ.Replace(
            ".", "").Replace("-", "").Replace("/", "");
            if (CNPJ.Length != 14)
                return false;
            tempCnpj = CNPJ.Substring(0, 12);
            for (int i = 0; i < 12; i++)
                soma +=
                int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma +=
                int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto;
            return CNPJ.EndsWith(digito);
        }

        [DllImport("DllInscE32.dll")]
        public static extern int ConsisteInscricaoEstadual(string cInsc, string cUF);

        public static bool validIE(string ie, string estado)
        {
            int retorno = ConsisteInscricaoEstadual(ie, estado);

            if (retorno == 0)
                return true;
            else
                return false;
        }
    }
}
