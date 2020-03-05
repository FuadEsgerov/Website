using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Repository.Models
{
    public class Product : BaseEntity
    {
         public int CategoryId { get; set; }
            [Required]
            [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string SKU { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Column(TypeName="ntext")]
        public string Text { get; set; }

        [Required]
        public decimal Price { get; set; }

   
        public int? LabelId { get; set; }
        [Required]
        public bool IsTopSelling { get; set; }
        [Required]
        public bool IsFeatured { get; set; }
      
        public byte StarCount { get; set; }
        
        public Category Category { get; set; }
        
        public Label Label { get; set; }

            public ICollection<ProductPhoto> Photos { get; set; }
            public ICollection<ProductReview> Reviews { get; set; }
            public ICollection<ProductOptionItem> OptionItems { get; set; }
            public ICollection<ProductDiscount> Discounts { get; set; }
            public ICollection<Wishlist> Wishlists { get; set; }

    }
}
