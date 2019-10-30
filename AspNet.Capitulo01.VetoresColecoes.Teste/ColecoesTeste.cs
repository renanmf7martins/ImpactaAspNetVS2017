using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AspNet.Capitulo01.VetoresColecoes.Teste
{
    /// <summary>
    /// Descrição resumida para UnitTest1
    /// </summary>
    [TestClass]
    public class ColecoesTeste
    {
        public ColecoesTeste()
        {
            //
            // TODO: Adicionar lógica de construtor aqui
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>() { 2,3,4,5};
            inteiros.Add(15);

            inteiros[0] = 23;


            var maisInteiros = new List<int> { 4, 2, 3};
            maisInteiros.AddRange(inteiros);

            inteiros.Insert(3, 2);

            inteiros.Remove(20);

            inteiros.RemoveAll(h => h == 2);
            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros.Last();
            ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)} : {inteiro}");
            }


        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2019, 11, 2), "Finados");
            feriados.Add(new DateTime(2019, 11, 15), "Proclamação da república");
            feriados.Add(Convert.ToDateTime("20/11/2019"), "Consciência Negra");

            var finados = feriados[new DateTime(2019, 11, 2)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"Data: {feriado.Key.ToString("dd/MM/yyyy HH:mm")} " +
                                  $"Feriado: {feriado.Value}.");

                Console.WriteLine($"Data: {feriado.Key.ToShortDateString()} " +
                                  $"Feriado: {feriado.Value}.");

            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2019,11,20)));
            Console.WriteLine(feriados.ContainsValue("Finados"));


        }
    }
}
