using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Display(Name = "ItemList")]
        public String ItemList { get;  set; }
        public String QuantityList { get; set; }
        public bool verified { get; set; }
    }

}