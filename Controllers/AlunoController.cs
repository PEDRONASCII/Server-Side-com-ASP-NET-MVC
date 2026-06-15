using Microsoft.AspNetCore.Mvc;
using Server_Side_com_ASP_NET_MVC.Models;

namespace Server_Side_com_ASP_NET_MVC.Controllers
{
    public class AlunoController : Controller
    {
        // Passo 4 - GET: exibe o formulário vazio
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // Passo 5 - POST: recebe e valida os dados
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmacao", aluno);
            }

            // Se inválido, volta pro formulário com os erros
            return View(aluno);
        }

        // Página de confirmação
        public IActionResult Confirmacao(Aluno aluno)
        {
            return View(aluno);
        }
    }
}