using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nani.Models;

namespace nani.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class naniController : Controller
    {
        public IEnumerable<Product> GetAll(){
            return new List<Product> {
                new Product {
                    ProductId = 1,
                    Name = "My Awesome Product1",
                    Description = "This is a super cool awesome product1"
                },
                new Product {
                    ProductId = 2,
                    Name = "My Awesome Product2",
                    Description = "This is a super cool awesome product2"
                },
                new Product {
                    ProductId = 3,
                    Name = "My Awesome Product3",
                    Description = "This is a super cool awesome product3"
                }
            };
        }
    }
}