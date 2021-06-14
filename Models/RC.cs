using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class RC
    {
        [Key]
        public int RC_Number { get; set; }
        public int Item_Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public String Branch_Name { get; set; }
        public String Receiver_Name { get; set; }
        public DateTime Datetime { get; set; }
        public String Signature { get; set; }

    }
}