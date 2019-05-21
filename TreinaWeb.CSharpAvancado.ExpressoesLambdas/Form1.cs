using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinaWeb.CSharpAvancado.ExpressoesLambdas
{
    public partial class FrmLambda : Form
    {
        public FrmLambda()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Func<string, string, string> concatenador = (texto1, texto2) => $"{texto1} {texto2}";
            Action<string> escritor = (texto) => txbResultado.Text = texto; 
            escritor(concatenador(txbTexto1.Text, txbTexto2.Text));
        }
    }
}
