using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GSLAB3.WebAPI.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String Nome { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public String Descricao { get; set; }

        [Column(TypeName = "float")]
        public float Valor { get; set; }
    }
}
