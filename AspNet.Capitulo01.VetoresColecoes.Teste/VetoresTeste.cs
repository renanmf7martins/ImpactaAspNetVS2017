using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.VetoresColecoes.Teste
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                inteiros[i] = i + 1;
                Console.WriteLine($"O valor do vetor na posição[{i}] é igual a: {inteiros[i]}");

            }

            var decimais = new decimal[] { 0.2m, 5, 2.52m, 1.9m};

            decimal[] maisDecimais = { 2, 5.8m, 0.5m };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é: {decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[]
            {
                2.1m,
                1.6m,
                -8
            };

            Array.Resize(ref decimais, 4);

            decimais[3] = 1.7m;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(decimais[i]);
            }

        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[]
            {
                2.1m,
                1.6m,
                -8
            };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -8);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            Console.WriteLine(Media(new decimal [] 
            {
                10,
                10,
                10,
                10
            }));

            decimal[] decimais = new decimal[] { 4, 5, 6, 7 };
            Console.WriteLine(Media(1.9m, 2.34m, 3.54m));
            Console.WriteLine(decimais.Average());
        }

        private decimal Media2Numeros(decimal a, decimal b)
        {
            return (a + b) / 2;
        }

        /// <summary>
        /// Calcula a média dos valores passados.
        /// </summary>
        /// <param name="valores">Array de valores a calcular.</param>
        /// <returns>Média.</returns>
        private decimal Media(params decimal[] valores)
        {
            decimal somatoria = 0;
            foreach (var item in valores)
            {
                somatoria += item;
            }

            return somatoria / valores.Length;
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Renan";

            Assert.AreEqual(nome[0], 'R');

            foreach (var letra in nome)
            {
                Console.WriteLine(letra);
            }
        }



    }
}
