using System;

namespace TreinaWeb.CSharpAvancado.DelegatesMulticast
{
    using static Console;
    class Program
    {
        delegate void VerificaIdade(int idade);

        private static VerificaIdade _verificaIdade;
        static void Main(string[] args)
        {
            WriteLine("Digite o seu sexo:");
            var sexo = Console.ReadLine();
            WriteLine("Digite o sua idade:");
            var idade = Console.ReadLine();

            if (sexo == "H")
            {
                _verificaIdade = new VerificaIdade(VerificaIdadeHomem);
                _verificaIdade += VerificaCarregaPesoHomem;
            }
            else
            {
                _verificaIdade = new VerificaIdade(VerificaIdadeMulher);
                _verificaIdade += VerificaCarregaPesoMulher;
            }

            _verificaIdade(int.Parse(idade));
        }

        #region homem
        static void VerificaIdadeHomem(int idade)
        {
            if(idade>21)
                WriteLine("Você já cresceu");
            else
                WriteLine("Você ainda está crescendo");
        }
        
        static void VerificaCarregaPesoHomem(int idade)
        {
            if(idade>25)
                WriteLine("Você pode carregar bastante peso");
            else
                WriteLine("Você não pode carregar peso");
        }
        #endregion
        
        #region mulher
        static void VerificaIdadeMulher(int idade)
        {
            if(idade>18)
                WriteLine("Você já cresceu");
            else
                WriteLine("Você ainda está crescendo");
        }
        
        static void VerificaCarregaPesoMulher(int idade)
        {
            if(idade>30)
                WriteLine("Você pode carregar bastante peso");
            else
                WriteLine("Você não pode carregar peso");
        }
        #endregion
    }
}