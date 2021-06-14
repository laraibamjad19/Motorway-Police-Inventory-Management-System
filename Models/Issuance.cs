using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class Issuance
    {
        [Key]
        public int RC_Number { get; set; }
        public int Quantity { get; set; }
        public String Name { get; set; }
        public String Signatures { get; set; }
    }
}