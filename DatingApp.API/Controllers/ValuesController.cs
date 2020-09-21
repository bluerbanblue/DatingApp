using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MyWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            this._context = context;
        }

        // GET: api/values
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        // GET: api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST: api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT: api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        // DELETE: api/values/5
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}