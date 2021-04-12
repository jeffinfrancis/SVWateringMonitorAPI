using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SVMonitorController : ControllerBase
    {
        // GET: api/<SVMonitorController>
        [HttpGet]
        public IEnumerable<Plants> Get()
        {
            return new PlantsData().GetPlants();
        }

        // GET api/<SVMonitorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SVMonitorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SVMonitorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SVMonitorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
