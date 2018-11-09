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
    public class TripController : Controller
    {
        private readonly TripContext _context;

        public TripController(TripContext context)
        {
            _context = context;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Train100rows>> GetAll()
        {
            return _context.Train100rows.ToList();
        }
    }
}