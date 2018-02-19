using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Product_Server.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ReOrderLevel { get; set; }
        public float Price { get; set; }

        [ForeignKey("Supplier ID")]
        public int SupplierID { get; set; } 

    }
}