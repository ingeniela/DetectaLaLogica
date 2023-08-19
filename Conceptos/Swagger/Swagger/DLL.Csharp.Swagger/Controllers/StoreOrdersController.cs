using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DLL.Csharp.Swagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreOrdersController : ControllerBase
    {
        private readonly ILogger<StoreOrdersController> _logger;

        private static List<Order> orders = new List<Order>();

        public StoreOrdersController(ILogger<StoreOrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            Order[] orderArray = orders.ToArray();
            return orderArray;
        }

        [HttpPost("{amount}")]
        public ActionResult<List<Order>> PostMany(int amount)
        {
            string[] firstNames = { "John", "Jane", "Mary", "Bob", "Alice", "Jack", "Jill", "Mike", "Emily", "Tom" };
            string[] lastNames = { "Doe", "Smith", "Johnson", "Brown", "Garcia", "Davis", "Wilson", "Lee", "Taylor", "Clark" };
            string[] clothingItems = { "T-Shirt", "Jeans", "Sneakers", "Hat", "Jacket", "Dress", "Skirt", "Sweater", "Scarf", "Gloves" };

            Random random = new Random(123);

            List<Order> newOrders = Enumerable.Range(1, amount).Select(index => new Order
            {
                Id = index,
                Name = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}",
                ClothingItem = clothingItems[random.Next(clothingItems.Length)],
                Quantity = random.Next(1, 30),
                Price = Math.Round(random.NextDouble() * 200, 2),
                PurchaseDate = DateTime.Now.AddDays(-random.Next(1, 30))
            }).ToList();

            orders.AddRange(newOrders);

            return newOrders;
        }

        [HttpPost]
        public ActionResult<Order> Post(Order order)
        {
            order.Id = orders.Count + 1;
            orders.Add(order);
            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }

        [HttpPut("{id}")]
        public ActionResult<Order> Put(int id, Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
            {
                return NotFound();
            }
            existingOrder.Name = order.Name;
            existingOrder.ClothingItem = order.ClothingItem;
            existingOrder.Quantity = order.Quantity;
            existingOrder.Price = order.Price;
            existingOrder.PurchaseDate = order.PurchaseDate;

            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
            {
                return NotFound();
            }
            orders.Remove(existingOrder);
            return "Deleted Successfully";
        }
    }
}
