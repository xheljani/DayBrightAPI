using DayBrightAPI.Models;
using DayBrightAPI.Repositories.Patients;

public class PatientService : IPatientService
{
    private readonly IPatientRepository _repository;

    public PatientService(IPatientRepository repository)
    {
        _repository = repository;
    }

    public async Task<Patients> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Patients>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task AddAsync(Patients patient)
    {
        await _repository.AddAsync(patient);
    }

    public async Task UpdateAsync(Patients patient)
    {
        await _repository.UpdateAsync(patient);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
