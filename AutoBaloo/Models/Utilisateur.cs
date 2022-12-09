
using AutoBaloo.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Utilisateur:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nom d'utilisateur")]
        public string NomUtilisateur { get; set; }

        [Display(Name = "Email ")]
        public string EmailUtilisateur { get; set; }
        public string MotPasse { get; set; }

        [Display(Name = "Adresse")]
        public string Adresse { get; set; }

        //Relationships
        public List<Reservation> Reservations { get; set; }
    }
}
