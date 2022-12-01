using AutoBaloo.Data.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class VehiculeCreateViewModel
    {



        [Display(Name = "Marque")]
        [Required(ErrorMessage = "La marque d'une voiture est obligatoire")]
        public MarqueVehicule MarqueVehicule { get; set; }

        [Display(Name = "Statut")]
        [Required(ErrorMessage = "il faut choisir un statut ")]
        public StatutVehicule StatutVehicule { get; set; }

        [Display(Name = "Carburant")]
        [Required(ErrorMessage = "Type de carburant est obligatoire")]
        public string TypeCarbu { get; set; }

        [Display(Name = "Prix")]
        [Required(ErrorMessage = "prix d'une voiture est obligatoire ")]
        public Decimal PrixVehicule { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "la modéle d'une voiture est obligatoire")]
        public string DescriptionVehicule { get; set; }

        [Display(Name = "Date de construction")]
        [Required(ErrorMessage = "Date de construction est obligatoire ")]
        public string DateConstruct { get; set; }

        [Display(Name = "Kilometrage")]
        [Required(ErrorMessage = "Il faut mettre la kilometrage d'une voiture ")]
        public string KM { get; set; }

        [Display(Name = "L'option")]

        public string OptionVehicule { get; set; }

        [Display(Name = "Couleur")]

        public string CouleurVehicule { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload File")]
        [Required(ErrorMessage = "Please choose file to upload.")]
 


        public IFormFile Image { get; set; }
    }
}

