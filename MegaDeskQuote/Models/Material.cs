using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskQuote.Models
{
    public class Material
    {
        public int ID { get; set; }

        [Required, StringLength(30, MinimumLength = 3)]
        public string MaterialType { get; set; }

        //
        [Display(Name = "Material Cost"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaterialCost { get; set; }
    }
}
