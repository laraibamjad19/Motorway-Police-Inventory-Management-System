using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class RepairedItem
    {
        [Key]
        public int Item_ID { get; set; }
        public String Item_Name { get; set; }
        public int Vendor_ID { get; set;}
        public String Vendor_Name { get; set; }
        public int Bill_number { get; set;}
        public double Cost { get; set; }
        public DateTime ApprovalDate { get; set;}
        public int ApprovalNumber { get; set; }
    }
}