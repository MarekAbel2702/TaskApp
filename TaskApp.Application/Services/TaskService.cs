using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.DTOs;
using TaskApp.Application.Interfaces;
using TaskApp.Domain.Entities;
using TaskApp.Domain.Interfaces;

namespace TaskApp.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TaskItemDto> CreateTaskAsync(CreateTaskItemDto dto)
        {
            var task = _mapper.Map<TaskItem>(dto);
            await _repository.AddAsync(task);
            return _mapper.Map<TaskItemDto>(task);
        }

        public async Task<bool> DeleteTaskAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
            return true;
        }

        public async Task<List<TaskItemDto>> GetAllTasksAsync()
        {
            var tasks = await _repository.GetAllAsync();
            return _mapper.Map<List<TaskItemDto>>(tasks);
        }

        public async Task<TaskItemDto?> GetTaskByIdAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            return task is null ? null : _mapper.Map<TaskItemDto>(task);
        }

        public async Task<bool> MarkAsDoneAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task == null) return false;
            task.MarkAsDone();
            await _repository.UpdateAsync(task);
            return true;
        }

        public async Task<bool> MarkAsUndoneAsync(Guid id)
        {
            var task = await _repository.GetByIdAsync(id);
            if (task == null) return false;
            task.MarkAsUndone();
            await _repository.UpdateAsync(task);
            return true;
        }
    }
}
