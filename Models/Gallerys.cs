using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatCentral.Models
{
    public class Gallerys
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        [Column(TypeName = "decimal(9, 0)")]
        public decimal ImplantID { get; set; }
        [Column(TypeName = "decimal(5, 0)")]
        public decimal Age { get; set; }
        public string Breed { get; set; }
        [Display(Name = "Special Description")]
        public string SpecialDescription { get; set; }
    }
}
