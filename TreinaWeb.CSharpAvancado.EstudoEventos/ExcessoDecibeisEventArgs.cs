using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSharpAvancado.EstudoEventos
{
    public class ExcessoDecibeisEventArgs : EventArgs
    {
        public int IntensidadeLatido { get; internal set; }
    }
}
