using Microsoft.AspNetCore.Mvc;
using Server_Side_com_ASP_NET_MVC.Models;

namespace Server_Side_com_ASP_NET_MVC.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            ModelState.Remove("DataNascimento");

            if (!aluno.DataNascimento.HasValue)
            {
                ModelState.AddModelError("DataNascimento", "Data de Nascimento é obrigatória");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmacao", aluno);
            }

            return View(aluno);
        }

        public IActionResult Confirmacao(Aluno aluno)
        {
            return View(aluno);
        }
    }
}
