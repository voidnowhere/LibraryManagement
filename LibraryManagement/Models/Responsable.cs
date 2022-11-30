using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Models
{
    internal class Responsable : Utilisateur
    {
        [MaxLength(127)]
        [DefaultValue("123456")]
        public string Password { get; set; }

        [DefaultValue(false)]
        public bool Admin { get; }
    }
}
