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
    public class DocsLevelPostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DocsLevelPostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DocsLevelPosts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocsLevelPost>>> GetdocsLevelPosts()
        {
            return await _context.docsLevelPosts.ToListAsync();
        }

        // GET: api/DocsLevelPosts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DocsLevelPost>> GetDocsLevelPost(long id)
        {
            var docsLevelPost = await _context.docsLevelPosts.FindAsync(id);

            if (docsLevelPost == null)
            {
                return NotFound();
            }

            return docsLevelPost;
        }        
        
        // GET: api/DocsLevelPosts/5
        [HttpGet("/api/DocsLevelPosts/ByDocsLevel/{id}")]
        public async Task<ActionResult<IEnumerable<DocsLevelPost>>> GetDocsLevelPostByDocsLevel(long id)
        {
            var docsLevel = await _context.docsLevels.FindAsync(id);

            if (docsLevel == null)
            {
                return NotFound();
            }

            var newPosts = new List<DocsLevelPost>();
            foreach(var i in _context.docsLevelPosts)
            {
                if (i.DocsLevelId == id)
                    newPosts.Add(i);
            } 

            return newPosts;
        }

        // PUT: api/DocsLevelPosts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("/api/DocsLevelPosts/Update/{id}")]
        public async Task<IActionResult> PutDocsLevelPost(long id, DocsLevelPost docsLevelPost)
        {
            if (id != docsLevelPost.Id)
            {
                return BadRequest();
            }

            _context.Entry(docsLevelPost).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocsLevelPostExists(id))
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

        // POST: api/DocsLevelPosts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("/api/DocsLevelPosts/Create")]
        public async Task<ActionResult<DocsLevelPost>> PostDocsLevelPost(DocsLevelPost docsLevelPost)
        {
            _context.docsLevelPosts.Add(docsLevelPost);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDocsLevelPost", new { id = docsLevelPost.Id }, docsLevelPost);
        }

        // DELETE: api/DocsLevelPosts/5
        [HttpDelete("/api/DocsLevelPosts/Delete/{id}")]
        public async Task<ActionResult<DocsLevelPost>> DeleteDocsLevelPost(long id)
        {
            var docsLevelPost = await _context.docsLevelPosts.FindAsync(id);
            if (docsLevelPost == null)
            {
                return NotFound();
            }

            _context.docsLevelPosts.Remove(docsLevelPost);
            await _context.SaveChangesAsync();

            return docsLevelPost;
        }

        private bool DocsLevelPostExists(long id)
        {
            return _context.docsLevelPosts.Any(e => e.Id == id);
        }
    }
}
