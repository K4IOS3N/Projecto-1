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
        public DbSet<Livro>? Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=samsys123;Persist Security Info=True;User ID=samsys;Initial Catalog=GestaoLivros_db;Data Source=DESKTOP-IBTQDC0\SQLEXPRESS");
        }
    }
}

