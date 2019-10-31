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
    public class MarcaRepositorio
    {
        private readonly string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoMarca"];

        public List<Marca> Obter()
        {
            var marcas = new List<Marca>();
            string[] resultados = null;

            foreach (var linha in
                File.ReadAllLines(caminhoArquivo))
            {
                resultados = linha.Split('|');

                Marca marca = new Marca {
                    Id = Convert.ToInt32(resultados[0]),
                    Nome = resultados[1]
                };
                marcas.Add(marca);
            }

            return marcas;
        }

        public Marca Obter(int id)
        {
            int idEncontrado = 0;

            Marca marca = null;

            string[] resultados = null;

            foreach (var linha in
                File.ReadAllLines(caminhoArquivo))
            {
                resultados = linha.Split('|');
                idEncontrado = Convert.ToInt32(resultados[0]);

                if (id == idEncontrado)
                {
                    marca = new Marca {
                        Id = idEncontrado,
                        Nome = resultados[1]
                    };
                    break;
                }
            }
            return marca;
        }
    }
}
