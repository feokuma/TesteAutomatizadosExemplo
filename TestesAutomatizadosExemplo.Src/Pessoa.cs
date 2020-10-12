using System;

namespace TestesAutomatizadosExemplo
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento.Date;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public bool ÉMaiorDeIdade => CalculaIdade() >= 18;

        private int CalculaIdade()
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if(DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                idade += 1;

            return idade;
        }
    }
}
