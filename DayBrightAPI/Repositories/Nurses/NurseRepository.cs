using DayBrightAPI.Models;
using Microsoft.EntityFrameworkCore;

public class NurseRepository : INurseRepository
{
    private readonly ApplicationDbContext _context;

    public NurseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Nurses> GetByIdAsync(int id)
    {
        return await _context.Nurses.FindAsync(id);
    }

    public async Task<IEnumerable<Nurses>> GetAllAsync()
    {
        return await _context.Nurses.ToListAsync();
    }

    public async Task AddAsync(Nurses nurse)
    {
        await _context.Nurses.AddAsync(nurse);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Nurses nurse)
    {
        _context.Nurses.Update(nurse);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var nurse = await GetByIdAsync(id);
        if (nurse != null)
        {
            _context.Nurses.Remove(nurse);
            await _context.SaveChangesAsync();
        }
    }
}
