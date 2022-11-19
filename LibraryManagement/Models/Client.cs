using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBibliotheque.Models
{
    internal class Client : Utilisateur
    {
        public string CIN { get; set; }
        public List<Emprunt> Emprunts { get; set; }
    }
}
