using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class User :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]

        public string Surname { get; set; }
       
        [MaxLength(100)]
        public string Token { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Wishlist> Wishlists { get; set; }

    }
}
