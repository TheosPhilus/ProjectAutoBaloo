
using AutoBaloo.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        public string NomUtilisateur { get; set; }
        public string EmailUtilisateur { get; set; }
        public string MotPasse { get; set; }
        public string Adresse { get; set; }

        //Relationships
        public List<Reservation> Reservations { get; set; }
    }
}
