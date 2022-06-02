using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using _4SemEksamen.Models;
using _4SemEksamen.Managers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _4SemEksamen.Controllers
{
    [Authorize]
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
        [EnableCors("allMethods")]
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            return Manager.GetAll();
        }

        // GET api/<PersonController>/5
        [EnableCors("policy")]
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return Manager.GetById(id);
        }

        // POST api/<PersonController>
        [EnableCors("allMethods")]
        [HttpPost]
        public void Post([FromBody] Person value)
        {
            Manager.Add(value);
        }

        // PUT api/<PersonController>/5
        [EnableCors("allMethods")]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            Manager.Update(id, value);
        }

        // DELETE api/<PersonController>/5
        [EnableCors("allMethods")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Manager.Delete(id);
        }
    }
}
