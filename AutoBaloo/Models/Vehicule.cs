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

        public MarqueVehicule MarqueVehicule { get; set; }
        public StatutVehicule StatutVehicule { get; set; }
        public string TypeCarbu { get; set; }
        public Decimal PrixVehicule { get; set; }
        public string DescriptionVehicule { get; set; }
        public string DateConstruct { get; set; }
        public string KM { get; set; }
        public string OptionVehicule { get; set; }
        public string CouleurVehicule { get; set; }
        public string ImageURL { get; set; }

        //Relationships
        public List<Stock> Stocks { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
