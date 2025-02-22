using System.ComponentModel.DataAnnotations;

namespace CatCentral.Models
{
    public class Toy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Groom>? grooms { get; set; }
        public string Size { get; set; }
        [DisplayFormat(DataFormatString = "{0:0}")]
        public decimal Quantity { get; set; }
        [Display(Name = "Special Description")]
        public string SpecialDescription { get; set; }
    }
}
