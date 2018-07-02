using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/Database")]
    public class DatabaseController : Controller
    {
        private DannyStageDBContext _context;
        public static List<DataBasePerson> dbpersonlist = new List<DataBasePerson>();

        public DatabaseController(DannyStageDBContext context)
        {
            _context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<DataBasePerson> Get()
        {
            dbpersonlist = _context.DBperson.ToList();
            return dbpersonlist;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public DataBasePerson Get(int id)
        {
            DataBasePerson dbperson = _context.DBperson.SingleOrDefault(x => x.Id == id);
            return dbperson;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]DataBasePerson value)
        {
            DataBasePerson newperson = new DataBasePerson
            {
                Name = value.Name,
                Age = value.Age
            };


            _context.DBperson.Add(newperson);
            _context.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public DataBasePerson Edit(int id, [FromBody]DataBasePerson person)
        {
            DataBasePerson editperson = _context.DBperson.SingleOrDefault(x => x.Id == id);
            editperson.Name = person.Name;
            editperson.Age = person.Age;
            _context.SaveChanges();
            return editperson;
            
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DataBasePerson removeperson = _context.DBperson.FirstOrDefault(x => x.Id == id);
            _context.DBperson.Remove(removeperson);
            _context.SaveChanges();
        }
    }
}
