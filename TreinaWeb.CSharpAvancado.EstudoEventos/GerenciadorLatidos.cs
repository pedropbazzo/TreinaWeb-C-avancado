using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSharpAvancado.EstudoEventos
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatido;
        //public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);
        //public event ExcessoDecibeisHandler ExcessoDecibeisEvent;
        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatido = 0;
        }

        public int Latir()
        {
            _intensidadeLatido += 10;

            if (_intensidadeLatido > 80)
                OnExcessoDecibeis(new ExcessoDecibeisEventArgs { IntensidadeLatido = _intensidadeLatido });

            return _intensidadeLatido;
        }
        protected void OnExcessoDecibeis(EventArgs e)
        {
            ExcessoDecibeisEvent?.Invoke(this, e);
        }
    }
}
