using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderProcessTracking.Domain.Entities;
using OrderProcessTracking.Domain.Entities.Common;
using OrderProcessTracking.UI.Core;
using OrderProcessTracking_UI.Models;
using System.Collections.Generic;
using System.Xml.Linq;

namespace OrderProcessTracking.UI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public async Task<object> Get(DataSourceLoadOptions loadOptions)
        {
            List<Product> b = await HttpManager.GetAs<List<Product>>("/Products");
            return DataSourceLoader.Load(b, loadOptions);
        }
        [HttpPost]
        public IActionResult Post(string values)
        { 
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(int key, string values)
        { 
            return Ok();
        }

        [HttpDelete]
        public void Delete(int key)
        {
             
        }
    }
}
