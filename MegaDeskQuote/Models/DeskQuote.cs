using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskQuote.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }

        //
        [Required, StringLength(60, MinimumLength = 3)]
        public string Customer { get; set; }

        //
        [Display(Name = "Date Quote"), DataType(DataType.Date), Required]
        public DateTime DateQuote { get; set; }

        //
        [Range(24, 96)]
        //[Column(TypeName = "int(18, 0)")]
        public int Width { get; set; }

        //
        [Range(12, 48)]
        //[Column(TypeName = "int(18, 0)")]
        public int Depth { get; set; }


        //

        [Display(Name = "Cost Size"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostSize { get; set; }

        //
        [Display(Name = "Total Size")]
        //[Column(TypeName = "int(18, 0)")]
        public int TotalSize { get; set; }

        //
        [Display(Name = "Size Overage")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SizeOverage { get; set; }

        //
        [Range(0, 7)]
        public int Drawers { get; set; }


        [Display(Name = "DrawerCost"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]        
        public decimal DrawerCost { get; set; }

        //
        //public string Material { get; set; }

        [Display(Name = "Material Cost"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]

        //
        public decimal MaterialCost { get; set; } 


        [Display(Name = "Shipping Method ")]
        
        public string ShippingMethod { get; set; }


        //
        [Display(Name = "Shipping Cost") , DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ShippingCost { get; set; }

        [Display(Name = "Total"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }

        //type of materials enumerated
        [EnumDataType(typeof(TMaterials))]
        public TMaterials Material { get; set; }
        public enum TMaterials
        {
            Oak = 1,
            Laminate = 2,
            Pine = 3,
            Rosewood = 4,
            Veneer = 5
        }


        //rush order days
        [EnumDataType(typeof(OptShipping))]
        public OptShipping RushDay { get; set; }
        public enum OptShipping
        {
            Three = 3,
            Five = 5,
            Seven = 7,
            Fourteen = 14
        }

    }
}
