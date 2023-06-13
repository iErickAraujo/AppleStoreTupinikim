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
    public class DeletarProdutoController : Controller
    {
        //conexão com o banco
        //cliente firebase
        IFirebaseClient cliente;

        public DeletarProdutoController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {   //chave secreta e url do banco
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

        }
        //
        //Deletar produto
        public IActionResult DeletarProduto(string idproduto)
        {
            //
            FirebaseResponse response = cliente.Delete("Produtos/" + idproduto);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retorna para a view lista de produtos
                return RedirectToAction("ListaDeProdutos", "ListaDeProdutos");
            }
            else { return View(); }
        }
    }
}
