using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_template.Controllers.Models;
using dotnet_core_template.Models;
using dotnet_core_template.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_template.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ValueService valueService;
        
        public ValuesController(ValueService valueService)
        {
            this.valueService = valueService;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Value>> Get() => valueService.GetAll();

        // GET api/values/5
        [HttpGet("{id}", Name = "GetValue")]
        public ActionResult<Value> Get(int id)
        {
            var value = valueService.Get(id);
            
            if (value == null)
            {
                return NotFound();
            }
            
            return value;
            
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Value> Create([FromBody] ValueRequest request)
        {
            var value = valueService.Create(new Value {
                Titulo = request.Titulo
            });
            
            return CreatedAtRoute("GetValue", new { id = value.Id.ToString()}, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ValueRequest request)
        {
            Value value = valueService.Get(id);
            
            if (value == null)
            {
                return NotFound();
            }
            
            valueService.Update(id, value);
            
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var value = valueService.Get(id);
            
            if (value == null)
            {
                return NotFound();
            }
            
            valueService.Remove(value.Id);
            
            return NoContent();
        }
    }
}
