using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ByteAttack.Models;
using ByteAttack.Repositorio;

namespace Byte.Attack.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult CadFuncionario(Funcionario funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}