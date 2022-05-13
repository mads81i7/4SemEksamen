using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _4SemEksamen.Models;
using _4SemEksamen.Managers;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _4SemEksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonsManager Manager;

        public PersonController()
        {
            Manager = new PersonsManager();
        }

        // GET: api/<PersonController>
        [EnableCors("policy")]
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return Manager.GetAll();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Manager.GetById(id);
        }

        // POST api/<PersonController>
        [EnableCors("policy")]
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            Manager.Add(value);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            Manager.Update(id, value);
        }

        // DELETE api/<PersonController>/5
        [EnableCors("policy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Manager.Delete(id);
        }
    }
}
