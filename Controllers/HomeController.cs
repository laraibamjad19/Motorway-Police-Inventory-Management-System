using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Repository;

namespace InventoryManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        IInventory invrepos;
        public HomeController() {
            this.invrepos = new InventoryRepository(new InventoryDBContext()); 
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}