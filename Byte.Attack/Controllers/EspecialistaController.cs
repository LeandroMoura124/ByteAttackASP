using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ByteAttack.Models;
using ByteAttack.Repositorio;

namespace Byte.Attack.Controllers
{
    public class EspecialistaController : Controller
    {
        // GET: Funcionario
        public ActionResult Especialista()
        {
            var especialista = new Especialista();
            return View(especialista);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult CadEspecialista(Especialista especialista)
        {
            ac.CadastrarEspecialista(especialista);
            return View(especialista);
        }

        public ActionResult ListarEspecialista()
        {
            var ExibirEspec = new Acoes();
            var TodosEspec = ExibirEspec.ListarEspecialista();
            return View(TodosEspec);
        }
    }
}