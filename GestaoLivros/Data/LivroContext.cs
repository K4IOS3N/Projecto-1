using GestaoLivros.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoLivros.Data
{
    public class LivroContext : DbContext
    {
        

        public LivroContext(DbContextOptions options):base(options)
        {
           
        }

        public DbSet<Livro>? Livros { get; set; }
    }
}

