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
    public class EmployeePositionsController : ControllerBase
    {
        private readonly TheFootballClientContext _context;

        public EmployeePositionsController(TheFootballClientContext context)
        {
            _context = context;
        }

        // GET: api/EmployeePositions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeePosition>>> GetEmployeePositions()
        {
            return await _context.EmployeePositions.ToListAsync();
        }

        // GET: api/EmployeePositions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeePosition>> GetEmployeePosition(int id)
        {
            var employeePosition = await _context.EmployeePositions.FindAsync(id);

            if (employeePosition == null)
            {
                return NotFound();
            }

            return employeePosition;
        }

        // PUT: api/EmployeePositions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeePosition(int id, EmployeePosition employeePosition)
        {
            if (id != employeePosition.Id)
            {
                return BadRequest();
            }

            _context.Entry(employeePosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeePositionExists(id))
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

        // POST: api/EmployeePositions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeePosition>> PostEmployeePosition(string name, string description)
        {
            _context.EmployeePositions.Add(new EmployeePosition(name, description));
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEmployeePosition", new { id = employeePosition.Id }, employeePosition);
            return NoContent();
        }

        // DELETE: api/EmployeePositions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeePosition(int id)
        {
            var employeePosition = await _context.EmployeePositions.FindAsync(id);
            if (employeePosition == null)
            {
                return NotFound();
            }

            _context.EmployeePositions.Remove(employeePosition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeePositionExists(int id)
        {
            return _context.EmployeePositions.Any(e => e.Id == id);
        }
    }
}
