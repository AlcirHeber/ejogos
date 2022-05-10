using EJOGOS1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS1.Controllers
{
    public class EquipeController : Controller
    {
        
        //ActionResult representam os varios codigos HTTP,
        //Codigos HTTP - 

        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            //ViewBag = Reserva de espaço para armazenar informações para recuperar na View

            //ViewBag = tem a função de "carregar" as informações do CONTROLLER para a VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
