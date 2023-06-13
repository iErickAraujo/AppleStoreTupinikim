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
        //IFirebaseClient cliente;
        
        //public BDController()
        //{
        //    IFirebaseConfig config = new FirebaseConfig
        //    {   //chave secreta e url do banco
        //        AuthSecret = "qj6UFKzbgzouzi7c6ErsPSFfANZ1M8s6ZEOHxpZS",
        //        BasePath = "https://crudprodutos785-default-rtdb.firebaseio.com/",
        //    };

        //    cliente = new FirebaseClient(config);

        //}

    }
}
