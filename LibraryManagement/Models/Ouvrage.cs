using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    internal abstract class Ouvrage
    {
        public int Id { get; set; }
        public string Type { get; }
        public string Auteur { get; set; }
        public string Titre { get; set; }
        public int Quantite { get; set; }
        public int Disponible { get; set; }
        public List<Emprunt> Emprunts { get; set; }
    }
}
