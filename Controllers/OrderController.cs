using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace InventoryManagmentSystem.Controllers
{
    public class OrderController : ApiController
    {
        private IInventory invrepos;
        public OrderController()
        {
            this.invrepos = new InventoryRepository(new InventoryDBContext());
        }
        
        // GET: api/PlaceOrder/5
        [Route("api/Order/PlaceOrder")]
        [HttpPost]
        public bool PlaceOrder([FromBody] String []Items)
        {
            return this.invrepos.PlaceOrder(Items);
 
        }
    }
}
