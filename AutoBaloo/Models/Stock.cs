using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        public string DateStock { get; set; }
        public int QteStock { get; set; }


        //Vehicule 
        public int IdVehicule { get; set; }
        [ForeignKey("IdVehicule")]
        public Vehicule Vehicule { get; set; }
    }
}
