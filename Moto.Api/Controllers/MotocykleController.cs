using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moto.Api.Services;
using Moto.Api.Entities;
using Moto.Api.Models;

namespace Moto.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Motocykle")]
    public class MotocykleController : Controller
    {
        private IMotocykleRepository _motocykleRepository;

        public MotocykleController(IMotocykleRepository motocykleRepository)
        {
            _motocykleRepository = motocykleRepository;
        }

        // GET: api/Motocykle
        [HttpGet]
        public IEnumerable<MotocyklDto> Get()
        {
            return _motocykleRepository.GetMotorcycles();
        }

        // GET: api/Motocykle/5
        [HttpGet("{id}", Name = "Get")]
        public MotocyklDto Get(int id)
        {
            return _motocykleRepository.GetMotorcycle(id);
        }
        
        // POST: api/Motocykle
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Motocykle/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
