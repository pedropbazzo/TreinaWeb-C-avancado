using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinaWeb.CSharpAvancado.EstudoEventos
{
    public partial class FrmGerenciadorLatidosCachorros : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;

        public FrmGerenciadorLatidosCachorros()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender,args) => 
            {
                MessageBox.Show("O CACHORRO PASSOU DOS LIMITES!"
                + Environment.NewLine
                + $"Intensidade do latido:{((ExcessoDecibeisEventArgs)args).IntensidadeLatido}",
            "EXCESSO DECIBEIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender,args) =>
            {
                MessageBox.Show("TÁ MULTADO VAGABUNDO!!!", "EXCESSO DECIBEIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            PingClient();
        }

        private void FrmGerenciadorLatidosCachorros_Load(object sender, EventArgs e)
        {
            pgrIntensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgrIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
        }

        private float PingClient()
        {

            float result = 0;
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            try
            {
                PingReply reply = p.Send("8.8.8.8");
                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show("huhgj");
                }
            }
            catch (PingException pe)
            {
                MessageBox.Show(pe.Message, "LALA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var lala = new[]  { new { nana = "lala" }, new { nana = "alala" } };

            return result;


        }
    }
}
