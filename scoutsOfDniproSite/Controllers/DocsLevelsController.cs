using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using scoutsOfDniproSite;
using scoutsOfDniproSite.Models;

namespace scoutsOfDniproSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocsLevelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DocsLevelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DocsLevels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocsLevel>>> GetdocsLevels()
        {
            return await _context.docsLevels.ToListAsync();
        }

        // GET: api/DocsLevels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocsLevel>> GetDocsLevel(long id)
        {
            var docsLevel = await _context.docsLevels.FindAsync(id);

            if (docsLevel == null)
            {
                return NotFound();
            }

            return docsLevel;
        }

        // PUT: api/DocsLevels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("/api/DocsLevels/Update/{id}")]
        public async Task<IActionResult> PutDocsLevel(long id, DocsLevel docsLevel)
        {
            if (id != docsLevel.Id)
            {
                return BadRequest();
            }

            _context.Entry(docsLevel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocsLevelExists(id))
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

        // POST: api/DocsLevels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("/api/DocsLevels/Create")]
        public async Task<ActionResult<DocsLevel>> PostDocsLevel(DocsLevel docsLevel)
        {
            _context.docsLevels.Add(docsLevel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocsLevel", new { id = docsLevel.Id }, docsLevel);
        }

        // DELETE: api/DocsLevels/5
        [HttpDelete("/api/DocsLevels/Delete/{id}")]
        public async Task<ActionResult<DocsLevel>> DeleteDocsLevel(long id)
        {
            var docsLevel = await _context.docsLevels.FindAsync(id);
            if (docsLevel == null)
            {
                return NotFound();
            }

            _context.docsLevels.Remove(docsLevel);
            await _context.SaveChangesAsync();

            return docsLevel;
        }

        private bool DocsLevelExists(long id)
        {
            return _context.docsLevels.Any(e => e.Id == id);
        }
    }
}
