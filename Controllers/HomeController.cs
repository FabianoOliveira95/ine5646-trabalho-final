using Microsoft.AspNetCore.Mvc;
using SuddenAmbiente.Repository;

namespace SuddenAmbiente.Controllers
{
    public class HomeController : Controller
	{
		// Exemplo com injeção de dependencia
		private IImovelRepository _imovel;


		//Autenticação salva em sessão no HTTPWebRequest
		public HomeController(IImovelRepository imovel)
		{
			_imovel = imovel;
		}

		public IActionResult Index()
		{

			ViewData["Message"] = "Your application description page.";

			return View();
		}

	}

}
