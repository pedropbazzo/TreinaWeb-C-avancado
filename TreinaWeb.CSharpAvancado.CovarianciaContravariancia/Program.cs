using System;

namespace TreinaWeb.CSharpAvancado.CovarianciaContravariancia
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ftp = new ManipuladorFtp<Nivel1>();
            IArmazenador<Nivel3> armazenador = ftp;
            armazenador.Armazenar(new Nivel3());
            IArmazenador<Nivel2> armazenador2 = ftp;
            armazenador2.Armazenar(new Nivel2());

            IRecuperador<Nivel1> recuperador = ftp;
            Console.WriteLine(recuperador.Recuperar(0));
            Console.WriteLine(recuperador.Recuperar(1));
            
            Console.ReadKey();
        }
    }
}