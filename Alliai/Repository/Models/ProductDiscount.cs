using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
  public  class ProductDiscount
    {
        public int Id { get; set; }
        public int DiscountID { get; set; }
        public int ProductID { get; set; }
        public Discount Discount { get; set; }
        public Product Product { get; set; }
    }
}
