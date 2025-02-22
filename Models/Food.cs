using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatCentral.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Groom>? grooms { get; set; }
        public string Brand { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}")]
        public decimal Quantity { get; set;}
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Special Description")]
        public string SpecialDescription { get; set; }
    }
}
