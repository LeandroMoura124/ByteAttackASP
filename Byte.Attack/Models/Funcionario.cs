using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteAttack.Models
{
    public class Funcionario : Controller
    {
        // GET: Funcionario
        [Range(1, 10, ErrorMessage = "O código deve ter de 1 a 10 dígitos")]
        public ushort FuncCod { get; set; }

        [Required(ErrorMessage = "O nome do funcionário é obrigatório")]
        public string FuncNome { get; set; }

        [StringLength(14, MinimumLength = 10, ErrorMessage = "CPF incompleto ou inválido.")]
        public string FuncCPF { get; set; }


        [StringLength(12, MinimumLength = 7, ErrorMessage = "RG incompleto ou inválido.")]
        public string FuncRg { get; set; }

        public DateTime FuncDtNasc
        {
            get
            {
                return this.funcDtNasc.HasValue
                    ? this.funcDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.funcDtNasc = value;
            }
        }
        private DateTime? funcDtNasc = null;

        [StringLength(100, MinimumLength = 10, ErrorMessage = "Informe o endereço completo.")]
        public string FuncEnd { get; set; }

        public string FuncCel { get; set; }


        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string FuncEmail { get; set; }


        [StringLength(100, MinimumLength = 3, ErrorMessage = "Informe o cargo a qual exerce.")]
        public string FuncCargo { get; set; }

    }
}
