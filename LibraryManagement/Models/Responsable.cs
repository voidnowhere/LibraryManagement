using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque.Models
{
    internal class Responsable : Utilisateur
    {
        public string Password { get; set; }
        public bool Admin { get; } = false;
    }
}
