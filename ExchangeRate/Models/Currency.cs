using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExchangeRate.Models
{
    public class Currency
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Statut { get; set; }
        [Required]
        public double Value { get; set; }
    }
}