using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SuddenAmbiente.Repository;
using System.Linq;
using System.Threading.Tasks;
using SuddenAmbiente.Models;

namespace SuddenAmbiente.Controllers
{
    public class CorretorController : Controller
    {
        // Exemplo com injeção de dependencia
        private ICorretorRepository _corretor;

        public CorretorController(ICorretorRepository corretor)
        {
            _corretor = corretor;
        }

        public IActionResult Autenticacao()
        {
            List<Corretor> listCorretor = _corretor.FindAll();
            ViewBag.listCorretor = listCorretor;
            return View();
        }

        public IActionResult CadastrarCorretor()
        {
            List<Corretor> listCorretor = _corretor.FindAll();
            ViewBag.listCorretor = listCorretor;
            return View();
        }


        public IActionResult Visualizacao()
        {
            return View();
        }

        public IActionResult Autenticar(string email, string senha)
        {
            string response = "";
            List<Corretor> listCorretor = _corretor.FindAll();

            foreach(Corretor corretor in listCorretor)
            {
                if(corretor.Email == email && corretor.Senha == senha)
                {
                    return Json(new { redirectToUrl = Url.Action("CadastrarImovel", "Imovel", new { Nome = corretor.Nome }) });
                }
            }

            return Json(response);
        }


        /// <summary>
        /// Salva os dados do produto.  
        /// </summary>
        public IActionResult Salvar()
        {
            Corretor corretor = new Corretor();
            corretor.IdCorretor = new Random().Next(1, 1000);
            corretor.Nome = Request.Form["Nome"];
            corretor.Email = Request.Form["Email"];
            corretor.Senha = Request.Form["Senha"];

            _corretor.Add(corretor);

            return Redirect("Autenticacao");
        }
    }
}
