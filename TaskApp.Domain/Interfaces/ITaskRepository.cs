using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Domain.Entities;

namespace TaskApp.Domain.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskItem?> GetByIdAsync(Guid id);
        Task<List<TaskItem>> GetAllAsync();
        Task AddAsync (TaskItem task);
        Task UpdateAsync (TaskItem task);
        Task DeleteAsync (Guid id);
    }
}
