using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        readonly XDocument arquivoXml = 
            XDocument.Load
            (
                ConfigurationManager
                    .AppSettings["caminhoArquivoModelo"]
            );

        public List<Modelo> ObterPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if(elemento.Element("marcaId").Value == 
                    marcaId.ToString())
                {
                    modelos.Add(new Modelo
                    {
                        Id = Convert.ToInt32(elemento.Element("id").Value),
                        Nome = elemento.Element("nome").Value,
                        Marca = new MarcaRepositorio().Obter(marcaId)
                    });
                }
            }

            return modelos;
        }

        public Modelo Obter(int id)
        {
            Modelo modelo = null;

            int idEncontrado = 0;

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                idEncontrado = Convert.ToInt32(elemento.Element("id").Value);

                if (idEncontrado == id)
                {
                    modelo = new Modelo
                    {
                        Id = idEncontrado,
                        Nome = elemento.Element("nome").Value,
                        Marca = new MarcaRepositorio()
                            .Obter(
                                Convert.ToInt32
                                (
                                    elemento.Element("marcaId").Value
                                ))
                    };

                    break;
                }
            }

            return modelo;
        }


    }
}
