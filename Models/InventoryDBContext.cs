using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventoryManagmentSystem.Models
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() :base("InventoryDBContext")
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Consumable> Consumables { get; set; }
        public DbSet<Durable> Durables { get; set; }
        public DbSet<DeadItem> DeadItem { get; set; }
        public DbSet<Issuance> Issuances { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<RC> RoadCertificates { get; set; }
        public DbSet<RepairedItem> RepairedItems { get; set; }
        public DbSet<Stationery> Stationeries { get; set; }
        public DbSet<RegularEmployee> RegularEmployees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Employee> Employees { get; set; }
       
    }
}