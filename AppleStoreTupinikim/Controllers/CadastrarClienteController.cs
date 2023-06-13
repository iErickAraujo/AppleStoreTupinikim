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
    public class CadastrarClienteController : Controller
    {
        //conexão com o banco
        //cliente firebase
        IFirebaseClient cliente;

        public CadastrarClienteController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {   //chave secreta e url do banco
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

        }
        //
        //view do metodo criar, metodo para retornar uma lista do formulario
        public IActionResult CadastrarCliente()
        {
            return View();
        }

        //Set do produto no banco
        [HttpPost]
        public IActionResult CadastrarCliente(Cliente oCliente)
        {
            //gera chaves aleatorias que nunca se repetem
            string idGerador = Guid.NewGuid().ToString("N");//N para formatos puros sem caracteres
            //Cria no banco uma lista com o nome contatos+id gerado+cliente com base na classe modelo
            SetResponse response = cliente.Set("Clientes/" + idGerador, oCliente);
            //se esta tudo ok retorna a lista
            //se esta tudo ok retorna atualiza o cliente
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retorna para a view lista de produtos
                return RedirectToAction("CadastrarCliente", "CadastrarCliente");
            }
            else { return View(); }

        }
    }
}
