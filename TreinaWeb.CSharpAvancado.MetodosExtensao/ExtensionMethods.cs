using System;
using System.Collections.Generic;
using System.Text;

namespace TreinaWeb.CSharpAvancado.MetodosExtensao.Metodos
{
    public static class ExtensionMethods
    {
        public static string InverterCaixa(this string self)
        {
            var resultado = "";
            foreach (char letra in self)
            {
                var isUpperCase = letra.ToString() == letra.ToString().ToLower() ? true : false;
                resultado += isUpperCase ? letra.ToString().ToUpper() : letra.ToString().ToLower();
            }
            return resultado;
        }
    }
}
