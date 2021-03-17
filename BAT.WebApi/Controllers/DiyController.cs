using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BAT.WebApi;
using BAT.WebApi.Entities;

namespace BAT.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiyController : ControllerBase
    {
        private readonly BatDbContext _context;

        public DiyController(BatDbContext context)
        {
            _context = context;
        }

        // GET: api/Diy
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Diy>>> GetDiys()
        {
            return await _context.Diys.ToListAsync();
        }

        // GET: api/Diy/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Diy>> GetDiy(int id)
        {
            var diy = await _context.Diys.FindAsync(id);

            if (diy == null)
            {
                return NotFound();
            }

            return diy;
        }

        // PUT: api/Diy/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiy(int id, Diy diy)
        {
            if (id != diy.Id)
            {
                return BadRequest();
            }

            _context.Entry(diy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Diy
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Diy>> PostDiy(Diy diy)
        {
            _context.Diys.Add(diy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiy", new { id = diy.Id }, diy);
        }

        // DELETE: api/Diy/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Diy>> DeleteDiy(int id)
        {
            var diy = await _context.Diys.FindAsync(id);
            if (diy == null)
            {
                return NotFound();
            }

            _context.Diys.Remove(diy);
            await _context.SaveChangesAsync();

            return diy;
        }

        private bool DiyExists(int id)
        {
            return _context.Diys.Any(e => e.Id == id);
        }
    }
}
