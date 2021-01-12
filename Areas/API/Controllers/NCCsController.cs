using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoAnASP1.Areas.Admin.Data;
using DoAnASP1.Areas.Admin.Models;

namespace DoAnASP1.Areas.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NCCsController : ControllerBase
    {
        private readonly DPcontext _context;

        public NCCsController(DPcontext context)
        {
            _context = context;
        }

        // GET: api/NCCs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NCC>>> GetNCC()
        {
            return await _context.NCC.ToListAsync();
        }

        // GET: api/NCCs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NCC>> GetNCC(int id)
        {
            var nCC = await _context.NCC.FindAsync(id);

            if (nCC == null)
            {
                return NotFound();
            }

            return nCC;
        }

        // PUT: api/NCCs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNCC(int id, NCC nCC)
        {
            if (id != nCC.ID)
            {
                return BadRequest();
            }

            _context.Entry(nCC).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NCCExists(id))
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

        // POST: api/NCCs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NCC>> PostNCC(NCC nCC)
        {
            _context.NCC.Add(nCC);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNCC", new { id = nCC.ID }, nCC);
        }

        // DELETE: api/NCCs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NCC>> DeleteNCC(int id)
        {
            var nCC = await _context.NCC.FindAsync(id);
            if (nCC == null)
            {
                return NotFound();
            }

            _context.NCC.Remove(nCC);
            await _context.SaveChangesAsync();

            return nCC;
        }

        private bool NCCExists(int id)
        {
            return _context.NCC.Any(e => e.ID == id);
        }
    }
}
