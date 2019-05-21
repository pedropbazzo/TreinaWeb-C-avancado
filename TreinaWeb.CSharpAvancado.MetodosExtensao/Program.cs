using System;
using TreinaWeb.CSharpAvancado.MetodosExtensao.Metodos;

namespace TreinaWeb.CSharpAvancado.MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que você quer inverter: ");
            string frase = Console.ReadLine();

            Console.WriteLine($"Sua nova frase é {frase.InverterCaixa()}");

            Console.ReadKey();
        }
    }
}
