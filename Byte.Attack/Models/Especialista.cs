using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteAttack.Models
{
    public class Especialista : Controller
    {
        // GET: Funcionario
        [Range(1, 10, ErrorMessage = "O código deve ter de 1 a 10 dígitos")]
        public ushort EspecialistaID { get; set; }

        [Required(ErrorMessage = "O nome do especialista é obrigatório")]
        public string EspecialistaNome { get; set; }


        public DateTime EspecDtNasc
        {
            get
            {
                return this.especDtNasc.HasValue
                    ? this.especDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.especDtNasc = value;
            }
        }
        private DateTime? especDtNasc = null;



        [StringLength(14, MinimumLength = 10, ErrorMessage = "CPF incompleto ou inválido.")]
        public string EspecCPF { get; set; }



        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string EspecEmail { get; set; }


        public string EspecCel { get; set; }



    }
}
