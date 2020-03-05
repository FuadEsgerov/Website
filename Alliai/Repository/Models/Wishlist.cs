using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
   public class Wishlist:BaseEntity
    {
      
        public int ProductId { get; set; }
     
        public int UserId { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }

    }
}
