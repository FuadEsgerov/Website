using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class ProductSpec :BaseEntity
    {
        public int Orderby { get; set; }
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required]
        [MaxLength(500)]
        public string Value { get; set; }
    
    }
}
