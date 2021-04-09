using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSLAB3.WebAPI.Models
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options): base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
