using DayBrightAPI.Models;

public interface INurseService
{
    Task<Nurses> GetByIdAsync(int id);
    Task<IEnumerable<Nurses>> GetAllAsync();
    Task AddAsync(Nurses nurse);
    Task UpdateAsync(Nurses nurse);
    Task DeleteAsync(int id);
}
