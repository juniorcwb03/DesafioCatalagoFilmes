using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DesafioCatalagoFilmes.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public string Titulo { get; set; }
        public string DataLancamento { get; set; }
        public string GeneroFilme { get; set; }
        public string Diretor { get; set; }
        public string ListaAutores { get; set; }
    }
}
