using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;
using TfcInfrastracture.DbContext;

namespace TheFootballClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerAttributeSetsController : ControllerBase
    {
        private readonly TheFootballClientContext _context;

        public PlayerAttributeSetsController(TheFootballClientContext context)
        {
            _context = context;
        }

        // GET: api/PlayerAttributeSets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerAttributeSet>>> GetPlayerAttributeSets()
        {
            return await _context.PlayerAttributeSets.ToListAsync();
        }

        // GET: api/PlayerAttributeSets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerAttributeSet>> GetPlayerAttributeSet(int id)
        {
            var playerAttributeSet = await _context.PlayerAttributeSets.FindAsync(id);

            if (playerAttributeSet == null)
            {
                return NotFound();
            }

            return playerAttributeSet;
        }

        // PUT: api/PlayerAttributeSets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerAttributeSet(int id, PlayerAttributeSet playerAttributeSet)
        {
            if (id != playerAttributeSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(playerAttributeSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerAttributeSetExists(id))
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

        // POST: api/PlayerAttributeSets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerAttributeSet>> PostPlayerAttributeSet(PlayerAttributeSet playerAttributeSet)
        {
            _context.PlayerAttributeSets.Add(playerAttributeSet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayerAttributeSet", new { id = playerAttributeSet.Id }, playerAttributeSet);
        }

        // DELETE: api/PlayerAttributeSets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerAttributeSet(int id)
        {
            var playerAttributeSet = await _context.PlayerAttributeSets.FindAsync(id);
            if (playerAttributeSet == null)
            {
                return NotFound();
            }

            _context.PlayerAttributeSets.Remove(playerAttributeSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerAttributeSetExists(int id)
        {
            return _context.PlayerAttributeSets.Any(e => e.Id == id);
        }
    }
}
