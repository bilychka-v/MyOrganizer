using Domain;

namespace Application.IRepositories;

public interface ITaskRepository
{
    Task<IEnumerable<Tasks>> GetAllAsync();
    Task<Tasks> GetByIdAsync(Guid id);
    Task<Tasks> CreateAsync(Tasks task);
    Task<Tasks> UpdateAsync(Tasks task);
    Task DeleteAsync(Guid id);
}