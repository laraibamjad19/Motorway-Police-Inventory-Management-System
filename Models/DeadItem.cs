using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class DeadItem 
    {
        [Key]
        public int Item_ID { get; set; }
        public String Item_Name { get; set; }
        public double Purchase_Price { get; set; }
        public double Reserve_Prie { get; set; }
        public String Approving_Auth { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime AuctionDate { get; set; }
        public DateTime AdDate { get; set; }
    }
}