using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteAttack.Models
{
    public class Cliente : Controller
    {
        // GET: Cliente

        [Required(ErrorMessage = "O nome do cliente é obrigatório!")]
        public string ClienteNome { get; set; }

        [StringLength(14, MinimumLength = 10, ErrorMessage = "CPF incompleto ou inválido.")]
        public string ClienteCPF { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        public DateTime ClieDtNasc
        {
            get
            {
                return this.clieDtNasc.HasValue
                    ? this.clieDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.clieDtNasc = value;
            }
        }
        private DateTime? clieDtNasc = null;

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]

        public string ClienteEmail { get; set; }



        public string ClienteCel { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "Informe o endereço completo.")]
        public string ClienteEnd { get; set; }
    }
}