using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public abstract class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Item_ID { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public String Vendor_Name { get; set; }
        public int Invoice_Number { get; set; }
        public int warranty { get; set; }
    }
}