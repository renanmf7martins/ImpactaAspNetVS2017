using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        private MarcaRepositorio marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void ObterTest()
        {
            var marcas = marcaRepositorio.Obter();

            int i = 0;

            foreach (var marca in marcas)
            {
                Marca marcaLoop = marcaRepositorio.Obter(++i);
                Assert.AreEqual(marcaLoop.Id, marca.Id);
                Assert.AreEqual(marcaLoop.Nome, marca.Nome);
            }
        }

        [TestMethod()]
        public void ObterPorIdTest()
        {
            for (int i = 1; i <= 4; i++)
            {
                var marca = marcaRepositorio.Obter(i);
                Assert.AreEqual(marca.Id, i);
            }
        }
    }
}