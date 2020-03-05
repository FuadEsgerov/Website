using System.Collections.Generic;
using Repository.Enums;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public  class ProductOption :BaseEntity
    {
        [Required]
        public OptionsType Type { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductOptionItem> OptionItems { get; set; }

    }
}
