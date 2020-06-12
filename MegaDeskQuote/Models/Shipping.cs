using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskQuote.Models
{
    public class Shipping
    {

        public int ID { get; set; }
        public int RushDay { get; set; }
        [Required, StringLength(30, MinimumLength = 3)]
        public string RushDaysName { get; set; }
    }
}
