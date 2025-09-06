using Application.IRepositories;
using Domain;

namespace Application.Services;

public class TaskService
{
    private readonly ITaskRepository _repository;

    public TaskService(ITaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Tasks>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Tasks> GetByIdAsync(Guid id)
    {
        var task = await _repository.GetByIdAsync(id);
        return task;
    }

    public async Task<Tasks> CreateAsync(Tasks task)
    {
        return await _repository.CreateAsync(task);
    }
}