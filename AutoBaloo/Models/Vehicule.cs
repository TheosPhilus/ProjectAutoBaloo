using AutoBaloo.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Vehicule
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Marque")]
        public MarqueVehicule MarqueVehicule { get; set; }
        
        [Display(Name = "Statut")]
        public StatutVehicule StatutVehicule { get; set; }

        [Display(Name = "Carburant")]
        public string TypeCarbu { get; set; }

        [Display(Name = "Prix")]
        public Decimal PrixVehicule { get; set; }

        [Display(Name = "Description")]
        public string DescriptionVehicule { get; set; }

        [Display(Name = "Date de construction")]
        public string DateConstruct { get; set; }

        [Display(Name = "Kilogramme")]
        public string KM { get; set; }

        [Display(Name = "L'option")]
        public string OptionVehicule { get; set; }

        [Display(Name = "Couleur")]
        public string CouleurVehicule { get; set; }

        [Display(Name = "L'image")]
        public string ImageURL { get; set; }

        //Relationships
        public List<Stock> Stocks { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
