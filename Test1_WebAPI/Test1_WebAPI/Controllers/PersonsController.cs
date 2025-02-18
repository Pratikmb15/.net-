using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Test1_WebAPI.Repository.Context;
using Test1_WebAPI.Repository.Models;

namespace Test1_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly PersonDbContext _context;

        public PersonsController(PersonDbContext context)
        {
            _context = context;
        }
        [HttpGet("getpersons")]

        public List<Person> GetAllPersons()
        {
            
            return _context.Person.ToList();
        }

    }
}
