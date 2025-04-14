using _35._RestApiWithEfCore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace _35._RestApiWithEfCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context)
        {
                _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            foreach (var item in order.OrderItems)
            {
                var existing = await _context.Products.FirstOrDefaultAsync();

                if(existing == null)
                {
                    return BadRequest();
                }

                if (existing.Stock < item.Quantity)
                    return BadRequest($"Item {item.Product.Name} doesn't have this amount.");

                existing.Stock -= item.Quantity;
            }
            order.CreatedAt = DateTime.UtcNow;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(order);
        }
    }
}
