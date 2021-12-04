using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteAttack.Models
{
    public class Procedimento : Controller
    {
        // GET: Funcionario
        [Range(1, 10, ErrorMessage = "O código deve ter de 1 a 10 dígitos")]
        public ushort ProcedimentoID { get; set; }

        [Required(ErrorMessage = "O nome do procedimento é obrigatório")]
        public string ProcedimentoNome { get; set; }

      
        public DateTime ProceDtNasc
        {
            get
            {
                return this.proceDtNasc.HasValue
                    ? this.proceDtNasc.Value
                    : DateTime.Now;
            }
            set
            {
                this.proceDtNasc = value;
            }
        }
        private DateTime? proceDtNasc = null;

        [StringLength(100, MinimumLength = 10, ErrorMessage = "Informe a descrição completa.")]
        public string ProcedimentoDesc { get; set; }


        public string ProcedimentoMtd { get; set; }


        
        public string ProcedimentoValor { get; set; }

    }
}
