using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ByteAttack.Repositorio;
using System.Web.Security;
using ByteAttack.Models;
using System.Web.Mvc;

namespace Byte.Attack.Controllers
{
    public class LoginController : Controller
    {
        Acoes aA = new Acoes();
        //instaciando classe AlunosAcoes 

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult VerificarUsuario(Usuario u)
        {
            // enviando os dados do form para serem checados no banco
            aA.TestarUsuario(u);

            // foi devolvido um resultado do banco, caso as informaççoes
            // do banco forem diferentes de nula, ou seja se foram
            // encontradas informações no banco serão criadas sessões
            if (u.nm_usuario != null && u.ds_senha != null)
            {
                FormsAuthentication.SetAuthCookie(u.nm_usuario, false);
                Session["usuarioLogado"] = u.nm_usuario.ToString();
                Session["senhaLogado"] = u.ds_senha.ToString();

                //direcionando o usuario para pagina Index da home
                return RedirectToAction("Index", "Home");
            }

            else
            {
                // se estiver errado usuário e senha permaneça na pagina login
                return RedirectToAction("Login", "Login");
            }
        }

        // ao clicar no botão logout, estaremos deslogando do ssitema
        public ActionResult Logout()
        {
            Session["usuarioLogado"] = null; // destruindo a sessão.
            return RedirectToAction("Login", "Login");
        }
    }
}