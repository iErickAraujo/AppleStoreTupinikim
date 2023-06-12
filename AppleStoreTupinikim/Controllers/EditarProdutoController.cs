using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using Microsoft.AspNetCore.Mvc;

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
    }
}
