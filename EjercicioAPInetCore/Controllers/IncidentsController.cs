using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IncidentApi.Models;

namespace EjercicioAPInetCore.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class IncidentsController : ControllerBase
    {
        private readonly IncidentContext _context;

        public IncidentsController(IncidentContext context)
        {
            _context = context;
        }

        // GET: api/Incidents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incident>>> GetIncidents()
        {
            return await _context.Incidents.ToListAsync();
        }

        // GET: api/Incidents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Incident>> GetIncident(long id)
        {
            var incident = await _context.Incidents.FindAsync(id);

            if (incident == null)
            {
                return NotFound();
            }

            return incident;
        }

        // PUT: api/Incidents/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncident(long id, IncidentStaging incidentStaging)
        {
            var existingIncident = await _context.Incidents.FindAsync(id);
            if (existingIncident == null)
            {
                return NotFound();
            }

            // Verificar si los campos son nulos antes de asignar
            if (incidentStaging.reporter != null)
            {
                existingIncident.reporter = incidentStaging.reporter;
            }

            if (incidentStaging.description != null)
            {
                existingIncident.description = incidentStaging.description;
            }

            if (incidentStaging.status != null)
            {
                existingIncident.status = incidentStaging.status;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidentExists(id))
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

        // POST: api/Incidents
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Incident>> PostIncident(IncidentStaging incidentStaging)
        {
            // Manual validation for required fields
            if (incidentStaging.reporter == null || incidentStaging.description == null || incidentStaging.status == null)
            {
                return BadRequest("Reporter, description, y status son requeridos.");
            }

            var incident = new Incident
            {
                reporter = incidentStaging.reporter,
                description = incidentStaging.description,
                status = incidentStaging.status
            };

            _context.Incidents.Add(incident);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIncident), new { id = incident.id }, incident);
        }

        // DELETE: api/Incidents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncident(long id)
        {
            var incident = await _context.Incidents.FindAsync(id);
            if (incident == null)
            {
                return NotFound();
            }

            _context.Incidents.Remove(incident);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IncidentExists(long id)
        {
            return _context.Incidents.Any(e => e.id == id);
        }
    }
}
