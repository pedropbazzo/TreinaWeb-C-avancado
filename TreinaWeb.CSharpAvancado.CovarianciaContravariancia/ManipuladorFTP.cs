using System.Collections.Generic;

namespace TreinaWeb.CSharpAvancado.CovarianciaContravariancia
{
    public class ManipuladorFtp<T> : IArmazenador<T>,IRecuperador<T>
    {
        private List<T> lista = new List<T>();
        
        public void Armazenar(T objeto)
        {
            lista.Add(objeto);
        }

        public T Recuperar(int index)
        {
            return lista[index];
        }
    }
}