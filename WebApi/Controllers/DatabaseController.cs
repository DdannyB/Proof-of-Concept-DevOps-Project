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
            Names newname = new Names
            {
                Name = value.Name,
                Age = value.Age
            };


            _context.Names.Add(newname);
            _context.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public Names Edit(int id, [FromBody]Names name)
        {
            Names editname = _context.Names.FirstOrDefault(x => x.Id == id);
            editname.Name = name.Name;
            editname.Age = name.Age;
            _context.SaveChanges();
            return editname;
            
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Names removename = _context.Names.FirstOrDefault(x => x.Id == id);
            _context.Names.Remove(removename);
            _context.SaveChanges();
        }
    }
}
