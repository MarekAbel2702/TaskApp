using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;

namespace TaskApp.Application.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskItemDto>> GetAllTasksAsync();
        Task<TaskItemDto?> GetTaskByIdAsync(Guid id);
        Task<TaskItemDto> CreateTaskAsync(Task item);
        Task<bool> DeleteTaskAsync(Guid id);
        Task<bool> MarkAsDoneAsync(Guid id);
        Task<bool> MarkAsUndoneAsync(Guid id);
    }
}
