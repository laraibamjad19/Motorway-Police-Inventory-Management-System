using InventoryManagmentSystem.Models;
using InventoryManagmentSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryManagmentSystem.Controllers
{
    public class EmployeeController : ApiController
    {
        private IInventory invrepos;
        public EmployeeController()
        {
            this.invrepos = new InventoryRepository(new InventoryDBContext());
        }
        // GET: api/Employee/5
        [Route("api/Employee/GetAllEmployee")]
        public List<Employee> GetAllEmployee()
        {
            return invrepos.GetAllEmployee();
        }

        [HttpPost]
        [Route("api/Employee/InsertOfficer")]
        public void InsertOfficer([FromBody]Officer o)
        {
            this.invrepos.InsertEmployee(o);
        }

        [HttpPost]
        [Route("api/Employee/RegularEmployee")]
        public void InsertRegularEmployee([FromBody]RegularEmployee o)
        {
            this.invrepos.InsertEmployee(o);
        }

        [HttpPost]
        [Route("api/Employee/Login")]
        public bool Login([FromBody]string inputstring)
        {
            string un = inputstring;
            string[] input = inputstring.Split(new Char[] {',' });

 
            return invrepos.compareOfficer(input[0], input[1]) ;
            
        }
        [HttpPost]
        [Route("api/Employee/LoginOfficer")]
        public bool LoginOfficer([FromBody]string inputstring)
        {
            string un = inputstring;
            string[] input = inputstring.Split(new Char[] { ',' });


            return invrepos.compareOfficer(input[0], input[1]);

        }
        [HttpPost]
        [Route("api/Employee/LoginRegularEmployee")]
        public bool LoginRegularEmployee([FromBody]string inputstring)
        {
            string un = inputstring;
            string[] input = inputstring.Split(new Char[] { ',' });


            return invrepos.compareRegularEmployee(input[0], input[1]);

        }
        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
