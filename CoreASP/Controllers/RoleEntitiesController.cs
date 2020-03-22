using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreASP.Entity;
using CoreASP.Util;

namespace CoreASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleEntitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RoleEntitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/RoleEntities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleEntity>>> GetRoleEntity()
        {
            return await _context.RoleEntity.ToListAsync();
        }

        // GET: api/RoleEntities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleEntity>> GetRoleEntity(int id)
        {
            var roleEntity = await _context.RoleEntity.FindAsync(id);

            if (roleEntity == null)
            {
                return NotFound();
            }

            return roleEntity;
        }

        // PUT: api/RoleEntities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleEntity(int id, RoleEntity roleEntity)
        {
            if (id != roleEntity.roleId)
            {
                return BadRequest();
            }

            _context.Entry(roleEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleEntityExists(id))
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

        // POST: api/RoleEntities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RoleEntity>> PostRoleEntity(RoleEntity roleEntity)
        {
            _context.RoleEntity.Add(roleEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleEntity", new { id = roleEntity.roleId }, roleEntity);
        }

        // DELETE: api/RoleEntities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoleEntity>> DeleteRoleEntity(int id)
        {
            var roleEntity = await _context.RoleEntity.FindAsync(id);
            if (roleEntity == null)
            {
                return NotFound();
            }

            _context.RoleEntity.Remove(roleEntity);
            await _context.SaveChangesAsync();

            return roleEntity;
        }

        private bool RoleEntityExists(int id)
        {
            return _context.RoleEntity.Any(e => e.roleId == id);
        }
    }
}
