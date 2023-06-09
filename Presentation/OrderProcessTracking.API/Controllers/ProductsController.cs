using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderProcessTracking.Application.Repositories;
using OrderProcessTracking.Domain.Entities;

namespace OrderProcessTracking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private ISellerWriteRepository _sellerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository,ISellerWriteRepository sellerWriteRepository )
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _sellerWriteRepository = sellerWriteRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           return Ok(JsonConvert.SerializeObject(_productReadRepository.GetAll());

            //List<Seller> sellerList = new() {
            //    new() {Id = Guid.NewGuid(), Name = "Seller 1 ", Code = "320-01", Email = "seller1@gmail.com", PhoneNumber = "555 555 11 11", WebSite = "www.seller1.com", Adress = "Seller 1 Address", },
            //    new() {Id = Guid.NewGuid(), Name = "Seller 2 ", Code = "320-02", Email = "seller2@gmail.com", PhoneNumber = "555 555 22 22", WebSite = "www.seller2.com", Adress = "Seller 2 Address", },
            //};
            //await _sellerWriteRepository.AddRangeAsync(sellerList);
            //await _sellerWriteRepository.SaveAsync();

            //List<Product> productList = new() {
            //    new() {Id = Guid.NewGuid(), Name = "Product 1 ", Stock = 5, },
            //    new() {Id = Guid.NewGuid(), Name = "Product 2 ", Stock = 5, },
            //};
            //await _productWriteRepository.AddRangeAsync(productList);
            //await _productWriteRepository.SaveAsync();

            //await _orderWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), TotalAmount = 5.0, Description = "Test Sipariþ 1", SellerId = Guid.Parse("6157bf66-6ff0-4010-a3bf-9dbeb9415f6f"), State = OrderState.Bekliyor},
            //    new() { Id = Guid.NewGuid(), TotalAmount = 6.0, Description = "Test Sipariþ 2", SellerId =  Guid.Parse("6157bf66-6ff0-4010-a3bf-9dbeb9415f6f"), State = OrderState.Bekliyor},
            //    new() { Id = Guid.NewGuid(), TotalAmount = 7.0, Description = "Test Sipariþ 3", SellerId =  Guid.Parse("6157bf66-6ff0-4010-a3bf-9dbeb9415f6f"), State = OrderState.Bekliyor},
            //    new() { Id = Guid.NewGuid(), TotalAmount = 8.0, Description = "Test Sipariþ 4", SellerId =  Guid.Parse("6157bf66-6ff0-4010-a3bf-9dbeb9415f6f"), State = OrderState.Bekliyor},
            //    new() { Id = Guid.NewGuid(), TotalAmount = 9.0, Description = "Test Sipariþ 5", SellerId =  Guid.Parse("6157bf66-6ff0-4010-a3bf-9dbeb9415f6f"), State = OrderState.Bekliyor},
            //});
            //await _orderWriteRepository.SaveAsync();

            //Product p = await _productReadRepository.GetByIdAsync("ae2277c5-277f-4477-9bc6-71f7323e9718");
            //p.Name = "product 555";
            //_productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product p = await _productReadRepository.GetByIdAsync(id);
            return Ok(p);
        }
    }
}