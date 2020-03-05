using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public  class Label :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
