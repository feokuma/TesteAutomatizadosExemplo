using System;

namespace TestesAutomatizadosExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa("Fernando", "Okuma", new DateTime(2010, 05, 11));

            if (pessoa.ÉMaiorDeIdade)
                Console.WriteLine("Esta pessoa é maior de idade");
            else
                Console.WriteLine("Esta pessoa é menor de idade");
        }
    }
}
