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
    public class CorRepositorioTests
    {
        CorRepositorio corRepositorio = null;

        [TestMethod()]
        public void ObterTest()
        {
            corRepositorio = new CorRepositorio();
            var cores = corRepositorio.Obter();

            cores.ForEach(cor =>
            {
                Console.WriteLine($"Id: {cor.Id.ToString()}  - Cor: {cor.Nome}.");
            });
        }

        [TestMethod]
        public void ObterPorId()
        {
            corRepositorio = new CorRepositorio();
            var cor = corRepositorio.Obter(6);

            //Console.WriteLine($"Id: {cor.Id.ToString()}  - Cor: {cor.Nome}.");

            //Assert.AreEqual(cor.Nome, "Preto");
            Assert.IsNull(cor);
        }
    }
}