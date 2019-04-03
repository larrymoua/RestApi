using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class RemoveInventoryController : ApiController
    {
        InventoriesDataContext db;
        public RemoveInventoryController()
        {
            db = new InventoriesDataContext();
        }
        // GET: api/RemoveInventory
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RemoveInventory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RemoveInventory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RemoveInventory/5
        public void Put([FromBody]RemoveInventory inventories)
        {
            var findCables = db.Inventories.Where(i => i.ItemName == "Cable").SingleOrDefault();
            var findConnecters = db.Inventories.Where(i => i.ItemName == "Connector").SingleOrDefault();
            var findHeatshrink = db.Inventories.Where(i => i.ItemName == "HeatShrink").SingleOrDefault();
            findCables.Quantity = findCables.Quantity - inventories.CableQuantity;
            findConnecters.Quantity = findConnecters.Quantity - inventories.ConnecterQuantity;
            findHeatshrink.Quantity = findHeatshrink.Quantity - inventories.HeatShrinkQuantity;
            db.SubmitChanges();
        }

        // DELETE: api/RemoveInventory/5
        public void Delete(int id)
        {
        }
    }
}
