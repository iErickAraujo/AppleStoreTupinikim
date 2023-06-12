using Microsoft.AspNetCore.Mvc;

//importação das bibliotecas
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;
//
//importa o modelo de classe
using AppleStoreTupinikim.Models;
//importa os controllers do projeto
using AppleStoreTupinikim.Controllers;

namespace AppleStoreTupinikim.Controllers
{
    public class ListadeProdutosController : Controller
    {
        //conexão com o banco
        //cliente firebase
        IFirebaseClient cliente;

        public ListadeProdutosController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {   //chave secreta e url do banco
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

        }
        //
        public IActionResult ListaDeProdutos()
        {
            //Lista para armazenar todos os produtos que estão no banco de dados
            Dictionary<string,Produtos> lista=new Dictionary<string,Produtos>();

            //Get Busca no banco tudo quem vem a ser produtos
            FirebaseResponse response = cliente.Get("Produtos");
            //validar se esta retornando dados validos
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //lista recebe os dados que vem do banco//response resposta que estamos tendo ao receber produtos//armazena em um objeto do tipo discionario
                lista = JsonConvert.DeserializeObject < Dictionary<string, Produtos>>(response.Body);
            }

            List<Produtos> listaProdutos = new List<Produtos>();
            //percorre cada um dos itens que vem da lista do banco
            //e agrega na lista de produtos
            foreach (KeyValuePair<string,Produtos> elemento in lista)
            {
                listaProdutos.Add(new Produtos() {
                IdProduto= elemento.Key,
                Nome=elemento.Value.Nome,
                Valor= elemento.Value.Valor,
                Estoque= elemento.Value.Estoque,
                }
                );
            }
            return View(listaProdutos);
        }

    }
}
