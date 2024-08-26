using DayBrightAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class NursesController : ControllerBase
{
    private readonly INurseService _service;

    public NursesController(INurseService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Nurses>> GetById(int id)
    {
        var nurse = await _service.GetByIdAsync(id);
        if (nurse == null)
        {
            return NotFound();
        }
        return Ok(nurse);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Nurses>>> GetAll()
    {
        var nurses = await _service.GetAllAsync();
        return Ok(nurses);
    }

    [HttpPost]
    public async Task<ActionResult> Create(Nurses nurse)
    {
        await _service.AddAsync(nurse);
        return CreatedAtAction(nameof(GetById), new { id = nurse.Id }, nurse);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(Guid id, Nurses nurse)
    {
        if (id != nurse.Id)
        {
            return BadRequest();
        }

        await _service.UpdateAsync(nurse);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var existingNurse = await _service.GetByIdAsync(id);
        if (existingNurse == null)
        {
            return NotFound();
        }

        await _service.DeleteAsync(id);
        return NoContent();
    }
}
