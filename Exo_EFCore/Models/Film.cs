using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_EFCore.Models
{
    public class Film
    {
        public required int FilmId { get; set; }
        public required string Titre { get; set; }
        public required int AnneeSortie { get; set; }
        public required string Realisateur { get; set; }
        public required string ActeurPrincipal { get; set; }
        public required string Genre { get; set; }
    }
}
