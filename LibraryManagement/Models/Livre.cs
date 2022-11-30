using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    internal class Livre : Ouvrage
    {
        [MaxLength(100)]
        public string Editeur { get; set; }
    }
}
