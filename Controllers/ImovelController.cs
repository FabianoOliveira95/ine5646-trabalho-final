using Microsoft.AspNetCore.Mvc;
using SuddenAmbiente.ControllerDB;
using SuddenAmbiente.Models;
using SuddenAmbiente.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuddenAmbiente.Controllers
{
    public class ImovelController : Controller
    {
        private IImovelRepository _imovel;
        private IInteresseRepository _interesse;
        private ICorretorRepository _corretor;

        public ImovelController(IImovelRepository imovel, IInteresseRepository interesse, ICorretorRepository corretor)
        {
            _imovel = imovel;
            _interesse = interesse;
            _corretor = corretor;
        }

        public IActionResult CadastrarImovel(string Nome)
        {
            List<Imovel> listImovel = _imovel.FindAll();
            List<Interesse> listInteresse = _interesse.FindAll();
            ViewBag.listImovel = listImovel;
            ViewBag.listInteresse = listInteresse;
            ViewBag.Nome = Nome;
            return View();
        }

        public IActionResult ProcurarImovel()
        {
            List<Imovel> listImovel = _imovel.FindAll();
            ViewBag.listImovel = listImovel;
            return View();
        }


        public IActionResult Visualizacao()
        {
            return View();
        }


        /// <summary>
        /// Salva os dados do imóvel.  
        /// </summary>
        public IActionResult Salvar()
        {
            Imovel imovel = new Imovel();
            imovel.IdImovel = new Random().Next(1, 1000);
            imovel.Imagem = Request.Form["Imagem"];
            imovel.NumeroInscricao = Request.Form["NumeroInscricao"];
            imovel.Endereco = Request.Form["Endereco"];
            imovel.Tipo = Request.Form["Tipo"] == "0" ? "Casa" : "Apartamento"; ;
            imovel.NumeroDormitorios = Request.Form["NumeroDormitorios"];
            imovel.NumeroBanheiros = Request.Form["NumeroBanheiros"];
            imovel.NumeroVagasGaragem = Request.Form["NumeroVagasGaragem"];
            imovel.ValorAluguel = "R$" + Request.Form["ValorAluguel"];
            imovel.Situacao = Convert.ToString(Request.Form["Situacao"]);
            
            switch(imovel.Situacao)
            {
                case "0":
                    imovel.Situacao = "Livre";
                    break;

                case "1":
                    imovel.Situacao = "Reservado";
                    break;

                case "2":
                    imovel.Situacao = "Alugado";
                    break;

                case "3":
                    imovel.Situacao = "Indisponível";
                    break;
            }

            _imovel.Add(imovel);

            return Redirect("CadastrarImovel");
        }

        public IActionResult Atualizar()
        {
            string inscricao = Request.Form["NumeroInscricao"];
            string situcao = Convert.ToString(Request.Form["Situacao"]);

            switch (situcao)
            {
                case "0":
                    situcao = "Livre";
                    break;

                case "1":
                    situcao = "Reservado";
                    break;

                case "2":
                    situcao = "Alugado";
                    break;

                case "3":
                    situcao = "Indisponível";
                    break;
            }

            Imovel imovel = _imovel.GetByInscricao(inscricao);
            imovel.Situacao = situcao;

            _imovel.Update(imovel);

            return Redirect("CadastrarImovel");
        }

        public IActionResult SalvarInteresse()
        {
            Interesse interesse = new Interesse();
            interesse.IdInteresse = new Random().Next(1, 1000);
            interesse.Nome = Request.Form["Nome"];
            interesse.Contato = Request.Form["Contato"];
            interesse.InscricaoImovelUm = Request.Form["InscricaoImovelUm"];
            interesse.InscricaoImovelDois = Request.Form["InscricaoImovelDois"];
            interesse.InscricaoImovelTres = Request.Form["InscricaoImovelTres"];

            _interesse.Add(interesse);

            return Redirect("ProcurarImovel");
        }

        public IActionResult AlterarSenha()
        {
            string nome = Request.Form["Nome"];
            string senha = Request.Form["Senha"];

            Corretor corretor = _corretor.GetByName(nome);
            corretor.Senha = senha;

            _corretor.Update(corretor);

            ViewBag.Nome = nome;

            return View("CadastrarImovel");
        }
    }
}
