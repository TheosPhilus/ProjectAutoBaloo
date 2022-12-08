﻿
using AutoBaloo.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Stock :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Date de stock ")]
        public string DateStock { get; set; }
        [Display(Name = "Quantité de stock ")]
        public int QteStock { get; set; }


        //Vehicule 
        public int IdVehicule { get; set; }
        [ForeignKey("IdVehicule")]
        public Vehicule Vehicule { get; set; }
    }
}
