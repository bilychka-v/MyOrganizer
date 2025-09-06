using System.Collections;
using Application.IRepositories;
using Db;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class TaskRepository : ITaskRepository
{
    private readonly DataContext _context;

    public TaskRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Tasks>> GetAllAsync()
    {
        return await _context.Tasks.ToListAsync();
    }

    public async Task<Tasks> GetByIdAsync(Guid id)
    {
        var task = await _context.Tasks.FindAsync(id);
        return task;
    }

    public async Task<Tasks> CreateAsync(Tasks task)
    {
        await _context.Tasks.AddAsync(task);
        await _context.SaveChangesAsync();
        
        return task;
    }

    public async Task<Tasks> UpdateAsync(Tasks task)
    {
        _context.Tasks.Update(task);
        await _context.SaveChangesAsync();
        
        return task;
    }

    public async Task DeleteAsync(Guid id)
    {
        var task = await _context.Tasks.FindAsync(id);
        _context.Tasks.Remove(task);
        
        await _context.SaveChangesAsync();
    }
}