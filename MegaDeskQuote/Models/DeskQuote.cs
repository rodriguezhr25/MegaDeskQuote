using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskQuote.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        [Required, StringLength(60, MinimumLength = 3)]
        public string Customer { get; set; }


        [Display(Name = "Date Quote"), DataType(DataType.Date), Required]
        public DateTime DateQuote { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Width { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Depth { get; set; }
        [Display(Name = "Cost Size"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostSize { get; set; }
        [Display(Name = "Total Size")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalSize { get; set; }
        [Display(Name = "Size Overage")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SizeOverage { get; set; }
        public int Drawers { get; set; }
        [Display(Name = "DrawerCost")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DrawerCost { get; set; }
        public string Material { get; set; }
        [Display(Name = "Material Cost"), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal MaterialCost { get; set; }
        [Display(Name = "Shipping Method ")]
        public string ShippingMethod { get; set; }
        [Display(Name = "Shipping Cost") , DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ShippingCost { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total { get; set; }
    }
}
