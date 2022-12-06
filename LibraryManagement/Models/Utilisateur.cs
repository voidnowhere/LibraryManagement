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
    internal abstract class Utilisateur
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Type { get; }

        [MaxLength(50)]
        public string Nom { get; set; }
        
        [MaxLength(50)]
        public string Prenom { get; set; }
    }
}
