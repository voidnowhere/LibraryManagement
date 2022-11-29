using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    internal class Emprunt
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        [DefaultValue(false)]
        public bool Retourne { get; set; }
        public Client Client { get; set; }
        public Ouvrage Ouvrage { get; set; }
    }
}
