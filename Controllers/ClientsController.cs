using Microsoft.AspNetCore.Mvc;
using ProjetCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetCrud.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Clients
    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetClients()
    {
        return _context.Clients.ToList();
    }

    // GET: api/Clients/5
    [HttpGet("{id}")]
    public ActionResult<Client> GetClient(int id)
    {
        var client = _context.Clients.Find(id);
        if (client == null)
        {
            return NotFound();
        }
        return client;
    }

    // POST: api/Clients (Ajout)
    [HttpPost]
    public ActionResult<Client> PostClient(Client client)
    {
        _context.Clients.Add(client);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
    }

    // PUT: api/Clients/5 (Modification)
    [HttpPut("{id}")]
    public IActionResult PutClient(int id, Client client)
    {
        if (id != client.Id)
        {
            return BadRequest();
        }

        _context.Entry(client).State = EntityState.Modified;
        try
        {
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Clients.Any(e => e.Id == id))
            {
                return NotFound();
            }
            throw;
        }
        return NoContent();
    }

    // DELETE: api/Clients/5 (Suppression)
    [HttpDelete("{id}")]
    public IActionResult DeleteClient(int id)
    {
        var client = _context.Clients.Find(id);
        if (client == null)
        {
            return NotFound();
        }

        _context.Clients.Remove(client);
        _context.SaveChanges();
        return NoContent();
    }
}