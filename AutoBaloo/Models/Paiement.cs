
using AutoBaloo.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoBaloo.Models
{
    public class Paiement 
    {
        [Key]
        public int Id { get; set; }

        public string MoyenPaiement { get; set; }
        public string MontantPaiement { get; set; }
        public string DatePaiement { get; set; }

        //Reservation 
        public int IdReservation { get; set; }
        [ForeignKey("IdReservation")]
        public Reservation Reservation { get; set; }
    }
}
