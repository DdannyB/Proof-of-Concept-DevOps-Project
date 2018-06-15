using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseController : Controller
    {
        private DannyStageDBContext _context;
        public static List<Names> nameslist;

        public DatabaseController(DannyStageDBContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Names> Get()
        {
            nameslist = _context.Names.ToList();
            return nameslist;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Names value)
        {
            _context.Names.Add( new Names { Id = value.Id, Name = value.Name, Age = value.Age });
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
