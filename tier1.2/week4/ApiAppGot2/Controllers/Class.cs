
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiAppGot2.Models;

namespace ApiAppGot2.Controllers
{
    [Route("api/goTCharacters")]
    [ApiController]
    public class GoTCharactersController : ControllerBase
    {
        private readonly GoTCharacterContext _context;

        public GoTCharactersController(GoTCharacterContext context)
        {
            _context = context;
        }

        // GET: api/GoTCharacters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GoTCharacter>>> GetgoTCharacters()
        {
            if (_context.goTCharacters == null)
            {
                return NotFound();
            }
            return await _context.goTCharacters.ToListAsync();
        }

        // GET: api/GoTCharacters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GoTCharacter>> GetGoTCharacter(int id)
        {
            if (_context.goTCharacters == null)
            {
                return NotFound();
            }
            var goTCharacter = await _context.goTCharacters.FindAsync(id);

            if (goTCharacter == null)
            {
                return NotFound();
            }

            return goTCharacter;
        }

        // PUT: api/GoTCharacters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGoTCharacter(int id, GoTCharacter goTCharacter)
        {
            if (id != goTCharacter.Id)
            {
                return BadRequest();
            }

            _context.Entry(goTCharacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GoTCharacterExists(id))
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

        // POST: api/GoTCharacters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GoTCharacter>> PostGoTCharacter(GoTCharacter goTCharacter)
        {
            if (_context.goTCharacters == null)
            {
                return Problem("Entity set 'GoTCharacterContext.goTCharacters'  is null.");
            }
            _context.goTCharacters.Add(goTCharacter);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetGoTCharacter", new { id = goTCharacter.Id }, goTCharacter);
            return CreatedAtAction(nameof(GetGoTCharacter), new { id = goTCharacter.Id }, goTCharacter);
        }

        // DELETE: api/GoTCharacters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGoTCharacter(int id)
        {
            if (_context.goTCharacters == null)
            {
                return NotFound();
            }
            var goTCharacter = await _context.goTCharacters.FindAsync(id);
            if (goTCharacter == null)
            {
                return NotFound();
            }

            _context.goTCharacters.Remove(goTCharacter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GoTCharacterExists(int id)
        {
            return (_context.goTCharacters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
