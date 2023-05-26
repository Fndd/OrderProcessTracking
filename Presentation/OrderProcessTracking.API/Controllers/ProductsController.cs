using Microsoft.AspNetCore.Mvc;
using OrderProcessTracking.Application.Repositories;
using OrderProcessTracking.Domain.Entities;

namespace OrderProcessTracking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id =  Guid.NewGuid(), Name ="Product 1", CreatedDate = DateTime.UtcNow, Stock = 10 },
            //    new() { Id =  Guid.NewGuid(), Name ="Product 2", CreatedDate = DateTime.UtcNow, Stock = 11 },
            //    new() { Id =  Guid.NewGuid(), Name ="Product 3", CreatedDate = DateTime.UtcNow, Stock = 12 },
            //    new() { Id =  Guid.NewGuid(), Name ="Product 4", CreatedDate = DateTime.UtcNow, Stock = 13 },
            //    new() { Id =  Guid.NewGuid(), Name ="Product 5", CreatedDate = DateTime.UtcNow, Stock = 14 },
            //});
            //await _productWriteRepository.SaveAsync();
            Product p = await _productReadRepository.GetByIdAsync("ae2277c5-277f-4477-9bc6-71f7323e9718");
            p.Name = "product 555";
            _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product p = await _productReadRepository.GetByIdAsync(id);
            return Ok(p);
        }
    }
}