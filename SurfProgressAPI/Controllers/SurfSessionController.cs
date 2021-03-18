using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurfProgressAPI.Data;
using SurfProgressAPI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfProgressAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfSessionController : ControllerBase
    {
        private readonly SurfProgressDbContext _db;

        public SurfSessionController(SurfProgressDbContext db)
        {
            _db = db;
        }

        // POST - CREATE: api/SurfSession
        [HttpPost]
        public async Task<ActionResult<SurfSession>> PostSurfSession(SurfSession surfSession)
        {
            _db.SurfSessions.Add(surfSession);
            await _db.SaveChangesAsync();

            // Attention actionName can cause problems.
            return CreatedAtAction("GetSurfSessionById", new { id = surfSession.SurfSessionId }, surfSession);
        }

        // GET - READ: api/SurfSession
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurfSession>>> GetSurfSessions()
        {
            // Eager Loading
            //return await _db.SurfSessions.Include(s => s.Surfboard).ToListAsync();
            return await _db.SurfSessions.ToListAsync();
        }

        // GET - READ: api/SurfSession/3
        [HttpGet("{id}")]
        public async Task<ActionResult<SurfSession>> GetSurfSessionById(int id)
        {
            SurfSession surfSession = await _db.SurfSessions.FindAsync(id);

            if (surfSession == null)
            {
                return NotFound();
            }

            return surfSession;
        }

        // PUT - UPDATE: api/SurfSession/3
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurfSession(int id, SurfSession surfSession)
        {
            if (id != surfSession.SurfSessionId)
            {
                return BadRequest();
            }

            _db.Entry(surfSession).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               if (!SurfSessionExists(id))
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

        // DELETE: api/SurfSession/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurfSession(int id)
        {
            SurfSession surfSession = await _db.SurfSessions.FindAsync(id);
            if (surfSession == null)
            {
                return NotFound();
            }

            _db.SurfSessions.Remove(surfSession);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool SurfSessionExists(int id)
        {
            return _db.SurfSessions.Any(e => e.SurfSessionId == id);
        }

    }
}
