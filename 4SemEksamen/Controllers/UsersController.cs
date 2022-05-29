using _4SemEksamen.Managers;
using _4SemEksamen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _4SemEksamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager _manager;
        public UsersController(UserContext context)
        {
            _manager = new UserManager(context);
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _manager.Get(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public User Post([FromBody] User value)
        {
            return _manager.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            _manager.Update(id, value);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
