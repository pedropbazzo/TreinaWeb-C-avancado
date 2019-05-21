using System;
using System.Collections.Generic;

namespace TreinaWeb.CSharpAvancado.EstudoLINQ
{
    public static class ExtensionMethos
    {
        public static List<T> Exercicio2<T>(this List<T> self, Func<List<T>, List<T>> func) => func(self);
    }
}
