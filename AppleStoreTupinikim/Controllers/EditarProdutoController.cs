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
    public class EditarProdutoController : Controller
    {
        //conexão com o banco
        //cliente firebase
        IFirebaseClient cliente;

        public EditarProdutoController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {   //chave secreta e url do banco
                AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
                BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
            };

            cliente = new FirebaseClient(config);

        }
        //
        public IActionResult EditarProduto(string idproduto)
        {
            //Get Busca no banco pelo Idproduto
            FirebaseResponse response = cliente.Get("Produtos/"+ idproduto);
            //para obter o produto//convert o conteudo para classe produtos
            Produtos produto = response.ResultAs<Produtos>();
            //atualizar o produto.IdProduto com idproduto(que foi recebido)
            //pois no banco não existe id dentro dos valores
            //somente Nome, Valor e Estoque;
            produto.IdProduto = idproduto;
            return View(produto);
        }
        //metodo para editar
        [HttpPost]
        public IActionResult EditarProduto(Produtos oProduto)
        {
            //armazenar o idProduto temporariamente
            string idproduto=oProduto.IdProduto;
            //pois não queremos que o id entre nos valores do banco
            //sendo assim não inserir
            oProduto.IdProduto = null;

            //Update//passa oProduto para ser atualizado
            //dessa forma estamos dizendo que o idproduto vai atualizar seus dados
            FirebaseResponse response = cliente.Update("Produtos/" + idproduto, oProduto);
            //se esta tudo ok retorna atualiza o produto
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                //retorna para a view lista de produtos
                return RedirectToAction("ListaDeProdutos", "ListaDeProdutos");
            }
            else { return View(); }
        }
    }
}
