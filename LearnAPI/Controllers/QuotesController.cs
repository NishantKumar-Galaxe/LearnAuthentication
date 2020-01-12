using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnAPI.Data;
using LearnAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private QuoteDBContext _quotesDbContext;
        public QuotesController(QuoteDBContext quotesDbContext)
        {
            _quotesDbContext = quotesDbContext;
        }

        // GET: api/Quotes
        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            var res = _quotesDbContext.Quotes;
            return res.ToList();
        }

        // GET: api/Quotes/5
        [HttpGet("{id}", Name = "Get")]
        public Quotes Get(int id)
        {
            return _quotesDbContext.Quotes.Find(id);
        }

        // POST: api/Quotes
        [HttpPost]
        public void Post([FromBody] Quotes value)
        {
            _quotesDbContext.Quotes.Add(value);
            _quotesDbContext.SaveChanges();
        }

        // PUT: api/Quotes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quotes value)
        {
            var objQuote = _quotesDbContext.Quotes.Find(id);
            objQuote.Title = value.Title;
            objQuote.Author = value.Author;
            objQuote.Description = value.Description;
            _quotesDbContext.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
