using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tehtava2
{
    [Route("/api/players/{playerId:Guid}/items")]
    [ApiController]    
    public class ItemsController
    {
        ItemsProcessor _processor;

        public ItemsController(ItemsProcessor processor)
        {
            _processor = processor;
        }

        [HttpGet("{id:Guid}")]
        public Task<Item> Get(Guid playerid, Guid id)
        {
            return _processor.Get(playerid, id);
        }

        [HttpGet]
        public Task<Item[]> GetAll(Guid playerid)
        {
            return _processor.GetAll(playerid);
        }

        [HttpPost]
        [ExceptionCatcher]
        public Task<Item> Create(Guid playerid, [FromBody] NewItem item)
        {
            return _processor.Create(playerid, item);
        }

        [HttpPut("{id:Guid}")]
        public Task<Item> Modify(Guid playerid, Guid itemid, [FromBody] ModifiedItem item)
        {
            return _processor.Modify(playerid, itemid, item);
        }

        [HttpDelete("{id:Guid}")]
        public Task<Item> Delete(Guid playerid, Guid itemid)
        {
            return _processor.Delete(playerid, itemid);
        }
    }
}