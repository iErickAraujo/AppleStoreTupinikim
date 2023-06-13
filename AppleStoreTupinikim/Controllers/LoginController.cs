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
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace AppleStoreTupinikim.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        //login, validações e mensagens de erro
        [HttpPost]
        public IActionResult Entrar(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //verifica o login se for correto redireciona para home
                    if (cliente.Login == "admin" && cliente.Senha == "admin")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        //se não mostra esta mensagem de erro
                        TempData["MensagemErro"] = "Usuário e/ou senha inválidos. Por favor, tente novamente.";
                    }
                }
                else
                {
                    //se os campos estiverem vazios ou se somente um for preenchido mostra esta mensagem de erro
                    TempData["MensagemErro"] = "Por favor, verifique se os campos do formulário estão preenchidos corretamente.";
                }

                return RedirectToAction("Login");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível realizar o login. Detalhes do erro: {erro.Message}";
                return RedirectToAction("Login");
            }
        }

    }
}
