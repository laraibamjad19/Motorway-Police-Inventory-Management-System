using System.Web.Http;
using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Repository;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Helpers;
using System.Collections.Generic;

namespace InventoryManagmentSystem.Controllers
{
    public class ItemController : ApiController
    {
        private IInventory invrepos;
        public ItemController() {
            this.invrepos = new InventoryRepository(new InventoryDBContext());
        }

        // GET: api/Item/5
        [Route("api/Item/ViewInventory")]
        public List<Item> GetAllItems()
        {
            return invrepos.GetAllItems();
        }
        [HttpGet]
        [Route("api/Item/GetItemById/{id}")]
        public Item GetItemById([FromUri]int id)
        {
            return invrepos.GetItemById(id);
        }

        // POST: api/Item
        [HttpPost]
        [Route("api/Item/AddConsumable")]
        public int AddConsumable([FromBody]Consumable obj)
        {
            if (obj.Price <= 100000)
            {
                invrepos.InsertItem(obj);
                return 0;
            }
            else
                return -1;
        }
        [HttpPost]
        [Route("api/Item/AddDurable")]
        public int AddDurable([FromBody]Durable obj)
        {
            if (obj.Price > 100000 || obj.warranty >=1)
            {
                invrepos.InsertItem(obj);
                return 0;
            }
            else
                return -1;
        }
        [HttpPost]
        [Route("api/Item/AddStationery")]
        public int AddStationery([FromBody]Stationery obj)
        {
            if (obj.Price <= 100000)
            {
                invrepos.InsertItem(obj);
                return 0;
            }
            else
                return -1;
        }

        // PUT: api/Item/5
        [HttpPut]
        [Route("api/Item/UpdateConsumable/{id}")]
        public int UpdateConsumable([FromUri]int id, [FromBody]Consumable value)
        {
            return invrepos.UpdateConsumable(id, value);

        }
        [HttpPut]
        [Route("api/Item/UpdateDurable/{id}")]
        public int UpdateDurable([FromUri]int id, [FromBody]Durable value)
        {
            return invrepos.UpdateDurable(id, value);

        }
        [HttpPut]
        [Route("api/Item/UpdateStationery/{id}")]
        public int UpdateStationery([FromUri]int id, [FromBody]Stationery value)
        {
            return invrepos.UpdateStationery(id, value);

        }

        // DELETE: api/Item/5
        [HttpDelete]
        [Route("api/Item/DeleteItem/{id}")]
        public int DeleteItem([FromUri]int id)
        {
            return invrepos.DeleteItem(id);
        }
    }
}
