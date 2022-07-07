using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoLivros.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Isbn { get; set; }
        public string? Autor { get; set; }


    }
}
