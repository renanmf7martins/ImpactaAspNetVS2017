using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        private readonly ModeloRepositorio modeloRepositorio = new ModeloRepositorio();

        [TestMethod()]
        public void ObterPorMarcaTest()
        {
            var modelos = modeloRepositorio.ObterPorMarca(1);

            modelos.ForEach(modelo =>
            {
                Console.WriteLine($"Id: {modelo.Id}, " +
                    $"Nome: {modelo.Nome}, Marca(Nome): {modelo.Marca.Nome}");
            });

            modelos = modeloRepositorio.ObterPorMarca(9);

            Assert.IsTrue(modelos.Count == 0);
        }

        [TestMethod()]
        public void ObterTest()
        {
            var modelo = modeloRepositorio.Obter(1);

            Console.WriteLine($"Id: {modelo.Id}, " +
                $"Nome: {modelo.Nome}, Marca(Nome): {modelo.Marca.Nome}");

            //Assert.IsTrue(modelos.Count == 0);
        }
    }
}