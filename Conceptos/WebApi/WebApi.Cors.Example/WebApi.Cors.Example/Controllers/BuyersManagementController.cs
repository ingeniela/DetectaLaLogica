using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Cors.Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyersManagementController : Controller
    {
        private readonly ILogger<BuyersManagementController> _logger;

        private static List<Buyer> buyers = new List<Buyer>();

        public BuyersManagementController(ILogger<BuyersManagementController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<Buyer> Get()
        {
            Buyer[] arrayBuyers = buyers.ToArray();
            return arrayBuyers;
        }
        [HttpPost("{amount}")]
        public ActionResult<List<Buyer>> PostMany(int amount)
        {
            string[] firstNames = { "John", "Jane", "Mary", "Bob", "Alice", "Jack", "Jill", "Mike", "Emily", "Tom" };
            string[] lastNames = { "Doe", "Smith", "Johnson", "Brown", "Garcia", "Davis", "Wilson", "Lee", "Taylor", "Clark" };
            string[] clothingItems = { "T-Shirt", "Jeans", "Sneakers", "Hat", "Jacket", "Dress", "Skirt", "Sweater", "Scarf", "Gloves" };

            Random random = new Random(123);

            List<Buyer> newBuyers = Enumerable.Range(1, amount).Select(index => new Buyer
            {
                Id = index,
                Name = $"{firstNames[random.Next(firstNames.Length)]} {lastNames[random.Next(lastNames.Length)]}",
                ClothingItem = clothingItems[random.Next(clothingItems.Length)],
                Quantity = random.Next(1, 30),
                Price = Math.Round(random.NextDouble() * 200, 2),
                PurchaseDate = DateTime.Now.AddDays(-random.Next(1, 30))
            }).ToList();

            buyers.AddRange(newBuyers);

            return newBuyers;
        }

        [HttpPost]
        public ActionResult<Buyer> Post(Buyer buyer)
        {
            buyer.Id = buyers.Count + 1;
            buyers.Add(buyer);
            return CreatedAtAction(nameof(Get), new { id = buyer.Id }, buyer);
        }

        [HttpPut("{id}")]
        public ActionResult<Buyer> Put(int id, Buyer buyer)
        {
            var existingBuyer = buyers.FirstOrDefault(b => b.Id == id);
            if (existingBuyer == null)
            {
                return NotFound();
            }
            existingBuyer.Name = buyer.Name;
            existingBuyer.ClothingItem = buyer.ClothingItem;
            existingBuyer.Quantity = buyer.Quantity;
            existingBuyer.Price = buyer.Price;
            existingBuyer.PurchaseDate = buyer.PurchaseDate;

            return CreatedAtAction(nameof(Get), new { id = buyer.Id }, buyer);
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            var existingBuyer = buyers.FirstOrDefault(b => b.Id == id);
            if (existingBuyer == null)
            {
                return NotFound();
            }
            buyers.Remove(existingBuyer);
            return "Deleted Successfully";
        }
    }
}