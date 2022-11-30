using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    [Index(nameof(CIN), IsUnique = true)]
    internal class Client : Utilisateur
    {
        [MaxLength(10)]
        public string CIN { get; set; }
        
        public List<Emprunt> Emprunts { get; set; }
    }
}
