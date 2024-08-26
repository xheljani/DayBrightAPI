using DayBrightAPI.Models;

public interface IPatientService
{
    Task<Patients> GetByIdAsync(int id);
    Task<IEnumerable<Patients>> GetAllAsync();
    Task AddAsync(Patients patient);
    Task UpdateAsync(Patients patient);
    Task DeleteAsync(int id);
}
