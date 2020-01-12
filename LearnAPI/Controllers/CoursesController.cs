using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        List<Quotes> lstQuotes = new List<Quotes>()
        {
            new Quotes{Id=1,Author="Nishant",Title="RPA Developer",Description="Fundamentals of RPA"},
            new Quotes{Id=1,Author="Sashank",Title="SFG",Description="Fundamentals of Sterlling FileGateway"}
        };


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            return lstQuotes;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
