using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatCentral.Models
{
    public class Groom
    {
        public int ID { get; set; }

        //public string Name { get; set; }
        [Display(Name = "Name")]
        public int? GallerysID { get; set; }
        public Gallerys? Gallerys { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        //public string Food { get; set; }
        [Display(Name = "Food")]
        public int? FoodID { get; set; }
        [Display(Name = "Food")]
        public Food? Food { get; set; }
        public string Supplies { get; set; }
        //public string Toys { get; set; }
        public int? ToyID { get; set; }
        [Display(Name = "Toys")]
        public Toy? Toy { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
