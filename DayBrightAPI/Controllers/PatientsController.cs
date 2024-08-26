using DayBrightAPI.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PatientsController : ControllerBase
{
    private readonly IPatientService _service;

    public PatientsController(IPatientService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patients>> GetById(int id)
    {
        var patient = await _service.GetByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }
        return Ok(patient);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Patients>>> GetAll()
    {
        var patients = await _service.GetAllAsync();
        return Ok(patients);
    }

    [HttpPost]
    public async Task<ActionResult> Create(Patients patient)
    {
        await _service.AddAsync(patient);
        return CreatedAtAction(nameof(GetById), new { id = patient.Id }, patient);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, Patients patient)
    {
        if (id != patient.Id)
        {
            return BadRequest();
        }

        await _service.UpdateAsync(patient);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var existingPatient = await _service.GetByIdAsync(id);
        if (existingPatient == null)
        {
            return NotFound();
        }

        await _service.DeleteAsync(id);
        return NoContent();
    }
}
