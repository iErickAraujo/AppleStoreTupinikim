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

namespace AppleStoreTupinikim.Controllers
{
    public class BDController : Controller
    {
        //conexão com o banco
        //cliente firebase
        IFirebaseClient cliente;
        
        public BDController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {   //chave secreta e url do banco
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

        }
        //Get produto
        public IActionResult Inicio()
        {
            return View();
        }
        //view do metodo criar, metodo para retornar uma lista do formulario
        //public IActionResult Criar()
        //{
        //    return View();
        //}

        public IActionResult Editar()
        {
            return View();
        }
        [HttpDelete]
        public IActionResult Excluir()
        {
            return View();
        }
        //Set do produto no banco
        //[HttpPost]
        //public IActionResult Criar(Produtos oProduto)
        //{
        //    //gera chaves aleatorias que nunca se repetem
        //    string idGerador = Guid.NewGuid().ToString("N");//N para formatos puros sem caracteres
        //    //Cria no banco uma lista com o nome contatos+id gerado+produto com base na classe modelo
        //    SetResponse response = cliente.Set("Produtos/" + idGerador, oProduto);
        //    //se esta tudo ok retorna a lista
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        return View();
        //    }
        //    else { return View(); }

        //}
    }
}
