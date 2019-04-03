using RestApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class InventoryController : ApiController
    {
        InventoriesDataContext db;
        public InventoryController()
        {
           db = new InventoriesDataContext();
        }
        // GET: api/Inventory
        public IEnumerable<Inventory> Get()
        {
            var AllInventory = db.Inventories.ToList();
            return AllInventory;
        }

        // GET: api/Inventory/5
        public Inventory Get(string id)
        {
            var FindInventory = db.Inventories.Where(i => i.ItemPartNumber == id).Single();
            return FindInventory;
        }

        // POST: api/Inventory
        public void Post([FromBody]Inventory inventory)
        {
            db.Inventories.InsertOnSubmit(inventory);
            db.SubmitChanges();
        }
        [HttpPut]
        // PUT: api/Inventory/5
        public void Put([FromBody]Inventory inventory)
        {
            var founditem = db.Inventories.Where(i => i.ItemPartNumber == inventory.ItemPartNumber).SingleOrDefault();
            founditem.Quantity = inventory.Quantity;
            founditem.Description = inventory.Description;
            founditem.ImagePath = inventory.ImagePath;
            founditem.OrderStatus = inventory.OrderStatus;
            db.SubmitChanges();
        }

        // DELETE: api/Inv

        [HttpDelete]
        public void Delete(string id)
        {
            var findItem = db.Inventories.Where(i => i.ItemPartNumber == id).FirstOrDefault();
            db.Inventories.DeleteOnSubmit(findItem);
            db.SubmitChanges();
        }
    }
}
