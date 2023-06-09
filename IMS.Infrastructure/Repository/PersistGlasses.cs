using IMS.Domain.Entities;
using IMS.Infrastructure.Interfaces;
using IMS.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace IMS.Infrastructure;

public class PersistGlasses : IRepository<Glasses>
{
    private readonly GlassesContext _context;

    public PersistGlasses(GlassesContext context)
    {
        _context = context;
    }

    public void RemoveType(Glasses glasses)
    {
        _context.Glasses.Remove(glasses);
    }

    public async Task<IEnumerable<Glasses>> GetAllTypesAsync()
    {
        return await _context.Glasses.ToListAsync();
    }

    public async Task<Glasses> GetTypeById(int id)
    {
        var result = await _context.Glasses.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
        {
            throw new Exception("O valor é nulo");
        }
        return result;
    }

    public async Task InsertType(Glasses glasses)
    {
        await _context.AddAsync(glasses);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateType(Glasses glasses)
    {
        _context.Entry(glasses).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
