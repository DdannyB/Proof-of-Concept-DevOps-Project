using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Database;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Tags")]
    public class TagsController : Controller
    {
        private DannyStageDBContext _context;
        public static List<Tags> tagslist = new List<Tags>();

        public TagsController(DannyStageDBContext context)
        {
            _context = context;
        }

        // GET: api/Tags
        [HttpGet]
        public List<Tags> Get()
        {
            tagslist = _context.Tags.ToList();
            return tagslist;
        }

        // GET: api/Tags/5
        [HttpGet("{id}", Name = "Get")]
        public Tags Get(int id)
        {
            Tags tagname = _context.Tags.SingleOrDefault(x => x.Id == id);
            return tagname;
        }
        
        // POST: api/Tags
        [HttpPost]
        public void Post([FromBody]Tags value)
        {
            Tags tagname = new Tags
            {
                Name = value.Name
            };

            _context.Tags.Add(tagname);
            _context.SaveChanges();
        }
        
        // PUT: api/Tags/5
        [HttpPut("{id}")]
        public Tags Edit(int id, [FromBody]Tags value)
        {
            Tags edittag = _context.Tags.SingleOrDefault(x => x.Id == id);
            edittag.Name = value.Name;
            _context.SaveChanges();
            return edittag;
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Tags removetag = _context.Tags.SingleOrDefault(x => x.Id == id);
            _context.Tags.Remove(removetag);
            _context.SaveChanges();
        }
    }
}
