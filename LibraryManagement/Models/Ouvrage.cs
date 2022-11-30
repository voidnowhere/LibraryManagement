using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    [Index(nameof(Type))]
    internal abstract class Ouvrage
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Type { get; }

        [MaxLength(100)]
        public string Auteur { get; set; }

        [MaxLength(100)]
        public string Titre { get; set; }
        
        public int Quantite { get; set; }
        
        public int Disponible { get; set; }
        
        public List<Emprunt> Emprunts { get; set; }
    }
}
