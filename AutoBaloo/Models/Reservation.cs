using AutoBaloo.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public string DateDebut { get; set; }
        public int Duree { get; set; }
        public string MontantReservation { get; set; }
        public string DateFin { get; set; }
        public TypeReservation TypeReservation { get; set; }

        //Relationships
        public List<Paiement> Paiements { get; set; }

        //Vehicule 
        public int IdVehicule { get; set; }
        [ForeignKey("IdVehicule")]
        public Vehicule Vehicule { get; set; }

        //Utilisateur 
        public int IdUtilisateur { get; set; }
        [ForeignKey("IdUtilisateur")]
        public Utilisateur Utilisateur { get; set; }
    }
}
