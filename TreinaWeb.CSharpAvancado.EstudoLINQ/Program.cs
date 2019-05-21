using System;
using System.Collections.Generic;
using System.Linq;

namespace TreinaWeb.CSharpAvancado.EstudoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var pessoasComIrmaos = from pessoa in CarregarListaPessoas()
                                   where pessoa.QuantidadeIrmaos > 0
                                   select pessoa;*/

            var pessoasComIrmaos = CarregarListaPessoas().Where(pessoa => pessoa.QuantidadeIrmaos > 0);

/*            var pessoasMaioresDe18Anos = from pessoa in CarregarListaPessoas()
                                         where pessoa.Idade >= 18
                                         orderby pessoa.Nome
                                         select new { pessoa.Nome };*/

            var pessoasMaioresDe18Anos = CarregarListaPessoas()
                .Where(pessoa => pessoa.Idade >= 18)
                .OrderBy(pessoa => pessoa.Nome)
                .ThenByDescending(pessoa => pessoa.Idade)
                .Select(pessoa => new {pessoa.Nome});

            var exercicio2 = CarregarListaPessoas().Exercicio2(f =>
            {
                var newList = new List<Pessoa>();

                foreach (var pessoa in f)
                {
                    if (pessoa.Idade % 2 == 0)
                    {
                        newList.Add(pessoa);
                    }
                }

                return newList;
            });

            var exercicio3parte1 = Exercicio3Parte1(new List<int> {1, 2, 3}, new List<int> {1, 5, 3});

           // Console.ReadKey();
        }

        private static IEnumerable<T> Exercicio3Parte1<T>(IEnumerable<T> lista1, IEnumerable<T> lista2) => lista1.Concat(lista2).Distinct();

        private static List<Pessoa> CarregarListaPessoas()
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa("Joao",18,2),
                new Pessoa("Maria",30,0),
                new Pessoa("Jose",50,6)
            };

            return pessoas;
        }
    }

    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }

        public Pessoa(string nome, int idade, int quantidadeIrmaos)
        {
            Nome = nome;
            Idade = idade;
            QuantidadeIrmaos = quantidadeIrmaos;
        }
    }
}
