using NUnit.Framework;
using System;

namespace TestesAutomatizadosExemplo.Testes
{
    public class PessoaTestes
    {
        [Test]
        public void NomeDeveSerPreenchidoComNomeRecebidoNoConstrutor()
        {
            // arranje
            var nome = "Fernando";
            var pessoa = new Pessoa(nome, "Okuma", DateTime.Now);

            // act
            var nomeDaPessoa = pessoa.Nome;

            //assert
            Assert.AreEqual(nomeDaPessoa, nome);
        }

        [Test]
        public void SobrenomeDeveSerPreenchidoComSobrenomeRecebidoNoConstrutor()
        {
            // arranje
            var sobrenome = "Okuma";
            var pessoa = new Pessoa("Fernando", sobrenome, DateTime.Now);

            // act
            var sobrenomeDaPessoa = pessoa.Sobrenome;

            // assert
            Assert.AreEqual(sobrenomeDaPessoa, sobrenome);
        }

        [Test]
        public void ÉMaiorDeIdadeDeveRetornarTrueQuandoDiferençaEntreDataAtualEDataNascimentoForMaiorOuIgualADezoitoAnos()
        {
            // configura
            int AnoDeNascimento = DateTime.Now.Year - 18;
            var dataNascimento = new DateTime(AnoDeNascimento, DateTime.Now.Month, DateTime.Now.Day);
            var pessoa = new Pessoa("nome", "sobrenome", dataNascimento);

            // executa
            var ÉMaiorDeIdade = pessoa.ÉMaiorDeIdade;

            // valida
            Assert.IsTrue(ÉMaiorDeIdade);
        }
    }
}