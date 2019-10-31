using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        private readonly string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> Obter()
        {
            var cores = new List<Cor>();

            foreach (var linha in
                File.ReadAllLines(caminhoArquivo))
            {
                Cor cor = new Cor {
                    Id = Convert.ToInt32(linha.Substring(0, 5)),
                    Nome = linha.Substring(5)
                };
                cores.Add(cor);
            }

            return cores;
        }

        public Cor Obter(int id)
        {
            int idEncontrado = 0;

            Cor cor = null;

            foreach (var linha in
                File.ReadAllLines(caminhoArquivo))
            {
                idEncontrado = Convert.ToInt32(linha.Substring(0, 5));

                if (id == idEncontrado)
                {
                    cor = new Cor {
                        Id = idEncontrado,
                        Nome = linha.Substring(5)
                    };
                    break;
                }
            }
            return cor;
        }

    }
}
