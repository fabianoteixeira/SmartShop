using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartShop.Domain.Commands.Categoria;
using SmartShop.Domain.Core.Bus;

namespace SmartShop.Aplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        private readonly IMediatorHandler Bus;

        public ValuesController(IMediatorHandler bus)
        {
            Bus = bus;
        }




        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //RegisterNewCategoria c = new RegisterNewCategoria("papelaria");

            //Bus.SendCommand(c);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
