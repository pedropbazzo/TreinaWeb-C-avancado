using System;

namespace TreinaWeb.CSharpAvancado.DelegatesGenericos
{
    class Program
    {
        //delegate T CalculoMatematico<T>(T a, T b);
        
        static void Main(string[] args)
        {
            var p = new Program();
            //var calculo = new CalculoMatematico<int>(p.SomarInt);
            Func<int, int, int> calculo = p.SomarInt;
            Action<int> resultadoAction = p.ImprimirResultado;
            Action gritar = p.GritarIury;
            resultadoAction(calculo(1, 1));
            gritar();
            //ExibirInformacoesDelegate(calculo);
        }
//
//        private static void ExibirInformacoesDelegate<T>(CalculoMatematico<T> calculo)
//        {
//            Console.WriteLine(calculo.Method);
//            Console.WriteLine(calculo.Target);
//        }

        int SomarInt(int a, int b)
        {
            return a + b;
        }

        void GritarIury() => Console.WriteLine("IURYYYY!!!");

        void ImprimirResultado(int resultado) => Console.WriteLine(resultado);

        decimal SomarDecimal(decimal a, decimal b)
        {
            return a+b;
        }
    }
}