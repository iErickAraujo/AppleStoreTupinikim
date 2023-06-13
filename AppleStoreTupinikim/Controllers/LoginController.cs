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
        [HttpPost]
        public IActionResult Entrar(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index","Home");
                }
                return View("Index");
            }
            catch (Exception error)
            {
                TempData["Message error"] = $"Não conseguimos realizar seu login tente novamente{error.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
