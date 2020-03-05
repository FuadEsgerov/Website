using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class ProductPhoto :BaseEntity
    {
        public int Orderby { get; set; }
        public int ProductId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public Product Product { get; set; }
    }
}
