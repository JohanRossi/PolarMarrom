using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace PolarMarrom.Classes
{
    internal class ArquivosJson
    {
        private static string caminhoArquivoPedidos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pedidos.json");
        private static string caminhoArquivoProdutos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "produtos.json");

        private static void VerificaArquivo(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                File.WriteAllText(caminhoArquivo, string.Empty);
            }
            else
            {
                using (FileStream fileStream = File.Create(caminhoArquivo))
                {
                    fileStream.Close();
                }
            }
        }

        public static void ExportarProdutosJson(List<Produto> listaDados)
        {
            VerificaArquivo(caminhoArquivoProdutos);

            string dadosJson = JsonConvert.SerializeObject(listaDados, Formatting.Indented);

            File.WriteAllText(caminhoArquivoProdutos, dadosJson);
        }

        public static void ExportarPedidosJson(List<Pedido> listaDados)
        {
            VerificaArquivo(caminhoArquivoPedidos);

            string dadosJson = JsonConvert.SerializeObject(listaDados, Formatting.Indented);

            File.WriteAllText(caminhoArquivoPedidos, dadosJson);
        }

        public static List<Produto> ImportarProdutosJson()
        {
            if (File.Exists(caminhoArquivoProdutos))
            {
                string dadosJson = File.ReadAllText(caminhoArquivoProdutos);

                List<Produto> listaDados = JsonConvert.DeserializeObject<List<Produto>>(dadosJson);

                return listaDados;
            }
            else
            {
                return new List<Produto>();
            }
        }

        public static List<Pedido> ImportarPedidosJson()
        {
            if (File.Exists(caminhoArquivoPedidos))
            {
                string dadosJson = File.ReadAllText(caminhoArquivoPedidos);

                List<Pedido> listaDados = JsonConvert.DeserializeObject<List<Pedido>>(dadosJson);

                return listaDados;
            }
            else
            {
                return new List<Pedido>();
            }
        }
    }
}