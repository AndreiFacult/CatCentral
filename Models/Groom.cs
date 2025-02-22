using System.ComponentModel.DataAnnotations.Schema;

namespace CatCentral.Models
{
    public class Groom
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public string Food { get; set; }
        public string Supplies { get; set; }
        public string Toys { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
