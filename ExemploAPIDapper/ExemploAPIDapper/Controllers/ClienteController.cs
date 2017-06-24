using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExemploAPIDapper.Services;
using ExemploAPIDapper.Model;

namespace ExemploAPIDapper.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    public class ClienteController : Controller
    {
        private IRepositorio<Cliente> _service;

        public ClienteController(IRepositorio<Cliente> service)
        {
            _service = service;
        }
        // GET: api/Cliente
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public Cliente Get(int id)
        {
            return _service.GetId(id);
        }
        
        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] Cliente cli)
        {
            _service.Add(cli);
        }
        
        // PUT: api/Cliente/5
        [HttpPut]
        public void Put([FromBody]Cliente cli)
        {
            _service.Update(cli);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete()]
        public void Delete([FromBody] Cliente cli)
        {
            _service.Delete(cli);
        }
    }
}
