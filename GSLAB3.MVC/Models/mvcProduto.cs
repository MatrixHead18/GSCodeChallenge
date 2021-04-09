using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GSLAB3.MVC.Models
{
    public class mvcProduto
    {
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        public float Valor { get; set; }
    }
}
