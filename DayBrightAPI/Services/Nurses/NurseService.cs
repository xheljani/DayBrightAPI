using DayBrightAPI.Models;

public class NurseService : INurseService
{
    private readonly INurseRepository _repository;

    public NurseService(INurseRepository repository)
    {
        _repository = repository;
    }

    public async Task<Nurses> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<Nurses>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task AddAsync(Nurses nurse)
    {
        await _repository.AddAsync(nurse);
    }

    public async Task UpdateAsync(Nurses nurse)
    {
        await _repository.UpdateAsync(nurse);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }
}
