using InventoryBackend.Interfaces;
using InventoryBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemRepositoryInterface _itemRepository;

        public ItemController(ItemRepositoryInterface itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Item>))]   
        public IActionResult GetItems()
        {
            var pokemons = _itemRepository.GetItems();  

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
    }

}   
