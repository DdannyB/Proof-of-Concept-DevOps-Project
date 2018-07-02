using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/Memory")]
    public class MemoryController : Controller
    {
        private static List<Person> Persons;
        
        public MemoryController()
        {//Controleren of de lijst met personen gevuld is.
            if (Persons == null)
            {//Als de lijst leeg is worden deze personen toegevoegd.
                Persons = new List<Person>
                {
                    new Person
                    {
                        Id = 1,
                        Name = "Danny",
                        Age = 23
                    },
                    new Person
                    {
                        Id = 2,
                        Name = "Brouwers",
                        Age = 23

                    },
                    new Person
                    {
                        Id = 3,
                        Name = "DevOps",
                        Age = 1
                    }
                };

            }
        }
        // GET api/values
        [HttpGet(Name = "Values")]
        public List<Person> Get()
        {
            return Persons;
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Persons.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person p)
        {
            Persons.Add(new Person { Id = p.Id, Name = p.Name, Age = p.Age });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Person Edit2(int id, [FromBody]Person p)
        {
            Person model = Persons.FirstOrDefault(x => x.Id == id);
            model.Name = p.Name;
            model.Age = p.Age;

            return model;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Person model = Persons.FirstOrDefault(x => x.Id == id);
            Persons.Remove(model);
        }
    }
}
