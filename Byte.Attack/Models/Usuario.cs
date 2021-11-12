using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ByteAttack.Models
{
    public class Usuario
    {

        public int cd_usuario { get; set; }

        [Required(ErrorMessage = "Obrigátório informar o nome do Aluno !!")]
        [Display(Name = "Nome do usuário")]
        public string nm_usuario { get; set; }

        [Required(ErrorMessage = "Obrigátório informar a senha do Aluno !!")]
        [Display(Name = "Senha do usuário")]
        public string ds_senha { get; set; }
    }
}