using DayBrightAPI.Models;

namespace DayBrightAPI.Repositories.Patients
{
    public interface IPatientRepository
    {
        Task<Models.Patients> GetByIdAsync(int id);
        Task<IEnumerable<Models.Patients>> GetAllAsync();
        Task AddAsync(Models.Patients patient);
        Task UpdateAsync(Models.Patients patient);
        Task DeleteAsync(int id);
    }
}
