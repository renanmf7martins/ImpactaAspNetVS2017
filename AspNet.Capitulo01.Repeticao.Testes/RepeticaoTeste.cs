using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo01.Repeticao.Testes {
    [TestClass]
    public class RepeticaoTeste {
        [TestMethod]
        public void TabuadaTeste() {
            
            for (int m = 1; m <= 10; ++m) {
                for (int j = 1; j <= 10; ++j) {
                    Console.WriteLine($"{m} x {j} = {m * j}.{Environment.NewLine}");
                }
                Console.WriteLine($"{Environment.NewLine}-----------------{Environment.NewLine}");
            }
        }

        [TestMethod]
        public void EstruturaForTeste() 
        {
            int i = 1;
            //for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i)) {
            //    i++;
            //}

            for (Console.WriteLine("Iniciou"); i <= 3; Console.WriteLine(i++)) {
                
            }

            /*
             * for(1 - Inicialização; 2 - Critério; 4 - Pós Execução)
             * {
             *      3 - Execução;
             * }
             */



        }

        [TestMethod]
        public void ForApenasComCondicaoTeste() {
            var i = 1;

            for(;i <= 3;) 
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTeste() {

            for (int i = 0; i <= 10; i++) {

                if (i <= 5) {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTeste() {

            for (int i = 1; i <= 10; i++) {

                Console.WriteLine(i);

                if (i > 5) {
                    break;
                }
            }
        }



    }
}
